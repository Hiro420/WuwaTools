// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GenericPrompt : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static GenericPrompt GetRootAsGenericPrompt(ByteBuffer _bb) { return GetRootAsGenericPrompt(_bb, new GenericPrompt()); }
  public static GenericPrompt GetRootAsGenericPrompt(ByteBuffer _bb, GenericPrompt obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GenericPrompt __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string TipsId { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTipsIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetTipsIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetTipsIdArray() { return __p.__vector_as_array<byte>(4); }
  public int TypeId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string TipsText { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTipsTextBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTipsTextBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTipsTextArray() { return __p.__vector_as_array<byte>(8); }
  public string ExtraText { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExtraTextBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetExtraTextBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetExtraTextArray() { return __p.__vector_as_array<byte>(10); }
  public int Duration { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Priority { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.GenericPrompt> CreateGenericPrompt(FlatBufferBuilder builder,
      StringOffset tips_idOffset = default(StringOffset),
      int type_id = 0,
      StringOffset tips_textOffset = default(StringOffset),
      StringOffset extra_textOffset = default(StringOffset),
      int duration = 0,
      int priority = 0) {
    builder.StartTable(6);
    GenericPrompt.AddPriority(builder, priority);
    GenericPrompt.AddDuration(builder, duration);
    GenericPrompt.AddExtraText(builder, extra_textOffset);
    GenericPrompt.AddTipsText(builder, tips_textOffset);
    GenericPrompt.AddTypeId(builder, type_id);
    GenericPrompt.AddTipsId(builder, tips_idOffset);
    return GenericPrompt.EndGenericPrompt(builder);
  }

  public static void StartGenericPrompt(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddTipsId(FlatBufferBuilder builder, StringOffset tipsIdOffset) { builder.AddOffset(0, tipsIdOffset.Value, 0); }
  public static void AddTypeId(FlatBufferBuilder builder, int typeId) { builder.AddInt(1, typeId, 0); }
  public static void AddTipsText(FlatBufferBuilder builder, StringOffset tipsTextOffset) { builder.AddOffset(2, tipsTextOffset.Value, 0); }
  public static void AddExtraText(FlatBufferBuilder builder, StringOffset extraTextOffset) { builder.AddOffset(3, extraTextOffset.Value, 0); }
  public static void AddDuration(FlatBufferBuilder builder, int duration) { builder.AddInt(4, duration, 0); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(5, priority, 0); }
  public static Offset<WWParser.Defs.GenericPrompt> EndGenericPrompt(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.GenericPrompt>(o);
  }
  public GenericPromptT UnPack() {
    var _o = new GenericPromptT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GenericPromptT _o) {
    _o.TipsId = this.TipsId;
    _o.TypeId = this.TypeId;
    _o.TipsText = this.TipsText;
    _o.ExtraText = this.ExtraText;
    _o.Duration = this.Duration;
    _o.Priority = this.Priority;
  }
  public static Offset<WWParser.Defs.GenericPrompt> Pack(FlatBufferBuilder builder, GenericPromptT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.GenericPrompt>);
    var _tips_id = _o.TipsId == null ? default(StringOffset) : builder.CreateString(_o.TipsId);
    var _tips_text = _o.TipsText == null ? default(StringOffset) : builder.CreateString(_o.TipsText);
    var _extra_text = _o.ExtraText == null ? default(StringOffset) : builder.CreateString(_o.ExtraText);
    return CreateGenericPrompt(
      builder,
      _tips_id,
      _o.TypeId,
      _tips_text,
      _extra_text,
      _o.Duration,
      _o.Priority);
  }
}

public class GenericPromptT
{
  [Newtonsoft.Json.JsonProperty("tips_id")]
  public string TipsId { get; set; }
  [Newtonsoft.Json.JsonProperty("type_id")]
  public int TypeId { get; set; }
  [Newtonsoft.Json.JsonProperty("tips_text")]
  public string TipsText { get; set; }
  [Newtonsoft.Json.JsonProperty("extra_text")]
  public string ExtraText { get; set; }
  [Newtonsoft.Json.JsonProperty("duration")]
  public int Duration { get; set; }
  [Newtonsoft.Json.JsonProperty("priority")]
  public int Priority { get; set; }

  public GenericPromptT() {
    this.TipsId = null;
    this.TypeId = 0;
    this.TipsText = null;
    this.ExtraText = null;
    this.Duration = 0;
    this.Priority = 0;
  }
}


static public class GenericPromptVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*TipsId*/, false)
      && verifier.VerifyField(tablePos, 6 /*TypeId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*TipsText*/, false)
      && verifier.VerifyString(tablePos, 10 /*ExtraText*/, false)
      && verifier.VerifyField(tablePos, 12 /*Duration*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*Priority*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
