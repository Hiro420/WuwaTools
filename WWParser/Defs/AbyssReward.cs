// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AbyssReward : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static AbyssReward GetRootAsAbyssReward(ByteBuffer _bb) { return GetRootAsAbyssReward(_bb, new AbyssReward()); }
  public static AbyssReward GetRootAsAbyssReward(ByteBuffer _bb, AbyssReward obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AbyssReward __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RewardType { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ConditionId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DropId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Title { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTitleBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTitleArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<WWParser.Defs.AbyssReward> CreateAbyssReward(FlatBufferBuilder builder,
      int id = 0,
      int reward_type = 0,
      int condition_id = 0,
      int drop_id = 0,
      StringOffset titleOffset = default(StringOffset)) {
    builder.StartTable(5);
    AbyssReward.AddTitle(builder, titleOffset);
    AbyssReward.AddDropId(builder, drop_id);
    AbyssReward.AddConditionId(builder, condition_id);
    AbyssReward.AddRewardType(builder, reward_type);
    AbyssReward.AddId(builder, id);
    return AbyssReward.EndAbyssReward(builder);
  }

  public static void StartAbyssReward(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddRewardType(FlatBufferBuilder builder, int rewardType) { builder.AddInt(1, rewardType, 0); }
  public static void AddConditionId(FlatBufferBuilder builder, int conditionId) { builder.AddInt(2, conditionId, 0); }
  public static void AddDropId(FlatBufferBuilder builder, int dropId) { builder.AddInt(3, dropId, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset) { builder.AddOffset(4, titleOffset.Value, 0); }
  public static Offset<WWParser.Defs.AbyssReward> EndAbyssReward(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.AbyssReward>(o);
  }
  public AbyssRewardT UnPack() {
    var _o = new AbyssRewardT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AbyssRewardT _o) {
    _o.Id = this.Id;
    _o.RewardType = this.RewardType;
    _o.ConditionId = this.ConditionId;
    _o.DropId = this.DropId;
    _o.Title = this.Title;
  }
  public static Offset<WWParser.Defs.AbyssReward> Pack(FlatBufferBuilder builder, AbyssRewardT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.AbyssReward>);
    var _title = _o.Title == null ? default(StringOffset) : builder.CreateString(_o.Title);
    return CreateAbyssReward(
      builder,
      _o.Id,
      _o.RewardType,
      _o.ConditionId,
      _o.DropId,
      _title);
  }
}

public class AbyssRewardT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("reward_type")]
  public int RewardType { get; set; }
  [Newtonsoft.Json.JsonProperty("condition_id")]
  public int ConditionId { get; set; }
  [Newtonsoft.Json.JsonProperty("drop_id")]
  public int DropId { get; set; }
  [Newtonsoft.Json.JsonProperty("title")]
  public string Title { get; set; }

  public AbyssRewardT() {
    this.Id = 0;
    this.RewardType = 0;
    this.ConditionId = 0;
    this.DropId = 0;
    this.Title = null;
  }
}


static public class AbyssRewardVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*RewardType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ConditionId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*DropId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*Title*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
