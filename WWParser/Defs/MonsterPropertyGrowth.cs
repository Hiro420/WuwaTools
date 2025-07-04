// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MonsterPropertyGrowth : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static MonsterPropertyGrowth GetRootAsMonsterPropertyGrowth(ByteBuffer _bb) { return GetRootAsMonsterPropertyGrowth(_bb, new MonsterPropertyGrowth()); }
  public static MonsterPropertyGrowth GetRootAsMonsterPropertyGrowth(ByteBuffer _bb, MonsterPropertyGrowth obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MonsterPropertyGrowth __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CurveId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LifeMaxRatio { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AtkRatio { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DefRatio { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int HardnessMaxRatio { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int HardnessRatio { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int HardnessRecoverRatio { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RageMaxRatio { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RageRatio { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RageRecoverRatio { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.MonsterPropertyGrowth> CreateMonsterPropertyGrowth(FlatBufferBuilder builder,
      int id = 0,
      int curve_id = 0,
      int level = 0,
      int life_max_ratio = 0,
      int atk_ratio = 0,
      int def_ratio = 0,
      int hardness_max_ratio = 0,
      int hardness_ratio = 0,
      int hardness_recover_ratio = 0,
      int rage_max_ratio = 0,
      int rage_ratio = 0,
      int rage_recover_ratio = 0) {
    builder.StartTable(12);
    MonsterPropertyGrowth.AddRageRecoverRatio(builder, rage_recover_ratio);
    MonsterPropertyGrowth.AddRageRatio(builder, rage_ratio);
    MonsterPropertyGrowth.AddRageMaxRatio(builder, rage_max_ratio);
    MonsterPropertyGrowth.AddHardnessRecoverRatio(builder, hardness_recover_ratio);
    MonsterPropertyGrowth.AddHardnessRatio(builder, hardness_ratio);
    MonsterPropertyGrowth.AddHardnessMaxRatio(builder, hardness_max_ratio);
    MonsterPropertyGrowth.AddDefRatio(builder, def_ratio);
    MonsterPropertyGrowth.AddAtkRatio(builder, atk_ratio);
    MonsterPropertyGrowth.AddLifeMaxRatio(builder, life_max_ratio);
    MonsterPropertyGrowth.AddLevel(builder, level);
    MonsterPropertyGrowth.AddCurveId(builder, curve_id);
    MonsterPropertyGrowth.AddId(builder, id);
    return MonsterPropertyGrowth.EndMonsterPropertyGrowth(builder);
  }

  public static void StartMonsterPropertyGrowth(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddCurveId(FlatBufferBuilder builder, int curveId) { builder.AddInt(1, curveId, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(2, level, 0); }
  public static void AddLifeMaxRatio(FlatBufferBuilder builder, int lifeMaxRatio) { builder.AddInt(3, lifeMaxRatio, 0); }
  public static void AddAtkRatio(FlatBufferBuilder builder, int atkRatio) { builder.AddInt(4, atkRatio, 0); }
  public static void AddDefRatio(FlatBufferBuilder builder, int defRatio) { builder.AddInt(5, defRatio, 0); }
  public static void AddHardnessMaxRatio(FlatBufferBuilder builder, int hardnessMaxRatio) { builder.AddInt(6, hardnessMaxRatio, 0); }
  public static void AddHardnessRatio(FlatBufferBuilder builder, int hardnessRatio) { builder.AddInt(7, hardnessRatio, 0); }
  public static void AddHardnessRecoverRatio(FlatBufferBuilder builder, int hardnessRecoverRatio) { builder.AddInt(8, hardnessRecoverRatio, 0); }
  public static void AddRageMaxRatio(FlatBufferBuilder builder, int rageMaxRatio) { builder.AddInt(9, rageMaxRatio, 0); }
  public static void AddRageRatio(FlatBufferBuilder builder, int rageRatio) { builder.AddInt(10, rageRatio, 0); }
  public static void AddRageRecoverRatio(FlatBufferBuilder builder, int rageRecoverRatio) { builder.AddInt(11, rageRecoverRatio, 0); }
  public static Offset<WWParser.Defs.MonsterPropertyGrowth> EndMonsterPropertyGrowth(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.MonsterPropertyGrowth>(o);
  }
  public MonsterPropertyGrowthT UnPack() {
    var _o = new MonsterPropertyGrowthT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MonsterPropertyGrowthT _o) {
    _o.Id = this.Id;
    _o.CurveId = this.CurveId;
    _o.Level = this.Level;
    _o.LifeMaxRatio = this.LifeMaxRatio;
    _o.AtkRatio = this.AtkRatio;
    _o.DefRatio = this.DefRatio;
    _o.HardnessMaxRatio = this.HardnessMaxRatio;
    _o.HardnessRatio = this.HardnessRatio;
    _o.HardnessRecoverRatio = this.HardnessRecoverRatio;
    _o.RageMaxRatio = this.RageMaxRatio;
    _o.RageRatio = this.RageRatio;
    _o.RageRecoverRatio = this.RageRecoverRatio;
  }
  public static Offset<WWParser.Defs.MonsterPropertyGrowth> Pack(FlatBufferBuilder builder, MonsterPropertyGrowthT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.MonsterPropertyGrowth>);
    return CreateMonsterPropertyGrowth(
      builder,
      _o.Id,
      _o.CurveId,
      _o.Level,
      _o.LifeMaxRatio,
      _o.AtkRatio,
      _o.DefRatio,
      _o.HardnessMaxRatio,
      _o.HardnessRatio,
      _o.HardnessRecoverRatio,
      _o.RageMaxRatio,
      _o.RageRatio,
      _o.RageRecoverRatio);
  }
}

public class MonsterPropertyGrowthT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("curve_id")]
  public int CurveId { get; set; }
  [Newtonsoft.Json.JsonProperty("level")]
  public int Level { get; set; }
  [Newtonsoft.Json.JsonProperty("life_max_ratio")]
  public int LifeMaxRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("atk_ratio")]
  public int AtkRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("def_ratio")]
  public int DefRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("hardness_max_ratio")]
  public int HardnessMaxRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("hardness_ratio")]
  public int HardnessRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("hardness_recover_ratio")]
  public int HardnessRecoverRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("rage_max_ratio")]
  public int RageMaxRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("rage_ratio")]
  public int RageRatio { get; set; }
  [Newtonsoft.Json.JsonProperty("rage_recover_ratio")]
  public int RageRecoverRatio { get; set; }

  public MonsterPropertyGrowthT() {
    this.Id = 0;
    this.CurveId = 0;
    this.Level = 0;
    this.LifeMaxRatio = 0;
    this.AtkRatio = 0;
    this.DefRatio = 0;
    this.HardnessMaxRatio = 0;
    this.HardnessRatio = 0;
    this.HardnessRecoverRatio = 0;
    this.RageMaxRatio = 0;
    this.RageRatio = 0;
    this.RageRecoverRatio = 0;
  }
}


static public class MonsterPropertyGrowthVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*CurveId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Level*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*LifeMaxRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*AtkRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*DefRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*HardnessMaxRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*HardnessRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*HardnessRecoverRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*RageMaxRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*RageRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*RageRecoverRatio*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
