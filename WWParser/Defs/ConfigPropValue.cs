// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConfigPropValue : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ConfigPropValue GetRootAsConfigPropValue(ByteBuffer _bb) { return GetRootAsConfigPropValue(_bb, new ConfigPropValue()); }
  public static ConfigPropValue GetRootAsConfigPropValue(ByteBuffer _bb, ConfigPropValue obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConfigPropValue __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool IsRatio { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<WWParser.Defs.ConfigPropValue> CreateConfigPropValue(FlatBufferBuilder builder,
      int id = 0,
      float value = 0.0f,
      bool is_ratio = false) {
    builder.StartTable(3);
    ConfigPropValue.AddValue(builder, value);
    ConfigPropValue.AddId(builder, id);
    ConfigPropValue.AddIsRatio(builder, is_ratio);
    return ConfigPropValue.EndConfigPropValue(builder);
  }

  public static void StartConfigPropValue(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddValue(FlatBufferBuilder builder, float value) { builder.AddFloat(1, value, 0.0f); }
  public static void AddIsRatio(FlatBufferBuilder builder, bool isRatio) { builder.AddBool(2, isRatio, false); }
  public static Offset<WWParser.Defs.ConfigPropValue> EndConfigPropValue(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ConfigPropValue>(o);
  }
  public ConfigPropValueT UnPack() {
    var _o = new ConfigPropValueT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConfigPropValueT _o) {
    _o.Id = this.Id;
    _o.Value = this.Value;
    _o.IsRatio = this.IsRatio;
  }
  public static Offset<WWParser.Defs.ConfigPropValue> Pack(FlatBufferBuilder builder, ConfigPropValueT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ConfigPropValue>);
    return CreateConfigPropValue(
      builder,
      _o.Id,
      _o.Value,
      _o.IsRatio);
  }
}

public class ConfigPropValueT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("value")]
  public float Value { get; set; }
  [Newtonsoft.Json.JsonProperty("is_ratio")]
  public bool IsRatio { get; set; }

  public ConfigPropValueT() {
    this.Id = 0;
    this.Value = 0.0f;
    this.IsRatio = false;
  }
}


static public class ConfigPropValueVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Value*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*IsRatio*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
