// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GameplayCue : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static GameplayCue GetRootAsGameplayCue(ByteBuffer _bb) { return GetRootAsGameplayCue(_bb, new GameplayCue()); }
  public static GameplayCue GetRootAsGameplayCue(ByteBuffer _bb, GameplayCue obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GameplayCue __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public double Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)0.0; } }
  public string Path { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetPathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetPathArray() { return __p.__vector_as_array<byte>(6); }
  public int CueType { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)1; } }
  public int Comp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string CompName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCompNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetCompNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetCompNameArray() { return __p.__vector_as_array<byte>(12); }
  public string Socket { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSocketBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetSocketBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetSocketArray() { return __p.__vector_as_array<byte>(14); }
  public WWParser.Defs.Vector? Location { get { int o = __p.__offset(16); return o != 0 ? (WWParser.Defs.Vector?)(new WWParser.Defs.Vector()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public WWParser.Defs.Vector? Rotation { get { int o = __p.__offset(18); return o != 0 ? (WWParser.Defs.Vector?)(new WWParser.Defs.Vector()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public WWParser.Defs.Vector? Scale { get { int o = __p.__offset(20); return o != 0 ? (WWParser.Defs.Vector?)(new WWParser.Defs.Vector()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public int LocRule { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RotaRule { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SclRule { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EndRule { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Magni { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AttrId { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Tag { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTagBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetTagBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetTagArray() { return __p.__vector_as_array<byte>(34); }
  public int Max { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)10000; } }
  public int Min { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool BListenAttr { get { int o = __p.__offset(40); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool BSoftFollow { get { int o = __p.__offset(42); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool BLockRevolution { get { int o = __p.__offset(44); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public WWParser.Defs.Vector? LockRotation { get { int o = __p.__offset(46); return o != 0 ? (WWParser.Defs.Vector?)(new WWParser.Defs.Vector()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public bool LockCamera { get { int o = __p.__offset(48); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int InterpSpeed { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)5; } }
  public int FarthestDistance { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)100; } }
  public WWParser.Defs.Vector? FaultTolerance { get { int o = __p.__offset(54); return o != 0 ? (WWParser.Defs.Vector?)(new WWParser.Defs.Vector()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public float TargetScaleUp(int j) { int o = __p.__offset(56); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int TargetScaleUpLength { get { int o = __p.__offset(56); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetTargetScaleUpBytes() { return __p.__vector_as_span<float>(56, 4); }
#else
  public ArraySegment<byte>? GetTargetScaleUpBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public float[] GetTargetScaleUpArray() { return __p.__vector_as_array<float>(56); }
  public string Resources(int j) { int o = __p.__offset(58); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ResourcesLength { get { int o = __p.__offset(58); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Parameters(int j) { int o = __p.__offset(60); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ParametersLength { get { int o = __p.__offset(60); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int Group { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Priority { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.GameplayCue> CreateGameplayCue(FlatBufferBuilder builder,
      double id = 0.0,
      StringOffset pathOffset = default(StringOffset),
      int cue_type = 1,
      int comp = 0,
      StringOffset comp_nameOffset = default(StringOffset),
      StringOffset socketOffset = default(StringOffset),
      Offset<WWParser.Defs.Vector> locationOffset = default(Offset<WWParser.Defs.Vector>),
      Offset<WWParser.Defs.Vector> rotationOffset = default(Offset<WWParser.Defs.Vector>),
      Offset<WWParser.Defs.Vector> scaleOffset = default(Offset<WWParser.Defs.Vector>),
      int loc_rule = 0,
      int rota_rule = 0,
      int scl_rule = 0,
      int end_rule = 0,
      int magni = 0,
      int attr_id = 0,
      StringOffset tagOffset = default(StringOffset),
      int max = 10000,
      int min = 0,
      bool b_listen_attr = false,
      bool b_soft_follow = false,
      bool b_lock_revolution = false,
      Offset<WWParser.Defs.Vector> lock_rotationOffset = default(Offset<WWParser.Defs.Vector>),
      bool lock_camera = false,
      int interp_speed = 5,
      int farthest_distance = 100,
      Offset<WWParser.Defs.Vector> fault_toleranceOffset = default(Offset<WWParser.Defs.Vector>),
      VectorOffset target_scale_upOffset = default(VectorOffset),
      VectorOffset resourcesOffset = default(VectorOffset),
      VectorOffset parametersOffset = default(VectorOffset),
      int group = 0,
      int priority = 0) {
    builder.StartTable(31);
    GameplayCue.AddId(builder, id);
    GameplayCue.AddPriority(builder, priority);
    GameplayCue.AddGroup(builder, group);
    GameplayCue.AddParameters(builder, parametersOffset);
    GameplayCue.AddResources(builder, resourcesOffset);
    GameplayCue.AddTargetScaleUp(builder, target_scale_upOffset);
    GameplayCue.AddFaultTolerance(builder, fault_toleranceOffset);
    GameplayCue.AddFarthestDistance(builder, farthest_distance);
    GameplayCue.AddInterpSpeed(builder, interp_speed);
    GameplayCue.AddLockRotation(builder, lock_rotationOffset);
    GameplayCue.AddMin(builder, min);
    GameplayCue.AddMax(builder, max);
    GameplayCue.AddTag(builder, tagOffset);
    GameplayCue.AddAttrId(builder, attr_id);
    GameplayCue.AddMagni(builder, magni);
    GameplayCue.AddEndRule(builder, end_rule);
    GameplayCue.AddSclRule(builder, scl_rule);
    GameplayCue.AddRotaRule(builder, rota_rule);
    GameplayCue.AddLocRule(builder, loc_rule);
    GameplayCue.AddScale(builder, scaleOffset);
    GameplayCue.AddRotation(builder, rotationOffset);
    GameplayCue.AddLocation(builder, locationOffset);
    GameplayCue.AddSocket(builder, socketOffset);
    GameplayCue.AddCompName(builder, comp_nameOffset);
    GameplayCue.AddComp(builder, comp);
    GameplayCue.AddCueType(builder, cue_type);
    GameplayCue.AddPath(builder, pathOffset);
    GameplayCue.AddLockCamera(builder, lock_camera);
    GameplayCue.AddBLockRevolution(builder, b_lock_revolution);
    GameplayCue.AddBSoftFollow(builder, b_soft_follow);
    GameplayCue.AddBListenAttr(builder, b_listen_attr);
    return GameplayCue.EndGameplayCue(builder);
  }

  public static void StartGameplayCue(FlatBufferBuilder builder) { builder.StartTable(31); }
  public static void AddId(FlatBufferBuilder builder, double id) { builder.AddDouble(0, id, 0.0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset) { builder.AddOffset(1, pathOffset.Value, 0); }
  public static void AddCueType(FlatBufferBuilder builder, int cueType) { builder.AddInt(2, cueType, 1); }
  public static void AddComp(FlatBufferBuilder builder, int comp) { builder.AddInt(3, comp, 0); }
  public static void AddCompName(FlatBufferBuilder builder, StringOffset compNameOffset) { builder.AddOffset(4, compNameOffset.Value, 0); }
  public static void AddSocket(FlatBufferBuilder builder, StringOffset socketOffset) { builder.AddOffset(5, socketOffset.Value, 0); }
  public static void AddLocation(FlatBufferBuilder builder, Offset<WWParser.Defs.Vector> locationOffset) { builder.AddOffset(6, locationOffset.Value, 0); }
  public static void AddRotation(FlatBufferBuilder builder, Offset<WWParser.Defs.Vector> rotationOffset) { builder.AddOffset(7, rotationOffset.Value, 0); }
  public static void AddScale(FlatBufferBuilder builder, Offset<WWParser.Defs.Vector> scaleOffset) { builder.AddOffset(8, scaleOffset.Value, 0); }
  public static void AddLocRule(FlatBufferBuilder builder, int locRule) { builder.AddInt(9, locRule, 0); }
  public static void AddRotaRule(FlatBufferBuilder builder, int rotaRule) { builder.AddInt(10, rotaRule, 0); }
  public static void AddSclRule(FlatBufferBuilder builder, int sclRule) { builder.AddInt(11, sclRule, 0); }
  public static void AddEndRule(FlatBufferBuilder builder, int endRule) { builder.AddInt(12, endRule, 0); }
  public static void AddMagni(FlatBufferBuilder builder, int magni) { builder.AddInt(13, magni, 0); }
  public static void AddAttrId(FlatBufferBuilder builder, int attrId) { builder.AddInt(14, attrId, 0); }
  public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset) { builder.AddOffset(15, tagOffset.Value, 0); }
  public static void AddMax(FlatBufferBuilder builder, int max) { builder.AddInt(16, max, 10000); }
  public static void AddMin(FlatBufferBuilder builder, int min) { builder.AddInt(17, min, 0); }
  public static void AddBListenAttr(FlatBufferBuilder builder, bool bListenAttr) { builder.AddBool(18, bListenAttr, false); }
  public static void AddBSoftFollow(FlatBufferBuilder builder, bool bSoftFollow) { builder.AddBool(19, bSoftFollow, false); }
  public static void AddBLockRevolution(FlatBufferBuilder builder, bool bLockRevolution) { builder.AddBool(20, bLockRevolution, false); }
  public static void AddLockRotation(FlatBufferBuilder builder, Offset<WWParser.Defs.Vector> lockRotationOffset) { builder.AddOffset(21, lockRotationOffset.Value, 0); }
  public static void AddLockCamera(FlatBufferBuilder builder, bool lockCamera) { builder.AddBool(22, lockCamera, false); }
  public static void AddInterpSpeed(FlatBufferBuilder builder, int interpSpeed) { builder.AddInt(23, interpSpeed, 5); }
  public static void AddFarthestDistance(FlatBufferBuilder builder, int farthestDistance) { builder.AddInt(24, farthestDistance, 100); }
  public static void AddFaultTolerance(FlatBufferBuilder builder, Offset<WWParser.Defs.Vector> faultToleranceOffset) { builder.AddOffset(25, faultToleranceOffset.Value, 0); }
  public static void AddTargetScaleUp(FlatBufferBuilder builder, VectorOffset targetScaleUpOffset) { builder.AddOffset(26, targetScaleUpOffset.Value, 0); }
  public static VectorOffset CreateTargetScaleUpVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTargetScaleUpVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTargetScaleUpVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTargetScaleUpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTargetScaleUpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddResources(FlatBufferBuilder builder, VectorOffset resourcesOffset) { builder.AddOffset(27, resourcesOffset.Value, 0); }
  public static VectorOffset CreateResourcesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateResourcesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResourcesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResourcesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartResourcesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParameters(FlatBufferBuilder builder, VectorOffset parametersOffset) { builder.AddOffset(28, parametersOffset.Value, 0); }
  public static VectorOffset CreateParametersVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateParametersVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParametersVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParametersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGroup(FlatBufferBuilder builder, int group) { builder.AddInt(29, group, 0); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(30, priority, 0); }
  public static Offset<WWParser.Defs.GameplayCue> EndGameplayCue(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.GameplayCue>(o);
  }
  public GameplayCueT UnPack() {
    var _o = new GameplayCueT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GameplayCueT _o) {
    _o.Id = this.Id;
    _o.Path = this.Path;
    _o.CueType = this.CueType;
    _o.Comp = this.Comp;
    _o.CompName = this.CompName;
    _o.Socket = this.Socket;
    _o.Location = this.Location.HasValue ? this.Location.Value.UnPack() : null;
    _o.Rotation = this.Rotation.HasValue ? this.Rotation.Value.UnPack() : null;
    _o.Scale = this.Scale.HasValue ? this.Scale.Value.UnPack() : null;
    _o.LocRule = this.LocRule;
    _o.RotaRule = this.RotaRule;
    _o.SclRule = this.SclRule;
    _o.EndRule = this.EndRule;
    _o.Magni = this.Magni;
    _o.AttrId = this.AttrId;
    _o.Tag = this.Tag;
    _o.Max = this.Max;
    _o.Min = this.Min;
    _o.BListenAttr = this.BListenAttr;
    _o.BSoftFollow = this.BSoftFollow;
    _o.BLockRevolution = this.BLockRevolution;
    _o.LockRotation = this.LockRotation.HasValue ? this.LockRotation.Value.UnPack() : null;
    _o.LockCamera = this.LockCamera;
    _o.InterpSpeed = this.InterpSpeed;
    _o.FarthestDistance = this.FarthestDistance;
    _o.FaultTolerance = this.FaultTolerance.HasValue ? this.FaultTolerance.Value.UnPack() : null;
    _o.TargetScaleUp = new List<float>();
    for (var _j = 0; _j < this.TargetScaleUpLength; ++_j) {_o.TargetScaleUp.Add(this.TargetScaleUp(_j));}
    _o.Resources = new List<string>();
    for (var _j = 0; _j < this.ResourcesLength; ++_j) {_o.Resources.Add(this.Resources(_j));}
    _o.Parameters = new List<string>();
    for (var _j = 0; _j < this.ParametersLength; ++_j) {_o.Parameters.Add(this.Parameters(_j));}
    _o.Group = this.Group;
    _o.Priority = this.Priority;
  }
  public static Offset<WWParser.Defs.GameplayCue> Pack(FlatBufferBuilder builder, GameplayCueT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.GameplayCue>);
    var _path = _o.Path == null ? default(StringOffset) : builder.CreateString(_o.Path);
    var _comp_name = _o.CompName == null ? default(StringOffset) : builder.CreateString(_o.CompName);
    var _socket = _o.Socket == null ? default(StringOffset) : builder.CreateString(_o.Socket);
    var _location = _o.Location == null ? default(Offset<WWParser.Defs.Vector>) : WWParser.Defs.Vector.Pack(builder, _o.Location);
    var _rotation = _o.Rotation == null ? default(Offset<WWParser.Defs.Vector>) : WWParser.Defs.Vector.Pack(builder, _o.Rotation);
    var _scale = _o.Scale == null ? default(Offset<WWParser.Defs.Vector>) : WWParser.Defs.Vector.Pack(builder, _o.Scale);
    var _tag = _o.Tag == null ? default(StringOffset) : builder.CreateString(_o.Tag);
    var _lock_rotation = _o.LockRotation == null ? default(Offset<WWParser.Defs.Vector>) : WWParser.Defs.Vector.Pack(builder, _o.LockRotation);
    var _fault_tolerance = _o.FaultTolerance == null ? default(Offset<WWParser.Defs.Vector>) : WWParser.Defs.Vector.Pack(builder, _o.FaultTolerance);
    var _target_scale_up = default(VectorOffset);
    if (_o.TargetScaleUp != null) {
      var __target_scale_up = _o.TargetScaleUp.ToArray();
      _target_scale_up = CreateTargetScaleUpVector(builder, __target_scale_up);
    }
    var _resources = default(VectorOffset);
    if (_o.Resources != null) {
      var __resources = new StringOffset[_o.Resources.Count];
      for (var _j = 0; _j < __resources.Length; ++_j) { __resources[_j] = builder.CreateString(_o.Resources[_j]); }
      _resources = CreateResourcesVector(builder, __resources);
    }
    var _parameters = default(VectorOffset);
    if (_o.Parameters != null) {
      var __parameters = new StringOffset[_o.Parameters.Count];
      for (var _j = 0; _j < __parameters.Length; ++_j) { __parameters[_j] = builder.CreateString(_o.Parameters[_j]); }
      _parameters = CreateParametersVector(builder, __parameters);
    }
    return CreateGameplayCue(
      builder,
      _o.Id,
      _path,
      _o.CueType,
      _o.Comp,
      _comp_name,
      _socket,
      _location,
      _rotation,
      _scale,
      _o.LocRule,
      _o.RotaRule,
      _o.SclRule,
      _o.EndRule,
      _o.Magni,
      _o.AttrId,
      _tag,
      _o.Max,
      _o.Min,
      _o.BListenAttr,
      _o.BSoftFollow,
      _o.BLockRevolution,
      _lock_rotation,
      _o.LockCamera,
      _o.InterpSpeed,
      _o.FarthestDistance,
      _fault_tolerance,
      _target_scale_up,
      _resources,
      _parameters,
      _o.Group,
      _o.Priority);
  }
}

public class GameplayCueT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public double Id { get; set; }
  [Newtonsoft.Json.JsonProperty("path")]
  public string Path { get; set; }
  [Newtonsoft.Json.JsonProperty("cue_type")]
  public int CueType { get; set; }
  [Newtonsoft.Json.JsonProperty("comp")]
  public int Comp { get; set; }
  [Newtonsoft.Json.JsonProperty("comp_name")]
  public string CompName { get; set; }
  [Newtonsoft.Json.JsonProperty("socket")]
  public string Socket { get; set; }
  [Newtonsoft.Json.JsonProperty("location")]
  public WWParser.Defs.VectorT Location { get; set; }
  [Newtonsoft.Json.JsonProperty("rotation")]
  public WWParser.Defs.VectorT Rotation { get; set; }
  [Newtonsoft.Json.JsonProperty("scale")]
  public WWParser.Defs.VectorT Scale { get; set; }
  [Newtonsoft.Json.JsonProperty("loc_rule")]
  public int LocRule { get; set; }
  [Newtonsoft.Json.JsonProperty("rota_rule")]
  public int RotaRule { get; set; }
  [Newtonsoft.Json.JsonProperty("scl_rule")]
  public int SclRule { get; set; }
  [Newtonsoft.Json.JsonProperty("end_rule")]
  public int EndRule { get; set; }
  [Newtonsoft.Json.JsonProperty("magni")]
  public int Magni { get; set; }
  [Newtonsoft.Json.JsonProperty("attr_id")]
  public int AttrId { get; set; }
  [Newtonsoft.Json.JsonProperty("tag")]
  public string Tag { get; set; }
  [Newtonsoft.Json.JsonProperty("max")]
  public int Max { get; set; }
  [Newtonsoft.Json.JsonProperty("min")]
  public int Min { get; set; }
  [Newtonsoft.Json.JsonProperty("b_listen_attr")]
  public bool BListenAttr { get; set; }
  [Newtonsoft.Json.JsonProperty("b_soft_follow")]
  public bool BSoftFollow { get; set; }
  [Newtonsoft.Json.JsonProperty("b_lock_revolution")]
  public bool BLockRevolution { get; set; }
  [Newtonsoft.Json.JsonProperty("lock_rotation")]
  public WWParser.Defs.VectorT LockRotation { get; set; }
  [Newtonsoft.Json.JsonProperty("lock_camera")]
  public bool LockCamera { get; set; }
  [Newtonsoft.Json.JsonProperty("interp_speed")]
  public int InterpSpeed { get; set; }
  [Newtonsoft.Json.JsonProperty("farthest_distance")]
  public int FarthestDistance { get; set; }
  [Newtonsoft.Json.JsonProperty("fault_tolerance")]
  public WWParser.Defs.VectorT FaultTolerance { get; set; }
  [Newtonsoft.Json.JsonProperty("target_scale_up")]
  public List<float> TargetScaleUp { get; set; }
  [Newtonsoft.Json.JsonProperty("resources")]
  public List<string> Resources { get; set; }
  [Newtonsoft.Json.JsonProperty("parameters")]
  public List<string> Parameters { get; set; }
  [Newtonsoft.Json.JsonProperty("group")]
  public int Group { get; set; }
  [Newtonsoft.Json.JsonProperty("priority")]
  public int Priority { get; set; }

  public GameplayCueT() {
    this.Id = 0.0;
    this.Path = null;
    this.CueType = 1;
    this.Comp = 0;
    this.CompName = null;
    this.Socket = null;
    this.Location = null;
    this.Rotation = null;
    this.Scale = null;
    this.LocRule = 0;
    this.RotaRule = 0;
    this.SclRule = 0;
    this.EndRule = 0;
    this.Magni = 0;
    this.AttrId = 0;
    this.Tag = null;
    this.Max = 10000;
    this.Min = 0;
    this.BListenAttr = false;
    this.BSoftFollow = false;
    this.BLockRevolution = false;
    this.LockRotation = null;
    this.LockCamera = false;
    this.InterpSpeed = 5;
    this.FarthestDistance = 100;
    this.FaultTolerance = null;
    this.TargetScaleUp = null;
    this.Resources = null;
    this.Parameters = null;
    this.Group = 0;
    this.Priority = 0;
  }
}


static public class GameplayCueVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*double*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*Path*/, false)
      && verifier.VerifyField(tablePos, 8 /*CueType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Comp*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*CompName*/, false)
      && verifier.VerifyString(tablePos, 14 /*Socket*/, false)
      && verifier.VerifyTable(tablePos, 16 /*Location*/, WWParser.Defs.VectorVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 18 /*Rotation*/, WWParser.Defs.VectorVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 20 /*Scale*/, WWParser.Defs.VectorVerify.Verify, false)
      && verifier.VerifyField(tablePos, 22 /*LocRule*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*RotaRule*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*SclRule*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*EndRule*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*Magni*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*AttrId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 34 /*Tag*/, false)
      && verifier.VerifyField(tablePos, 36 /*Max*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*Min*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*BListenAttr*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 42 /*BSoftFollow*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 44 /*BLockRevolution*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTable(tablePos, 46 /*LockRotation*/, WWParser.Defs.VectorVerify.Verify, false)
      && verifier.VerifyField(tablePos, 48 /*LockCamera*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 50 /*InterpSpeed*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 52 /*FarthestDistance*/, 4 /*int*/, 4, false)
      && verifier.VerifyTable(tablePos, 54 /*FaultTolerance*/, WWParser.Defs.VectorVerify.Verify, false)
      && verifier.VerifyVectorOfData(tablePos, 56 /*TargetScaleUp*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 58 /*Resources*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 60 /*Parameters*/, false)
      && verifier.VerifyField(tablePos, 62 /*Group*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 64 /*Priority*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
