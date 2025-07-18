// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ServerLimit : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static ServerLimit GetRootAsServerLimit(ByteBuffer _bb) { return GetRootAsServerLimit(_bb, new ServerLimit()); }
  public static ServerLimit GetRootAsServerLimit(ByteBuffer _bb, ServerLimit obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ServerLimit __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Id { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetIdArray() { return __p.__vector_as_array<byte>(4); }
  public string CountryCodes { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCountryCodesBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetCountryCodesBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetCountryCodesArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<WWParser.Defs.ServerLimit> CreateServerLimit(FlatBufferBuilder builder,
      StringOffset idOffset = default(StringOffset),
      StringOffset country_codesOffset = default(StringOffset)) {
    builder.StartTable(2);
    ServerLimit.AddCountryCodes(builder, country_codesOffset);
    ServerLimit.AddId(builder, idOffset);
    return ServerLimit.EndServerLimit(builder);
  }

  public static void StartServerLimit(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, StringOffset idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  public static void AddCountryCodes(FlatBufferBuilder builder, StringOffset countryCodesOffset) { builder.AddOffset(1, countryCodesOffset.Value, 0); }
  public static Offset<WWParser.Defs.ServerLimit> EndServerLimit(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.ServerLimit>(o);
  }
  public ServerLimitT UnPack() {
    var _o = new ServerLimitT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ServerLimitT _o) {
    _o.Id = this.Id;
    _o.CountryCodes = this.CountryCodes;
  }
  public static Offset<WWParser.Defs.ServerLimit> Pack(FlatBufferBuilder builder, ServerLimitT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.ServerLimit>);
    var _id = _o.Id == null ? default(StringOffset) : builder.CreateString(_o.Id);
    var _country_codes = _o.CountryCodes == null ? default(StringOffset) : builder.CreateString(_o.CountryCodes);
    return CreateServerLimit(
      builder,
      _id,
      _country_codes);
  }
}

public class ServerLimitT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public string Id { get; set; }
  [Newtonsoft.Json.JsonProperty("country_codes")]
  public string CountryCodes { get; set; }

  public ServerLimitT() {
    this.Id = null;
    this.CountryCodes = null;
  }
}


static public class ServerLimitVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Id*/, false)
      && verifier.VerifyString(tablePos, 6 /*CountryCodes*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
