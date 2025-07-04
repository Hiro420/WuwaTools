// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ExploreActivityTask : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ExploreActivityTask GetRootAsExploreActivityTask(ByteBuffer _bb) { return GetRootAsExploreActivityTask(_bb, new ExploreActivityTask()); }
  public static ExploreActivityTask GetRootAsExploreActivityTask(ByteBuffer _bb, ExploreActivityTask obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ExploreActivityTask __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TaskId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ActivityId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DropId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Desc { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.ExploreActivityTask> CreateExploreActivityTask(FlatBufferBuilder builder,
      int task_id = 0,
      int activity_id = 0,
      int drop_id = 0,
      StringOffset descOffset = default(StringOffset)) {
    builder.StartTable(4);
    ExploreActivityTask.AddDesc(builder, descOffset);
    ExploreActivityTask.AddDropId(builder, drop_id);
    ExploreActivityTask.AddActivityId(builder, activity_id);
    ExploreActivityTask.AddTaskId(builder, task_id);
    return ExploreActivityTask.EndExploreActivityTask(builder);
  }

  public static void StartExploreActivityTask(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddTaskId(FlatBufferBuilder builder, int taskId) { builder.AddInt(0, taskId, 0); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(1, activityId, 0); }
  public static void AddDropId(FlatBufferBuilder builder, int dropId) { builder.AddInt(2, dropId, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset) { builder.AddOffset(3, descOffset.Value, 0); }
  public static Offset<WWParser.Defs.ExploreActivityTask> EndExploreActivityTask(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ExploreActivityTask>(o);
  }
  public ExploreActivityTaskT UnPack() {
    var _o = new ExploreActivityTaskT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ExploreActivityTaskT _o) {
    _o.TaskId = this.TaskId;
    _o.ActivityId = this.ActivityId;
    _o.DropId = this.DropId;
    _o.Desc = this.Desc;
  }
  public static Offset<WWParser.Defs.ExploreActivityTask> Pack(FlatBufferBuilder builder, ExploreActivityTaskT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ExploreActivityTask>);
    var _desc = _o.Desc == null ? default(StringOffset) : builder.CreateString(_o.Desc);
    return CreateExploreActivityTask(
      builder,
      _o.TaskId,
      _o.ActivityId,
      _o.DropId,
      _desc);
  }
}

public class ExploreActivityTaskT
{
  [Newtonsoft.Json.JsonProperty("task_id")]
  public int TaskId { get; set; }
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("drop_id")]
  public int DropId { get; set; }
  [Newtonsoft.Json.JsonProperty("desc")]
  public string Desc { get; set; }

  public ExploreActivityTaskT() {
    this.TaskId = 0;
    this.ActivityId = 0;
    this.DropId = 0;
    this.Desc = null;
  }
}


static public class ExploreActivityTaskVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TaskId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*DropId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*Desc*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
