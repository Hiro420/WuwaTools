// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CircumFluenceTask : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static CircumFluenceTask GetRootAsCircumFluenceTask(ByteBuffer _bb) { return GetRootAsCircumFluenceTask(_bb, new CircumFluenceTask()); }
  public static CircumFluenceTask GetRootAsCircumFluenceTask(ByteBuffer _bb, CircumFluenceTask obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CircumFluenceTask __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TaskType { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)2; } }
  public string TargetName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTargetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTargetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTargetNameArray() { return __p.__vector_as_array<byte>(8); }
  public int TaskSubType { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExploreType { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TargetReward { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TargetFunc { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.CircumFluenceTask> CreateCircumFluenceTask(FlatBufferBuilder builder,
      int id = 0,
      int task_type = 2,
      StringOffset target_nameOffset = default(StringOffset),
      int task_sub_type = 0,
      int explore_type = 0,
      int target_reward = 0,
      int target_func = 0) {
    builder.StartTable(7);
    CircumFluenceTask.AddTargetFunc(builder, target_func);
    CircumFluenceTask.AddTargetReward(builder, target_reward);
    CircumFluenceTask.AddExploreType(builder, explore_type);
    CircumFluenceTask.AddTaskSubType(builder, task_sub_type);
    CircumFluenceTask.AddTargetName(builder, target_nameOffset);
    CircumFluenceTask.AddTaskType(builder, task_type);
    CircumFluenceTask.AddId(builder, id);
    return CircumFluenceTask.EndCircumFluenceTask(builder);
  }

  public static void StartCircumFluenceTask(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTaskType(FlatBufferBuilder builder, int taskType) { builder.AddInt(1, taskType, 2); }
  public static void AddTargetName(FlatBufferBuilder builder, StringOffset targetNameOffset) { builder.AddOffset(2, targetNameOffset.Value, 0); }
  public static void AddTaskSubType(FlatBufferBuilder builder, int taskSubType) { builder.AddInt(3, taskSubType, 0); }
  public static void AddExploreType(FlatBufferBuilder builder, int exploreType) { builder.AddInt(4, exploreType, 0); }
  public static void AddTargetReward(FlatBufferBuilder builder, int targetReward) { builder.AddInt(5, targetReward, 0); }
  public static void AddTargetFunc(FlatBufferBuilder builder, int targetFunc) { builder.AddInt(6, targetFunc, 0); }
  public static Offset<WWParser.Defs.CircumFluenceTask> EndCircumFluenceTask(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.CircumFluenceTask>(o);
  }
  public CircumFluenceTaskT UnPack() {
    var _o = new CircumFluenceTaskT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CircumFluenceTaskT _o) {
    _o.Id = this.Id;
    _o.TaskType = this.TaskType;
    _o.TargetName = this.TargetName;
    _o.TaskSubType = this.TaskSubType;
    _o.ExploreType = this.ExploreType;
    _o.TargetReward = this.TargetReward;
    _o.TargetFunc = this.TargetFunc;
  }
  public static Offset<WWParser.Defs.CircumFluenceTask> Pack(FlatBufferBuilder builder, CircumFluenceTaskT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.CircumFluenceTask>);
    var _target_name = _o.TargetName == null ? default(StringOffset) : builder.CreateString(_o.TargetName);
    return CreateCircumFluenceTask(
      builder,
      _o.Id,
      _o.TaskType,
      _target_name,
      _o.TaskSubType,
      _o.ExploreType,
      _o.TargetReward,
      _o.TargetFunc);
  }
}

public class CircumFluenceTaskT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("task_type")]
  public int TaskType { get; set; }
  [Newtonsoft.Json.JsonProperty("target_name")]
  public string TargetName { get; set; }
  [Newtonsoft.Json.JsonProperty("task_sub_type")]
  public int TaskSubType { get; set; }
  [Newtonsoft.Json.JsonProperty("explore_type")]
  public int ExploreType { get; set; }
  [Newtonsoft.Json.JsonProperty("target_reward")]
  public int TargetReward { get; set; }
  [Newtonsoft.Json.JsonProperty("target_func")]
  public int TargetFunc { get; set; }

  public CircumFluenceTaskT() {
    this.Id = 0;
    this.TaskType = 2;
    this.TargetName = null;
    this.TaskSubType = 0;
    this.ExploreType = 0;
    this.TargetReward = 0;
    this.TargetFunc = 0;
  }
}


static public class CircumFluenceTaskVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*TaskType*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*TargetName*/, false)
      && verifier.VerifyField(tablePos, 10 /*TaskSubType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ExploreType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*TargetReward*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*TargetFunc*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
