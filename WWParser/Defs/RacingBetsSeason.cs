// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RacingBetsSeason : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RacingBetsSeason GetRootAsRacingBetsSeason(ByteBuffer _bb) { return GetRootAsRacingBetsSeason(_bb, new RacingBetsSeason()); }
  public static RacingBetsSeason GetRootAsRacingBetsSeason(ByteBuffer _bb, RacingBetsSeason obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RacingBetsSeason __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MoneyId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EndReward { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GroupMatches(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int GroupMatchesLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetGroupMatchesBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetGroupMatchesBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetGroupMatchesArray() { return __p.__vector_as_array<int>(10); }
  public int OddsUpdate(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int OddsUpdateLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetOddsUpdateBytes() { return __p.__vector_as_span<int>(12, 4); }
#else
  public ArraySegment<byte>? GetOddsUpdateBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetOddsUpdateArray() { return __p.__vector_as_array<int>(12); }
  public int GearNum { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LegMatchRoundMinTime { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DungeonInstanceId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DungeonEntranceId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ButtleScreenCd { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RandomSeedIndex { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EndMailId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RacingBetsSeason> CreateRacingBetsSeason(FlatBufferBuilder builder,
      int id = 0,
      int money_id = 0,
      int end_reward = 0,
      VectorOffset group_matchesOffset = default(VectorOffset),
      VectorOffset odds_updateOffset = default(VectorOffset),
      int gear_num = 0,
      int leg_match_round_min_time = 0,
      int dungeon_instance_id = 0,
      int dungeon_entrance_id = 0,
      int buttle_screen_cd = 0,
      int random_seed_index = 0,
      int end_mail_id = 0) {
    builder.StartTable(12);
    RacingBetsSeason.AddEndMailId(builder, end_mail_id);
    RacingBetsSeason.AddRandomSeedIndex(builder, random_seed_index);
    RacingBetsSeason.AddButtleScreenCd(builder, buttle_screen_cd);
    RacingBetsSeason.AddDungeonEntranceId(builder, dungeon_entrance_id);
    RacingBetsSeason.AddDungeonInstanceId(builder, dungeon_instance_id);
    RacingBetsSeason.AddLegMatchRoundMinTime(builder, leg_match_round_min_time);
    RacingBetsSeason.AddGearNum(builder, gear_num);
    RacingBetsSeason.AddOddsUpdate(builder, odds_updateOffset);
    RacingBetsSeason.AddGroupMatches(builder, group_matchesOffset);
    RacingBetsSeason.AddEndReward(builder, end_reward);
    RacingBetsSeason.AddMoneyId(builder, money_id);
    RacingBetsSeason.AddId(builder, id);
    return RacingBetsSeason.EndRacingBetsSeason(builder);
  }

  public static void StartRacingBetsSeason(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddMoneyId(FlatBufferBuilder builder, int moneyId) { builder.AddInt(1, moneyId, 0); }
  public static void AddEndReward(FlatBufferBuilder builder, int endReward) { builder.AddInt(2, endReward, 0); }
  public static void AddGroupMatches(FlatBufferBuilder builder, VectorOffset groupMatchesOffset) { builder.AddOffset(3, groupMatchesOffset.Value, 0); }
  public static VectorOffset CreateGroupMatchesVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateGroupMatchesVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGroupMatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGroupMatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartGroupMatchesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOddsUpdate(FlatBufferBuilder builder, VectorOffset oddsUpdateOffset) { builder.AddOffset(4, oddsUpdateOffset.Value, 0); }
  public static VectorOffset CreateOddsUpdateVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateOddsUpdateVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOddsUpdateVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOddsUpdateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOddsUpdateVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGearNum(FlatBufferBuilder builder, int gearNum) { builder.AddInt(5, gearNum, 0); }
  public static void AddLegMatchRoundMinTime(FlatBufferBuilder builder, int legMatchRoundMinTime) { builder.AddInt(6, legMatchRoundMinTime, 0); }
  public static void AddDungeonInstanceId(FlatBufferBuilder builder, int dungeonInstanceId) { builder.AddInt(7, dungeonInstanceId, 0); }
  public static void AddDungeonEntranceId(FlatBufferBuilder builder, int dungeonEntranceId) { builder.AddInt(8, dungeonEntranceId, 0); }
  public static void AddButtleScreenCd(FlatBufferBuilder builder, int buttleScreenCd) { builder.AddInt(9, buttleScreenCd, 0); }
  public static void AddRandomSeedIndex(FlatBufferBuilder builder, int randomSeedIndex) { builder.AddInt(10, randomSeedIndex, 0); }
  public static void AddEndMailId(FlatBufferBuilder builder, int endMailId) { builder.AddInt(11, endMailId, 0); }
  public static Offset<WWParser.Defs.RacingBetsSeason> EndRacingBetsSeason(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RacingBetsSeason>(o);
  }
  public RacingBetsSeasonT UnPack() {
    var _o = new RacingBetsSeasonT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RacingBetsSeasonT _o) {
    _o.Id = this.Id;
    _o.MoneyId = this.MoneyId;
    _o.EndReward = this.EndReward;
    _o.GroupMatches = new List<int>();
    for (var _j = 0; _j < this.GroupMatchesLength; ++_j) {_o.GroupMatches.Add(this.GroupMatches(_j));}
    _o.OddsUpdate = new List<int>();
    for (var _j = 0; _j < this.OddsUpdateLength; ++_j) {_o.OddsUpdate.Add(this.OddsUpdate(_j));}
    _o.GearNum = this.GearNum;
    _o.LegMatchRoundMinTime = this.LegMatchRoundMinTime;
    _o.DungeonInstanceId = this.DungeonInstanceId;
    _o.DungeonEntranceId = this.DungeonEntranceId;
    _o.ButtleScreenCd = this.ButtleScreenCd;
    _o.RandomSeedIndex = this.RandomSeedIndex;
    _o.EndMailId = this.EndMailId;
  }
  public static Offset<WWParser.Defs.RacingBetsSeason> Pack(FlatBufferBuilder builder, RacingBetsSeasonT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RacingBetsSeason>);
    var _group_matches = default(VectorOffset);
    if (_o.GroupMatches != null) {
      var __group_matches = _o.GroupMatches.ToArray();
      _group_matches = CreateGroupMatchesVector(builder, __group_matches);
    }
    var _odds_update = default(VectorOffset);
    if (_o.OddsUpdate != null) {
      var __odds_update = _o.OddsUpdate.ToArray();
      _odds_update = CreateOddsUpdateVector(builder, __odds_update);
    }
    return CreateRacingBetsSeason(
      builder,
      _o.Id,
      _o.MoneyId,
      _o.EndReward,
      _group_matches,
      _odds_update,
      _o.GearNum,
      _o.LegMatchRoundMinTime,
      _o.DungeonInstanceId,
      _o.DungeonEntranceId,
      _o.ButtleScreenCd,
      _o.RandomSeedIndex,
      _o.EndMailId);
  }
}

public class RacingBetsSeasonT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("money_id")]
  public int MoneyId { get; set; }
  [Newtonsoft.Json.JsonProperty("end_reward")]
  public int EndReward { get; set; }
  [Newtonsoft.Json.JsonProperty("group_matches")]
  public List<int> GroupMatches { get; set; }
  [Newtonsoft.Json.JsonProperty("odds_update")]
  public List<int> OddsUpdate { get; set; }
  [Newtonsoft.Json.JsonProperty("gear_num")]
  public int GearNum { get; set; }
  [Newtonsoft.Json.JsonProperty("leg_match_round_min_time")]
  public int LegMatchRoundMinTime { get; set; }
  [Newtonsoft.Json.JsonProperty("dungeon_instance_id")]
  public int DungeonInstanceId { get; set; }
  [Newtonsoft.Json.JsonProperty("dungeon_entrance_id")]
  public int DungeonEntranceId { get; set; }
  [Newtonsoft.Json.JsonProperty("buttle_screen_cd")]
  public int ButtleScreenCd { get; set; }
  [Newtonsoft.Json.JsonProperty("random_seed_index")]
  public int RandomSeedIndex { get; set; }
  [Newtonsoft.Json.JsonProperty("end_mail_id")]
  public int EndMailId { get; set; }

  public RacingBetsSeasonT() {
    this.Id = 0;
    this.MoneyId = 0;
    this.EndReward = 0;
    this.GroupMatches = null;
    this.OddsUpdate = null;
    this.GearNum = 0;
    this.LegMatchRoundMinTime = 0;
    this.DungeonInstanceId = 0;
    this.DungeonEntranceId = 0;
    this.ButtleScreenCd = 0;
    this.RandomSeedIndex = 0;
    this.EndMailId = 0;
  }
}


static public class RacingBetsSeasonVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MoneyId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*EndReward*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*GroupMatches*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*OddsUpdate*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 14 /*GearNum*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*LegMatchRoundMinTime*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*DungeonInstanceId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*DungeonEntranceId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*ButtleScreenCd*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*RandomSeedIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*EndMailId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
