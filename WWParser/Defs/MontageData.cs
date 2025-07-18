// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MontageData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static MontageData GetRootAsMontageData(ByteBuffer _bb) { return GetRootAsMontageData(_bb, new MontageData()); }
  public static MontageData GetRootAsMontageData(ByteBuffer _bb, MontageData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MontageData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string ActionMontage { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetActionMontageBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetActionMontageBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetActionMontageArray() { return __p.__vector_as_array<byte>(6); }
  public string ExpressionMontage { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExpressionMontageBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetExpressionMontageBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetExpressionMontageArray() { return __p.__vector_as_array<byte>(8); }
  public string MouthSequence { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMouthSequenceBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetMouthSequenceBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetMouthSequenceArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.MontageData> CreateMontageData(FlatBufferBuilder builder,
      int id = 0,
      StringOffset action_montageOffset = default(StringOffset),
      StringOffset expression_montageOffset = default(StringOffset),
      StringOffset mouth_sequenceOffset = default(StringOffset)) {
    builder.StartTable(4);
    MontageData.AddMouthSequence(builder, mouth_sequenceOffset);
    MontageData.AddExpressionMontage(builder, expression_montageOffset);
    MontageData.AddActionMontage(builder, action_montageOffset);
    MontageData.AddId(builder, id);
    return MontageData.EndMontageData(builder);
  }

  public static void StartMontageData(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddActionMontage(FlatBufferBuilder builder, StringOffset actionMontageOffset) { builder.AddOffset(1, actionMontageOffset.Value, 0); }
  public static void AddExpressionMontage(FlatBufferBuilder builder, StringOffset expressionMontageOffset) { builder.AddOffset(2, expressionMontageOffset.Value, 0); }
  public static void AddMouthSequence(FlatBufferBuilder builder, StringOffset mouthSequenceOffset) { builder.AddOffset(3, mouthSequenceOffset.Value, 0); }
  public static Offset<WWParser.Defs.MontageData> EndMontageData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.MontageData>(o);
  }
  public MontageDataT UnPack() {
    var _o = new MontageDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MontageDataT _o) {
    _o.Id = this.Id;
    _o.ActionMontage = this.ActionMontage;
    _o.ExpressionMontage = this.ExpressionMontage;
    _o.MouthSequence = this.MouthSequence;
  }
  public static Offset<WWParser.Defs.MontageData> Pack(FlatBufferBuilder builder, MontageDataT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.MontageData>);
    var _action_montage = _o.ActionMontage == null ? default(StringOffset) : builder.CreateString(_o.ActionMontage);
    var _expression_montage = _o.ExpressionMontage == null ? default(StringOffset) : builder.CreateString(_o.ExpressionMontage);
    var _mouth_sequence = _o.MouthSequence == null ? default(StringOffset) : builder.CreateString(_o.MouthSequence);
    return CreateMontageData(
      builder,
      _o.Id,
      _action_montage,
      _expression_montage,
      _mouth_sequence);
  }
}

public class MontageDataT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("action_montage")]
  public string ActionMontage { get; set; }
  [Newtonsoft.Json.JsonProperty("expression_montage")]
  public string ExpressionMontage { get; set; }
  [Newtonsoft.Json.JsonProperty("mouth_sequence")]
  public string MouthSequence { get; set; }

  public MontageDataT() {
    this.Id = 0;
    this.ActionMontage = null;
    this.ExpressionMontage = null;
    this.MouthSequence = null;
  }
}


static public class MontageDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*ActionMontage*/, false)
      && verifier.VerifyString(tablePos, 8 /*ExpressionMontage*/, false)
      && verifier.VerifyString(tablePos, 10 /*MouthSequence*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
