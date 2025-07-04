// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RiskHarvestArtifact : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RiskHarvestArtifact GetRootAsRiskHarvestArtifact(ByteBuffer _bb) { return GetRootAsRiskHarvestArtifact(_bb, new RiskHarvestArtifact()); }
  public static RiskHarvestArtifact GetRootAsRiskHarvestArtifact(ByteBuffer _bb, RiskHarvestArtifact obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RiskHarvestArtifact __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BuffGroup(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BuffGroupLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBuffGroupBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetBuffGroupBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetBuffGroupArray() { return __p.__vector_as_array<int>(6); }
  public int BasicBuffGroup(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BasicBuffGroupLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBasicBuffGroupBytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetBasicBuffGroupBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetBasicBuffGroupArray() { return __p.__vector_as_array<int>(8); }

  public static Offset<WWParser.Defs.RiskHarvestArtifact> CreateRiskHarvestArtifact(FlatBufferBuilder builder,
      int id = 0,
      VectorOffset buff_groupOffset = default(VectorOffset),
      VectorOffset basic_buff_groupOffset = default(VectorOffset)) {
    builder.StartTable(3);
    RiskHarvestArtifact.AddBasicBuffGroup(builder, basic_buff_groupOffset);
    RiskHarvestArtifact.AddBuffGroup(builder, buff_groupOffset);
    RiskHarvestArtifact.AddId(builder, id);
    return RiskHarvestArtifact.EndRiskHarvestArtifact(builder);
  }

  public static void StartRiskHarvestArtifact(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddBuffGroup(FlatBufferBuilder builder, VectorOffset buffGroupOffset) { builder.AddOffset(1, buffGroupOffset.Value, 0); }
  public static VectorOffset CreateBuffGroupVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBuffGroupVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBuffGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBuffGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBuffGroupVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBasicBuffGroup(FlatBufferBuilder builder, VectorOffset basicBuffGroupOffset) { builder.AddOffset(2, basicBuffGroupOffset.Value, 0); }
  public static VectorOffset CreateBasicBuffGroupVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBasicBuffGroupVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBasicBuffGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBasicBuffGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBasicBuffGroupVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.RiskHarvestArtifact> EndRiskHarvestArtifact(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RiskHarvestArtifact>(o);
  }
  public RiskHarvestArtifactT UnPack() {
    var _o = new RiskHarvestArtifactT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RiskHarvestArtifactT _o) {
    _o.Id = this.Id;
    _o.BuffGroup = new List<int>();
    for (var _j = 0; _j < this.BuffGroupLength; ++_j) {_o.BuffGroup.Add(this.BuffGroup(_j));}
    _o.BasicBuffGroup = new List<int>();
    for (var _j = 0; _j < this.BasicBuffGroupLength; ++_j) {_o.BasicBuffGroup.Add(this.BasicBuffGroup(_j));}
  }
  public static Offset<WWParser.Defs.RiskHarvestArtifact> Pack(FlatBufferBuilder builder, RiskHarvestArtifactT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RiskHarvestArtifact>);
    var _buff_group = default(VectorOffset);
    if (_o.BuffGroup != null) {
      var __buff_group = _o.BuffGroup.ToArray();
      _buff_group = CreateBuffGroupVector(builder, __buff_group);
    }
    var _basic_buff_group = default(VectorOffset);
    if (_o.BasicBuffGroup != null) {
      var __basic_buff_group = _o.BasicBuffGroup.ToArray();
      _basic_buff_group = CreateBasicBuffGroupVector(builder, __basic_buff_group);
    }
    return CreateRiskHarvestArtifact(
      builder,
      _o.Id,
      _buff_group,
      _basic_buff_group);
  }
}

public class RiskHarvestArtifactT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("buff_group")]
  public List<int> BuffGroup { get; set; }
  [Newtonsoft.Json.JsonProperty("basic_buff_group")]
  public List<int> BasicBuffGroup { get; set; }

  public RiskHarvestArtifactT() {
    this.Id = 0;
    this.BuffGroup = null;
    this.BasicBuffGroup = null;
  }
}


static public class RiskHarvestArtifactVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*BuffGroup*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*BasicBuffGroup*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
