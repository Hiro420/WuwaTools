// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RogueResTalentTree : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RogueResTalentTree GetRootAsRogueResTalentTree(ByteBuffer _bb) { return GetRootAsRogueResTalentTree(_bb, new RogueResTalentTree()); }
  public static RogueResTalentTree GetRootAsRogueResTalentTree(ByteBuffer _bb, RogueResTalentTree obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RogueResTalentTree __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SeasonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Condition { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Consule(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ConsuleLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetConsuleBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetConsuleBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetConsuleArray() { return __p.__vector_as_array<int>(10); }
  public int Describe { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RogueResTalentTree> CreateRogueResTalentTree(FlatBufferBuilder builder,
      int id = 0,
      int season_id = 0,
      int condition = 0,
      VectorOffset consuleOffset = default(VectorOffset),
      int describe = 0) {
    builder.StartTable(5);
    RogueResTalentTree.AddDescribe(builder, describe);
    RogueResTalentTree.AddConsule(builder, consuleOffset);
    RogueResTalentTree.AddCondition(builder, condition);
    RogueResTalentTree.AddSeasonId(builder, season_id);
    RogueResTalentTree.AddId(builder, id);
    return RogueResTalentTree.EndRogueResTalentTree(builder);
  }

  public static void StartRogueResTalentTree(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, int seasonId) { builder.AddInt(1, seasonId, 0); }
  public static void AddCondition(FlatBufferBuilder builder, int condition) { builder.AddInt(2, condition, 0); }
  public static void AddConsule(FlatBufferBuilder builder, VectorOffset consuleOffset) { builder.AddOffset(3, consuleOffset.Value, 0); }
  public static VectorOffset CreateConsuleVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsuleVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsuleVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsuleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsuleVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDescribe(FlatBufferBuilder builder, int describe) { builder.AddInt(4, describe, 0); }
  public static Offset<WWParser.Defs.RogueResTalentTree> EndRogueResTalentTree(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RogueResTalentTree>(o);
  }
  public RogueResTalentTreeT UnPack() {
    var _o = new RogueResTalentTreeT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RogueResTalentTreeT _o) {
    _o.Id = this.Id;
    _o.SeasonId = this.SeasonId;
    _o.Condition = this.Condition;
    _o.Consule = new List<int>();
    for (var _j = 0; _j < this.ConsuleLength; ++_j) {_o.Consule.Add(this.Consule(_j));}
    _o.Describe = this.Describe;
  }
  public static Offset<WWParser.Defs.RogueResTalentTree> Pack(FlatBufferBuilder builder, RogueResTalentTreeT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RogueResTalentTree>);
    var _consule = default(VectorOffset);
    if (_o.Consule != null) {
      var __consule = _o.Consule.ToArray();
      _consule = CreateConsuleVector(builder, __consule);
    }
    return CreateRogueResTalentTree(
      builder,
      _o.Id,
      _o.SeasonId,
      _o.Condition,
      _consule,
      _o.Describe);
  }
}

public class RogueResTalentTreeT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("season_id")]
  public int SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("condition")]
  public int Condition { get; set; }
  [Newtonsoft.Json.JsonProperty("consule")]
  public List<int> Consule { get; set; }
  [Newtonsoft.Json.JsonProperty("describe")]
  public int Describe { get; set; }

  public RogueResTalentTreeT() {
    this.Id = 0;
    this.SeasonId = 0;
    this.Condition = 0;
    this.Consule = null;
    this.Describe = 0;
  }
}


static public class RogueResTalentTreeVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Condition*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*Consule*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 12 /*Describe*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
