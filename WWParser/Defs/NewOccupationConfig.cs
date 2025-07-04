// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct NewOccupationConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static NewOccupationConfig GetRootAsNewOccupationConfig(ByteBuffer _bb) { return GetRootAsNewOccupationConfig(_bb, new NewOccupationConfig()); }
  public static NewOccupationConfig GetRootAsNewOccupationConfig(ByteBuffer _bb, NewOccupationConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public NewOccupationConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Id { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetIdArray() { return __p.__vector_as_array<byte>(4); }
  public string OccupationType { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOccupationTypeBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetOccupationTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetOccupationTypeArray() { return __p.__vector_as_array<byte>(6); }
  public string OccupationData { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOccupationDataBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetOccupationDataBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetOccupationDataArray() { return __p.__vector_as_array<byte>(8); }
  public string OccupationNameStringKey { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOccupationNameStringKeyBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetOccupationNameStringKeyBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetOccupationNameStringKeyArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.NewOccupationConfig> CreateNewOccupationConfig(FlatBufferBuilder builder,
      StringOffset idOffset = default(StringOffset),
      StringOffset occupation_typeOffset = default(StringOffset),
      StringOffset occupation_dataOffset = default(StringOffset),
      StringOffset occupation_name_string_keyOffset = default(StringOffset)) {
    builder.StartTable(4);
    NewOccupationConfig.AddOccupationNameStringKey(builder, occupation_name_string_keyOffset);
    NewOccupationConfig.AddOccupationData(builder, occupation_dataOffset);
    NewOccupationConfig.AddOccupationType(builder, occupation_typeOffset);
    NewOccupationConfig.AddId(builder, idOffset);
    return NewOccupationConfig.EndNewOccupationConfig(builder);
  }

  public static void StartNewOccupationConfig(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, StringOffset idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  public static void AddOccupationType(FlatBufferBuilder builder, StringOffset occupationTypeOffset) { builder.AddOffset(1, occupationTypeOffset.Value, 0); }
  public static void AddOccupationData(FlatBufferBuilder builder, StringOffset occupationDataOffset) { builder.AddOffset(2, occupationDataOffset.Value, 0); }
  public static void AddOccupationNameStringKey(FlatBufferBuilder builder, StringOffset occupationNameStringKeyOffset) { builder.AddOffset(3, occupationNameStringKeyOffset.Value, 0); }
  public static Offset<WWParser.Defs.NewOccupationConfig> EndNewOccupationConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.NewOccupationConfig>(o);
  }
  public NewOccupationConfigT UnPack() {
    var _o = new NewOccupationConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(NewOccupationConfigT _o) {
    _o.Id = this.Id;
    _o.OccupationType = this.OccupationType;
    _o.OccupationData = this.OccupationData;
    _o.OccupationNameStringKey = this.OccupationNameStringKey;
  }
  public static Offset<WWParser.Defs.NewOccupationConfig> Pack(FlatBufferBuilder builder, NewOccupationConfigT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.NewOccupationConfig>);
    var _id = _o.Id == null ? default(StringOffset) : builder.CreateString(_o.Id);
    var _occupation_type = _o.OccupationType == null ? default(StringOffset) : builder.CreateString(_o.OccupationType);
    var _occupation_data = _o.OccupationData == null ? default(StringOffset) : builder.CreateString(_o.OccupationData);
    var _occupation_name_string_key = _o.OccupationNameStringKey == null ? default(StringOffset) : builder.CreateString(_o.OccupationNameStringKey);
    return CreateNewOccupationConfig(
      builder,
      _id,
      _occupation_type,
      _occupation_data,
      _occupation_name_string_key);
  }
}

public class NewOccupationConfigT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public string Id { get; set; }
  [Newtonsoft.Json.JsonProperty("occupation_type")]
  public string OccupationType { get; set; }
  [Newtonsoft.Json.JsonProperty("occupation_data")]
  public string OccupationData { get; set; }
  [Newtonsoft.Json.JsonProperty("occupation_name_string_key")]
  public string OccupationNameStringKey { get; set; }

  public NewOccupationConfigT() {
    this.Id = null;
    this.OccupationType = null;
    this.OccupationData = null;
    this.OccupationNameStringKey = null;
  }
}


static public class NewOccupationConfigVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Id*/, false)
      && verifier.VerifyString(tablePos, 6 /*OccupationType*/, false)
      && verifier.VerifyString(tablePos, 8 /*OccupationData*/, false)
      && verifier.VerifyString(tablePos, 10 /*OccupationNameStringKey*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
