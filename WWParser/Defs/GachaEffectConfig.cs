// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GachaEffectConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static GachaEffectConfig GetRootAsGachaEffectConfig(ByteBuffer _bb) { return GetRootAsGachaEffectConfig(_bb, new GachaEffectConfig()); }
  public static GachaEffectConfig GetRootAsGachaEffectConfig(ByteBuffer _bb, GachaEffectConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GachaEffectConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Times { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Quality { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string FinalShowSequencePath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFinalShowSequencePathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetFinalShowSequencePathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetFinalShowSequencePathArray() { return __p.__vector_as_array<byte>(10); }
  public WWParser.Defs.Color? DefaultColor { get { int o = __p.__offset(12); return o != 0 ? (WWParser.Defs.Color?)(new WWParser.Defs.Color()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public WWParser.Defs.Color? FinalColor { get { int o = __p.__offset(14); return o != 0 ? (WWParser.Defs.Color?)(new WWParser.Defs.Color()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public float DefaultProcess { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ChangeColorProcess { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CompleteChangeColorProcess { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float PlaySequenceProcess { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string SlideCurveAssetPath { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSlideCurveAssetPathBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetSlideCurveAssetPathBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetSlideCurveAssetPathArray() { return __p.__vector_as_array<byte>(24); }

  public static Offset<WWParser.Defs.GachaEffectConfig> CreateGachaEffectConfig(FlatBufferBuilder builder,
      int id = 0,
      int times = 0,
      int quality = 0,
      StringOffset final_show_sequence_pathOffset = default(StringOffset),
      Offset<WWParser.Defs.Color> default_colorOffset = default(Offset<WWParser.Defs.Color>),
      Offset<WWParser.Defs.Color> final_colorOffset = default(Offset<WWParser.Defs.Color>),
      float default_process = 0.0f,
      float change_color_process = 0.0f,
      float complete_change_color_process = 0.0f,
      float play_sequence_process = 0.0f,
      StringOffset slide_curve_asset_pathOffset = default(StringOffset)) {
    builder.StartTable(11);
    GachaEffectConfig.AddSlideCurveAssetPath(builder, slide_curve_asset_pathOffset);
    GachaEffectConfig.AddPlaySequenceProcess(builder, play_sequence_process);
    GachaEffectConfig.AddCompleteChangeColorProcess(builder, complete_change_color_process);
    GachaEffectConfig.AddChangeColorProcess(builder, change_color_process);
    GachaEffectConfig.AddDefaultProcess(builder, default_process);
    GachaEffectConfig.AddFinalColor(builder, final_colorOffset);
    GachaEffectConfig.AddDefaultColor(builder, default_colorOffset);
    GachaEffectConfig.AddFinalShowSequencePath(builder, final_show_sequence_pathOffset);
    GachaEffectConfig.AddQuality(builder, quality);
    GachaEffectConfig.AddTimes(builder, times);
    GachaEffectConfig.AddId(builder, id);
    return GachaEffectConfig.EndGachaEffectConfig(builder);
  }

  public static void StartGachaEffectConfig(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTimes(FlatBufferBuilder builder, int times) { builder.AddInt(1, times, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int quality) { builder.AddInt(2, quality, 0); }
  public static void AddFinalShowSequencePath(FlatBufferBuilder builder, StringOffset finalShowSequencePathOffset) { builder.AddOffset(3, finalShowSequencePathOffset.Value, 0); }
  public static void AddDefaultColor(FlatBufferBuilder builder, Offset<WWParser.Defs.Color> defaultColorOffset) { builder.AddOffset(4, defaultColorOffset.Value, 0); }
  public static void AddFinalColor(FlatBufferBuilder builder, Offset<WWParser.Defs.Color> finalColorOffset) { builder.AddOffset(5, finalColorOffset.Value, 0); }
  public static void AddDefaultProcess(FlatBufferBuilder builder, float defaultProcess) { builder.AddFloat(6, defaultProcess, 0.0f); }
  public static void AddChangeColorProcess(FlatBufferBuilder builder, float changeColorProcess) { builder.AddFloat(7, changeColorProcess, 0.0f); }
  public static void AddCompleteChangeColorProcess(FlatBufferBuilder builder, float completeChangeColorProcess) { builder.AddFloat(8, completeChangeColorProcess, 0.0f); }
  public static void AddPlaySequenceProcess(FlatBufferBuilder builder, float playSequenceProcess) { builder.AddFloat(9, playSequenceProcess, 0.0f); }
  public static void AddSlideCurveAssetPath(FlatBufferBuilder builder, StringOffset slideCurveAssetPathOffset) { builder.AddOffset(10, slideCurveAssetPathOffset.Value, 0); }
  public static Offset<WWParser.Defs.GachaEffectConfig> EndGachaEffectConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.GachaEffectConfig>(o);
  }
  public GachaEffectConfigT UnPack() {
    var _o = new GachaEffectConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GachaEffectConfigT _o) {
    _o.Id = this.Id;
    _o.Times = this.Times;
    _o.Quality = this.Quality;
    _o.FinalShowSequencePath = this.FinalShowSequencePath;
    _o.DefaultColor = this.DefaultColor.HasValue ? this.DefaultColor.Value.UnPack() : null;
    _o.FinalColor = this.FinalColor.HasValue ? this.FinalColor.Value.UnPack() : null;
    _o.DefaultProcess = this.DefaultProcess;
    _o.ChangeColorProcess = this.ChangeColorProcess;
    _o.CompleteChangeColorProcess = this.CompleteChangeColorProcess;
    _o.PlaySequenceProcess = this.PlaySequenceProcess;
    _o.SlideCurveAssetPath = this.SlideCurveAssetPath;
  }
  public static Offset<WWParser.Defs.GachaEffectConfig> Pack(FlatBufferBuilder builder, GachaEffectConfigT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.GachaEffectConfig>);
    var _final_show_sequence_path = _o.FinalShowSequencePath == null ? default(StringOffset) : builder.CreateString(_o.FinalShowSequencePath);
    var _default_color = _o.DefaultColor == null ? default(Offset<WWParser.Defs.Color>) : WWParser.Defs.Color.Pack(builder, _o.DefaultColor);
    var _final_color = _o.FinalColor == null ? default(Offset<WWParser.Defs.Color>) : WWParser.Defs.Color.Pack(builder, _o.FinalColor);
    var _slide_curve_asset_path = _o.SlideCurveAssetPath == null ? default(StringOffset) : builder.CreateString(_o.SlideCurveAssetPath);
    return CreateGachaEffectConfig(
      builder,
      _o.Id,
      _o.Times,
      _o.Quality,
      _final_show_sequence_path,
      _default_color,
      _final_color,
      _o.DefaultProcess,
      _o.ChangeColorProcess,
      _o.CompleteChangeColorProcess,
      _o.PlaySequenceProcess,
      _slide_curve_asset_path);
  }
}

public class GachaEffectConfigT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("times")]
  public int Times { get; set; }
  [Newtonsoft.Json.JsonProperty("quality")]
  public int Quality { get; set; }
  [Newtonsoft.Json.JsonProperty("final_show_sequence_path")]
  public string FinalShowSequencePath { get; set; }
  [Newtonsoft.Json.JsonProperty("default_color")]
  public WWParser.Defs.ColorT DefaultColor { get; set; }
  [Newtonsoft.Json.JsonProperty("final_color")]
  public WWParser.Defs.ColorT FinalColor { get; set; }
  [Newtonsoft.Json.JsonProperty("default_process")]
  public float DefaultProcess { get; set; }
  [Newtonsoft.Json.JsonProperty("change_color_process")]
  public float ChangeColorProcess { get; set; }
  [Newtonsoft.Json.JsonProperty("complete_change_color_process")]
  public float CompleteChangeColorProcess { get; set; }
  [Newtonsoft.Json.JsonProperty("play_sequence_process")]
  public float PlaySequenceProcess { get; set; }
  [Newtonsoft.Json.JsonProperty("slide_curve_asset_path")]
  public string SlideCurveAssetPath { get; set; }

  public GachaEffectConfigT() {
    this.Id = 0;
    this.Times = 0;
    this.Quality = 0;
    this.FinalShowSequencePath = null;
    this.DefaultColor = null;
    this.FinalColor = null;
    this.DefaultProcess = 0.0f;
    this.ChangeColorProcess = 0.0f;
    this.CompleteChangeColorProcess = 0.0f;
    this.PlaySequenceProcess = 0.0f;
    this.SlideCurveAssetPath = null;
  }
}


static public class GachaEffectConfigVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Times*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Quality*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*FinalShowSequencePath*/, false)
      && verifier.VerifyTable(tablePos, 12 /*DefaultColor*/, WWParser.Defs.ColorVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 14 /*FinalColor*/, WWParser.Defs.ColorVerify.Verify, false)
      && verifier.VerifyField(tablePos, 16 /*DefaultProcess*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*ChangeColorProcess*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*CompleteChangeColorProcess*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*PlaySequenceProcess*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 24 /*SlideCurveAssetPath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
