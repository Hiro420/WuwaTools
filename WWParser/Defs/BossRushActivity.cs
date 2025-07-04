// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BossRushActivity : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static BossRushActivity GetRootAsBossRushActivity(ByteBuffer _bb) { return GetRootAsBossRushActivity(_bb, new BossRushActivity()); }
  public static BossRushActivity GetRootAsBossRushActivity(ByteBuffer _bb, BossRushActivity obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BossRushActivity __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ActivityId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InstId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SortId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BuffCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DefaultBuff(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DefaultBuffLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetDefaultBuffBytes() { return __p.__vector_as_span<int>(16, 4); }
#else
  public ArraySegment<byte>? GetDefaultBuffBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public int[] GetDefaultBuffArray() { return __p.__vector_as_array<int>(16); }
  public int OptionalBuff(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int OptionalBuffLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetOptionalBuffBytes() { return __p.__vector_as_span<int>(18, 4); }
#else
  public ArraySegment<byte>? GetOptionalBuffBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public int[] GetOptionalBuffArray() { return __p.__vector_as_array<int>(18); }
  public int UnlockBuff(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int UnlockBuffLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetUnlockBuffBytes() { return __p.__vector_as_span<int>(20, 4); }
#else
  public ArraySegment<byte>? GetUnlockBuffBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public int[] GetUnlockBuffArray() { return __p.__vector_as_array<int>(20); }
  public int OpenDay { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Condition { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PreLevel { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RewardScore { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string LevelRewardDesc { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelRewardDescBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetLevelRewardDescBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetLevelRewardDescArray() { return __p.__vector_as_array<byte>(30); }
  public string LevelDesc { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLevelDescBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetLevelDescBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetLevelDescArray() { return __p.__vector_as_array<byte>(32); }
  public int RewardId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BossInfo { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string PreviewTexture { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPreviewTextureBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetPreviewTextureBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetPreviewTextureArray() { return __p.__vector_as_array<byte>(38); }
  public string StageTexture { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageTextureBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetStageTextureBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetStageTextureArray() { return __p.__vector_as_array<byte>(40); }
  public int BossCount { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ScoreBuffCount { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ScoreBuff(int j) { int o = __p.__offset(46); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ScoreBuffLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetScoreBuffBytes() { return __p.__vector_as_span<int>(46, 4); }
#else
  public ArraySegment<byte>? GetScoreBuffBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public int[] GetScoreBuffArray() { return __p.__vector_as_array<int>(46); }
  public WWParser.Defs.IntPair? LevelScoreRewardList(int j) { int o = __p.__offset(48); return o != 0 ? (WWParser.Defs.IntPair?)(new WWParser.Defs.IntPair()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int LevelScoreRewardListLength { get { int o = __p.__offset(48); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string RewardName { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardNameBytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetRewardNameBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetRewardNameArray() { return __p.__vector_as_array<byte>(50); }
  public string RewardTexture { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardTextureBytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetRewardTextureBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetRewardTextureArray() { return __p.__vector_as_array<byte>(52); }

  public static Offset<WWParser.Defs.BossRushActivity> CreateBossRushActivity(FlatBufferBuilder builder,
      int id = 0,
      int activity_id = 0,
      int inst_id = 0,
      int group_id = 0,
      int sort_id = 0,
      int buff_count = 0,
      VectorOffset default_buffOffset = default(VectorOffset),
      VectorOffset optional_buffOffset = default(VectorOffset),
      VectorOffset unlock_buffOffset = default(VectorOffset),
      int open_day = 0,
      int condition = 0,
      int pre_level = 0,
      int reward_score = 0,
      StringOffset level_reward_descOffset = default(StringOffset),
      StringOffset level_descOffset = default(StringOffset),
      int reward_id = 0,
      int boss_info = 0,
      StringOffset preview_textureOffset = default(StringOffset),
      StringOffset stage_textureOffset = default(StringOffset),
      int boss_count = 0,
      int score_buff_count = 0,
      VectorOffset score_buffOffset = default(VectorOffset),
      VectorOffset level_score_reward_listOffset = default(VectorOffset),
      StringOffset reward_nameOffset = default(StringOffset),
      StringOffset reward_textureOffset = default(StringOffset)) {
    builder.StartTable(25);
    BossRushActivity.AddRewardTexture(builder, reward_textureOffset);
    BossRushActivity.AddRewardName(builder, reward_nameOffset);
    BossRushActivity.AddLevelScoreRewardList(builder, level_score_reward_listOffset);
    BossRushActivity.AddScoreBuff(builder, score_buffOffset);
    BossRushActivity.AddScoreBuffCount(builder, score_buff_count);
    BossRushActivity.AddBossCount(builder, boss_count);
    BossRushActivity.AddStageTexture(builder, stage_textureOffset);
    BossRushActivity.AddPreviewTexture(builder, preview_textureOffset);
    BossRushActivity.AddBossInfo(builder, boss_info);
    BossRushActivity.AddRewardId(builder, reward_id);
    BossRushActivity.AddLevelDesc(builder, level_descOffset);
    BossRushActivity.AddLevelRewardDesc(builder, level_reward_descOffset);
    BossRushActivity.AddRewardScore(builder, reward_score);
    BossRushActivity.AddPreLevel(builder, pre_level);
    BossRushActivity.AddCondition(builder, condition);
    BossRushActivity.AddOpenDay(builder, open_day);
    BossRushActivity.AddUnlockBuff(builder, unlock_buffOffset);
    BossRushActivity.AddOptionalBuff(builder, optional_buffOffset);
    BossRushActivity.AddDefaultBuff(builder, default_buffOffset);
    BossRushActivity.AddBuffCount(builder, buff_count);
    BossRushActivity.AddSortId(builder, sort_id);
    BossRushActivity.AddGroupId(builder, group_id);
    BossRushActivity.AddInstId(builder, inst_id);
    BossRushActivity.AddActivityId(builder, activity_id);
    BossRushActivity.AddId(builder, id);
    return BossRushActivity.EndBossRushActivity(builder);
  }

  public static void StartBossRushActivity(FlatBufferBuilder builder) { builder.StartTable(25); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(1, activityId, 0); }
  public static void AddInstId(FlatBufferBuilder builder, int instId) { builder.AddInt(2, instId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, int groupId) { builder.AddInt(3, groupId, 0); }
  public static void AddSortId(FlatBufferBuilder builder, int sortId) { builder.AddInt(4, sortId, 0); }
  public static void AddBuffCount(FlatBufferBuilder builder, int buffCount) { builder.AddInt(5, buffCount, 0); }
  public static void AddDefaultBuff(FlatBufferBuilder builder, VectorOffset defaultBuffOffset) { builder.AddOffset(6, defaultBuffOffset.Value, 0); }
  public static VectorOffset CreateDefaultBuffVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDefaultBuffVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDefaultBuffVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDefaultBuffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDefaultBuffVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOptionalBuff(FlatBufferBuilder builder, VectorOffset optionalBuffOffset) { builder.AddOffset(7, optionalBuffOffset.Value, 0); }
  public static VectorOffset CreateOptionalBuffVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateOptionalBuffVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOptionalBuffVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOptionalBuffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOptionalBuffVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnlockBuff(FlatBufferBuilder builder, VectorOffset unlockBuffOffset) { builder.AddOffset(8, unlockBuffOffset.Value, 0); }
  public static VectorOffset CreateUnlockBuffVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnlockBuffVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockBuffVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockBuffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnlockBuffVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOpenDay(FlatBufferBuilder builder, int openDay) { builder.AddInt(9, openDay, 0); }
  public static void AddCondition(FlatBufferBuilder builder, int condition) { builder.AddInt(10, condition, 0); }
  public static void AddPreLevel(FlatBufferBuilder builder, int preLevel) { builder.AddInt(11, preLevel, 0); }
  public static void AddRewardScore(FlatBufferBuilder builder, int rewardScore) { builder.AddInt(12, rewardScore, 0); }
  public static void AddLevelRewardDesc(FlatBufferBuilder builder, StringOffset levelRewardDescOffset) { builder.AddOffset(13, levelRewardDescOffset.Value, 0); }
  public static void AddLevelDesc(FlatBufferBuilder builder, StringOffset levelDescOffset) { builder.AddOffset(14, levelDescOffset.Value, 0); }
  public static void AddRewardId(FlatBufferBuilder builder, int rewardId) { builder.AddInt(15, rewardId, 0); }
  public static void AddBossInfo(FlatBufferBuilder builder, int bossInfo) { builder.AddInt(16, bossInfo, 0); }
  public static void AddPreviewTexture(FlatBufferBuilder builder, StringOffset previewTextureOffset) { builder.AddOffset(17, previewTextureOffset.Value, 0); }
  public static void AddStageTexture(FlatBufferBuilder builder, StringOffset stageTextureOffset) { builder.AddOffset(18, stageTextureOffset.Value, 0); }
  public static void AddBossCount(FlatBufferBuilder builder, int bossCount) { builder.AddInt(19, bossCount, 0); }
  public static void AddScoreBuffCount(FlatBufferBuilder builder, int scoreBuffCount) { builder.AddInt(20, scoreBuffCount, 0); }
  public static void AddScoreBuff(FlatBufferBuilder builder, VectorOffset scoreBuffOffset) { builder.AddOffset(21, scoreBuffOffset.Value, 0); }
  public static VectorOffset CreateScoreBuffVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateScoreBuffVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScoreBuffVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScoreBuffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartScoreBuffVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelScoreRewardList(FlatBufferBuilder builder, VectorOffset levelScoreRewardListOffset) { builder.AddOffset(22, levelScoreRewardListOffset.Value, 0); }
  public static VectorOffset CreateLevelScoreRewardListVector(FlatBufferBuilder builder, Offset<WWParser.Defs.IntPair>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLevelScoreRewardListVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.IntPair>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLevelScoreRewardListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.IntPair>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLevelScoreRewardListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.IntPair>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLevelScoreRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardName(FlatBufferBuilder builder, StringOffset rewardNameOffset) { builder.AddOffset(23, rewardNameOffset.Value, 0); }
  public static void AddRewardTexture(FlatBufferBuilder builder, StringOffset rewardTextureOffset) { builder.AddOffset(24, rewardTextureOffset.Value, 0); }
  public static Offset<WWParser.Defs.BossRushActivity> EndBossRushActivity(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.BossRushActivity>(o);
  }
  public BossRushActivityT UnPack() {
    var _o = new BossRushActivityT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BossRushActivityT _o) {
    _o.Id = this.Id;
    _o.ActivityId = this.ActivityId;
    _o.InstId = this.InstId;
    _o.GroupId = this.GroupId;
    _o.SortId = this.SortId;
    _o.BuffCount = this.BuffCount;
    _o.DefaultBuff = new List<int>();
    for (var _j = 0; _j < this.DefaultBuffLength; ++_j) {_o.DefaultBuff.Add(this.DefaultBuff(_j));}
    _o.OptionalBuff = new List<int>();
    for (var _j = 0; _j < this.OptionalBuffLength; ++_j) {_o.OptionalBuff.Add(this.OptionalBuff(_j));}
    _o.UnlockBuff = new List<int>();
    for (var _j = 0; _j < this.UnlockBuffLength; ++_j) {_o.UnlockBuff.Add(this.UnlockBuff(_j));}
    _o.OpenDay = this.OpenDay;
    _o.Condition = this.Condition;
    _o.PreLevel = this.PreLevel;
    _o.RewardScore = this.RewardScore;
    _o.LevelRewardDesc = this.LevelRewardDesc;
    _o.LevelDesc = this.LevelDesc;
    _o.RewardId = this.RewardId;
    _o.BossInfo = this.BossInfo;
    _o.PreviewTexture = this.PreviewTexture;
    _o.StageTexture = this.StageTexture;
    _o.BossCount = this.BossCount;
    _o.ScoreBuffCount = this.ScoreBuffCount;
    _o.ScoreBuff = new List<int>();
    for (var _j = 0; _j < this.ScoreBuffLength; ++_j) {_o.ScoreBuff.Add(this.ScoreBuff(_j));}
    _o.LevelScoreRewardList = new List<WWParser.Defs.IntPairT>();
    for (var _j = 0; _j < this.LevelScoreRewardListLength; ++_j) {_o.LevelScoreRewardList.Add(this.LevelScoreRewardList(_j).HasValue ? this.LevelScoreRewardList(_j).Value.UnPack() : null);}
    _o.RewardName = this.RewardName;
    _o.RewardTexture = this.RewardTexture;
  }
  public static Offset<WWParser.Defs.BossRushActivity> Pack(FlatBufferBuilder builder, BossRushActivityT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.BossRushActivity>);
    var _default_buff = default(VectorOffset);
    if (_o.DefaultBuff != null) {
      var __default_buff = _o.DefaultBuff.ToArray();
      _default_buff = CreateDefaultBuffVector(builder, __default_buff);
    }
    var _optional_buff = default(VectorOffset);
    if (_o.OptionalBuff != null) {
      var __optional_buff = _o.OptionalBuff.ToArray();
      _optional_buff = CreateOptionalBuffVector(builder, __optional_buff);
    }
    var _unlock_buff = default(VectorOffset);
    if (_o.UnlockBuff != null) {
      var __unlock_buff = _o.UnlockBuff.ToArray();
      _unlock_buff = CreateUnlockBuffVector(builder, __unlock_buff);
    }
    var _level_reward_desc = _o.LevelRewardDesc == null ? default(StringOffset) : builder.CreateString(_o.LevelRewardDesc);
    var _level_desc = _o.LevelDesc == null ? default(StringOffset) : builder.CreateString(_o.LevelDesc);
    var _preview_texture = _o.PreviewTexture == null ? default(StringOffset) : builder.CreateString(_o.PreviewTexture);
    var _stage_texture = _o.StageTexture == null ? default(StringOffset) : builder.CreateString(_o.StageTexture);
    var _score_buff = default(VectorOffset);
    if (_o.ScoreBuff != null) {
      var __score_buff = _o.ScoreBuff.ToArray();
      _score_buff = CreateScoreBuffVector(builder, __score_buff);
    }
    var _level_score_reward_list = default(VectorOffset);
    if (_o.LevelScoreRewardList != null) {
      var __level_score_reward_list = new Offset<WWParser.Defs.IntPair>[_o.LevelScoreRewardList.Count];
      for (var _j = 0; _j < __level_score_reward_list.Length; ++_j) { __level_score_reward_list[_j] = WWParser.Defs.IntPair.Pack(builder, _o.LevelScoreRewardList[_j]); }
      _level_score_reward_list = CreateLevelScoreRewardListVector(builder, __level_score_reward_list);
    }
    var _reward_name = _o.RewardName == null ? default(StringOffset) : builder.CreateString(_o.RewardName);
    var _reward_texture = _o.RewardTexture == null ? default(StringOffset) : builder.CreateString(_o.RewardTexture);
    return CreateBossRushActivity(
      builder,
      _o.Id,
      _o.ActivityId,
      _o.InstId,
      _o.GroupId,
      _o.SortId,
      _o.BuffCount,
      _default_buff,
      _optional_buff,
      _unlock_buff,
      _o.OpenDay,
      _o.Condition,
      _o.PreLevel,
      _o.RewardScore,
      _level_reward_desc,
      _level_desc,
      _o.RewardId,
      _o.BossInfo,
      _preview_texture,
      _stage_texture,
      _o.BossCount,
      _o.ScoreBuffCount,
      _score_buff,
      _level_score_reward_list,
      _reward_name,
      _reward_texture);
  }
}

public class BossRushActivityT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("inst_id")]
  public int InstId { get; set; }
  [Newtonsoft.Json.JsonProperty("group_id")]
  public int GroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("sort_id")]
  public int SortId { get; set; }
  [Newtonsoft.Json.JsonProperty("buff_count")]
  public int BuffCount { get; set; }
  [Newtonsoft.Json.JsonProperty("default_buff")]
  public List<int> DefaultBuff { get; set; }
  [Newtonsoft.Json.JsonProperty("optional_buff")]
  public List<int> OptionalBuff { get; set; }
  [Newtonsoft.Json.JsonProperty("unlock_buff")]
  public List<int> UnlockBuff { get; set; }
  [Newtonsoft.Json.JsonProperty("open_day")]
  public int OpenDay { get; set; }
  [Newtonsoft.Json.JsonProperty("condition")]
  public int Condition { get; set; }
  [Newtonsoft.Json.JsonProperty("pre_level")]
  public int PreLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_score")]
  public int RewardScore { get; set; }
  [Newtonsoft.Json.JsonProperty("level_reward_desc")]
  public string LevelRewardDesc { get; set; }
  [Newtonsoft.Json.JsonProperty("level_desc")]
  public string LevelDesc { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_id")]
  public int RewardId { get; set; }
  [Newtonsoft.Json.JsonProperty("boss_info")]
  public int BossInfo { get; set; }
  [Newtonsoft.Json.JsonProperty("preview_texture")]
  public string PreviewTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("stage_texture")]
  public string StageTexture { get; set; }
  [Newtonsoft.Json.JsonProperty("boss_count")]
  public int BossCount { get; set; }
  [Newtonsoft.Json.JsonProperty("score_buff_count")]
  public int ScoreBuffCount { get; set; }
  [Newtonsoft.Json.JsonProperty("score_buff")]
  public List<int> ScoreBuff { get; set; }
  [Newtonsoft.Json.JsonProperty("level_score_reward_list")]
  public List<WWParser.Defs.IntPairT> LevelScoreRewardList { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_name")]
  public string RewardName { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_texture")]
  public string RewardTexture { get; set; }

  public BossRushActivityT() {
    this.Id = 0;
    this.ActivityId = 0;
    this.InstId = 0;
    this.GroupId = 0;
    this.SortId = 0;
    this.BuffCount = 0;
    this.DefaultBuff = null;
    this.OptionalBuff = null;
    this.UnlockBuff = null;
    this.OpenDay = 0;
    this.Condition = 0;
    this.PreLevel = 0;
    this.RewardScore = 0;
    this.LevelRewardDesc = null;
    this.LevelDesc = null;
    this.RewardId = 0;
    this.BossInfo = 0;
    this.PreviewTexture = null;
    this.StageTexture = null;
    this.BossCount = 0;
    this.ScoreBuffCount = 0;
    this.ScoreBuff = null;
    this.LevelScoreRewardList = null;
    this.RewardName = null;
    this.RewardTexture = null;
  }
}


static public class BossRushActivityVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*InstId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*GroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*SortId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*BuffCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*DefaultBuff*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*OptionalBuff*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*UnlockBuff*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 22 /*OpenDay*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*Condition*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*PreLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*RewardScore*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 30 /*LevelRewardDesc*/, false)
      && verifier.VerifyString(tablePos, 32 /*LevelDesc*/, false)
      && verifier.VerifyField(tablePos, 34 /*RewardId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*BossInfo*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 38 /*PreviewTexture*/, false)
      && verifier.VerifyString(tablePos, 40 /*StageTexture*/, false)
      && verifier.VerifyField(tablePos, 42 /*BossCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 44 /*ScoreBuffCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 46 /*ScoreBuff*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 48 /*LevelScoreRewardList*/, WWParser.Defs.IntPairVerify.Verify, false)
      && verifier.VerifyString(tablePos, 50 /*RewardName*/, false)
      && verifier.VerifyString(tablePos, 52 /*RewardTexture*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
