// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SkillVehicleButton : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static SkillVehicleButton GetRootAsSkillVehicleButton(ByteBuffer _bb) { return GetRootAsSkillVehicleButton(_bb, new SkillVehicleButton()); }
  public static SkillVehicleButton GetRootAsSkillVehicleButton(ByteBuffer _bb, SkillVehicleButton obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SkillVehicleButton __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PbDataId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public int ButtonType { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ActionType { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SkillId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.DicIntInt? SkillIdTagMap(int j) { int o = __p.__offset(16); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int SkillIdTagMapLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string SkillIcon { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillIconBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetSkillIconBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetSkillIconArray() { return __p.__vector_as_array<byte>(18); }
  public int SkillIconTags(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int SkillIconTagsLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetSkillIconTagsBytes() { return __p.__vector_as_span<int>(20, 4); }
#else
  public ArraySegment<byte>? GetSkillIconTagsBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public int[] GetSkillIconTagsArray() { return __p.__vector_as_array<int>(20); }
  public int EnableTags(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int EnableTagsLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetEnableTagsBytes() { return __p.__vector_as_span<int>(22, 4); }
#else
  public ArraySegment<byte>? GetEnableTagsBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public int[] GetEnableTagsArray() { return __p.__vector_as_array<int>(22); }
  public int DisableTags(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DisableTagsLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetDisableTagsBytes() { return __p.__vector_as_span<int>(24, 4); }
#else
  public ArraySegment<byte>? GetDisableTagsBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public int[] GetDisableTagsArray() { return __p.__vector_as_array<int>(24); }
  public WWParser.Defs.DicIntIntArray? DisableSkillIdTags(int j) { int o = __p.__offset(26); return o != 0 ? (WWParser.Defs.DicIntIntArray?)(new WWParser.Defs.DicIntIntArray()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DisableSkillIdTagsLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool IsCdVisible { get { int o = __p.__offset(28); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsLongPressControlCamera { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int LongPressTime { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)500; } }
  public WWParser.Defs.DicIntInt? DynamicEffectTagMap(int j) { int o = __p.__offset(34); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DynamicEffectTagMapLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool ShowLongPress { get { int o = __p.__offset(36); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<WWParser.Defs.SkillVehicleButton> CreateSkillVehicleButton(FlatBufferBuilder builder,
      int id = 0,
      int pb_data_id = 0,
      StringOffset nameOffset = default(StringOffset),
      int button_type = 0,
      int action_type = 0,
      int skill_id = 0,
      VectorOffset skill_id_tag_mapOffset = default(VectorOffset),
      StringOffset skill_iconOffset = default(StringOffset),
      VectorOffset skill_icon_tagsOffset = default(VectorOffset),
      VectorOffset enable_tagsOffset = default(VectorOffset),
      VectorOffset disable_tagsOffset = default(VectorOffset),
      VectorOffset disable_skill_id_tagsOffset = default(VectorOffset),
      bool is_cd_visible = false,
      bool is_long_press_control_camera = false,
      int long_press_time = 500,
      VectorOffset dynamic_effect_tag_mapOffset = default(VectorOffset),
      bool show_long_press = false) {
    builder.StartTable(17);
    SkillVehicleButton.AddDynamicEffectTagMap(builder, dynamic_effect_tag_mapOffset);
    SkillVehicleButton.AddLongPressTime(builder, long_press_time);
    SkillVehicleButton.AddDisableSkillIdTags(builder, disable_skill_id_tagsOffset);
    SkillVehicleButton.AddDisableTags(builder, disable_tagsOffset);
    SkillVehicleButton.AddEnableTags(builder, enable_tagsOffset);
    SkillVehicleButton.AddSkillIconTags(builder, skill_icon_tagsOffset);
    SkillVehicleButton.AddSkillIcon(builder, skill_iconOffset);
    SkillVehicleButton.AddSkillIdTagMap(builder, skill_id_tag_mapOffset);
    SkillVehicleButton.AddSkillId(builder, skill_id);
    SkillVehicleButton.AddActionType(builder, action_type);
    SkillVehicleButton.AddButtonType(builder, button_type);
    SkillVehicleButton.AddName(builder, nameOffset);
    SkillVehicleButton.AddPbDataId(builder, pb_data_id);
    SkillVehicleButton.AddId(builder, id);
    SkillVehicleButton.AddShowLongPress(builder, show_long_press);
    SkillVehicleButton.AddIsLongPressControlCamera(builder, is_long_press_control_camera);
    SkillVehicleButton.AddIsCdVisible(builder, is_cd_visible);
    return SkillVehicleButton.EndSkillVehicleButton(builder);
  }

  public static void StartSkillVehicleButton(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddPbDataId(FlatBufferBuilder builder, int pbDataId) { builder.AddInt(1, pbDataId, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddButtonType(FlatBufferBuilder builder, int buttonType) { builder.AddInt(3, buttonType, 0); }
  public static void AddActionType(FlatBufferBuilder builder, int actionType) { builder.AddInt(4, actionType, 0); }
  public static void AddSkillId(FlatBufferBuilder builder, int skillId) { builder.AddInt(5, skillId, 0); }
  public static void AddSkillIdTagMap(FlatBufferBuilder builder, VectorOffset skillIdTagMapOffset) { builder.AddOffset(6, skillIdTagMapOffset.Value, 0); }
  public static VectorOffset CreateSkillIdTagMapVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSkillIdTagMapVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillIdTagMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillIdTagMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSkillIdTagMapVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillIcon(FlatBufferBuilder builder, StringOffset skillIconOffset) { builder.AddOffset(7, skillIconOffset.Value, 0); }
  public static void AddSkillIconTags(FlatBufferBuilder builder, VectorOffset skillIconTagsOffset) { builder.AddOffset(8, skillIconTagsOffset.Value, 0); }
  public static VectorOffset CreateSkillIconTagsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSkillIconTagsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillIconTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillIconTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSkillIconTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEnableTags(FlatBufferBuilder builder, VectorOffset enableTagsOffset) { builder.AddOffset(9, enableTagsOffset.Value, 0); }
  public static VectorOffset CreateEnableTagsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnableTagsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnableTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnableTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnableTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDisableTags(FlatBufferBuilder builder, VectorOffset disableTagsOffset) { builder.AddOffset(10, disableTagsOffset.Value, 0); }
  public static VectorOffset CreateDisableTagsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDisableTagsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDisableTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDisableTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDisableTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDisableSkillIdTags(FlatBufferBuilder builder, VectorOffset disableSkillIdTagsOffset) { builder.AddOffset(11, disableSkillIdTagsOffset.Value, 0); }
  public static VectorOffset CreateDisableSkillIdTagsVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntIntArray>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDisableSkillIdTagsVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntIntArray>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDisableSkillIdTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntIntArray>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDisableSkillIdTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntIntArray>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDisableSkillIdTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsCdVisible(FlatBufferBuilder builder, bool isCdVisible) { builder.AddBool(12, isCdVisible, false); }
  public static void AddIsLongPressControlCamera(FlatBufferBuilder builder, bool isLongPressControlCamera) { builder.AddBool(13, isLongPressControlCamera, false); }
  public static void AddLongPressTime(FlatBufferBuilder builder, int longPressTime) { builder.AddInt(14, longPressTime, 500); }
  public static void AddDynamicEffectTagMap(FlatBufferBuilder builder, VectorOffset dynamicEffectTagMapOffset) { builder.AddOffset(15, dynamicEffectTagMapOffset.Value, 0); }
  public static VectorOffset CreateDynamicEffectTagMapVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDynamicEffectTagMapVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDynamicEffectTagMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDynamicEffectTagMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDynamicEffectTagMapVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowLongPress(FlatBufferBuilder builder, bool showLongPress) { builder.AddBool(16, showLongPress, false); }
  public static Offset<WWParser.Defs.SkillVehicleButton> EndSkillVehicleButton(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.SkillVehicleButton>(o);
  }
  public SkillVehicleButtonT UnPack() {
    var _o = new SkillVehicleButtonT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SkillVehicleButtonT _o) {
    _o.Id = this.Id;
    _o.PbDataId = this.PbDataId;
    _o.Name = this.Name;
    _o.ButtonType = this.ButtonType;
    _o.ActionType = this.ActionType;
    _o.SkillId = this.SkillId;
    _o.SkillIdTagMap = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.SkillIdTagMapLength; ++_j) {_o.SkillIdTagMap.Add(this.SkillIdTagMap(_j).HasValue ? this.SkillIdTagMap(_j).Value.UnPack() : null);}
    _o.SkillIcon = this.SkillIcon;
    _o.SkillIconTags = new List<int>();
    for (var _j = 0; _j < this.SkillIconTagsLength; ++_j) {_o.SkillIconTags.Add(this.SkillIconTags(_j));}
    _o.EnableTags = new List<int>();
    for (var _j = 0; _j < this.EnableTagsLength; ++_j) {_o.EnableTags.Add(this.EnableTags(_j));}
    _o.DisableTags = new List<int>();
    for (var _j = 0; _j < this.DisableTagsLength; ++_j) {_o.DisableTags.Add(this.DisableTags(_j));}
    _o.DisableSkillIdTags = new List<WWParser.Defs.DicIntIntArrayT>();
    for (var _j = 0; _j < this.DisableSkillIdTagsLength; ++_j) {_o.DisableSkillIdTags.Add(this.DisableSkillIdTags(_j).HasValue ? this.DisableSkillIdTags(_j).Value.UnPack() : null);}
    _o.IsCdVisible = this.IsCdVisible;
    _o.IsLongPressControlCamera = this.IsLongPressControlCamera;
    _o.LongPressTime = this.LongPressTime;
    _o.DynamicEffectTagMap = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.DynamicEffectTagMapLength; ++_j) {_o.DynamicEffectTagMap.Add(this.DynamicEffectTagMap(_j).HasValue ? this.DynamicEffectTagMap(_j).Value.UnPack() : null);}
    _o.ShowLongPress = this.ShowLongPress;
  }
  public static Offset<WWParser.Defs.SkillVehicleButton> Pack(FlatBufferBuilder builder, SkillVehicleButtonT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.SkillVehicleButton>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _skill_id_tag_map = default(VectorOffset);
    if (_o.SkillIdTagMap != null) {
      var __skill_id_tag_map = new Offset<WWParser.Defs.DicIntInt>[_o.SkillIdTagMap.Count];
      for (var _j = 0; _j < __skill_id_tag_map.Length; ++_j) { __skill_id_tag_map[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.SkillIdTagMap[_j]); }
      _skill_id_tag_map = CreateSkillIdTagMapVector(builder, __skill_id_tag_map);
    }
    var _skill_icon = _o.SkillIcon == null ? default(StringOffset) : builder.CreateString(_o.SkillIcon);
    var _skill_icon_tags = default(VectorOffset);
    if (_o.SkillIconTags != null) {
      var __skill_icon_tags = _o.SkillIconTags.ToArray();
      _skill_icon_tags = CreateSkillIconTagsVector(builder, __skill_icon_tags);
    }
    var _enable_tags = default(VectorOffset);
    if (_o.EnableTags != null) {
      var __enable_tags = _o.EnableTags.ToArray();
      _enable_tags = CreateEnableTagsVector(builder, __enable_tags);
    }
    var _disable_tags = default(VectorOffset);
    if (_o.DisableTags != null) {
      var __disable_tags = _o.DisableTags.ToArray();
      _disable_tags = CreateDisableTagsVector(builder, __disable_tags);
    }
    var _disable_skill_id_tags = default(VectorOffset);
    if (_o.DisableSkillIdTags != null) {
      var __disable_skill_id_tags = new Offset<WWParser.Defs.DicIntIntArray>[_o.DisableSkillIdTags.Count];
      for (var _j = 0; _j < __disable_skill_id_tags.Length; ++_j) { __disable_skill_id_tags[_j] = WWParser.Defs.DicIntIntArray.Pack(builder, _o.DisableSkillIdTags[_j]); }
      _disable_skill_id_tags = CreateDisableSkillIdTagsVector(builder, __disable_skill_id_tags);
    }
    var _dynamic_effect_tag_map = default(VectorOffset);
    if (_o.DynamicEffectTagMap != null) {
      var __dynamic_effect_tag_map = new Offset<WWParser.Defs.DicIntInt>[_o.DynamicEffectTagMap.Count];
      for (var _j = 0; _j < __dynamic_effect_tag_map.Length; ++_j) { __dynamic_effect_tag_map[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.DynamicEffectTagMap[_j]); }
      _dynamic_effect_tag_map = CreateDynamicEffectTagMapVector(builder, __dynamic_effect_tag_map);
    }
    return CreateSkillVehicleButton(
      builder,
      _o.Id,
      _o.PbDataId,
      _name,
      _o.ButtonType,
      _o.ActionType,
      _o.SkillId,
      _skill_id_tag_map,
      _skill_icon,
      _skill_icon_tags,
      _enable_tags,
      _disable_tags,
      _disable_skill_id_tags,
      _o.IsCdVisible,
      _o.IsLongPressControlCamera,
      _o.LongPressTime,
      _dynamic_effect_tag_map,
      _o.ShowLongPress);
  }
}

public class SkillVehicleButtonT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("pb_data_id")]
  public int PbDataId { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("button_type")]
  public int ButtonType { get; set; }
  [Newtonsoft.Json.JsonProperty("action_type")]
  public int ActionType { get; set; }
  [Newtonsoft.Json.JsonProperty("skill_id")]
  public int SkillId { get; set; }
  [Newtonsoft.Json.JsonProperty("skill_id_tag_map")]
  public List<WWParser.Defs.DicIntIntT> SkillIdTagMap { get; set; }
  [Newtonsoft.Json.JsonProperty("skill_icon")]
  public string SkillIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("skill_icon_tags")]
  public List<int> SkillIconTags { get; set; }
  [Newtonsoft.Json.JsonProperty("enable_tags")]
  public List<int> EnableTags { get; set; }
  [Newtonsoft.Json.JsonProperty("disable_tags")]
  public List<int> DisableTags { get; set; }
  [Newtonsoft.Json.JsonProperty("disable_skill_id_tags")]
  public List<WWParser.Defs.DicIntIntArrayT> DisableSkillIdTags { get; set; }
  [Newtonsoft.Json.JsonProperty("is_cd_visible")]
  public bool IsCdVisible { get; set; }
  [Newtonsoft.Json.JsonProperty("is_long_press_control_camera")]
  public bool IsLongPressControlCamera { get; set; }
  [Newtonsoft.Json.JsonProperty("long_press_time")]
  public int LongPressTime { get; set; }
  [Newtonsoft.Json.JsonProperty("dynamic_effect_tag_map")]
  public List<WWParser.Defs.DicIntIntT> DynamicEffectTagMap { get; set; }
  [Newtonsoft.Json.JsonProperty("show_long_press")]
  public bool ShowLongPress { get; set; }

  public SkillVehicleButtonT() {
    this.Id = 0;
    this.PbDataId = 0;
    this.Name = null;
    this.ButtonType = 0;
    this.ActionType = 0;
    this.SkillId = 0;
    this.SkillIdTagMap = null;
    this.SkillIcon = null;
    this.SkillIconTags = null;
    this.EnableTags = null;
    this.DisableTags = null;
    this.DisableSkillIdTags = null;
    this.IsCdVisible = false;
    this.IsLongPressControlCamera = false;
    this.LongPressTime = 500;
    this.DynamicEffectTagMap = null;
    this.ShowLongPress = false;
  }
}


static public class SkillVehicleButtonVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*PbDataId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyField(tablePos, 10 /*ButtonType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ActionType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*SkillId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 16 /*SkillIdTagMap*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyString(tablePos, 18 /*SkillIcon*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*SkillIconTags*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*EnableTags*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*DisableTags*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 26 /*DisableSkillIdTags*/, WWParser.Defs.DicIntIntArrayVerify.Verify, false)
      && verifier.VerifyField(tablePos, 28 /*IsCdVisible*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 30 /*IsLongPressControlCamera*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 32 /*LongPressTime*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 34 /*DynamicEffectTagMap*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyField(tablePos, 36 /*ShowLongPress*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
