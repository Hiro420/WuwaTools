// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GlobalConfigFromCsv : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static GlobalConfigFromCsv GetRootAsGlobalConfigFromCsv(ByteBuffer _bb) { return GetRootAsGlobalConfigFromCsv(_bb, new GlobalConfigFromCsv()); }
  public static GlobalConfigFromCsv GetRootAsGlobalConfigFromCsv(ByteBuffer _bb, GlobalConfigFromCsv obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GlobalConfigFromCsv __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string Desc { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(8); }
  public string Type { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTypeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetTypeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetTypeArray() { return __p.__vector_as_array<byte>(10); }
  public string Value { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetValueBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetValueArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<WWParser.Defs.GlobalConfigFromCsv> CreateGlobalConfigFromCsv(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset descOffset = default(StringOffset),
      StringOffset typeOffset = default(StringOffset),
      StringOffset valueOffset = default(StringOffset)) {
    builder.StartTable(5);
    GlobalConfigFromCsv.AddValue(builder, valueOffset);
    GlobalConfigFromCsv.AddType(builder, typeOffset);
    GlobalConfigFromCsv.AddDesc(builder, descOffset);
    GlobalConfigFromCsv.AddName(builder, nameOffset);
    GlobalConfigFromCsv.AddId(builder, id);
    return GlobalConfigFromCsv.EndGlobalConfigFromCsv(builder);
  }

  public static void StartGlobalConfigFromCsv(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset) { builder.AddOffset(2, descOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset) { builder.AddOffset(3, typeOffset.Value, 0); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset) { builder.AddOffset(4, valueOffset.Value, 0); }
  public static Offset<WWParser.Defs.GlobalConfigFromCsv> EndGlobalConfigFromCsv(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.GlobalConfigFromCsv>(o);
  }
  public GlobalConfigFromCsvT UnPack() {
    var _o = new GlobalConfigFromCsvT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GlobalConfigFromCsvT _o) {
    _o.Id = this.Id;
    _o.Name = this.Name;
    _o.Desc = this.Desc;
    _o.Type = this.Type;
    _o.Value = this.Value;
  }
  public static Offset<WWParser.Defs.GlobalConfigFromCsv> Pack(FlatBufferBuilder builder, GlobalConfigFromCsvT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.GlobalConfigFromCsv>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _desc = _o.Desc == null ? default(StringOffset) : builder.CreateString(_o.Desc);
    var _type = _o.Type == null ? default(StringOffset) : builder.CreateString(_o.Type);
    var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
    return CreateGlobalConfigFromCsv(
      builder,
      _o.Id,
      _name,
      _desc,
      _type,
      _value);
  }
}

public class GlobalConfigFromCsvT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("desc")]
  public string Desc { get; set; }
  [Newtonsoft.Json.JsonProperty("type")]
  public string Type { get; set; }
  [Newtonsoft.Json.JsonProperty("value")]
  public string Value { get; set; }

  public GlobalConfigFromCsvT() {
    this.Id = 0;
    this.Name = null;
    this.Desc = null;
    this.Type = null;
    this.Value = null;
  }
}


static public class GlobalConfigFromCsvVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyString(tablePos, 8 /*Desc*/, false)
      && verifier.VerifyString(tablePos, 10 /*Type*/, false)
      && verifier.VerifyString(tablePos, 12 /*Value*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
