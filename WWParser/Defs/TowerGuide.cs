// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TowerGuide : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static TowerGuide GetRootAsTowerGuide(ByteBuffer _bb) { return GetRootAsTowerGuide(_bb, new TowerGuide()); }
  public static TowerGuide GetRootAsTowerGuide(ByteBuffer _bb, TowerGuide obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TowerGuide __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Difficulty { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.DicIntInt? RewardItem(int j) { int o = __p.__offset(8); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RewardItemLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int TrialRoleId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MapMark { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.TowerGuide> CreateTowerGuide(FlatBufferBuilder builder,
      int id = 0,
      int difficulty = 0,
      VectorOffset reward_itemOffset = default(VectorOffset),
      int trial_role_id = 0,
      int map_mark = 0) {
    builder.StartTable(5);
    TowerGuide.AddMapMark(builder, map_mark);
    TowerGuide.AddTrialRoleId(builder, trial_role_id);
    TowerGuide.AddRewardItem(builder, reward_itemOffset);
    TowerGuide.AddDifficulty(builder, difficulty);
    TowerGuide.AddId(builder, id);
    return TowerGuide.EndTowerGuide(builder);
  }

  public static void StartTowerGuide(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddDifficulty(FlatBufferBuilder builder, int difficulty) { builder.AddInt(1, difficulty, 0); }
  public static void AddRewardItem(FlatBufferBuilder builder, VectorOffset rewardItemOffset) { builder.AddOffset(2, rewardItemOffset.Value, 0); }
  public static VectorOffset CreateRewardItemVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRewardItemVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardItemVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardItemVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardItemVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTrialRoleId(FlatBufferBuilder builder, int trialRoleId) { builder.AddInt(3, trialRoleId, 0); }
  public static void AddMapMark(FlatBufferBuilder builder, int mapMark) { builder.AddInt(4, mapMark, 0); }
  public static Offset<WWParser.Defs.TowerGuide> EndTowerGuide(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.TowerGuide>(o);
  }
  public TowerGuideT UnPack() {
    var _o = new TowerGuideT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TowerGuideT _o) {
    _o.Id = this.Id;
    _o.Difficulty = this.Difficulty;
    _o.RewardItem = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.RewardItemLength; ++_j) {_o.RewardItem.Add(this.RewardItem(_j).HasValue ? this.RewardItem(_j).Value.UnPack() : null);}
    _o.TrialRoleId = this.TrialRoleId;
    _o.MapMark = this.MapMark;
  }
  public static Offset<WWParser.Defs.TowerGuide> Pack(FlatBufferBuilder builder, TowerGuideT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.TowerGuide>);
    var _reward_item = default(VectorOffset);
    if (_o.RewardItem != null) {
      var __reward_item = new Offset<WWParser.Defs.DicIntInt>[_o.RewardItem.Count];
      for (var _j = 0; _j < __reward_item.Length; ++_j) { __reward_item[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.RewardItem[_j]); }
      _reward_item = CreateRewardItemVector(builder, __reward_item);
    }
    return CreateTowerGuide(
      builder,
      _o.Id,
      _o.Difficulty,
      _reward_item,
      _o.TrialRoleId,
      _o.MapMark);
  }
}

public class TowerGuideT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("difficulty")]
  public int Difficulty { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_item")]
  public List<WWParser.Defs.DicIntIntT> RewardItem { get; set; }
  [Newtonsoft.Json.JsonProperty("trial_role_id")]
  public int TrialRoleId { get; set; }
  [Newtonsoft.Json.JsonProperty("map_mark")]
  public int MapMark { get; set; }

  public TowerGuideT() {
    this.Id = 0;
    this.Difficulty = 0;
    this.RewardItem = null;
    this.TrialRoleId = 0;
    this.MapMark = 0;
  }
}


static public class TowerGuideVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Difficulty*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 8 /*RewardItem*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyField(tablePos, 10 /*TrialRoleId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*MapMark*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
