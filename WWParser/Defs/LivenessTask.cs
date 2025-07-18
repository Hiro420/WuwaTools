// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LivenessTask : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static LivenessTask GetRootAsLivenessTask(ByteBuffer _bb) { return GetRootAsLivenessTask(_bb, new LivenessTask()); }
  public static LivenessTask GetRootAsLivenessTask(ByteBuffer _bb, LivenessTask obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LivenessTask __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TaskId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string TaskName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTaskNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTaskNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTaskNameArray() { return __p.__vector_as_array<byte>(6); }
  public int UpdateType { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public WWParser.Defs.DicIntInt? TaskReward(int j) { int o = __p.__offset(10); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int TaskRewardLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string TaskFunc(int j) { int o = __p.__offset(12); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int TaskFuncLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int UnlockCondition { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SortRank { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.LivenessTask> CreateLivenessTask(FlatBufferBuilder builder,
      int task_id = 0,
      StringOffset task_nameOffset = default(StringOffset),
      int update_type = 0,
      VectorOffset task_rewardOffset = default(VectorOffset),
      VectorOffset task_funcOffset = default(VectorOffset),
      int unlock_condition = 0,
      int sort_rank = 0) {
    builder.StartTable(7);
    LivenessTask.AddSortRank(builder, sort_rank);
    LivenessTask.AddUnlockCondition(builder, unlock_condition);
    LivenessTask.AddTaskFunc(builder, task_funcOffset);
    LivenessTask.AddTaskReward(builder, task_rewardOffset);
    LivenessTask.AddUpdateType(builder, update_type);
    LivenessTask.AddTaskName(builder, task_nameOffset);
    LivenessTask.AddTaskId(builder, task_id);
    return LivenessTask.EndLivenessTask(builder);
  }

  public static void StartLivenessTask(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddTaskId(FlatBufferBuilder builder, int taskId) { builder.AddInt(0, taskId, 0); }
  public static void AddTaskName(FlatBufferBuilder builder, StringOffset taskNameOffset) { builder.AddOffset(1, taskNameOffset.Value, 0); }
  public static void AddUpdateType(FlatBufferBuilder builder, int updateType) { builder.AddInt(2, updateType, 0); }
  public static void AddTaskReward(FlatBufferBuilder builder, VectorOffset taskRewardOffset) { builder.AddOffset(3, taskRewardOffset.Value, 0); }
  public static VectorOffset CreateTaskRewardVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTaskRewardVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTaskRewardVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTaskRewardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTaskRewardVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTaskFunc(FlatBufferBuilder builder, VectorOffset taskFuncOffset) { builder.AddOffset(4, taskFuncOffset.Value, 0); }
  public static VectorOffset CreateTaskFuncVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTaskFuncVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTaskFuncVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTaskFuncVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTaskFuncVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnlockCondition(FlatBufferBuilder builder, int unlockCondition) { builder.AddInt(5, unlockCondition, 0); }
  public static void AddSortRank(FlatBufferBuilder builder, int sortRank) { builder.AddInt(6, sortRank, 0); }
  public static Offset<WWParser.Defs.LivenessTask> EndLivenessTask(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.LivenessTask>(o);
  }
  public LivenessTaskT UnPack() {
    var _o = new LivenessTaskT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LivenessTaskT _o) {
    _o.TaskId = this.TaskId;
    _o.TaskName = this.TaskName;
    _o.UpdateType = this.UpdateType;
    _o.TaskReward = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.TaskRewardLength; ++_j) {_o.TaskReward.Add(this.TaskReward(_j).HasValue ? this.TaskReward(_j).Value.UnPack() : null);}
    _o.TaskFunc = new List<string>();
    for (var _j = 0; _j < this.TaskFuncLength; ++_j) {_o.TaskFunc.Add(this.TaskFunc(_j));}
    _o.UnlockCondition = this.UnlockCondition;
    _o.SortRank = this.SortRank;
  }
  public static Offset<WWParser.Defs.LivenessTask> Pack(FlatBufferBuilder builder, LivenessTaskT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.LivenessTask>);
    var _task_name = _o.TaskName == null ? default(StringOffset) : builder.CreateString(_o.TaskName);
    var _task_reward = default(VectorOffset);
    if (_o.TaskReward != null) {
      var __task_reward = new Offset<WWParser.Defs.DicIntInt>[_o.TaskReward.Count];
      for (var _j = 0; _j < __task_reward.Length; ++_j) { __task_reward[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.TaskReward[_j]); }
      _task_reward = CreateTaskRewardVector(builder, __task_reward);
    }
    var _task_func = default(VectorOffset);
    if (_o.TaskFunc != null) {
      var __task_func = new StringOffset[_o.TaskFunc.Count];
      for (var _j = 0; _j < __task_func.Length; ++_j) { __task_func[_j] = builder.CreateString(_o.TaskFunc[_j]); }
      _task_func = CreateTaskFuncVector(builder, __task_func);
    }
    return CreateLivenessTask(
      builder,
      _o.TaskId,
      _task_name,
      _o.UpdateType,
      _task_reward,
      _task_func,
      _o.UnlockCondition,
      _o.SortRank);
  }
}

public class LivenessTaskT
{
  [Newtonsoft.Json.JsonProperty("task_id")]
  public int TaskId { get; set; }
  [Newtonsoft.Json.JsonProperty("task_name")]
  public string TaskName { get; set; }
  [Newtonsoft.Json.JsonProperty("update_type")]
  public int UpdateType { get; set; }
  [Newtonsoft.Json.JsonProperty("task_reward")]
  public List<WWParser.Defs.DicIntIntT> TaskReward { get; set; }
  [Newtonsoft.Json.JsonProperty("task_func")]
  public List<string> TaskFunc { get; set; }
  [Newtonsoft.Json.JsonProperty("unlock_condition")]
  public int UnlockCondition { get; set; }
  [Newtonsoft.Json.JsonProperty("sort_rank")]
  public int SortRank { get; set; }

  public LivenessTaskT() {
    this.TaskId = 0;
    this.TaskName = null;
    this.UpdateType = 0;
    this.TaskReward = null;
    this.TaskFunc = null;
    this.UnlockCondition = 0;
    this.SortRank = 0;
  }
}


static public class LivenessTaskVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TaskId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*TaskName*/, false)
      && verifier.VerifyField(tablePos, 8 /*UpdateType*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 10 /*TaskReward*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyVectorOfStrings(tablePos, 12 /*TaskFunc*/, false)
      && verifier.VerifyField(tablePos, 14 /*UnlockCondition*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*SortRank*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
