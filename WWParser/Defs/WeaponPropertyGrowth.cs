// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WeaponPropertyGrowth : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static WeaponPropertyGrowth GetRootAsWeaponPropertyGrowth(ByteBuffer _bb) { return GetRootAsWeaponPropertyGrowth(_bb, new WeaponPropertyGrowth()); }
  public static WeaponPropertyGrowth GetRootAsWeaponPropertyGrowth(ByteBuffer _bb, WeaponPropertyGrowth obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WeaponPropertyGrowth __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CurveId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BreachLevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CurveValue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.WeaponPropertyGrowth> CreateWeaponPropertyGrowth(FlatBufferBuilder builder,
      int id = 0,
      int curve_id = 0,
      int level = 0,
      int breach_level = 0,
      int curve_value = 0) {
    builder.StartTable(5);
    WeaponPropertyGrowth.AddCurveValue(builder, curve_value);
    WeaponPropertyGrowth.AddBreachLevel(builder, breach_level);
    WeaponPropertyGrowth.AddLevel(builder, level);
    WeaponPropertyGrowth.AddCurveId(builder, curve_id);
    WeaponPropertyGrowth.AddId(builder, id);
    return WeaponPropertyGrowth.EndWeaponPropertyGrowth(builder);
  }

  public static void StartWeaponPropertyGrowth(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddCurveId(FlatBufferBuilder builder, int curveId) { builder.AddInt(1, curveId, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(2, level, 0); }
  public static void AddBreachLevel(FlatBufferBuilder builder, int breachLevel) { builder.AddInt(3, breachLevel, 0); }
  public static void AddCurveValue(FlatBufferBuilder builder, int curveValue) { builder.AddInt(4, curveValue, 0); }
  public static Offset<WWParser.Defs.WeaponPropertyGrowth> EndWeaponPropertyGrowth(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.WeaponPropertyGrowth>(o);
  }
  public WeaponPropertyGrowthT UnPack() {
    var _o = new WeaponPropertyGrowthT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(WeaponPropertyGrowthT _o) {
    _o.Id = this.Id;
    _o.CurveId = this.CurveId;
    _o.Level = this.Level;
    _o.BreachLevel = this.BreachLevel;
    _o.CurveValue = this.CurveValue;
  }
  public static Offset<WWParser.Defs.WeaponPropertyGrowth> Pack(FlatBufferBuilder builder, WeaponPropertyGrowthT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.WeaponPropertyGrowth>);
    return CreateWeaponPropertyGrowth(
      builder,
      _o.Id,
      _o.CurveId,
      _o.Level,
      _o.BreachLevel,
      _o.CurveValue);
  }
}

public class WeaponPropertyGrowthT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("curve_id")]
  public int CurveId { get; set; }
  [Newtonsoft.Json.JsonProperty("level")]
  public int Level { get; set; }
  [Newtonsoft.Json.JsonProperty("breach_level")]
  public int BreachLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("curve_value")]
  public int CurveValue { get; set; }

  public WeaponPropertyGrowthT() {
    this.Id = 0;
    this.CurveId = 0;
    this.Level = 0;
    this.BreachLevel = 0;
    this.CurveValue = 0;
  }
}


static public class WeaponPropertyGrowthVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*CurveId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Level*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*BreachLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*CurveValue*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
