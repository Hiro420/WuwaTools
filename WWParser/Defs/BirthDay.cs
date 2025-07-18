// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BirthDay : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static BirthDay GetRootAsBirthDay(ByteBuffer _bb) { return GetRootAsBirthDay(_bb, new BirthDay()); }
  public static BirthDay GetRootAsBirthDay(ByteBuffer _bb, BirthDay obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BirthDay __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LimitYear { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BirthDayCardItemId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BirthDayReward { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ValidDay { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.BirthDay> CreateBirthDay(FlatBufferBuilder builder,
      int id = 0,
      int limit_year = 0,
      int birth_day_card_item_id = 0,
      int birth_day_reward = 0,
      int valid_day = 0) {
    builder.StartTable(5);
    BirthDay.AddValidDay(builder, valid_day);
    BirthDay.AddBirthDayReward(builder, birth_day_reward);
    BirthDay.AddBirthDayCardItemId(builder, birth_day_card_item_id);
    BirthDay.AddLimitYear(builder, limit_year);
    BirthDay.AddId(builder, id);
    return BirthDay.EndBirthDay(builder);
  }

  public static void StartBirthDay(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddLimitYear(FlatBufferBuilder builder, int limitYear) { builder.AddInt(1, limitYear, 0); }
  public static void AddBirthDayCardItemId(FlatBufferBuilder builder, int birthDayCardItemId) { builder.AddInt(2, birthDayCardItemId, 0); }
  public static void AddBirthDayReward(FlatBufferBuilder builder, int birthDayReward) { builder.AddInt(3, birthDayReward, 0); }
  public static void AddValidDay(FlatBufferBuilder builder, int validDay) { builder.AddInt(4, validDay, 0); }
  public static Offset<WWParser.Defs.BirthDay> EndBirthDay(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.BirthDay>(o);
  }
  public BirthDayT UnPack() {
    var _o = new BirthDayT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BirthDayT _o) {
    _o.Id = this.Id;
    _o.LimitYear = this.LimitYear;
    _o.BirthDayCardItemId = this.BirthDayCardItemId;
    _o.BirthDayReward = this.BirthDayReward;
    _o.ValidDay = this.ValidDay;
  }
  public static Offset<WWParser.Defs.BirthDay> Pack(FlatBufferBuilder builder, BirthDayT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.BirthDay>);
    return CreateBirthDay(
      builder,
      _o.Id,
      _o.LimitYear,
      _o.BirthDayCardItemId,
      _o.BirthDayReward,
      _o.ValidDay);
  }
}

public class BirthDayT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("limit_year")]
  public int LimitYear { get; set; }
  [Newtonsoft.Json.JsonProperty("birth_day_card_item_id")]
  public int BirthDayCardItemId { get; set; }
  [Newtonsoft.Json.JsonProperty("birth_day_reward")]
  public int BirthDayReward { get; set; }
  [Newtonsoft.Json.JsonProperty("valid_day")]
  public int ValidDay { get; set; }

  public BirthDayT() {
    this.Id = 0;
    this.LimitYear = 0;
    this.BirthDayCardItemId = 0;
    this.BirthDayReward = 0;
    this.ValidDay = 0;
  }
}


static public class BirthDayVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*LimitYear*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*BirthDayCardItemId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*BirthDayReward*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ValidDay*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
