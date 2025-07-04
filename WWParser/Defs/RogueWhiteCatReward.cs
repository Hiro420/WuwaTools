// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RogueWhiteCatReward : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RogueWhiteCatReward GetRootAsRogueWhiteCatReward(ByteBuffer _bb) { return GetRootAsRogueWhiteCatReward(_bb, new RogueWhiteCatReward()); }
  public static RogueWhiteCatReward GetRootAsRogueWhiteCatReward(ByteBuffer _bb, RogueWhiteCatReward obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RogueWhiteCatReward __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NeedEnergy { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ConditionGroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DropId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RogueWhiteCatReward> CreateRogueWhiteCatReward(FlatBufferBuilder builder,
      int id = 0,
      int need_energy = 0,
      int condition_group_id = 0,
      int drop_id = 0) {
    builder.StartTable(4);
    RogueWhiteCatReward.AddDropId(builder, drop_id);
    RogueWhiteCatReward.AddConditionGroupId(builder, condition_group_id);
    RogueWhiteCatReward.AddNeedEnergy(builder, need_energy);
    RogueWhiteCatReward.AddId(builder, id);
    return RogueWhiteCatReward.EndRogueWhiteCatReward(builder);
  }

  public static void StartRogueWhiteCatReward(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddNeedEnergy(FlatBufferBuilder builder, int needEnergy) { builder.AddInt(1, needEnergy, 0); }
  public static void AddConditionGroupId(FlatBufferBuilder builder, int conditionGroupId) { builder.AddInt(2, conditionGroupId, 0); }
  public static void AddDropId(FlatBufferBuilder builder, int dropId) { builder.AddInt(3, dropId, 0); }
  public static Offset<WWParser.Defs.RogueWhiteCatReward> EndRogueWhiteCatReward(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RogueWhiteCatReward>(o);
  }
  public RogueWhiteCatRewardT UnPack() {
    var _o = new RogueWhiteCatRewardT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RogueWhiteCatRewardT _o) {
    _o.Id = this.Id;
    _o.NeedEnergy = this.NeedEnergy;
    _o.ConditionGroupId = this.ConditionGroupId;
    _o.DropId = this.DropId;
  }
  public static Offset<WWParser.Defs.RogueWhiteCatReward> Pack(FlatBufferBuilder builder, RogueWhiteCatRewardT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RogueWhiteCatReward>);
    return CreateRogueWhiteCatReward(
      builder,
      _o.Id,
      _o.NeedEnergy,
      _o.ConditionGroupId,
      _o.DropId);
  }
}

public class RogueWhiteCatRewardT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("need_energy")]
  public int NeedEnergy { get; set; }
  [Newtonsoft.Json.JsonProperty("condition_group_id")]
  public int ConditionGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("drop_id")]
  public int DropId { get; set; }

  public RogueWhiteCatRewardT() {
    this.Id = 0;
    this.NeedEnergy = 0;
    this.ConditionGroupId = 0;
    this.DropId = 0;
  }
}


static public class RogueWhiteCatRewardVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*NeedEnergy*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ConditionGroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*DropId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
