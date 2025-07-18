// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SpringReward : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static SpringReward GetRootAsSpringReward(ByteBuffer _bb) { return GetRootAsSpringReward(_bb, new SpringReward()); }
  public static SpringReward GetRootAsSpringReward(ByteBuffer _bb, SpringReward obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SpringReward __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TaskThreshold { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ActivityId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TaskReward { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string TaskTitle { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTaskTitleBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTaskTitleBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTaskTitleArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<WWParser.Defs.SpringReward> CreateSpringReward(FlatBufferBuilder builder,
      int id = 0,
      int task_threshold = 0,
      int activity_id = 0,
      int task_reward = 0,
      StringOffset task_titleOffset = default(StringOffset)) {
    builder.StartTable(5);
    SpringReward.AddTaskTitle(builder, task_titleOffset);
    SpringReward.AddTaskReward(builder, task_reward);
    SpringReward.AddActivityId(builder, activity_id);
    SpringReward.AddTaskThreshold(builder, task_threshold);
    SpringReward.AddId(builder, id);
    return SpringReward.EndSpringReward(builder);
  }

  public static void StartSpringReward(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTaskThreshold(FlatBufferBuilder builder, int taskThreshold) { builder.AddInt(1, taskThreshold, 0); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(2, activityId, 0); }
  public static void AddTaskReward(FlatBufferBuilder builder, int taskReward) { builder.AddInt(3, taskReward, 0); }
  public static void AddTaskTitle(FlatBufferBuilder builder, StringOffset taskTitleOffset) { builder.AddOffset(4, taskTitleOffset.Value, 0); }
  public static Offset<WWParser.Defs.SpringReward> EndSpringReward(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.SpringReward>(o);
  }
  public SpringRewardT UnPack() {
    var _o = new SpringRewardT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SpringRewardT _o) {
    _o.Id = this.Id;
    _o.TaskThreshold = this.TaskThreshold;
    _o.ActivityId = this.ActivityId;
    _o.TaskReward = this.TaskReward;
    _o.TaskTitle = this.TaskTitle;
  }
  public static Offset<WWParser.Defs.SpringReward> Pack(FlatBufferBuilder builder, SpringRewardT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.SpringReward>);
    var _task_title = _o.TaskTitle == null ? default(StringOffset) : builder.CreateString(_o.TaskTitle);
    return CreateSpringReward(
      builder,
      _o.Id,
      _o.TaskThreshold,
      _o.ActivityId,
      _o.TaskReward,
      _task_title);
  }
}

public class SpringRewardT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("task_threshold")]
  public int TaskThreshold { get; set; }
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("task_reward")]
  public int TaskReward { get; set; }
  [Newtonsoft.Json.JsonProperty("task_title")]
  public string TaskTitle { get; set; }

  public SpringRewardT() {
    this.Id = 0;
    this.TaskThreshold = 0;
    this.ActivityId = 0;
    this.TaskReward = 0;
    this.TaskTitle = null;
  }
}


static public class SpringRewardVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*TaskThreshold*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*TaskReward*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*TaskTitle*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
