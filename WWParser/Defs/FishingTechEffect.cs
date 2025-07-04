// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FishingTechEffect : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static FishingTechEffect GetRootAsFishingTechEffect(ByteBuffer _bb) { return GetRootAsFishingTechEffect(_bb, new FishingTechEffect()); }
  public static FishingTechEffect GetRootAsFishingTechEffect(ByteBuffer _bb, FishingTechEffect obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FishingTechEffect __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Type { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.DicIntInt? Consume(int j) { int o = __p.__offset(8); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ConsumeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Desc { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(10); }
  public int Params(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ParamsLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetParamsBytes() { return __p.__vector_as_span<int>(12, 4); }
#else
  public ArraySegment<byte>? GetParamsBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetParamsArray() { return __p.__vector_as_array<int>(12); }
  public WWParser.Defs.DicIntInt? ParamDic(int j) { int o = __p.__offset(14); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ParamDicLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ShowParams(int j) { int o = __p.__offset(16); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShowParamsLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<WWParser.Defs.FishingTechEffect> CreateFishingTechEffect(FlatBufferBuilder builder,
      int id = 0,
      int type = 0,
      VectorOffset consumeOffset = default(VectorOffset),
      StringOffset descOffset = default(StringOffset),
      VectorOffset @paramsOffset = default(VectorOffset),
      VectorOffset param_dicOffset = default(VectorOffset),
      VectorOffset show_paramsOffset = default(VectorOffset)) {
    builder.StartTable(7);
    FishingTechEffect.AddShowParams(builder, show_paramsOffset);
    FishingTechEffect.AddParamDic(builder, param_dicOffset);
    FishingTechEffect.AddParams(builder, @paramsOffset);
    FishingTechEffect.AddDesc(builder, descOffset);
    FishingTechEffect.AddConsume(builder, consumeOffset);
    FishingTechEffect.AddType(builder, type);
    FishingTechEffect.AddId(builder, id);
    return FishingTechEffect.EndFishingTechEffect(builder);
  }

  public static void StartFishingTechEffect(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddType(FlatBufferBuilder builder, int type) { builder.AddInt(1, type, 0); }
  public static void AddConsume(FlatBufferBuilder builder, VectorOffset consumeOffset) { builder.AddOffset(2, consumeOffset.Value, 0); }
  public static VectorOffset CreateConsumeVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset) { builder.AddOffset(3, descOffset.Value, 0); }
  public static void AddParams(FlatBufferBuilder builder, VectorOffset paramsOffset) { builder.AddOffset(4, paramsOffset.Value, 0); }
  public static VectorOffset CreateParamsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParamsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParamDic(FlatBufferBuilder builder, VectorOffset paramDicOffset) { builder.AddOffset(5, paramDicOffset.Value, 0); }
  public static VectorOffset CreateParamDicVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateParamDicVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParamDicVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParamDicVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParamDicVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowParams(FlatBufferBuilder builder, VectorOffset showParamsOffset) { builder.AddOffset(6, showParamsOffset.Value, 0); }
  public static VectorOffset CreateShowParamsVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShowParamsVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowParamsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowParamsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShowParamsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.FishingTechEffect> EndFishingTechEffect(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.FishingTechEffect>(o);
  }
  public FishingTechEffectT UnPack() {
    var _o = new FishingTechEffectT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FishingTechEffectT _o) {
    _o.Id = this.Id;
    _o.Type = this.Type;
    _o.Consume = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.ConsumeLength; ++_j) {_o.Consume.Add(this.Consume(_j).HasValue ? this.Consume(_j).Value.UnPack() : null);}
    _o.Desc = this.Desc;
    _o.Params = new List<int>();
    for (var _j = 0; _j < this.ParamsLength; ++_j) {_o.Params.Add(this.Params(_j));}
    _o.ParamDic = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.ParamDicLength; ++_j) {_o.ParamDic.Add(this.ParamDic(_j).HasValue ? this.ParamDic(_j).Value.UnPack() : null);}
    _o.ShowParams = new List<string>();
    for (var _j = 0; _j < this.ShowParamsLength; ++_j) {_o.ShowParams.Add(this.ShowParams(_j));}
  }
  public static Offset<WWParser.Defs.FishingTechEffect> Pack(FlatBufferBuilder builder, FishingTechEffectT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.FishingTechEffect>);
    var _consume = default(VectorOffset);
    if (_o.Consume != null) {
      var __consume = new Offset<WWParser.Defs.DicIntInt>[_o.Consume.Count];
      for (var _j = 0; _j < __consume.Length; ++_j) { __consume[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.Consume[_j]); }
      _consume = CreateConsumeVector(builder, __consume);
    }
    var _desc = _o.Desc == null ? default(StringOffset) : builder.CreateString(_o.Desc);
    var _params = default(VectorOffset);
    if (_o.Params != null) {
      var __params = _o.Params.ToArray();
      _params = CreateParamsVector(builder, __params);
    }
    var _param_dic = default(VectorOffset);
    if (_o.ParamDic != null) {
      var __param_dic = new Offset<WWParser.Defs.DicIntInt>[_o.ParamDic.Count];
      for (var _j = 0; _j < __param_dic.Length; ++_j) { __param_dic[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.ParamDic[_j]); }
      _param_dic = CreateParamDicVector(builder, __param_dic);
    }
    var _show_params = default(VectorOffset);
    if (_o.ShowParams != null) {
      var __show_params = new StringOffset[_o.ShowParams.Count];
      for (var _j = 0; _j < __show_params.Length; ++_j) { __show_params[_j] = builder.CreateString(_o.ShowParams[_j]); }
      _show_params = CreateShowParamsVector(builder, __show_params);
    }
    return CreateFishingTechEffect(
      builder,
      _o.Id,
      _o.Type,
      _consume,
      _desc,
      _params,
      _param_dic,
      _show_params);
  }
}

public class FishingTechEffectT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("type")]
  public int Type { get; set; }
  [Newtonsoft.Json.JsonProperty("consume")]
  public List<WWParser.Defs.DicIntIntT> Consume { get; set; }
  [Newtonsoft.Json.JsonProperty("desc")]
  public string Desc { get; set; }
  [Newtonsoft.Json.JsonProperty("params")]
  public List<int> Params { get; set; }
  [Newtonsoft.Json.JsonProperty("param_dic")]
  public List<WWParser.Defs.DicIntIntT> ParamDic { get; set; }
  [Newtonsoft.Json.JsonProperty("show_params")]
  public List<string> ShowParams { get; set; }

  public FishingTechEffectT() {
    this.Id = 0;
    this.Type = 0;
    this.Consume = null;
    this.Desc = null;
    this.Params = null;
    this.ParamDic = null;
    this.ShowParams = null;
  }
}


static public class FishingTechEffectVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Type*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 8 /*Consume*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyString(tablePos, 10 /*Desc*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*Params*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 14 /*ParamDic*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyVectorOfStrings(tablePos, 16 /*ShowParams*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
