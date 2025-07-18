// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BlackCoastThemeTaskRe : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static BlackCoastThemeTaskRe GetRootAsBlackCoastThemeTaskRe(ByteBuffer _bb) { return GetRootAsBlackCoastThemeTaskRe(_bb, new BlackCoastThemeTaskRe()); }
  public static BlackCoastThemeTaskRe GetRootAsBlackCoastThemeTaskRe(ByteBuffer _bb, BlackCoastThemeTaskRe obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BlackCoastThemeTaskRe __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TaskId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StageId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string TaskName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTaskNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTaskNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTaskNameArray() { return __p.__vector_as_array<byte>(8); }
  public int SortId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DropId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int JumpId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.BlackCoastThemeTaskRe> CreateBlackCoastThemeTaskRe(FlatBufferBuilder builder,
      int task_id = 0,
      int stage_id = 0,
      StringOffset task_nameOffset = default(StringOffset),
      int sort_id = 0,
      int drop_id = 0,
      int jump_id = 0) {
    builder.StartTable(6);
    BlackCoastThemeTaskRe.AddJumpId(builder, jump_id);
    BlackCoastThemeTaskRe.AddDropId(builder, drop_id);
    BlackCoastThemeTaskRe.AddSortId(builder, sort_id);
    BlackCoastThemeTaskRe.AddTaskName(builder, task_nameOffset);
    BlackCoastThemeTaskRe.AddStageId(builder, stage_id);
    BlackCoastThemeTaskRe.AddTaskId(builder, task_id);
    return BlackCoastThemeTaskRe.EndBlackCoastThemeTaskRe(builder);
  }

  public static void StartBlackCoastThemeTaskRe(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddTaskId(FlatBufferBuilder builder, int taskId) { builder.AddInt(0, taskId, 0); }
  public static void AddStageId(FlatBufferBuilder builder, int stageId) { builder.AddInt(1, stageId, 0); }
  public static void AddTaskName(FlatBufferBuilder builder, StringOffset taskNameOffset) { builder.AddOffset(2, taskNameOffset.Value, 0); }
  public static void AddSortId(FlatBufferBuilder builder, int sortId) { builder.AddInt(3, sortId, 0); }
  public static void AddDropId(FlatBufferBuilder builder, int dropId) { builder.AddInt(4, dropId, 0); }
  public static void AddJumpId(FlatBufferBuilder builder, int jumpId) { builder.AddInt(5, jumpId, 0); }
  public static Offset<WWParser.Defs.BlackCoastThemeTaskRe> EndBlackCoastThemeTaskRe(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.BlackCoastThemeTaskRe>(o);
  }
  public BlackCoastThemeTaskReT UnPack() {
    var _o = new BlackCoastThemeTaskReT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BlackCoastThemeTaskReT _o) {
    _o.TaskId = this.TaskId;
    _o.StageId = this.StageId;
    _o.TaskName = this.TaskName;
    _o.SortId = this.SortId;
    _o.DropId = this.DropId;
    _o.JumpId = this.JumpId;
  }
  public static Offset<WWParser.Defs.BlackCoastThemeTaskRe> Pack(FlatBufferBuilder builder, BlackCoastThemeTaskReT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.BlackCoastThemeTaskRe>);
    var _task_name = _o.TaskName == null ? default(StringOffset) : builder.CreateString(_o.TaskName);
    return CreateBlackCoastThemeTaskRe(
      builder,
      _o.TaskId,
      _o.StageId,
      _task_name,
      _o.SortId,
      _o.DropId,
      _o.JumpId);
  }
}

public class BlackCoastThemeTaskReT
{
  [Newtonsoft.Json.JsonProperty("task_id")]
  public int TaskId { get; set; }
  [Newtonsoft.Json.JsonProperty("stage_id")]
  public int StageId { get; set; }
  [Newtonsoft.Json.JsonProperty("task_name")]
  public string TaskName { get; set; }
  [Newtonsoft.Json.JsonProperty("sort_id")]
  public int SortId { get; set; }
  [Newtonsoft.Json.JsonProperty("drop_id")]
  public int DropId { get; set; }
  [Newtonsoft.Json.JsonProperty("jump_id")]
  public int JumpId { get; set; }

  public BlackCoastThemeTaskReT() {
    this.TaskId = 0;
    this.StageId = 0;
    this.TaskName = null;
    this.SortId = 0;
    this.DropId = 0;
    this.JumpId = 0;
  }
}


static public class BlackCoastThemeTaskReVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TaskId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*StageId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*TaskName*/, false)
      && verifier.VerifyField(tablePos, 10 /*SortId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*DropId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*JumpId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
