// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RogueRoomPool : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RogueRoomPool GetRootAsRogueRoomPool(ByteBuffer _bb) { return GetRootAsRogueRoomPool(_bb, new RogueRoomPool()); }
  public static RogueRoomPool GetRootAsRogueRoomPool(ByteBuffer _bb, RogueRoomPool obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RogueRoomPool __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BehaviorTree { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string RoomsMusicState { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRoomsMusicStateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetRoomsMusicStateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetRoomsMusicStateArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<WWParser.Defs.RogueRoomPool> CreateRogueRoomPool(FlatBufferBuilder builder,
      int id = 0,
      int behavior_tree = 0,
      StringOffset rooms_music_stateOffset = default(StringOffset)) {
    builder.StartTable(3);
    RogueRoomPool.AddRoomsMusicState(builder, rooms_music_stateOffset);
    RogueRoomPool.AddBehaviorTree(builder, behavior_tree);
    RogueRoomPool.AddId(builder, id);
    return RogueRoomPool.EndRogueRoomPool(builder);
  }

  public static void StartRogueRoomPool(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddBehaviorTree(FlatBufferBuilder builder, int behaviorTree) { builder.AddInt(1, behaviorTree, 0); }
  public static void AddRoomsMusicState(FlatBufferBuilder builder, StringOffset roomsMusicStateOffset) { builder.AddOffset(2, roomsMusicStateOffset.Value, 0); }
  public static Offset<WWParser.Defs.RogueRoomPool> EndRogueRoomPool(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RogueRoomPool>(o);
  }
  public RogueRoomPoolT UnPack() {
    var _o = new RogueRoomPoolT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RogueRoomPoolT _o) {
    _o.Id = this.Id;
    _o.BehaviorTree = this.BehaviorTree;
    _o.RoomsMusicState = this.RoomsMusicState;
  }
  public static Offset<WWParser.Defs.RogueRoomPool> Pack(FlatBufferBuilder builder, RogueRoomPoolT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RogueRoomPool>);
    var _rooms_music_state = _o.RoomsMusicState == null ? default(StringOffset) : builder.CreateString(_o.RoomsMusicState);
    return CreateRogueRoomPool(
      builder,
      _o.Id,
      _o.BehaviorTree,
      _rooms_music_state);
  }
}

public class RogueRoomPoolT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("behavior_tree")]
  public int BehaviorTree { get; set; }
  [Newtonsoft.Json.JsonProperty("rooms_music_state")]
  public string RoomsMusicState { get; set; }

  public RogueRoomPoolT() {
    this.Id = 0;
    this.BehaviorTree = 0;
    this.RoomsMusicState = null;
  }
}


static public class RogueRoomPoolVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*BehaviorTree*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*RoomsMusicState*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
