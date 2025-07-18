// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TowerConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static TowerConfig GetRootAsTowerConfig(ByteBuffer _bb) { return GetRootAsTowerConfig(_bb, new TowerConfig()); }
  public static TowerConfig GetRootAsTowerConfig(ByteBuffer _bb, TowerConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TowerConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Season { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Difficulty { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AreaNum { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Floor { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InstanceId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string AreaName { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAreaNameBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetAreaNameBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetAreaNameArray() { return __p.__vector_as_array<byte>(16); }
  public int Cost { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RecommendElement(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RecommendElementLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRecommendElementBytes() { return __p.__vector_as_span<int>(20, 4); }
#else
  public ArraySegment<byte>? GetRecommendElementBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public int[] GetRecommendElementArray() { return __p.__vector_as_array<int>(20); }
  public int ShowMonsters(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ShowMonstersLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetShowMonstersBytes() { return __p.__vector_as_span<int>(22, 4); }
#else
  public ArraySegment<byte>? GetShowMonstersBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public int[] GetShowMonstersArray() { return __p.__vector_as_array<int>(22); }
  public WWParser.Defs.IntPair? ShowMonstersAndLevel(int j) { int o = __p.__offset(24); return o != 0 ? (WWParser.Defs.IntPair?)(new WWParser.Defs.IntPair()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ShowMonstersAndLevelLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public double ShowBuffs(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetDouble(__p.__vector(o) + j * 8) : (double)0; }
  public int ShowBuffsLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<double> GetShowBuffsBytes() { return __p.__vector_as_span<double>(26, 8); }
#else
  public ArraySegment<byte>? GetShowBuffsBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public double[] GetShowBuffsArray() { return __p.__vector_as_array<double>(26); }
  public double RoleBuff(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetDouble(__p.__vector(o) + j * 8) : (double)0; }
  public int RoleBuffLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<double> GetRoleBuffBytes() { return __p.__vector_as_span<double>(28, 8); }
#else
  public ArraySegment<byte>? GetRoleBuffBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public double[] GetRoleBuffArray() { return __p.__vector_as_array<double>(28); }
  public double MonsterBuff(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetDouble(__p.__vector(o) + j * 8) : (double)0; }
  public int MonsterBuffLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<double> GetMonsterBuffBytes() { return __p.__vector_as_span<double>(30, 8); }
#else
  public ArraySegment<byte>? GetMonsterBuffBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public double[] GetMonsterBuffArray() { return __p.__vector_as_array<double>(30); }
  public int Target(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int TargetLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetTargetBytes() { return __p.__vector_as_span<int>(32, 4); }
#else
  public ArraySegment<byte>? GetTargetBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public int[] GetTargetArray() { return __p.__vector_as_array<int>(32); }
  public int TargetConfig(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int TargetConfigLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetTargetConfigBytes() { return __p.__vector_as_span<int>(34, 4); }
#else
  public ArraySegment<byte>? GetTargetConfigBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public int[] GetTargetConfigArray() { return __p.__vector_as_array<int>(34); }
  public string BgPath { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgPathBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetBgPathBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetBgPathArray() { return __p.__vector_as_array<byte>(36); }
  public string ItemBgPath { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetItemBgPathBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetItemBgPathBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetItemBgPathArray() { return __p.__vector_as_array<byte>(38); }

  public static Offset<WWParser.Defs.TowerConfig> CreateTowerConfig(FlatBufferBuilder builder,
      int id = 0,
      int season = 0,
      int difficulty = 0,
      int area_num = 0,
      int floor = 0,
      int instance_id = 0,
      StringOffset area_nameOffset = default(StringOffset),
      int cost = 0,
      VectorOffset recommend_elementOffset = default(VectorOffset),
      VectorOffset show_monstersOffset = default(VectorOffset),
      VectorOffset show_monsters_and_levelOffset = default(VectorOffset),
      VectorOffset show_buffsOffset = default(VectorOffset),
      VectorOffset role_buffOffset = default(VectorOffset),
      VectorOffset monster_buffOffset = default(VectorOffset),
      VectorOffset targetOffset = default(VectorOffset),
      VectorOffset target_configOffset = default(VectorOffset),
      StringOffset bg_pathOffset = default(StringOffset),
      StringOffset item_bg_pathOffset = default(StringOffset)) {
    builder.StartTable(18);
    TowerConfig.AddItemBgPath(builder, item_bg_pathOffset);
    TowerConfig.AddBgPath(builder, bg_pathOffset);
    TowerConfig.AddTargetConfig(builder, target_configOffset);
    TowerConfig.AddTarget(builder, targetOffset);
    TowerConfig.AddMonsterBuff(builder, monster_buffOffset);
    TowerConfig.AddRoleBuff(builder, role_buffOffset);
    TowerConfig.AddShowBuffs(builder, show_buffsOffset);
    TowerConfig.AddShowMonstersAndLevel(builder, show_monsters_and_levelOffset);
    TowerConfig.AddShowMonsters(builder, show_monstersOffset);
    TowerConfig.AddRecommendElement(builder, recommend_elementOffset);
    TowerConfig.AddCost(builder, cost);
    TowerConfig.AddAreaName(builder, area_nameOffset);
    TowerConfig.AddInstanceId(builder, instance_id);
    TowerConfig.AddFloor(builder, floor);
    TowerConfig.AddAreaNum(builder, area_num);
    TowerConfig.AddDifficulty(builder, difficulty);
    TowerConfig.AddSeason(builder, season);
    TowerConfig.AddId(builder, id);
    return TowerConfig.EndTowerConfig(builder);
  }

  public static void StartTowerConfig(FlatBufferBuilder builder) { builder.StartTable(18); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddSeason(FlatBufferBuilder builder, int season) { builder.AddInt(1, season, 0); }
  public static void AddDifficulty(FlatBufferBuilder builder, int difficulty) { builder.AddInt(2, difficulty, 0); }
  public static void AddAreaNum(FlatBufferBuilder builder, int areaNum) { builder.AddInt(3, areaNum, 0); }
  public static void AddFloor(FlatBufferBuilder builder, int floor) { builder.AddInt(4, floor, 0); }
  public static void AddInstanceId(FlatBufferBuilder builder, int instanceId) { builder.AddInt(5, instanceId, 0); }
  public static void AddAreaName(FlatBufferBuilder builder, StringOffset areaNameOffset) { builder.AddOffset(6, areaNameOffset.Value, 0); }
  public static void AddCost(FlatBufferBuilder builder, int cost) { builder.AddInt(7, cost, 0); }
  public static void AddRecommendElement(FlatBufferBuilder builder, VectorOffset recommendElementOffset) { builder.AddOffset(8, recommendElementOffset.Value, 0); }
  public static VectorOffset CreateRecommendElementVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRecommendElementVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecommendElementVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecommendElementVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRecommendElementVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowMonsters(FlatBufferBuilder builder, VectorOffset showMonstersOffset) { builder.AddOffset(9, showMonstersOffset.Value, 0); }
  public static VectorOffset CreateShowMonstersVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateShowMonstersVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowMonstersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowMonstersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShowMonstersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowMonstersAndLevel(FlatBufferBuilder builder, VectorOffset showMonstersAndLevelOffset) { builder.AddOffset(10, showMonstersAndLevelOffset.Value, 0); }
  public static VectorOffset CreateShowMonstersAndLevelVector(FlatBufferBuilder builder, Offset<WWParser.Defs.IntPair>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShowMonstersAndLevelVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.IntPair>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowMonstersAndLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.IntPair>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowMonstersAndLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.IntPair>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShowMonstersAndLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowBuffs(FlatBufferBuilder builder, VectorOffset showBuffsOffset) { builder.AddOffset(11, showBuffsOffset.Value, 0); }
  public static VectorOffset CreateShowBuffsVector(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddDouble(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateShowBuffsVectorBlock(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<double> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShowBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<double>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShowBuffsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRoleBuff(FlatBufferBuilder builder, VectorOffset roleBuffOffset) { builder.AddOffset(12, roleBuffOffset.Value, 0); }
  public static VectorOffset CreateRoleBuffVector(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddDouble(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRoleBuffVectorBlock(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRoleBuffVectorBlock(FlatBufferBuilder builder, ArraySegment<double> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRoleBuffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<double>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRoleBuffVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMonsterBuff(FlatBufferBuilder builder, VectorOffset monsterBuffOffset) { builder.AddOffset(13, monsterBuffOffset.Value, 0); }
  public static VectorOffset CreateMonsterBuffVector(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddDouble(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMonsterBuffVectorBlock(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMonsterBuffVectorBlock(FlatBufferBuilder builder, ArraySegment<double> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMonsterBuffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<double>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMonsterBuffVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddTarget(FlatBufferBuilder builder, VectorOffset targetOffset) { builder.AddOffset(14, targetOffset.Value, 0); }
  public static VectorOffset CreateTargetVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTargetVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTargetVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTargetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTargetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTargetConfig(FlatBufferBuilder builder, VectorOffset targetConfigOffset) { builder.AddOffset(15, targetConfigOffset.Value, 0); }
  public static VectorOffset CreateTargetConfigVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTargetConfigVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTargetConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTargetConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTargetConfigVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBgPath(FlatBufferBuilder builder, StringOffset bgPathOffset) { builder.AddOffset(16, bgPathOffset.Value, 0); }
  public static void AddItemBgPath(FlatBufferBuilder builder, StringOffset itemBgPathOffset) { builder.AddOffset(17, itemBgPathOffset.Value, 0); }
  public static Offset<WWParser.Defs.TowerConfig> EndTowerConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.TowerConfig>(o);
  }
  public TowerConfigT UnPack() {
    var _o = new TowerConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TowerConfigT _o) {
    _o.Id = this.Id;
    _o.Season = this.Season;
    _o.Difficulty = this.Difficulty;
    _o.AreaNum = this.AreaNum;
    _o.Floor = this.Floor;
    _o.InstanceId = this.InstanceId;
    _o.AreaName = this.AreaName;
    _o.Cost = this.Cost;
    _o.RecommendElement = new List<int>();
    for (var _j = 0; _j < this.RecommendElementLength; ++_j) {_o.RecommendElement.Add(this.RecommendElement(_j));}
    _o.ShowMonsters = new List<int>();
    for (var _j = 0; _j < this.ShowMonstersLength; ++_j) {_o.ShowMonsters.Add(this.ShowMonsters(_j));}
    _o.ShowMonstersAndLevel = new List<WWParser.Defs.IntPairT>();
    for (var _j = 0; _j < this.ShowMonstersAndLevelLength; ++_j) {_o.ShowMonstersAndLevel.Add(this.ShowMonstersAndLevel(_j).HasValue ? this.ShowMonstersAndLevel(_j).Value.UnPack() : null);}
    _o.ShowBuffs = new List<double>();
    for (var _j = 0; _j < this.ShowBuffsLength; ++_j) {_o.ShowBuffs.Add(this.ShowBuffs(_j));}
    _o.RoleBuff = new List<double>();
    for (var _j = 0; _j < this.RoleBuffLength; ++_j) {_o.RoleBuff.Add(this.RoleBuff(_j));}
    _o.MonsterBuff = new List<double>();
    for (var _j = 0; _j < this.MonsterBuffLength; ++_j) {_o.MonsterBuff.Add(this.MonsterBuff(_j));}
    _o.Target = new List<int>();
    for (var _j = 0; _j < this.TargetLength; ++_j) {_o.Target.Add(this.Target(_j));}
    _o.TargetConfig = new List<int>();
    for (var _j = 0; _j < this.TargetConfigLength; ++_j) {_o.TargetConfig.Add(this.TargetConfig(_j));}
    _o.BgPath = this.BgPath;
    _o.ItemBgPath = this.ItemBgPath;
  }
  public static Offset<WWParser.Defs.TowerConfig> Pack(FlatBufferBuilder builder, TowerConfigT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.TowerConfig>);
    var _area_name = _o.AreaName == null ? default(StringOffset) : builder.CreateString(_o.AreaName);
    var _recommend_element = default(VectorOffset);
    if (_o.RecommendElement != null) {
      var __recommend_element = _o.RecommendElement.ToArray();
      _recommend_element = CreateRecommendElementVector(builder, __recommend_element);
    }
    var _show_monsters = default(VectorOffset);
    if (_o.ShowMonsters != null) {
      var __show_monsters = _o.ShowMonsters.ToArray();
      _show_monsters = CreateShowMonstersVector(builder, __show_monsters);
    }
    var _show_monsters_and_level = default(VectorOffset);
    if (_o.ShowMonstersAndLevel != null) {
      var __show_monsters_and_level = new Offset<WWParser.Defs.IntPair>[_o.ShowMonstersAndLevel.Count];
      for (var _j = 0; _j < __show_monsters_and_level.Length; ++_j) { __show_monsters_and_level[_j] = WWParser.Defs.IntPair.Pack(builder, _o.ShowMonstersAndLevel[_j]); }
      _show_monsters_and_level = CreateShowMonstersAndLevelVector(builder, __show_monsters_and_level);
    }
    var _show_buffs = default(VectorOffset);
    if (_o.ShowBuffs != null) {
      var __show_buffs = _o.ShowBuffs.ToArray();
      _show_buffs = CreateShowBuffsVector(builder, __show_buffs);
    }
    var _role_buff = default(VectorOffset);
    if (_o.RoleBuff != null) {
      var __role_buff = _o.RoleBuff.ToArray();
      _role_buff = CreateRoleBuffVector(builder, __role_buff);
    }
    var _monster_buff = default(VectorOffset);
    if (_o.MonsterBuff != null) {
      var __monster_buff = _o.MonsterBuff.ToArray();
      _monster_buff = CreateMonsterBuffVector(builder, __monster_buff);
    }
    var _target = default(VectorOffset);
    if (_o.Target != null) {
      var __target = _o.Target.ToArray();
      _target = CreateTargetVector(builder, __target);
    }
    var _target_config = default(VectorOffset);
    if (_o.TargetConfig != null) {
      var __target_config = _o.TargetConfig.ToArray();
      _target_config = CreateTargetConfigVector(builder, __target_config);
    }
    var _bg_path = _o.BgPath == null ? default(StringOffset) : builder.CreateString(_o.BgPath);
    var _item_bg_path = _o.ItemBgPath == null ? default(StringOffset) : builder.CreateString(_o.ItemBgPath);
    return CreateTowerConfig(
      builder,
      _o.Id,
      _o.Season,
      _o.Difficulty,
      _o.AreaNum,
      _o.Floor,
      _o.InstanceId,
      _area_name,
      _o.Cost,
      _recommend_element,
      _show_monsters,
      _show_monsters_and_level,
      _show_buffs,
      _role_buff,
      _monster_buff,
      _target,
      _target_config,
      _bg_path,
      _item_bg_path);
  }
}

public class TowerConfigT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("season")]
  public int Season { get; set; }
  [Newtonsoft.Json.JsonProperty("difficulty")]
  public int Difficulty { get; set; }
  [Newtonsoft.Json.JsonProperty("area_num")]
  public int AreaNum { get; set; }
  [Newtonsoft.Json.JsonProperty("floor")]
  public int Floor { get; set; }
  [Newtonsoft.Json.JsonProperty("instance_id")]
  public int InstanceId { get; set; }
  [Newtonsoft.Json.JsonProperty("area_name")]
  public string AreaName { get; set; }
  [Newtonsoft.Json.JsonProperty("cost")]
  public int Cost { get; set; }
  [Newtonsoft.Json.JsonProperty("recommend_element")]
  public List<int> RecommendElement { get; set; }
  [Newtonsoft.Json.JsonProperty("show_monsters")]
  public List<int> ShowMonsters { get; set; }
  [Newtonsoft.Json.JsonProperty("show_monsters_and_level")]
  public List<WWParser.Defs.IntPairT> ShowMonstersAndLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("show_buffs")]
  public List<double> ShowBuffs { get; set; }
  [Newtonsoft.Json.JsonProperty("role_buff")]
  public List<double> RoleBuff { get; set; }
  [Newtonsoft.Json.JsonProperty("monster_buff")]
  public List<double> MonsterBuff { get; set; }
  [Newtonsoft.Json.JsonProperty("target")]
  public List<int> Target { get; set; }
  [Newtonsoft.Json.JsonProperty("target_config")]
  public List<int> TargetConfig { get; set; }
  [Newtonsoft.Json.JsonProperty("bg_path")]
  public string BgPath { get; set; }
  [Newtonsoft.Json.JsonProperty("item_bg_path")]
  public string ItemBgPath { get; set; }

  public TowerConfigT() {
    this.Id = 0;
    this.Season = 0;
    this.Difficulty = 0;
    this.AreaNum = 0;
    this.Floor = 0;
    this.InstanceId = 0;
    this.AreaName = null;
    this.Cost = 0;
    this.RecommendElement = null;
    this.ShowMonsters = null;
    this.ShowMonstersAndLevel = null;
    this.ShowBuffs = null;
    this.RoleBuff = null;
    this.MonsterBuff = null;
    this.Target = null;
    this.TargetConfig = null;
    this.BgPath = null;
    this.ItemBgPath = null;
  }
}


static public class TowerConfigVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Season*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Difficulty*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*AreaNum*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Floor*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*InstanceId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 16 /*AreaName*/, false)
      && verifier.VerifyField(tablePos, 18 /*Cost*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*RecommendElement*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*ShowMonsters*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 24 /*ShowMonstersAndLevel*/, WWParser.Defs.IntPairVerify.Verify, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*ShowBuffs*/, 8 /*double*/, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*RoleBuff*/, 8 /*double*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*MonsterBuff*/, 8 /*double*/, false)
      && verifier.VerifyVectorOfData(tablePos, 32 /*Target*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*TargetConfig*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 36 /*BgPath*/, false)
      && verifier.VerifyString(tablePos, 38 /*ItemBgPath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
