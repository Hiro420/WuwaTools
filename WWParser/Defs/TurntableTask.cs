// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TurntableTask : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static TurntableTask GetRootAsTurntableTask(ByteBuffer _bb) { return GetRootAsTurntableTask(_bb, new TurntableTask()); }
  public static TurntableTask GetRootAsTurntableTask(ByteBuffer _bb, TurntableTask obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TurntableTask __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TaskId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ActivityId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string TaskDescription { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTaskDescriptionBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTaskDescriptionBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTaskDescriptionArray() { return __p.__vector_as_array<byte>(8); }
  public int TaskReward { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TaskSort { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.TurntableTask> CreateTurntableTask(FlatBufferBuilder builder,
      int task_id = 0,
      int activity_id = 0,
      StringOffset task_descriptionOffset = default(StringOffset),
      int task_reward = 0,
      int task_sort = 0) {
    builder.StartTable(5);
    TurntableTask.AddTaskSort(builder, task_sort);
    TurntableTask.AddTaskReward(builder, task_reward);
    TurntableTask.AddTaskDescription(builder, task_descriptionOffset);
    TurntableTask.AddActivityId(builder, activity_id);
    TurntableTask.AddTaskId(builder, task_id);
    return TurntableTask.EndTurntableTask(builder);
  }

  public static void StartTurntableTask(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddTaskId(FlatBufferBuilder builder, int taskId) { builder.AddInt(0, taskId, 0); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(1, activityId, 0); }
  public static void AddTaskDescription(FlatBufferBuilder builder, StringOffset taskDescriptionOffset) { builder.AddOffset(2, taskDescriptionOffset.Value, 0); }
  public static void AddTaskReward(FlatBufferBuilder builder, int taskReward) { builder.AddInt(3, taskReward, 0); }
  public static void AddTaskSort(FlatBufferBuilder builder, int taskSort) { builder.AddInt(4, taskSort, 0); }
  public static Offset<WWParser.Defs.TurntableTask> EndTurntableTask(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.TurntableTask>(o);
  }
  public TurntableTaskT UnPack() {
    var _o = new TurntableTaskT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TurntableTaskT _o) {
    _o.TaskId = this.TaskId;
    _o.ActivityId = this.ActivityId;
    _o.TaskDescription = this.TaskDescription;
    _o.TaskReward = this.TaskReward;
    _o.TaskSort = this.TaskSort;
  }
  public static Offset<WWParser.Defs.TurntableTask> Pack(FlatBufferBuilder builder, TurntableTaskT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.TurntableTask>);
    var _task_description = _o.TaskDescription == null ? default(StringOffset) : builder.CreateString(_o.TaskDescription);
    return CreateTurntableTask(
      builder,
      _o.TaskId,
      _o.ActivityId,
      _task_description,
      _o.TaskReward,
      _o.TaskSort);
  }
}

public class TurntableTaskT
{
  [Newtonsoft.Json.JsonProperty("task_id")]
  public int TaskId { get; set; }
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("task_description")]
  public string TaskDescription { get; set; }
  [Newtonsoft.Json.JsonProperty("task_reward")]
  public int TaskReward { get; set; }
  [Newtonsoft.Json.JsonProperty("task_sort")]
  public int TaskSort { get; set; }

  public TurntableTaskT() {
    this.TaskId = 0;
    this.ActivityId = 0;
    this.TaskDescription = null;
    this.TaskReward = 0;
    this.TaskSort = 0;
  }
}


static public class TurntableTaskVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TaskId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*TaskDescription*/, false)
      && verifier.VerifyField(tablePos, 10 /*TaskReward*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*TaskSort*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
