// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RogueResPopularEntrieArg : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RogueResPopularEntrieArg GetRootAsRogueResPopularEntrieArg(ByteBuffer _bb) { return GetRootAsRogueResPopularEntrieArg(_bb, new RogueResPopularEntrieArg()); }
  public static RogueResPopularEntrieArg GetRootAsRogueResPopularEntrieArg(ByteBuffer _bb, RogueResPopularEntrieArg obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RogueResPopularEntrieArg __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SeasonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InstId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Slot { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RogueResPopularEntrieArg> CreateRogueResPopularEntrieArg(FlatBufferBuilder builder,
      int id = 0,
      int season_id = 0,
      int inst_id = 0,
      int slot = 0) {
    builder.StartTable(4);
    RogueResPopularEntrieArg.AddSlot(builder, slot);
    RogueResPopularEntrieArg.AddInstId(builder, inst_id);
    RogueResPopularEntrieArg.AddSeasonId(builder, season_id);
    RogueResPopularEntrieArg.AddId(builder, id);
    return RogueResPopularEntrieArg.EndRogueResPopularEntrieArg(builder);
  }

  public static void StartRogueResPopularEntrieArg(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, int seasonId) { builder.AddInt(1, seasonId, 0); }
  public static void AddInstId(FlatBufferBuilder builder, int instId) { builder.AddInt(2, instId, 0); }
  public static void AddSlot(FlatBufferBuilder builder, int slot) { builder.AddInt(3, slot, 0); }
  public static Offset<WWParser.Defs.RogueResPopularEntrieArg> EndRogueResPopularEntrieArg(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RogueResPopularEntrieArg>(o);
  }
  public RogueResPopularEntrieArgT UnPack() {
    var _o = new RogueResPopularEntrieArgT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RogueResPopularEntrieArgT _o) {
    _o.Id = this.Id;
    _o.SeasonId = this.SeasonId;
    _o.InstId = this.InstId;
    _o.Slot = this.Slot;
  }
  public static Offset<WWParser.Defs.RogueResPopularEntrieArg> Pack(FlatBufferBuilder builder, RogueResPopularEntrieArgT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RogueResPopularEntrieArg>);
    return CreateRogueResPopularEntrieArg(
      builder,
      _o.Id,
      _o.SeasonId,
      _o.InstId,
      _o.Slot);
  }
}

public class RogueResPopularEntrieArgT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("season_id")]
  public int SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("inst_id")]
  public int InstId { get; set; }
  [Newtonsoft.Json.JsonProperty("slot")]
  public int Slot { get; set; }

  public RogueResPopularEntrieArgT() {
    this.Id = 0;
    this.SeasonId = 0;
    this.InstId = 0;
    this.Slot = 0;
  }
}


static public class RogueResPopularEntrieArgVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*InstId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Slot*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
