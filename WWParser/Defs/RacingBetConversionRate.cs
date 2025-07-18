// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RacingBetConversionRate : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RacingBetConversionRate GetRootAsRacingBetConversionRate(ByteBuffer _bb) { return GetRootAsRacingBetConversionRate(_bb, new RacingBetConversionRate()); }
  public static RacingBetConversionRate GetRootAsRacingBetConversionRate(ByteBuffer _bb, RacingBetConversionRate obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RacingBetConversionRate __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SeasonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Rank { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ConversionRate { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RacingBetConversionRate> CreateRacingBetConversionRate(FlatBufferBuilder builder,
      int id = 0,
      int season_id = 0,
      int rank = 0,
      int conversion_rate = 0) {
    builder.StartTable(4);
    RacingBetConversionRate.AddConversionRate(builder, conversion_rate);
    RacingBetConversionRate.AddRank(builder, rank);
    RacingBetConversionRate.AddSeasonId(builder, season_id);
    RacingBetConversionRate.AddId(builder, id);
    return RacingBetConversionRate.EndRacingBetConversionRate(builder);
  }

  public static void StartRacingBetConversionRate(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, int seasonId) { builder.AddInt(1, seasonId, 0); }
  public static void AddRank(FlatBufferBuilder builder, int rank) { builder.AddInt(2, rank, 0); }
  public static void AddConversionRate(FlatBufferBuilder builder, int conversionRate) { builder.AddInt(3, conversionRate, 0); }
  public static Offset<WWParser.Defs.RacingBetConversionRate> EndRacingBetConversionRate(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RacingBetConversionRate>(o);
  }
  public RacingBetConversionRateT UnPack() {
    var _o = new RacingBetConversionRateT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RacingBetConversionRateT _o) {
    _o.Id = this.Id;
    _o.SeasonId = this.SeasonId;
    _o.Rank = this.Rank;
    _o.ConversionRate = this.ConversionRate;
  }
  public static Offset<WWParser.Defs.RacingBetConversionRate> Pack(FlatBufferBuilder builder, RacingBetConversionRateT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RacingBetConversionRate>);
    return CreateRacingBetConversionRate(
      builder,
      _o.Id,
      _o.SeasonId,
      _o.Rank,
      _o.ConversionRate);
  }
}

public class RacingBetConversionRateT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("season_id")]
  public int SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("rank")]
  public int Rank { get; set; }
  [Newtonsoft.Json.JsonProperty("conversion_rate")]
  public int ConversionRate { get; set; }

  public RacingBetConversionRateT() {
    this.Id = 0;
    this.SeasonId = 0;
    this.Rank = 0;
    this.ConversionRate = 0;
  }
}


static public class RacingBetConversionRateVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Rank*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ConversionRate*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
