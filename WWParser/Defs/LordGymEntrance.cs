// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LordGymEntrance : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static LordGymEntrance GetRootAsLordGymEntrance(ByteBuffer _bb) { return GetRootAsLordGymEntrance(_bb, new LordGymEntrance()); }
  public static LordGymEntrance GetRootAsLordGymEntrance(ByteBuffer _bb, LordGymEntrance obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LordGymEntrance __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MarkId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LordGymList(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int LordGymListLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetLordGymListBytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetLordGymListBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetLordGymListArray() { return __p.__vector_as_array<int>(8); }
  public string EntranceTitle { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEntranceTitleBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetEntranceTitleBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetEntranceTitleArray() { return __p.__vector_as_array<byte>(10); }
  public string EntranceDescription { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEntranceDescriptionBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetEntranceDescriptionBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetEntranceDescriptionArray() { return __p.__vector_as_array<byte>(12); }
  public int MeshId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Zoom(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ZoomLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetZoomBytes() { return __p.__vector_as_span<float>(16, 4); }
#else
  public ArraySegment<byte>? GetZoomBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public float[] GetZoomArray() { return __p.__vector_as_array<float>(16); }
  public float Location(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int LocationLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetLocationBytes() { return __p.__vector_as_span<float>(18, 4); }
#else
  public ArraySegment<byte>? GetLocationBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public float[] GetLocationArray() { return __p.__vector_as_array<float>(18); }
  public float Rotator(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int RotatorLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetRotatorBytes() { return __p.__vector_as_span<float>(20, 4); }
#else
  public ArraySegment<byte>? GetRotatorBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public float[] GetRotatorArray() { return __p.__vector_as_array<float>(20); }
  public string LordChangeMaterialController { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLordChangeMaterialControllerBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetLordChangeMaterialControllerBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetLordChangeMaterialControllerArray() { return __p.__vector_as_array<byte>(22); }
  public string LordIdleMaterialController { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLordIdleMaterialControllerBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetLordIdleMaterialControllerBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetLordIdleMaterialControllerArray() { return __p.__vector_as_array<byte>(24); }
  public string StandAnim { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStandAnimBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetStandAnimBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetStandAnimArray() { return __p.__vector_as_array<byte>(26); }
  public bool IsDebug { get { int o = __p.__offset(28); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<WWParser.Defs.LordGymEntrance> CreateLordGymEntrance(FlatBufferBuilder builder,
      int id = 0,
      int mark_id = 0,
      VectorOffset lord_gym_listOffset = default(VectorOffset),
      StringOffset entrance_titleOffset = default(StringOffset),
      StringOffset entrance_descriptionOffset = default(StringOffset),
      int mesh_id = 0,
      VectorOffset zoomOffset = default(VectorOffset),
      VectorOffset locationOffset = default(VectorOffset),
      VectorOffset rotatorOffset = default(VectorOffset),
      StringOffset lord_change_material_controllerOffset = default(StringOffset),
      StringOffset lord_idle_material_controllerOffset = default(StringOffset),
      StringOffset stand_animOffset = default(StringOffset),
      bool is_debug = false) {
    builder.StartTable(13);
    LordGymEntrance.AddStandAnim(builder, stand_animOffset);
    LordGymEntrance.AddLordIdleMaterialController(builder, lord_idle_material_controllerOffset);
    LordGymEntrance.AddLordChangeMaterialController(builder, lord_change_material_controllerOffset);
    LordGymEntrance.AddRotator(builder, rotatorOffset);
    LordGymEntrance.AddLocation(builder, locationOffset);
    LordGymEntrance.AddZoom(builder, zoomOffset);
    LordGymEntrance.AddMeshId(builder, mesh_id);
    LordGymEntrance.AddEntranceDescription(builder, entrance_descriptionOffset);
    LordGymEntrance.AddEntranceTitle(builder, entrance_titleOffset);
    LordGymEntrance.AddLordGymList(builder, lord_gym_listOffset);
    LordGymEntrance.AddMarkId(builder, mark_id);
    LordGymEntrance.AddId(builder, id);
    LordGymEntrance.AddIsDebug(builder, is_debug);
    return LordGymEntrance.EndLordGymEntrance(builder);
  }

  public static void StartLordGymEntrance(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddMarkId(FlatBufferBuilder builder, int markId) { builder.AddInt(1, markId, 0); }
  public static void AddLordGymList(FlatBufferBuilder builder, VectorOffset lordGymListOffset) { builder.AddOffset(2, lordGymListOffset.Value, 0); }
  public static VectorOffset CreateLordGymListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateLordGymListVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLordGymListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLordGymListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLordGymListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEntranceTitle(FlatBufferBuilder builder, StringOffset entranceTitleOffset) { builder.AddOffset(3, entranceTitleOffset.Value, 0); }
  public static void AddEntranceDescription(FlatBufferBuilder builder, StringOffset entranceDescriptionOffset) { builder.AddOffset(4, entranceDescriptionOffset.Value, 0); }
  public static void AddMeshId(FlatBufferBuilder builder, int meshId) { builder.AddInt(5, meshId, 0); }
  public static void AddZoom(FlatBufferBuilder builder, VectorOffset zoomOffset) { builder.AddOffset(6, zoomOffset.Value, 0); }
  public static VectorOffset CreateZoomVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateZoomVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateZoomVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateZoomVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartZoomVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLocation(FlatBufferBuilder builder, VectorOffset locationOffset) { builder.AddOffset(7, locationOffset.Value, 0); }
  public static VectorOffset CreateLocationVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateLocationVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLocationVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLocationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLocationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRotator(FlatBufferBuilder builder, VectorOffset rotatorOffset) { builder.AddOffset(8, rotatorOffset.Value, 0); }
  public static VectorOffset CreateRotatorVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRotatorVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotatorVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotatorVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRotatorVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLordChangeMaterialController(FlatBufferBuilder builder, StringOffset lordChangeMaterialControllerOffset) { builder.AddOffset(9, lordChangeMaterialControllerOffset.Value, 0); }
  public static void AddLordIdleMaterialController(FlatBufferBuilder builder, StringOffset lordIdleMaterialControllerOffset) { builder.AddOffset(10, lordIdleMaterialControllerOffset.Value, 0); }
  public static void AddStandAnim(FlatBufferBuilder builder, StringOffset standAnimOffset) { builder.AddOffset(11, standAnimOffset.Value, 0); }
  public static void AddIsDebug(FlatBufferBuilder builder, bool isDebug) { builder.AddBool(12, isDebug, false); }
  public static Offset<WWParser.Defs.LordGymEntrance> EndLordGymEntrance(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.LordGymEntrance>(o);
  }
  public LordGymEntranceT UnPack() {
    var _o = new LordGymEntranceT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LordGymEntranceT _o) {
    _o.Id = this.Id;
    _o.MarkId = this.MarkId;
    _o.LordGymList = new List<int>();
    for (var _j = 0; _j < this.LordGymListLength; ++_j) {_o.LordGymList.Add(this.LordGymList(_j));}
    _o.EntranceTitle = this.EntranceTitle;
    _o.EntranceDescription = this.EntranceDescription;
    _o.MeshId = this.MeshId;
    _o.Zoom = new List<float>();
    for (var _j = 0; _j < this.ZoomLength; ++_j) {_o.Zoom.Add(this.Zoom(_j));}
    _o.Location = new List<float>();
    for (var _j = 0; _j < this.LocationLength; ++_j) {_o.Location.Add(this.Location(_j));}
    _o.Rotator = new List<float>();
    for (var _j = 0; _j < this.RotatorLength; ++_j) {_o.Rotator.Add(this.Rotator(_j));}
    _o.LordChangeMaterialController = this.LordChangeMaterialController;
    _o.LordIdleMaterialController = this.LordIdleMaterialController;
    _o.StandAnim = this.StandAnim;
    _o.IsDebug = this.IsDebug;
  }
  public static Offset<WWParser.Defs.LordGymEntrance> Pack(FlatBufferBuilder builder, LordGymEntranceT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.LordGymEntrance>);
    var _lord_gym_list = default(VectorOffset);
    if (_o.LordGymList != null) {
      var __lord_gym_list = _o.LordGymList.ToArray();
      _lord_gym_list = CreateLordGymListVector(builder, __lord_gym_list);
    }
    var _entrance_title = _o.EntranceTitle == null ? default(StringOffset) : builder.CreateString(_o.EntranceTitle);
    var _entrance_description = _o.EntranceDescription == null ? default(StringOffset) : builder.CreateString(_o.EntranceDescription);
    var _zoom = default(VectorOffset);
    if (_o.Zoom != null) {
      var __zoom = _o.Zoom.ToArray();
      _zoom = CreateZoomVector(builder, __zoom);
    }
    var _location = default(VectorOffset);
    if (_o.Location != null) {
      var __location = _o.Location.ToArray();
      _location = CreateLocationVector(builder, __location);
    }
    var _rotator = default(VectorOffset);
    if (_o.Rotator != null) {
      var __rotator = _o.Rotator.ToArray();
      _rotator = CreateRotatorVector(builder, __rotator);
    }
    var _lord_change_material_controller = _o.LordChangeMaterialController == null ? default(StringOffset) : builder.CreateString(_o.LordChangeMaterialController);
    var _lord_idle_material_controller = _o.LordIdleMaterialController == null ? default(StringOffset) : builder.CreateString(_o.LordIdleMaterialController);
    var _stand_anim = _o.StandAnim == null ? default(StringOffset) : builder.CreateString(_o.StandAnim);
    return CreateLordGymEntrance(
      builder,
      _o.Id,
      _o.MarkId,
      _lord_gym_list,
      _entrance_title,
      _entrance_description,
      _o.MeshId,
      _zoom,
      _location,
      _rotator,
      _lord_change_material_controller,
      _lord_idle_material_controller,
      _stand_anim,
      _o.IsDebug);
  }
}

public class LordGymEntranceT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("mark_id")]
  public int MarkId { get; set; }
  [Newtonsoft.Json.JsonProperty("lord_gym_list")]
  public List<int> LordGymList { get; set; }
  [Newtonsoft.Json.JsonProperty("entrance_title")]
  public string EntranceTitle { get; set; }
  [Newtonsoft.Json.JsonProperty("entrance_description")]
  public string EntranceDescription { get; set; }
  [Newtonsoft.Json.JsonProperty("mesh_id")]
  public int MeshId { get; set; }
  [Newtonsoft.Json.JsonProperty("zoom")]
  public List<float> Zoom { get; set; }
  [Newtonsoft.Json.JsonProperty("location")]
  public List<float> Location { get; set; }
  [Newtonsoft.Json.JsonProperty("rotator")]
  public List<float> Rotator { get; set; }
  [Newtonsoft.Json.JsonProperty("lord_change_material_controller")]
  public string LordChangeMaterialController { get; set; }
  [Newtonsoft.Json.JsonProperty("lord_idle_material_controller")]
  public string LordIdleMaterialController { get; set; }
  [Newtonsoft.Json.JsonProperty("stand_anim")]
  public string StandAnim { get; set; }
  [Newtonsoft.Json.JsonProperty("is_debug")]
  public bool IsDebug { get; set; }

  public LordGymEntranceT() {
    this.Id = 0;
    this.MarkId = 0;
    this.LordGymList = null;
    this.EntranceTitle = null;
    this.EntranceDescription = null;
    this.MeshId = 0;
    this.Zoom = null;
    this.Location = null;
    this.Rotator = null;
    this.LordChangeMaterialController = null;
    this.LordIdleMaterialController = null;
    this.StandAnim = null;
    this.IsDebug = false;
  }
}


static public class LordGymEntranceVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MarkId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*LordGymList*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 10 /*EntranceTitle*/, false)
      && verifier.VerifyString(tablePos, 12 /*EntranceDescription*/, false)
      && verifier.VerifyField(tablePos, 14 /*MeshId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*Zoom*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*Location*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*Rotator*/, 4 /*float*/, false)
      && verifier.VerifyString(tablePos, 22 /*LordChangeMaterialController*/, false)
      && verifier.VerifyString(tablePos, 24 /*LordIdleMaterialController*/, false)
      && verifier.VerifyString(tablePos, 26 /*StandAnim*/, false)
      && verifier.VerifyField(tablePos, 28 /*IsDebug*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
