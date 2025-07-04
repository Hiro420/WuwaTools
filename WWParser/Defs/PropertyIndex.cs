// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PropertyIndex : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static PropertyIndex GetRootAsPropertyIndex(ByteBuffer _bb) { return GetRootAsPropertyIndex(_bb, new PropertyIndex()); }
  public static PropertyIndex GetRootAsPropertyIndex(ByteBuffer _bb, PropertyIndex obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PropertyIndex __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Key { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetKeyBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetKeyArray() { return __p.__vector_as_array<byte>(6); }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string AnotherName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnotherNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetAnotherNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetAnotherNameArray() { return __p.__vector_as_array<byte>(10); }
  public int ConvertToWhiteId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsShow { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsPercent { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int Priority { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Icon { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(20); }
  public string Dec { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDecBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetDecBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetDecArray() { return __p.__vector_as_array<byte>(22); }

  public static Offset<WWParser.Defs.PropertyIndex> CreatePropertyIndex(FlatBufferBuilder builder,
      int id = 0,
      StringOffset keyOffset = default(StringOffset),
      StringOffset nameOffset = default(StringOffset),
      StringOffset another_nameOffset = default(StringOffset),
      int convert_to_white_id = 0,
      bool is_show = false,
      bool is_percent = false,
      int priority = 0,
      StringOffset iconOffset = default(StringOffset),
      StringOffset decOffset = default(StringOffset)) {
    builder.StartTable(10);
    PropertyIndex.AddDec(builder, decOffset);
    PropertyIndex.AddIcon(builder, iconOffset);
    PropertyIndex.AddPriority(builder, priority);
    PropertyIndex.AddConvertToWhiteId(builder, convert_to_white_id);
    PropertyIndex.AddAnotherName(builder, another_nameOffset);
    PropertyIndex.AddName(builder, nameOffset);
    PropertyIndex.AddKey(builder, keyOffset);
    PropertyIndex.AddId(builder, id);
    PropertyIndex.AddIsPercent(builder, is_percent);
    PropertyIndex.AddIsShow(builder, is_show);
    return PropertyIndex.EndPropertyIndex(builder);
  }

  public static void StartPropertyIndex(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset) { builder.AddOffset(1, keyOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddAnotherName(FlatBufferBuilder builder, StringOffset anotherNameOffset) { builder.AddOffset(3, anotherNameOffset.Value, 0); }
  public static void AddConvertToWhiteId(FlatBufferBuilder builder, int convertToWhiteId) { builder.AddInt(4, convertToWhiteId, 0); }
  public static void AddIsShow(FlatBufferBuilder builder, bool isShow) { builder.AddBool(5, isShow, false); }
  public static void AddIsPercent(FlatBufferBuilder builder, bool isPercent) { builder.AddBool(6, isPercent, false); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(7, priority, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(8, iconOffset.Value, 0); }
  public static void AddDec(FlatBufferBuilder builder, StringOffset decOffset) { builder.AddOffset(9, decOffset.Value, 0); }
  public static Offset<WWParser.Defs.PropertyIndex> EndPropertyIndex(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.PropertyIndex>(o);
  }
  public PropertyIndexT UnPack() {
    var _o = new PropertyIndexT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PropertyIndexT _o) {
    _o.Id = this.Id;
    _o.Key = this.Key;
    _o.Name = this.Name;
    _o.AnotherName = this.AnotherName;
    _o.ConvertToWhiteId = this.ConvertToWhiteId;
    _o.IsShow = this.IsShow;
    _o.IsPercent = this.IsPercent;
    _o.Priority = this.Priority;
    _o.Icon = this.Icon;
    _o.Dec = this.Dec;
  }
  public static Offset<WWParser.Defs.PropertyIndex> Pack(FlatBufferBuilder builder, PropertyIndexT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.PropertyIndex>);
    var _key = _o.Key == null ? default(StringOffset) : builder.CreateString(_o.Key);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _another_name = _o.AnotherName == null ? default(StringOffset) : builder.CreateString(_o.AnotherName);
    var _icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _dec = _o.Dec == null ? default(StringOffset) : builder.CreateString(_o.Dec);
    return CreatePropertyIndex(
      builder,
      _o.Id,
      _key,
      _name,
      _another_name,
      _o.ConvertToWhiteId,
      _o.IsShow,
      _o.IsPercent,
      _o.Priority,
      _icon,
      _dec);
  }
}

public class PropertyIndexT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("key")]
  public string Key { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("another_name")]
  public string AnotherName { get; set; }
  [Newtonsoft.Json.JsonProperty("convert_to_white_id")]
  public int ConvertToWhiteId { get; set; }
  [Newtonsoft.Json.JsonProperty("is_show")]
  public bool IsShow { get; set; }
  [Newtonsoft.Json.JsonProperty("is_percent")]
  public bool IsPercent { get; set; }
  [Newtonsoft.Json.JsonProperty("priority")]
  public int Priority { get; set; }
  [Newtonsoft.Json.JsonProperty("icon")]
  public string Icon { get; set; }
  [Newtonsoft.Json.JsonProperty("dec")]
  public string Dec { get; set; }

  public PropertyIndexT() {
    this.Id = 0;
    this.Key = null;
    this.Name = null;
    this.AnotherName = null;
    this.ConvertToWhiteId = 0;
    this.IsShow = false;
    this.IsPercent = false;
    this.Priority = 0;
    this.Icon = null;
    this.Dec = null;
  }
}


static public class PropertyIndexVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Key*/, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyString(tablePos, 10 /*AnotherName*/, false)
      && verifier.VerifyField(tablePos, 12 /*ConvertToWhiteId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*IsShow*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 16 /*IsPercent*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 18 /*Priority*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*Icon*/, false)
      && verifier.VerifyString(tablePos, 22 /*Dec*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
