// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RogueWeeklyParam : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RogueWeeklyParam GetRootAsRogueWeeklyParam(ByteBuffer _bb) { return GetRootAsRogueWeeklyParam(_bb, new RogueWeeklyParam()); }
  public static RogueWeeklyParam GetRootAsRogueWeeklyParam(ByteBuffer _bb, RogueWeeklyParam obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RogueWeeklyParam __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string RoguelikeSettleBgs { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRoguelikeSettleBgsBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetRoguelikeSettleBgsBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetRoguelikeSettleBgsArray() { return __p.__vector_as_array<byte>(6); }
  public string RoguelikeSettleBgNormal { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRoguelikeSettleBgNormalBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetRoguelikeSettleBgNormalBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetRoguelikeSettleBgNormalArray() { return __p.__vector_as_array<byte>(8); }
  public string RoguelikeRoomFloatTipsNoHeadIcon { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRoguelikeRoomFloatTipsNoHeadIconBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetRoguelikeRoomFloatTipsNoHeadIconBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetRoguelikeRoomFloatTipsNoHeadIconArray() { return __p.__vector_as_array<byte>(10); }
  public string RoguelikeRoomFloatTipsSpecialIcon { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRoguelikeRoomFloatTipsSpecialIconBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetRoguelikeRoomFloatTipsSpecialIconBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetRoguelikeRoomFloatTipsSpecialIconArray() { return __p.__vector_as_array<byte>(12); }
  public int RoguelikeSettles { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RoguelikeSettlea { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RoguelikeSettleb { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RoguelikeSettlec { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PointItem { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PointItemMaxCount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TokenItem { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WeekTokenMaxCount { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InsideCurrency { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DungeonList(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DungeonListLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetDungeonListBytes() { return __p.__vector_as_span<int>(32, 4); }
#else
  public ArraySegment<byte>? GetDungeonListBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public int[] GetDungeonListArray() { return __p.__vector_as_array<int>(32); }
  public WWParser.Defs.DicIntInt? ValidRoleOpenTimeMap(int j) { int o = __p.__offset(34); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ValidRoleOpenTimeMapLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
  public WWParser.Defs.DicIntInt? DungeonRoleOpenTimeMap(int j) { int o = __p.__offset(36); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DungeonRoleOpenTimeMapLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<WWParser.Defs.RogueWeeklyParam> CreateRogueWeeklyParam(FlatBufferBuilder builder,
      int id = 0,
      StringOffset roguelike_settle_bgsOffset = default(StringOffset),
      StringOffset roguelike_settle_bg_normalOffset = default(StringOffset),
      StringOffset roguelike_room_float_tips_no_head_iconOffset = default(StringOffset),
      StringOffset roguelike_room_float_tips_special_iconOffset = default(StringOffset),
      int roguelike_settles = 0,
      int roguelike_settlea = 0,
      int roguelike_settleb = 0,
      int roguelike_settlec = 0,
      int point_item = 0,
      int point_item_max_count = 0,
      int token_item = 0,
      int week_token_max_count = 0,
      int inside_currency = 0,
      VectorOffset dungeon_listOffset = default(VectorOffset),
      VectorOffset valid_role_open_time_mapOffset = default(VectorOffset),
      VectorOffset dungeon_role_open_time_mapOffset = default(VectorOffset)) {
    builder.StartTable(17);
    RogueWeeklyParam.AddDungeonRoleOpenTimeMap(builder, dungeon_role_open_time_mapOffset);
    RogueWeeklyParam.AddValidRoleOpenTimeMap(builder, valid_role_open_time_mapOffset);
    RogueWeeklyParam.AddDungeonList(builder, dungeon_listOffset);
    RogueWeeklyParam.AddInsideCurrency(builder, inside_currency);
    RogueWeeklyParam.AddWeekTokenMaxCount(builder, week_token_max_count);
    RogueWeeklyParam.AddTokenItem(builder, token_item);
    RogueWeeklyParam.AddPointItemMaxCount(builder, point_item_max_count);
    RogueWeeklyParam.AddPointItem(builder, point_item);
    RogueWeeklyParam.AddRoguelikeSettlec(builder, roguelike_settlec);
    RogueWeeklyParam.AddRoguelikeSettleb(builder, roguelike_settleb);
    RogueWeeklyParam.AddRoguelikeSettlea(builder, roguelike_settlea);
    RogueWeeklyParam.AddRoguelikeSettles(builder, roguelike_settles);
    RogueWeeklyParam.AddRoguelikeRoomFloatTipsSpecialIcon(builder, roguelike_room_float_tips_special_iconOffset);
    RogueWeeklyParam.AddRoguelikeRoomFloatTipsNoHeadIcon(builder, roguelike_room_float_tips_no_head_iconOffset);
    RogueWeeklyParam.AddRoguelikeSettleBgNormal(builder, roguelike_settle_bg_normalOffset);
    RogueWeeklyParam.AddRoguelikeSettleBgs(builder, roguelike_settle_bgsOffset);
    RogueWeeklyParam.AddId(builder, id);
    return RogueWeeklyParam.EndRogueWeeklyParam(builder);
  }

  public static void StartRogueWeeklyParam(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddRoguelikeSettleBgs(FlatBufferBuilder builder, StringOffset roguelikeSettleBgsOffset) { builder.AddOffset(1, roguelikeSettleBgsOffset.Value, 0); }
  public static void AddRoguelikeSettleBgNormal(FlatBufferBuilder builder, StringOffset roguelikeSettleBgNormalOffset) { builder.AddOffset(2, roguelikeSettleBgNormalOffset.Value, 0); }
  public static void AddRoguelikeRoomFloatTipsNoHeadIcon(FlatBufferBuilder builder, StringOffset roguelikeRoomFloatTipsNoHeadIconOffset) { builder.AddOffset(3, roguelikeRoomFloatTipsNoHeadIconOffset.Value, 0); }
  public static void AddRoguelikeRoomFloatTipsSpecialIcon(FlatBufferBuilder builder, StringOffset roguelikeRoomFloatTipsSpecialIconOffset) { builder.AddOffset(4, roguelikeRoomFloatTipsSpecialIconOffset.Value, 0); }
  public static void AddRoguelikeSettles(FlatBufferBuilder builder, int roguelikeSettles) { builder.AddInt(5, roguelikeSettles, 0); }
  public static void AddRoguelikeSettlea(FlatBufferBuilder builder, int roguelikeSettlea) { builder.AddInt(6, roguelikeSettlea, 0); }
  public static void AddRoguelikeSettleb(FlatBufferBuilder builder, int roguelikeSettleb) { builder.AddInt(7, roguelikeSettleb, 0); }
  public static void AddRoguelikeSettlec(FlatBufferBuilder builder, int roguelikeSettlec) { builder.AddInt(8, roguelikeSettlec, 0); }
  public static void AddPointItem(FlatBufferBuilder builder, int pointItem) { builder.AddInt(9, pointItem, 0); }
  public static void AddPointItemMaxCount(FlatBufferBuilder builder, int pointItemMaxCount) { builder.AddInt(10, pointItemMaxCount, 0); }
  public static void AddTokenItem(FlatBufferBuilder builder, int tokenItem) { builder.AddInt(11, tokenItem, 0); }
  public static void AddWeekTokenMaxCount(FlatBufferBuilder builder, int weekTokenMaxCount) { builder.AddInt(12, weekTokenMaxCount, 0); }
  public static void AddInsideCurrency(FlatBufferBuilder builder, int insideCurrency) { builder.AddInt(13, insideCurrency, 0); }
  public static void AddDungeonList(FlatBufferBuilder builder, VectorOffset dungeonListOffset) { builder.AddOffset(14, dungeonListOffset.Value, 0); }
  public static VectorOffset CreateDungeonListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDungeonListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddValidRoleOpenTimeMap(FlatBufferBuilder builder, VectorOffset validRoleOpenTimeMapOffset) { builder.AddOffset(15, validRoleOpenTimeMapOffset.Value, 0); }
  public static VectorOffset CreateValidRoleOpenTimeMapVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateValidRoleOpenTimeMapVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateValidRoleOpenTimeMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateValidRoleOpenTimeMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartValidRoleOpenTimeMapVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDungeonRoleOpenTimeMap(FlatBufferBuilder builder, VectorOffset dungeonRoleOpenTimeMapOffset) { builder.AddOffset(16, dungeonRoleOpenTimeMapOffset.Value, 0); }
  public static VectorOffset CreateDungeonRoleOpenTimeMapVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDungeonRoleOpenTimeMapVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonRoleOpenTimeMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDungeonRoleOpenTimeMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDungeonRoleOpenTimeMapVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.RogueWeeklyParam> EndRogueWeeklyParam(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RogueWeeklyParam>(o);
  }
  public RogueWeeklyParamT UnPack() {
    var _o = new RogueWeeklyParamT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RogueWeeklyParamT _o) {
    _o.Id = this.Id;
    _o.RoguelikeSettleBgs = this.RoguelikeSettleBgs;
    _o.RoguelikeSettleBgNormal = this.RoguelikeSettleBgNormal;
    _o.RoguelikeRoomFloatTipsNoHeadIcon = this.RoguelikeRoomFloatTipsNoHeadIcon;
    _o.RoguelikeRoomFloatTipsSpecialIcon = this.RoguelikeRoomFloatTipsSpecialIcon;
    _o.RoguelikeSettles = this.RoguelikeSettles;
    _o.RoguelikeSettlea = this.RoguelikeSettlea;
    _o.RoguelikeSettleb = this.RoguelikeSettleb;
    _o.RoguelikeSettlec = this.RoguelikeSettlec;
    _o.PointItem = this.PointItem;
    _o.PointItemMaxCount = this.PointItemMaxCount;
    _o.TokenItem = this.TokenItem;
    _o.WeekTokenMaxCount = this.WeekTokenMaxCount;
    _o.InsideCurrency = this.InsideCurrency;
    _o.DungeonList = new List<int>();
    for (var _j = 0; _j < this.DungeonListLength; ++_j) {_o.DungeonList.Add(this.DungeonList(_j));}
    _o.ValidRoleOpenTimeMap = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.ValidRoleOpenTimeMapLength; ++_j) {_o.ValidRoleOpenTimeMap.Add(this.ValidRoleOpenTimeMap(_j).HasValue ? this.ValidRoleOpenTimeMap(_j).Value.UnPack() : null);}
    _o.DungeonRoleOpenTimeMap = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.DungeonRoleOpenTimeMapLength; ++_j) {_o.DungeonRoleOpenTimeMap.Add(this.DungeonRoleOpenTimeMap(_j).HasValue ? this.DungeonRoleOpenTimeMap(_j).Value.UnPack() : null);}
  }
  public static Offset<WWParser.Defs.RogueWeeklyParam> Pack(FlatBufferBuilder builder, RogueWeeklyParamT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RogueWeeklyParam>);
    var _roguelike_settle_bgs = _o.RoguelikeSettleBgs == null ? default(StringOffset) : builder.CreateString(_o.RoguelikeSettleBgs);
    var _roguelike_settle_bg_normal = _o.RoguelikeSettleBgNormal == null ? default(StringOffset) : builder.CreateString(_o.RoguelikeSettleBgNormal);
    var _roguelike_room_float_tips_no_head_icon = _o.RoguelikeRoomFloatTipsNoHeadIcon == null ? default(StringOffset) : builder.CreateString(_o.RoguelikeRoomFloatTipsNoHeadIcon);
    var _roguelike_room_float_tips_special_icon = _o.RoguelikeRoomFloatTipsSpecialIcon == null ? default(StringOffset) : builder.CreateString(_o.RoguelikeRoomFloatTipsSpecialIcon);
    var _dungeon_list = default(VectorOffset);
    if (_o.DungeonList != null) {
      var __dungeon_list = _o.DungeonList.ToArray();
      _dungeon_list = CreateDungeonListVector(builder, __dungeon_list);
    }
    var _valid_role_open_time_map = default(VectorOffset);
    if (_o.ValidRoleOpenTimeMap != null) {
      var __valid_role_open_time_map = new Offset<WWParser.Defs.DicIntInt>[_o.ValidRoleOpenTimeMap.Count];
      for (var _j = 0; _j < __valid_role_open_time_map.Length; ++_j) { __valid_role_open_time_map[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.ValidRoleOpenTimeMap[_j]); }
      _valid_role_open_time_map = CreateValidRoleOpenTimeMapVector(builder, __valid_role_open_time_map);
    }
    var _dungeon_role_open_time_map = default(VectorOffset);
    if (_o.DungeonRoleOpenTimeMap != null) {
      var __dungeon_role_open_time_map = new Offset<WWParser.Defs.DicIntInt>[_o.DungeonRoleOpenTimeMap.Count];
      for (var _j = 0; _j < __dungeon_role_open_time_map.Length; ++_j) { __dungeon_role_open_time_map[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.DungeonRoleOpenTimeMap[_j]); }
      _dungeon_role_open_time_map = CreateDungeonRoleOpenTimeMapVector(builder, __dungeon_role_open_time_map);
    }
    return CreateRogueWeeklyParam(
      builder,
      _o.Id,
      _roguelike_settle_bgs,
      _roguelike_settle_bg_normal,
      _roguelike_room_float_tips_no_head_icon,
      _roguelike_room_float_tips_special_icon,
      _o.RoguelikeSettles,
      _o.RoguelikeSettlea,
      _o.RoguelikeSettleb,
      _o.RoguelikeSettlec,
      _o.PointItem,
      _o.PointItemMaxCount,
      _o.TokenItem,
      _o.WeekTokenMaxCount,
      _o.InsideCurrency,
      _dungeon_list,
      _valid_role_open_time_map,
      _dungeon_role_open_time_map);
  }
}

public class RogueWeeklyParamT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_settle_bgs")]
  public string RoguelikeSettleBgs { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_settle_bg_normal")]
  public string RoguelikeSettleBgNormal { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_room_float_tips_no_head_icon")]
  public string RoguelikeRoomFloatTipsNoHeadIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_room_float_tips_special_icon")]
  public string RoguelikeRoomFloatTipsSpecialIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_settles")]
  public int RoguelikeSettles { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_settlea")]
  public int RoguelikeSettlea { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_settleb")]
  public int RoguelikeSettleb { get; set; }
  [Newtonsoft.Json.JsonProperty("roguelike_settlec")]
  public int RoguelikeSettlec { get; set; }
  [Newtonsoft.Json.JsonProperty("point_item")]
  public int PointItem { get; set; }
  [Newtonsoft.Json.JsonProperty("point_item_max_count")]
  public int PointItemMaxCount { get; set; }
  [Newtonsoft.Json.JsonProperty("token_item")]
  public int TokenItem { get; set; }
  [Newtonsoft.Json.JsonProperty("week_token_max_count")]
  public int WeekTokenMaxCount { get; set; }
  [Newtonsoft.Json.JsonProperty("inside_currency")]
  public int InsideCurrency { get; set; }
  [Newtonsoft.Json.JsonProperty("dungeon_list")]
  public List<int> DungeonList { get; set; }
  [Newtonsoft.Json.JsonProperty("valid_role_open_time_map")]
  public List<WWParser.Defs.DicIntIntT> ValidRoleOpenTimeMap { get; set; }
  [Newtonsoft.Json.JsonProperty("dungeon_role_open_time_map")]
  public List<WWParser.Defs.DicIntIntT> DungeonRoleOpenTimeMap { get; set; }

  public RogueWeeklyParamT() {
    this.Id = 0;
    this.RoguelikeSettleBgs = null;
    this.RoguelikeSettleBgNormal = null;
    this.RoguelikeRoomFloatTipsNoHeadIcon = null;
    this.RoguelikeRoomFloatTipsSpecialIcon = null;
    this.RoguelikeSettles = 0;
    this.RoguelikeSettlea = 0;
    this.RoguelikeSettleb = 0;
    this.RoguelikeSettlec = 0;
    this.PointItem = 0;
    this.PointItemMaxCount = 0;
    this.TokenItem = 0;
    this.WeekTokenMaxCount = 0;
    this.InsideCurrency = 0;
    this.DungeonList = null;
    this.ValidRoleOpenTimeMap = null;
    this.DungeonRoleOpenTimeMap = null;
  }
}


static public class RogueWeeklyParamVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*RoguelikeSettleBgs*/, false)
      && verifier.VerifyString(tablePos, 8 /*RoguelikeSettleBgNormal*/, false)
      && verifier.VerifyString(tablePos, 10 /*RoguelikeRoomFloatTipsNoHeadIcon*/, false)
      && verifier.VerifyString(tablePos, 12 /*RoguelikeRoomFloatTipsSpecialIcon*/, false)
      && verifier.VerifyField(tablePos, 14 /*RoguelikeSettles*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*RoguelikeSettlea*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*RoguelikeSettleb*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*RoguelikeSettlec*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*PointItem*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*PointItemMaxCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*TokenItem*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*WeekTokenMaxCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*InsideCurrency*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 32 /*DungeonList*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 34 /*ValidRoleOpenTimeMap*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 36 /*DungeonRoleOpenTimeMap*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
