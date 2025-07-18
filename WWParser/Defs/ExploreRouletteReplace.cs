// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ExploreRouletteReplace : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ExploreRouletteReplace GetRootAsExploreRouletteReplace(ByteBuffer _bb) { return GetRootAsExploreRouletteReplace(_bb, new ExploreRouletteReplace()); }
  public static ExploreRouletteReplace GetRootAsExploreRouletteReplace(ByteBuffer _bb, ExploreRouletteReplace obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ExploreRouletteReplace __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string TagsInForce(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int TagsInForceLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int Priority { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RouletteSkillIdList(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RouletteSkillIdListLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRouletteSkillIdListBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetRouletteSkillIdListBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetRouletteSkillIdListArray() { return __p.__vector_as_array<int>(10); }
  public int RouletteItemId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ReplaceSkillId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.ExploreRouletteReplace> CreateExploreRouletteReplace(FlatBufferBuilder builder,
      int id = 0,
      VectorOffset tags_in_forceOffset = default(VectorOffset),
      int priority = 0,
      VectorOffset roulette_skill_id_listOffset = default(VectorOffset),
      int roulette_item_id = 0,
      int replace_skill_id = 0) {
    builder.StartTable(6);
    ExploreRouletteReplace.AddReplaceSkillId(builder, replace_skill_id);
    ExploreRouletteReplace.AddRouletteItemId(builder, roulette_item_id);
    ExploreRouletteReplace.AddRouletteSkillIdList(builder, roulette_skill_id_listOffset);
    ExploreRouletteReplace.AddPriority(builder, priority);
    ExploreRouletteReplace.AddTagsInForce(builder, tags_in_forceOffset);
    ExploreRouletteReplace.AddId(builder, id);
    return ExploreRouletteReplace.EndExploreRouletteReplace(builder);
  }

  public static void StartExploreRouletteReplace(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTagsInForce(FlatBufferBuilder builder, VectorOffset tagsInForceOffset) { builder.AddOffset(1, tagsInForceOffset.Value, 0); }
  public static VectorOffset CreateTagsInForceVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTagsInForceVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsInForceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsInForceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsInForceVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(2, priority, 0); }
  public static void AddRouletteSkillIdList(FlatBufferBuilder builder, VectorOffset rouletteSkillIdListOffset) { builder.AddOffset(3, rouletteSkillIdListOffset.Value, 0); }
  public static VectorOffset CreateRouletteSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRouletteSkillIdListVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRouletteSkillIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRouletteSkillIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRouletteSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRouletteItemId(FlatBufferBuilder builder, int rouletteItemId) { builder.AddInt(4, rouletteItemId, 0); }
  public static void AddReplaceSkillId(FlatBufferBuilder builder, int replaceSkillId) { builder.AddInt(5, replaceSkillId, 0); }
  public static Offset<WWParser.Defs.ExploreRouletteReplace> EndExploreRouletteReplace(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ExploreRouletteReplace>(o);
  }
  public ExploreRouletteReplaceT UnPack() {
    var _o = new ExploreRouletteReplaceT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ExploreRouletteReplaceT _o) {
    _o.Id = this.Id;
    _o.TagsInForce = new List<string>();
    for (var _j = 0; _j < this.TagsInForceLength; ++_j) {_o.TagsInForce.Add(this.TagsInForce(_j));}
    _o.Priority = this.Priority;
    _o.RouletteSkillIdList = new List<int>();
    for (var _j = 0; _j < this.RouletteSkillIdListLength; ++_j) {_o.RouletteSkillIdList.Add(this.RouletteSkillIdList(_j));}
    _o.RouletteItemId = this.RouletteItemId;
    _o.ReplaceSkillId = this.ReplaceSkillId;
  }
  public static Offset<WWParser.Defs.ExploreRouletteReplace> Pack(FlatBufferBuilder builder, ExploreRouletteReplaceT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ExploreRouletteReplace>);
    var _tags_in_force = default(VectorOffset);
    if (_o.TagsInForce != null) {
      var __tags_in_force = new StringOffset[_o.TagsInForce.Count];
      for (var _j = 0; _j < __tags_in_force.Length; ++_j) { __tags_in_force[_j] = builder.CreateString(_o.TagsInForce[_j]); }
      _tags_in_force = CreateTagsInForceVector(builder, __tags_in_force);
    }
    var _roulette_skill_id_list = default(VectorOffset);
    if (_o.RouletteSkillIdList != null) {
      var __roulette_skill_id_list = _o.RouletteSkillIdList.ToArray();
      _roulette_skill_id_list = CreateRouletteSkillIdListVector(builder, __roulette_skill_id_list);
    }
    return CreateExploreRouletteReplace(
      builder,
      _o.Id,
      _tags_in_force,
      _o.Priority,
      _roulette_skill_id_list,
      _o.RouletteItemId,
      _o.ReplaceSkillId);
  }
}

public class ExploreRouletteReplaceT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("tags_in_force")]
  public List<string> TagsInForce { get; set; }
  [Newtonsoft.Json.JsonProperty("priority")]
  public int Priority { get; set; }
  [Newtonsoft.Json.JsonProperty("roulette_skill_id_list")]
  public List<int> RouletteSkillIdList { get; set; }
  [Newtonsoft.Json.JsonProperty("roulette_item_id")]
  public int RouletteItemId { get; set; }
  [Newtonsoft.Json.JsonProperty("replace_skill_id")]
  public int ReplaceSkillId { get; set; }

  public ExploreRouletteReplaceT() {
    this.Id = 0;
    this.TagsInForce = null;
    this.Priority = 0;
    this.RouletteSkillIdList = null;
    this.RouletteItemId = 0;
    this.ReplaceSkillId = 0;
  }
}


static public class ExploreRouletteReplaceVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfStrings(tablePos, 6 /*TagsInForce*/, false)
      && verifier.VerifyField(tablePos, 8 /*Priority*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*RouletteSkillIdList*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 12 /*RouletteItemId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ReplaceSkillId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
