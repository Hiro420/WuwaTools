// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MowTowerLevelsRe : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static MowTowerLevelsRe GetRootAsMowTowerLevelsRe(ByteBuffer _bb) { return GetRootAsMowTowerLevelsRe(_bb, new MowTowerLevelsRe()); }
  public static MowTowerLevelsRe GetRootAsMowTowerLevelsRe(ByteBuffer _bb, MowTowerLevelsRe obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MowTowerLevelsRe __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ActivityId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InstIds(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int InstIdsLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetInstIdsBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetInstIdsBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetInstIdsArray() { return __p.__vector_as_array<int>(10); }
  public int SortId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BuffCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int OptionalBuff(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int OptionalBuffLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetOptionalBuffBytes() { return __p.__vector_as_span<int>(16, 4); }
#else
  public ArraySegment<byte>? GetOptionalBuffBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public int[] GetOptionalBuffArray() { return __p.__vector_as_array<int>(16); }
  public int OpenDay { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PreLevel { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PassScore { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string LevelRewardDesc { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelRewardDescBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetLevelRewardDescBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetLevelRewardDescArray() { return __p.__vector_as_array<byte>(24); }
  public int MowTowerLevel(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MowTowerLevelLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMowTowerLevelBytes() { return __p.__vector_as_span<int>(26, 4); }
#else
  public ArraySegment<byte>? GetMowTowerLevelBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public int[] GetMowTowerLevelArray() { return __p.__vector_as_array<int>(26); }
  public string RewardName { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardNameBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetRewardNameBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetRewardNameArray() { return __p.__vector_as_array<byte>(28); }
  public string RewardTexture { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardTextureBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetRewardTextureBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetRewardTextureArray() { return __p.__vector_as_array<byte>(30); }
  public string LevelDesc { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelDescBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetLevelDescBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetLevelDescArray() { return __p.__vector_as_array<byte>(32); }
  public string NormalTexture { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNormalTextureBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetNormalTextureBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetNormalTextureArray() { return __p.__vector_as_array<byte>(34); }
  public string LockTexture { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLockTextureBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetLockTextureBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetLockTextureArray() { return __p.__vector_as_array<byte>(36); }
  public string LevelTips { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelTipsBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetLevelTipsBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetLevelTipsArray() { return __p.__vector_as_array<byte>(38); }
  public bool IsInfinite { get { int o = __p.__offset(40); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string MonsterDes { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMonsterDesBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetMonsterDesBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetMonsterDesArray() { return __p.__vector_as_array<byte>(42); }

  public static Offset<WWParser.Defs.MowTowerLevelsRe> CreateMowTowerLevelsRe(FlatBufferBuilder builder,
      int id = 0,
      int activity_id = 0,
      int group_id = 0,
      VectorOffset inst_idsOffset = default(VectorOffset),
      int sort_id = 0,
      int buff_count = 0,
      VectorOffset optional_buffOffset = default(VectorOffset),
      int open_day = 0,
      int pre_level = 0,
      int pass_score = 0,
      StringOffset level_reward_descOffset = default(StringOffset),
      VectorOffset mow_tower_levelOffset = default(VectorOffset),
      StringOffset reward_nameOffset = default(StringOffset),
      StringOffset reward_textureOffset = default(StringOffset),
      StringOffset level_descOffset = default(StringOffset),
      StringOffset normal_textureOffset = default(StringOffset),
      StringOffset lock_textureOffset = default(StringOffset),
      StringOffset level_tipsOffset = default(StringOffset),
      bool is_infinite = false,
      StringOffset monster_desOffset = default(StringOffset)) {
    builder.StartTable(20);
    MowTowerLevelsRe.AddMonsterDes(builder, monster_desOffset);
    MowTowerLevelsRe.AddLevelTips(builder, level_tipsOffset);
    MowTowerLevelsRe.AddLockTexture(builder, lock_textureOffset);
    MowTowerLevelsRe.AddNormalTexture(builder, normal_textureOffset);
    MowTowerLevelsRe.AddLevelDesc(builder, level_descOffset);
    MowTowerLevelsRe.AddRewardTexture(builder, reward_textureOffset);
    MowTowerLevelsRe.AddRewardName(builder, reward_nameOffset);
    MowTowerLevelsRe.AddMowTowerLevel(builder, mow_tower_levelOffset);
    MowTowerLevelsRe.AddLevelRewardDesc(builder, level_reward_descOffset);
    MowTowerLevelsRe.AddPassScore(builder, pass_score);
    MowTowerLevelsRe.AddPreLevel(builder, pre_level);
    MowTowerLevelsRe.AddOpenDay(builder, open_day);
    MowTowerLevelsRe.AddOptionalBuff(builder, optional_buffOffset);
    MowTowerLevelsRe.AddBuffCount(builder, buff_count);
    MowTowerLevelsRe.AddSortId(builder, sort_id);
    MowTowerLevelsRe.AddInstIds(builder, inst_idsOffset);
    MowTowerLevelsRe.AddGroupId(builder, group_id);
    MowTowerLevelsRe.AddActivityId(builder, activity_id);
    MowTowerLevelsRe.AddId(builder, id);
    MowTowerLevelsRe.AddIsInfinite(builder, is_infinite);
    return MowTowerLevelsRe.EndMowTowerLevelsRe(builder);
  }

  public static void StartMowTowerLevelsRe(FlatBufferBuilder builder) { builder.StartTable(20); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(1, activityId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, int groupId) { builder.AddInt(2, groupId, 0); }
  public static void AddInstIds(FlatBufferBuilder builder, VectorOffset instIdsOffset) { builder.AddOffset(3, instIdsOffset.Value, 0); }
  public static VectorOffset CreateInstIdsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInstIdsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInstIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInstIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInstIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSortId(FlatBufferBuilder builder, int sortId) { builder.AddInt(4, sortId, 0); }
  public static void AddBuffCount(FlatBufferBuilder builder, int buffCount) { builder.AddInt(5, buffCount, 0); }
  public static void AddOptionalBuff(FlatBufferBuilder builder, VectorOffset optionalBuffOffset) { builder.AddOffset(6, optionalBuffOffset.Value, 0); }
  public static VectorOffset CreateOptionalBuffVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateOptionalBuffVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOptionalBuffVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOptionalBuffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOptionalBuffVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOpenDay(FlatBufferBuilder builder, int openDay) { builder.AddInt(7, openDay, 0); }
  public static void AddPreLevel(FlatBufferBuilder builder, int preLevel) { builder.AddInt(8, preLevel, 0); }
  public static void AddPassScore(FlatBufferBuilder builder, int passScore) { builder.AddInt(9, passScore, 0); }
  public static void AddLevelRewardDesc(FlatBufferBuilder builder, StringOffset levelRewardDescOffset) { builder.AddOffset(10, levelRewardDescOffset.Value, 0); }
  public static void AddMowTowerLevel(FlatBufferBuilder builder, VectorOffset mowTowerLevelOffset) { builder.AddOffset(11, mowTowerLevelOffset.Value, 0); }
  public static VectorOffset CreateMowTowerLevelVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMowTowerLevelVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMowTowerLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMowTowerLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMowTowerLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardName(FlatBufferBuilder builder, StringOffset rewardNameOffset) { builder.AddOffset(12, rewardNameOffset.Value, 0); }
  public static void AddRewardTexture(FlatBufferBuilder builder, StringOffset rewardTextureOffset) { builder.AddOffset(13, rewardTextureOffset.Value, 0); }
  public static void AddLevelDesc(FlatBufferBuilder builder, StringOffset levelDescOffset) { builder.AddOffset(14, levelDescOffset.Value, 0); }
  public static void AddNormalTexture(FlatBufferBuilder builder, StringOffset normalTextureOffset) { builder.AddOffset(15, normalTextureOffset.Value, 0); }
  public static void AddLockTexture(FlatBufferBuilder builder, StringOffset lockTextureOffset) { builder.AddOffset(16, lockTextureOffset.Value, 0); }
  public static void AddLevelTips(FlatBufferBuilder builder, StringOffset levelTipsOffset) { builder.AddOffset(17, levelTipsOffset.Value, 0); }
  public static void AddIsInfinite(FlatBufferBuilder builder, bool isInfinite) { builder.AddBool(18, isInfinite, false); }
  public static void AddMonsterDes(FlatBufferBuilder builder, StringOffset monsterDesOffset) { builder.AddOffset(19, monsterDesOffset.Value, 0); }
  public static Offset<WWParser.Defs.MowTowerLevelsRe> EndMowTowerLevelsRe(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.MowTowerLevelsRe>(o);
  }
  public MowTowerLevelsReT UnPack() {
    var _o = new MowTowerLevelsReT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MowTowerLevelsReT _o) {
    _o.Id = this.Id;
    _o.ActivityId = this.ActivityId;
    _o.GroupId = this.GroupId;
    _o.InstIds = new List<int>();
    for (var _j = 0; _j < this.InstIdsLength; ++_j) {_o.InstIds.Add(this.InstIds(_j));}
    _o.SortId = this.SortId;
    _o.BuffCount = this.BuffCount;
    _o.OptionalBuff = new List<int>();
    for (var _j = 0; _j < this.OptionalBuffLength; ++_j) {_o.OptionalBuff.Add(this.OptionalBuff(_j));}
    _o.OpenDay = this.OpenDay;
    _o.PreLevel = this.PreLevel;
    _o.PassScore = this.PassScore;
    _o.LevelRewardDesc = this.LevelRewardDesc;
    _o.MowTowerLevel = new List<int>();
    for (var _j = 0; _j < this.MowTowerLevelLength; ++_j) {_o.MowTowerLevel.Add(this.MowTowerLevel(_j));}
    _o.RewardName = this.RewardName;
    _o.RewardTexture = this.RewardTexture;
    _o.LevelDesc = this.LevelDesc;
    _o.NormalTexture = this.NormalTexture;
    _o.LockTexture = this.LockTexture;
    _o.LevelTips = this.LevelTips;
    _o.IsInfinite = this.IsInfinite;
    _o.MonsterDes = this.MonsterDes;
  }
  public static Offset<WWParser.Defs.MowTowerLevelsRe> Pack(FlatBufferBuilder builder, MowTowerLevelsReT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.MowTowerLevelsRe>);
    var _inst_ids = default(VectorOffset);
    if (_o.InstIds != null) {
      var __inst_ids = _o.InstIds.ToArray();
      _inst_ids = CreateInstIdsVector(builder, __inst_ids);
    }
    var _optional_buff = default(VectorOffset);
    if (_o.OptionalBuff != null) {
      var __optional_buff = _o.OptionalBuff.ToArray();
      _optional_buff = CreateOptionalBuffVector(builder, __optional_buff);
    }
    var _level_reward_desc = _o.LevelRewardDesc == null ? default(StringOffset) : builder.CreateString(_o.LevelRewardDesc);
    var _mow_tower_level = default(VectorOffset);
    if (_o.MowTowerLevel != null) {
      var __mow_tower_level = _o.MowTowerLevel.ToArray();
      _mow_tower_level = CreateMowTowerLevelVector(builder, __mow_tower_level);
    }
    var _reward_name = _o.RewardName == null ? default(StringOffset) : builder.CreateString(_o.RewardName);
    var _reward_texture = _o.RewardTexture == null ? default(StringOffset) : builder.CreateString(_o.RewardTexture);
    var _level_desc = _o.LevelDesc == null ? default(StringOffset) : builder.CreateString(_o.LevelDesc);
    var _normal_texture = _o.NormalTexture == null ? default(StringOffset) : builder.CreateString(_o.NormalTexture);
    var _lock_texture = _o.LockTexture == null ? default(StringOffset) : builder.CreateString(_o.LockTexture);
    var _level_tips = _o.LevelTips == null ? default(StringOffset) : builder.CreateString(_o.LevelTips);
    var _monster_des = _o.MonsterDes == null ? default(StringOffset) : builder.CreateString(_o.MonsterDes);
    return CreateMowTowerLevelsRe(
      builder,
      _o.Id,
      _o.ActivityId,
      _o.GroupId,
      _inst_ids,
      _o.SortId,
      _o.BuffCount,
      _optional_buff,
      _o.OpenDay,
      _o.PreLevel,
      _o.PassScore,
      _level_reward_desc,
      _mow_tower_level,
      _reward_name,
      _reward_texture,
      _level_desc,
      _normal_texture,
      _lock_texture,
      _level_tips,
      _o.IsInfinite,
      _monster_des);
  }
}

public class MowTowerLevelsReT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("group_id")]
  public int GroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("inst_ids")]
  public List<int> InstIds { get; set; }
  [Newtonsoft.Json.JsonProperty("sort_id")]
  public int SortId { get; set; }
  [Newtonsoft.Json.JsonProperty("buff_count")]
  public int BuffCount { get; set; }
  [Newtonsoft.Json.JsonProperty("optional_buff")]
  public List<int> OptionalBuff { get; set; }
  [Newtonsoft.Json.JsonProperty("open_day")]
  public int OpenDay { get; set; }
  [Newtonsoft.Json.JsonProperty("pre_level")]
  public int PreLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("pass_score")]
  public int PassScore { get; set; }
  [Newtonsoft.Json.JsonProperty("level_reward_desc")]
  public string LevelRewardDesc { get; set; }
  [Newtonsoft.Json.JsonProperty("mow_tower_level")]
  public List<int> MowTowerLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_name")]
  public string RewardName { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_texture")]
  public string RewardTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("level_desc")]
  public string LevelDesc { get; set; }
  [Newtonsoft.Json.JsonProperty("normal_texture")]
  public string NormalTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("lock_texture")]
  public string LockTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("level_tips")]
  public string LevelTips { get; set; }
  [Newtonsoft.Json.JsonProperty("is_infinite")]
  public bool IsInfinite { get; set; }
  [Newtonsoft.Json.JsonProperty("monster_des")]
  public string MonsterDes { get; set; }

  public MowTowerLevelsReT() {
    this.Id = 0;
    this.ActivityId = 0;
    this.GroupId = 0;
    this.InstIds = null;
    this.SortId = 0;
    this.BuffCount = 0;
    this.OptionalBuff = null;
    this.OpenDay = 0;
    this.PreLevel = 0;
    this.PassScore = 0;
    this.LevelRewardDesc = null;
    this.MowTowerLevel = null;
    this.RewardName = null;
    this.RewardTexture = null;
    this.LevelDesc = null;
    this.NormalTexture = null;
    this.LockTexture = null;
    this.LevelTips = null;
    this.IsInfinite = false;
    this.MonsterDes = null;
  }
}


static public class MowTowerLevelsReVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*GroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*InstIds*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 12 /*SortId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*BuffCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*OptionalBuff*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 18 /*OpenDay*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*PreLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*PassScore*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 24 /*LevelRewardDesc*/, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*MowTowerLevel*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 28 /*RewardName*/, false)
      && verifier.VerifyString(tablePos, 30 /*RewardTexture*/, false)
      && verifier.VerifyString(tablePos, 32 /*LevelDesc*/, false)
      && verifier.VerifyString(tablePos, 34 /*NormalTexture*/, false)
      && verifier.VerifyString(tablePos, 36 /*LockTexture*/, false)
      && verifier.VerifyString(tablePos, 38 /*LevelTips*/, false)
      && verifier.VerifyField(tablePos, 40 /*IsInfinite*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 42 /*MonsterDes*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
