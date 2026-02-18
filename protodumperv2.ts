// Import the protobuf library and the root object from the Protocol.js file
const $protobuf = require("./JavaScript/Core/Define/Net/protobuf");

import Module from "module";
import path from "path";

// Get the original require function
const originalRequire = Module.prototype.require;

// Override only the function, keeping TS happy
(Module.prototype.require as any) = function (this: any, request: string) {
    if (request === "protobuf") {
        return originalRequire.call(this, path.resolve(__dirname, "./JavaScript/Core/Define/Net/protobuf"));
    }
    return originalRequire.call(this, request);
};

const $root = require("./JavaScript/Core/Define/Net/Protocol.js");
const $util = require("./JavaScript/Core/Define/Net/protobuf");
const $netdefine = require("./JavaScript/Core/Define/Net/NetDefine.js");
import { writeFileSync } from "fs";
type Long = any;
const Long = require("./JavaScript/Core/Define/Net/long.js");


// PushMessageIds
const PushMessageIds = $netdefine.PushMessageIds;

// RequestMessageIds
const RequestMessageIds = $netdefine.RequestMessageIds;

// ResponseMessageIds
const ResponseMessageIds = $netdefine.ResponseMessageIds;

// NotifyMessageIds
const NotifyMessageIds = $netdefine.NotifyMessageIds;

// pid to message def
const messageDefine = $netdefine.messageDefine;

const proto = Object.keys($root.Aki.Protocol);


// dict string: string
let pidcache:any = {};

function getProtoMessageTypeFromPid(pid: number): string {
    if (NotifyMessageIds.includes(pid)) {
        return "Notify";
    }
    if (RequestMessageIds.includes(pid)) {
        return "Request";
    }
    if (ResponseMessageIds.includes(pid)) {
        return "Response";
    }
    if (PushMessageIds.includes(pid)) {
        return "Push";
    }
    return "???";   
}

function getProtoNameForPid(constructor:any, nestedkeys:string[] = []) {
    for (const protoName of proto) {
        if (constructor === $root.Aki.Protocol[protoName]) {
            if (nestedkeys.length === 0) return protoName;
            let toret = nestedkeys.join(".") + "." + protoName;
            return toret;
        }
        if (!Object.keys($root.Aki.Protocol[protoName]).includes("create")) { 
            // tried to make it recursive but theres no reason to do so as of now
            for (let key in $root.Aki.Protocol[protoName]) {
                if (constructor === $root.Aki.Protocol[protoName][key]) {
                    return `${protoName}.${key}`;
                }
            }
        }
    }
}

for (const packetid of Object.keys(messageDefine)) {

    const constructor = messageDefine[packetid];
    let protoName = getProtoNameForPid(constructor);
    if (!protoName) {
        throw new Error(`Not found protoName for ${packetid}`);
    }
    protoName = protoName.replace(/\$/g, "DOLLAR");

    pidcache[packetid] = protoName;
}

writeFileSync(`PacketIds.json`, JSON.stringify(pidcache, null, 2), "utf8");

const WIRE_TYPE = {
    VARINT: 0,
    LENGTH_DELIMITED: 2,
    '32BIT': 5,
    '64BIT': 1,
    '64BIT_FLOAT': 6,  // Adding support for 64-bit float
    idk: 8
};

function encodeVarint(value: number | Long | bigint): Uint8Array {
    const bytes: number[] = [];
    if (typeof value === "number") {
        while (value > 0x7F) {
            bytes.push((value & 0x7F) | 0x80);
            value >>>= 7;
        }
        bytes.push(value);
    } else if (typeof value === "bigint") {
        while (value > 0x7F) {
            bytes.push(Number(value && 0x7F | 0x80));
            value >>= 7n;
        }
        bytes.push(Number(value));
    } else {
        while (value.greaterThan(0x7F)) {
            bytes.push(Number(value.and(0x7F).or(0x80)));
            value = value.shiftRightUnsigned(7);
        }
        bytes.push(Number(value));
    }
    return new Uint8Array(bytes);
}

function encodeString(value: string): Uint8Array {
    const textEncoder = new TextEncoder();
    const stringBytes = textEncoder.encode(value);
    const length = encodeVarint(stringBytes.length);
    return concatUint8Arrays(length, stringBytes);
}

function encodeBytes(value: Uint8Array): Uint8Array {
    const length = encodeVarint(value.length);
    return concatUint8Arrays(length, value);
}

function encodeFieldTag(fieldNumber: number, wireType: number): Uint8Array {
    const tag = (fieldNumber << 3) | wireType;
    return encodeVarint(tag);
}

function concatUint8Arrays(...arrays: Uint8Array[]): Uint8Array {
    const totalLength = arrays.reduce((sum, arr) => sum + arr.length, 0);
    const result = new Uint8Array(totalLength);
    let offset = 0;
    for (const arr of arrays) {
        result.set(arr, offset);
        offset += arr.length;
    }
    return result;
}

function getFieldTypeFromConstructorName(fieldvalue: object): string {
    // console.log("Fieldvalue: " + JSON.stringify(fieldvalue));
    try {
        for (const key in $root.Aki.Protocol) {
            // check if its a function
            let possibleType = $root.Aki.Protocol[key];
            
            if (!Object.keys(possibleType).includes("create") && !isEnum(possibleType)) {
                for (const key2 in possibleType) {
                    let possibleType2 = possibleType[key2];
                    if (typeof possibleType2 !== "function") {
                        continue;
                    }
                    if (possibleType2 == fieldvalue.constructor) {
                        return `${key}.${key2}`;
                    }
                    if (possibleType2.name == fieldvalue) {
                        return `${key}.${key2}`;
                    }
                }
            }

            if (typeof possibleType !== "function") {
                continue;
            }

            let inst = new possibleType();

            if (inst.constructor.name === `${fieldvalue}`) {
                return key;
            }
        }

            
        for (const key in $root.Aki.Protocol) {
            if ($root.Aki.Protocol[key] === fieldvalue.constructor || $root.Aki.Protocol[key] === fieldvalue) {
                return key;
            }
        }
    } catch (e) {
        console.log("Error: " + e);
    }
    
    console.log(`// Could not find type for ${fieldvalue.constructor.name}`);
    const fs = require('fs');
    const filedata = fs.readFileSync(`./JavaScript/Core/Define/Net/Protocol.js`, 'utf8');
    const regex = /.(\w+) = \(Yf\.create/gm;
    // find all the class names
    let match = regex.exec(filedata);
    if (match) {
        return match[1];
    }
    console.log("Could not find type for " + fieldvalue);
    return "???";
}


function encodeFloat(value: number): Uint8Array {
    const buffer = new ArrayBuffer(4);
    new DataView(buffer).setFloat32(0, value, true); // Little-endian
    return new Uint8Array(buffer);
}

function encodeDouble(value: number): Uint8Array {
    const buffer = new ArrayBuffer(8);
    new DataView(buffer).setFloat64(0, value, true);  // true for little-endian encoding
    return new Uint8Array(buffer);
}

enum ProtoFieldType {
    INT32 = "int32",
    UINT32 = "uint32",
    INT64 = "int64",
    UINT64 = "uint64",
    SINT32 = "sint32",
    SINT64 = "sint64",
    FIXED32 = "fixed32",
    FIXED64 = "fixed64",
    SFIXED32 = "sfixed32",
    SFIXED64 = "sfixed64",
    FLOAT = "float",
    DOUBLE = "double",
    STRING = "string",
    BYTES = "bytes",
    MESSAGE = "message"
}

function encodeFixed32(value: number): Uint8Array {
    const buffer = new ArrayBuffer(4);
    new DataView(buffer).setUint32(0, value, true);
    return new Uint8Array(buffer);
}

function encodeFixed64(value: bigint): Uint8Array {
    const buffer = new ArrayBuffer(8);
    const view = new DataView(buffer);

    if (value < 0n) {
        // Handle as signed 64-bit integer (sfixed64)
        view.setBigInt64(0, value, true);  // Big-endian encoding
    } else {
        // Handle as unsigned 64-bit integer (fixed64)
        view.setBigUint64(0, value, true); // Big-endian encoding
    }

    return new Uint8Array(buffer);
}

function encodeZigZag32(value: number): number {
    return (value << 1) ^ (value >> 31);
}

function encodeZigZag64(value: Long): Long {
    return value.shiftLeft(1).xor(value.shiftRight(63));
}

class ProtobufMessage {
    private fields: Uint8Array[];

    constructor() {
        this.fields = [];
    }

    addMapField(fieldNumber: number, map: Map<any, any>, keyfieldType: ProtoFieldType, valueFieldType: ProtoFieldType): void {
        // Iterate over key-value pairs in the map
        let ProtobufMessage_1 = new ProtobufMessage();
        for (const [key, value] of map) {
            // Encoding the key and value

            ProtobufMessage_1.addField(1, key, keyfieldType);
            ProtobufMessage_1.addField(2, value, valueFieldType);
            
            let nestedEncoded = ProtobufMessage_1.build();
            
            this.fields.push(concatUint8Arrays(encodeFieldTag(fieldNumber, WIRE_TYPE.LENGTH_DELIMITED), encodeBytes(nestedEncoded)));
        }
    }

    addField(fieldNumber: number, value: 

        number | string | Uint8Array | ProtobufMessage | bigint | Long |
        (number | string | Uint8Array | ProtobufMessage | bigint | Long)[], 
        
        fieldType: ProtoFieldType, repeated = false): void {
        if (Array.isArray(value)) {
            if (!repeated) {
                throw new Error("Array values must be marked as repeated.");
            }
            for (const item of value) {
                this.addField(fieldNumber, item, fieldType, false);
            }
            return;
        }

        let tag: Uint8Array;
        let encodedValue: Uint8Array;

        switch (fieldType) {
            case ProtoFieldType.SINT32:
            if (typeof value !== "number" || !Number.isInteger(value)) {
                throw new Error("SINT32 must be an integer.");
            }
            tag = encodeFieldTag(fieldNumber, WIRE_TYPE.VARINT);
            encodedValue = encodeVarint(encodeZigZag32(value));
            break;

        case ProtoFieldType.SINT64:
            if (!(value instanceof Long)) {
                throw new Error("SINT64 must be a Long instance.");
            }
            tag = encodeFieldTag(fieldNumber, WIRE_TYPE.VARINT);
            encodedValue = encodeVarint(encodeZigZag64(value));
            break;

            case ProtoFieldType.INT32:
            case ProtoFieldType.UINT32:
            case ProtoFieldType.INT64:
            case ProtoFieldType.UINT64:
                if ((typeof value !== "number" || !Number.isInteger(value) ) && typeof value !== "bigint" ) {
                    let valtype = typeof value;
                    throw new Error(`${fieldType} must be an integer, got ${valtype}.`);
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE.VARINT);
                encodedValue = encodeVarint(value);
                break;
            case ProtoFieldType.FIXED32:
            case ProtoFieldType.SFIXED32:
                if (typeof value !== "number") {
                    throw new Error(`${fieldType} must be a number.`);
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE["32BIT"]);
                encodedValue = encodeFixed32(value);
                break;
            case ProtoFieldType.FIXED64:
            case ProtoFieldType.SFIXED64:
                if (typeof value !== "bigint") {
                    throw new Error(`${fieldType} must be a number or bigint instance, got ${typeof value}.`);
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE["64BIT"]);  // Fixed (unsigned) 64-bit
                encodedValue = encodeFixed64(value); // encode as unsigned 64-bit
                break;
            case ProtoFieldType.FLOAT:
                if (typeof value !== "number") {
                    throw new Error("FLOAT must be a number.");
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE["32BIT"]);
                encodedValue = encodeFloat(value);
                break;
            case ProtoFieldType.DOUBLE:
                if (typeof value !== "number") {
                    throw new Error("DOUBLE must be a number.");
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE["64BIT_FLOAT"]);
                encodedValue = encodeDouble(value);
                break;
            case ProtoFieldType.STRING:
                if (typeof value !== "string") {
                    throw new Error("STRING must be a string.");
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE.LENGTH_DELIMITED);
                encodedValue = encodeString(value);
                break;
            case ProtoFieldType.BYTES:
                if (!(value instanceof Uint8Array)) {
                    throw new Error("BYTES must be a Uint8Array.");
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE.LENGTH_DELIMITED);
                encodedValue = encodeBytes(value);
                break;
            case ProtoFieldType.MESSAGE:
                if (!(value instanceof ProtobufMessage)) {
                    throw new Error("MESSAGE must be a ProtobufMessage instance.");
                }
                tag = encodeFieldTag(fieldNumber, WIRE_TYPE.LENGTH_DELIMITED);
                const nestedEncoded = value.build();
                const lengthPrefix = encodeVarint(nestedEncoded.length);
                encodedValue = concatUint8Arrays(lengthPrefix, nestedEncoded);
                break;
            default:
                throw new Error("Unsupported field type.");
        }

        this.fields.push(concatUint8Arrays(tag, encodedValue));
    }

    build(): Uint8Array {
        return concatUint8Arrays(...this.fields);
    }
}

function dumpMessage(ProtoName:string, ProtoClass:any, oneofs:any, isNested:boolean)
{
    let fieldcache:string[] = [];

    const testValues = {
        UINT32: 4294967294,
        SINT32: -123456,
        FIXED32: 123456,
        SFIXED32: -123456,
        INT64: 9223372036854775807n,
        SINT64: -9223372036854775807n,
        FIXED64: 9223372036854775807n,
        SFIXED64: -9223372036854775807n,
        FLOAT: Math.fround(4294967299.456),
        DOUBLE: 4294967299.456
    };

    let donefields:string[] = [];

    // Step pre-1: loop with repeated int32 values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const testval = testValues.UINT32;
        testMessage.addField(i, [testval, testval], ProtoFieldType.UINT32, true);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];
                if (fieldvalue === undefined || fieldvalue === 0 || donefields.includes(fieldname))
                    return;
                
                if (!Array.isArray(fieldvalue) || fieldvalue.length === 0) {
                    return;
                }

                let testval = fieldvalue[0];

                if (testval instanceof $protobuf.util.Long) {
                    switch (testval.low) {
                        case -2:
                            fieldcache.push(`repeated int64 ${fieldname} = ${i}`);
                            donefields.push(fieldname);
                            break;
                        default:
                            console.log("UNKNOWN " + JSON.stringify(fieldvalue) + " = " + fieldname);
                            break;
                    }
                    return;
                }

                switch (testval) {
                    case -2:
                        fieldcache.push(`repeated int32 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                        break;
                    case 4294967294:
                        fieldcache.push(`repeated uint32 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                        break;
                    case 2147483647:
                        fieldcache.push(`repeated sint32 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                        break;
                    case true:
                        fieldcache.push(`repeated bool ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                        break;
                    default:
                        console.log("UNKNOWN " + JSON.stringify(fieldvalue) + " = " + fieldname);
                        break;
                }

            });
        } catch (e) {
        }
    }

    // Step 1: loop with int values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let testval = testValues.UINT32;
        testMessage.addField(i, testval, ProtoFieldType.UINT32);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];
                let isIntNotUint = false;

                if (donefields.includes(fieldname))
                    return;

                if (fieldvalue === undefined || fieldvalue == 0)
                    return;

                if (fieldvalue < 0) {
                    isIntNotUint = true;
                }

                let int32max = 2147483647;

                if (fieldvalue == testval)
                {
                    fieldcache.push(`uint32 ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                } 
                else if (fieldvalue == -2)
                {
                    fieldcache.push(`int32 ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                } else if (fieldvalue === true)
                {
                    fieldcache.push(`bool ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                } else if (fieldvalue instanceof $protobuf.util.Long) 
                {
                    if (fieldvalue.unsigned === true && (fieldvalue.low == -2)) 
                    {
                        fieldcache.push(`uint64 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                    } else if (fieldvalue.unsigned === false && (fieldvalue.low == -2)) 
                    {
                        fieldcache.push(`int64 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                    } else if (fieldvalue.unsigned === false && (fieldvalue.low == 2147483647)) 
                    {
                        fieldcache.push(`sint64 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                    } 
                    else {
                        console.log("UNKNOWN " + JSON.stringify(fieldvalue) + " = " + fieldname);
                    }
                }
            });
        } catch (e) {
        }
    }

    // Step 1.1: loop with SINT32 values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const testval = testValues.SINT32;
        testMessage.addField(i, testval, ProtoFieldType.SINT32);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];

                // Fieldname: kbs Fieldvalue: -123456
                if (fieldvalue !== undefined && fieldvalue != 0 
                        && !donefields.includes(fieldname) 
                        && fieldvalue === testval
                        && fieldvalue == -123456
                    ) {
                    const str2add = (`sint32 ${fieldname} = ${i}`);
                    fieldcache.push(str2add);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 1.2: loop with SFIXED32 values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const testval = testValues.SFIXED32;
        testMessage.addField(i, testval, ProtoFieldType.SFIXED32);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];

                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname)) {
                    if (fieldvalue == 4294843840) {
                        const str2add = (`fixed32 ${fieldname} = ${i}`);
                        fieldcache.push(str2add);
                        donefields.push(fieldname);
                    }
                    else if (fieldvalue == -123456) {
                        const str2add = (`sfixed32 ${fieldname} = ${i}`);
                        fieldcache.push(str2add);
                        donefields.push(fieldname);
                    }
                }
            });
        } catch (e) {
        }
    }

    // Step 1.3: loop with S/U FIXED64 values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const signedValue = BigInt(-1234567890123456789);
        testMessage.addField(i, signedValue, ProtoFieldType.SFIXED64);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];
                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname) && fieldvalue instanceof $protobuf.util.Long) {
                    
                    if (fieldvalue.unsigned === true)
                    {
                        fieldcache.push(`fixed64 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                    } else if (fieldvalue.unsigned === false)
                    {
                        fieldcache.push(`sfixed64 ${fieldname} = ${i}`);
                        donefields.push(fieldname);
                    }
                }
            });
        } catch (e) {
        }
    }

    // Step 2: loop with string values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const strVal = "TestString";
        testMessage.addField(i, strVal, ProtoFieldType.STRING);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];
                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname) && fieldvalue === strVal) {
                    const str2add = (`string ${fieldname} = ${i}`);
                    fieldcache.push(str2add);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 4: loop with repeated string values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const repeatedStr:string[] = ["TestString", "CockAndBalls"];
        testMessage.addField(i, repeatedStr, ProtoFieldType.STRING, true);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];
                if (fieldvalue === undefined || fieldvalue === 0 || `${fieldvalue}` === "" || donefields.includes(fieldname))
                    return;
                if (`${fieldvalue}` === `TestString,CockAndBalls`) {
                    const str2add = (`repeated string ${fieldname} = ${i}`);
                    fieldcache.push(str2add);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 5: loop with repeated empty messages

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const nestedMessage = new ProtobufMessage();
        testMessage.addField(i, [nestedMessage, nestedMessage], ProtoFieldType.MESSAGE, true);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                let fieldname = `${field}`;
                let fieldvalue = protoInstance[fieldname];
                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname)) {
                    if (Array.isArray(fieldvalue)) {
                        const elementType = fieldvalue.length > 0 ? fieldvalue[0].constructor.name : "Empty Array";
                        const elementName = getFieldTypeFromConstructorName(elementType);
                        const str2add = (`repeated ${elementName} ${fieldname} = ${i}`);
                        fieldcache.push(str2add);
                        donefields.push(fieldname);
                    }
                }
            });
        } catch (e) {
        }
    }

    // Step 6: loop with double values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const testval = testValues.DOUBLE;
        testMessage.addField(i, testval, ProtoFieldType.DOUBLE);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];


                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname)) {
                    if (fieldvalue == testval) {
                        const str2add = (`double ${fieldname} = ${i}`);
                        fieldcache.push(str2add);
                        donefields.push(fieldname);
                    }
                }
            });
        } catch (e) {}
    }

    // Step 7: loop with float values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const testval = testValues.FLOAT;
        testMessage.addField(i, testval, ProtoFieldType.FLOAT);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];
                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname)) {
                    if (fieldvalue != testval)
                        return;
                    const str2add = (`float ${fieldname} = ${i}`);
                    fieldcache.push(str2add);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 9: loop bytearray values

    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        // add 0xdeadbeef as a byte array
        const testval = new Uint8Array([0xde, 0xad, 0xbe, 0xef]);
        testMessage.addField(i, testval, ProtoFieldType.BYTES);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                const fieldvalue = protoInstance[fieldname];
                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname)) {
                    if (!(fieldvalue instanceof Long)) {
                        if (fieldvalue[0] == 222 && fieldvalue[1] == 173 && fieldvalue[2] == 190 && fieldvalue[3] == 239) {
                            const str2add = (`bytes ${fieldname} = ${i}`);
                            fieldcache.push(str2add);
                            donefields.push(fieldname);
                        }
                    }
                }
            });
        } catch (e) {
        }
    }

    // Step 10: loop with map values
    // Step 10.1 loop with map<string, int32> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<string, number>();
        map.set("key1", 10);
        testMessage.addMapField(i, map, ProtoFieldType.STRING, ProtoFieldType.INT32);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance

            let protobytes = testMessage.build()

            protoInstance = ProtoClass.decode(protobytes);
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                if (fieldvalue == JSON.stringify(Object.fromEntries(map)))
                {
                    fieldcache.push(`map<string, int32> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 10.2 loop with map<int32, int32> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<number, number>();
        map.set(10, 10);
        testMessage.addMapField(i, map, ProtoFieldType.INT32, ProtoFieldType.INT32);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                if (fieldvalue == JSON.stringify(Object.fromEntries(map)))
                {
                    fieldcache.push(`map<int32, int32> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
                if (fieldvalue == `{"10":true}`)
                {
                    fieldcache.push(`map<int32, bool> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 10.3 loop with map<int32, string> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<number, string>();
        map.set(10, "TestString");
        testMessage.addMapField(i, map, ProtoFieldType.INT32, ProtoFieldType.STRING);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                if (fieldvalue == JSON.stringify(Object.fromEntries(map)))
                {
                    fieldcache.push(`map<int32, string> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 10.4 loop with map<string, string> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<string, string>();
        map.set("key1", "TestString");
        testMessage.addMapField(i, map, ProtoFieldType.STRING, ProtoFieldType.STRING);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                if (fieldvalue == JSON.stringify(Object.fromEntries(map)))
                {
                    fieldcache.push(`map<string, string> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 10.5 loop with map<int32, int64> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<number, bigint>();
        map.set(10, 9223372036854775807n);
        testMessage.addMapField(i, map, ProtoFieldType.INT32, ProtoFieldType.INT64);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());

            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                let tocompare = new Map<number, Long>();
                tocompare.set(10, Long.fromValue(9223372036854775807));
                if (`${JSON.stringify(protoInstance[fieldname])}` == `${JSON.stringify(Object.fromEntries(tocompare))}`)
                {
                    fieldcache.push(`map<int32, int64> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 10.6 loop with map<string, int64> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<string, bigint>();
        map.set("key1", 9223372036854775807n);
        testMessage.addMapField(i, map, ProtoFieldType.STRING, ProtoFieldType.INT64);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                if (fieldvalue == JSON.stringify(Object.fromEntries(map)))
                {
                    fieldcache.push(`map<string, int64> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 10.7 loop with map<int32, int64> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<number, bigint>();
        map.set(10, 9223372036854775807n);
        testMessage.addMapField(i, map, ProtoFieldType.INT32, ProtoFieldType.INT64);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                if (fieldvalue == JSON.stringify(Object.fromEntries(map)))
                {
                    fieldcache.push(`map<int32, int64> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 10.8 loop with map<int32, emptyProto> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<number, ProtobufMessage>();
        map.set(10, new ProtobufMessage());
        testMessage.addMapField(i, map, ProtoFieldType.INT32, ProtoFieldType.MESSAGE);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = `${JSON.stringify(protoInstance[fieldname])}`;
                if (fieldvalue.startsWith("{\"10\":"))
                {
                    let messageCtorname = getFieldTypeFromConstructorName(protoInstance[fieldname][10]);
                    fieldcache.push(`map<int32, ${messageCtorname}> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                    // SETS THE FIELDNAME TO DONEFIELDS
                }
            });
        } catch (e) {
        }
    }

    // Step 10.9 loop with map<int32, bool> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<number, number>();
        map.set(10, 1);
        testMessage.addMapField(i, map, ProtoFieldType.INT32, ProtoFieldType.INT32);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);

                if (fieldvalue == "{\"10\":true}")
                {
                    fieldcache.push(`map<int32, bool> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    
    // Step 10.10 loop with map<string, emptyProto> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<string, ProtobufMessage>();
        map.set("key1", new ProtobufMessage());
        testMessage.addMapField(i, map, ProtoFieldType.STRING, ProtoFieldType.MESSAGE);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                if (fieldvalue.startsWith("{\"key1\":"))
                {
                    let messageCtorname = getFieldTypeFromConstructorName(protoInstance[fieldname]["key1"]);
                    fieldcache.push(`map<string, ${messageCtorname}> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                    // SETS THE FIELDNAME TO DONEFIELDS
                }
            });
        } catch (e) {
        }
    }
    
    // Step 10.11: loop with map<int64, emptyProto> values
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        let map = new Map<bigint, ProtobufMessage>();
        map.set(10n, new ProtobufMessage());
        testMessage.addMapField(i, map, ProtoFieldType.INT64, ProtoFieldType.MESSAGE);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            var built = testMessage.build();
            // console.log(`Base64 of built message for map<int64, emptyProto>: ${btoa(String.fromCharCode(...built))}`);
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                const fieldname = `${field}`;
                if (donefields.includes(fieldname))
                    return;
                const fieldvalue = JSON.stringify(protoInstance[fieldname]);
                // console.log(`Fieldname: ${fieldname} Fieldvalue: ${fieldvalue}`);
                // hardcoded $util.longToHash() for 10n
                if (fieldvalue.startsWith(`{"\\n\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000":`))
                {
                    var firstKey = Object.keys(protoInstance[fieldname])[0];
                    var firstValue = protoInstance[fieldname][firstKey];
                    let messageCtorname = getFieldTypeFromConstructorName(firstValue);
                    fieldcache.push(`map<int64, ${messageCtorname}> ${fieldname} = ${i}`);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }

    // Step 11: loop empty messages
    for (let i = 1; i < 2000; i++) {
        const testMessage = new ProtobufMessage();
        const nestedMessage = new ProtobufMessage();
        testMessage.addField(i, nestedMessage, ProtoFieldType.MESSAGE);
        try {
            let protoInstance = ProtoClass.create(); // Creates an empty instance
            protoInstance = ProtoClass.decode(testMessage.build());
            let fields = Object.keys(protoInstance);
            fields.forEach((field) => {
                let fieldname = `${field}`;
                let fieldvalue = protoInstance[fieldname];
                if (fieldvalue !== undefined && fieldvalue != 0 && !donefields.includes(fieldname)) {
                    // console.log(`loop empty messages ${fieldname}`);
                    const elementName = getFieldTypeFromConstructorName(fieldvalue);
                    const str2add = (`${elementName} ${fieldname} = ${i}`);
                    fieldcache.push(str2add);
                    donefields.push(fieldname);
                }
            });
        } catch (e) {
        }
    }


    let sortedcache:any = {};
    fieldcache.forEach((field) => {
        let fieldval = field.split(" = ")[1];
        let fieldtype = field.split(" = ")[0];
        sortedcache[fieldval] = fieldtype;
    });

    sortedcache = Object.keys(sortedcache).sort().reduce((obj:any, key) => {
        obj[key] = sortedcache[key];
        return obj;
    }, {});
    
    let newprotoName = ProtoName.replace(/\$/g, "DOLLAR");
    let pre = "";
    if (isNested)
    {
        pre = "\t";
    }

    let fields = Object.keys(ProtoClass.create()); // Get field order

    // It could be faster to print them from sortedcache, but it's much better to use original field order

    if (Object.values(pidcache).includes(newprotoName)
        // or if any of the values ends with `.${newprotoName}`
        || Object.values(pidcache).some((pidcachevalue:any) => pidcachevalue.endsWith(`.${newprotoName}`))) {
        let pid = Object.keys(pidcache).find(key => pidcache[key] === newprotoName);
        if (pid === undefined) {
            pid = Object.keys(pidcache).find(key => pidcache[key].endsWith(`.${newprotoName}`));
        }
        let messagetype = getProtoMessageTypeFromPid(Number(pid));
        console.log(`${pre}// ${messagetype} : ${pid}\n${pre}message ${newprotoName} {`);
    } else {
        console.log(`${pre}message ${newprotoName} {`);
    }
    
    // Print fields in the order of `fields`
    fields.forEach((field) => {
        // Find corresponding key in sortedcache
        let entry = Object.entries(sortedcache).find(([key, value]:any) => value.endsWith(` ${field}`));
    
        if (!entry) 
        {
            console.log(`// ${field} (${newprotoName}) not found in sortedcache`);
            return;
        }
    
        let [key, value]:any = entry;
        
        // Check if the field is part of a oneof group
        let isOneOf = Object.values(oneofs).some((group:any) => group.includes(field));
        
        if (isOneOf) return; // Skip oneof fields
    
        let formattedField = value.replace(/\$/g, "DOLLAR");
        console.log(`${pre}\t${formattedField} = ${key};`);
    });
    
    // Process oneof fields
    for (let oneofKey in oneofs) {
        let newoneofKey = oneofKey.replace(/\$/g, "DOLLAR");
        console.log(`${pre}\toneof ${newoneofKey} {`);
        
        let oneof = oneofs[oneofKey];
        
        oneof.forEach((oneofValue:any) => {
            let entry = Object.entries(sortedcache).find(([key, value]:any) => value.endsWith(` ${oneofValue}`));
            
            if (!entry) return;
    
            let [key, value]:any = entry;
            let formattedField = value.replace(/\$/g, "DOLLAR");
    
            console.log(`${pre}\t\t${formattedField} = ${key};`);
        });
    
        console.log(`${pre}\t}`);
    }
    
    console.log(`${pre}}\n`);
    
}

function isEnum(obj:any) {
    return typeof obj === "object" && Object.values(obj).every(v => typeof v === "number");
}

// get all message names from $root
let messages = Object.keys($root.Aki.Protocol); // ["OXn"]// 

console.log(`// Dumped by Hiro420`)
console.log(`syntax = "proto3";\n`);

// loop through all messages
messages.forEach((message) => {
    // log the message type using reflection

    if (message !== "pGd" && message !== "upc") { // m3s
        // return;
    }
    
    let ProtoLogType = $root.Aki.Protocol[message];

    if (isEnum(ProtoLogType)) {
        let enumnames:string[] = [];
        let newmessage = message.replace(/\$/g, "DOLLAR");
        console.log(`enum ${newmessage} {`);
        for (let key in ProtoLogType) {
            // check if the value is a number
            if (isNaN(ProtoLogType[key])) {
                continue;
            }
            let newkey = key.replace(/\$/g, "DOLLAR");
            let pre = `${newmessage}_${newkey}`;
            if (enumnames.includes(pre.toLowerCase())) {
                pre = `${newmessage}_${newkey}${ProtoLogType[key]}`;
            }
            console.log(`\t${pre} = ${ProtoLogType[key]};`);
            enumnames.push(pre.toLowerCase());
        }
        console.log(`}\n`);
        return;
    }

    let oneofs:any = {};

    try {
        const propertyDescriptors = Object.getOwnPropertyDescriptors(ProtoLogType.prototype);
        for (const property in propertyDescriptors) {
            const descriptor = propertyDescriptors[property];

            if (descriptor.set) {
                let obj = {};
                descriptor.set.call(obj, "cockandballs");
                if (!oneofs[property]) {
                    oneofs[property] = [];
                }
                for (let key in obj) {
                    oneofs[property].push(key);
                }
            }
        }
    } catch (e) {
        // console.log(e);
    }


    if (!Object.keys(ProtoLogType).includes("create")) { 
        let newkey = message.replace(/\$/g, "DOLLAR");
        if (Object.values(pidcache).includes(newkey)) {
            let pid = Object.keys(pidcache).find(key => pidcache[key] === newkey);
            let messagetype = getProtoMessageTypeFromPid(Number(pid));
            console.log(`// ${messagetype} : ${pid}\nmessage ${newkey} {`);
        } else {
            console.log(`message ${newkey} {`);
        }
        Object.keys(ProtoLogType).forEach((key) => {
            if (isEnum(ProtoLogType[key])) {
                let newmessage = key.replace(/\$/g, "DOLLAR");
                console.log(`\tenum ${newmessage} {`);
                let newprotolog = ProtoLogType[key];
                for (let key in newprotolog) {
                    // check if the value is a number
                    if (isNaN(newprotolog[key])) {
                        continue;
                    }
                    let newkey = key.replace(/\$/g, "DOLLAR");
                    console.log(`\t\t${newmessage}_${newkey} = ${newprotolog[key]};`);
                }
                console.log(`\t}\n`);
            } else {
                dumpMessage(key, ProtoLogType[key], oneofs, true);
            }
        });
        console.log(`}\n`);
    } else {
        dumpMessage(message, ProtoLogType, oneofs, false);
    }
    


    // check for oneOfGetter
    /*
    	}, gu), o.oNs = (Object.defineProperty(h.prototype, "e5n", {
		get: $util.oneOfGetter(t = ["V8n", "CKn", "fKn", "pKn", "vKn", "j8n", "EKn", "MKn", "SKn", "yKn", "IKn", "TKn", "LKn"]),
		set: $util.oneOfSetter(t)
    */
});