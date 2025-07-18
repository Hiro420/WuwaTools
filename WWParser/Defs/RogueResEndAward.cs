// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RogueResEndAward : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RogueResEndAward GetRootAsRogueResEndAward(ByteBuffer _bb) { return GetRootAsRogueResEndAward(_bb, new RogueResEndAward()); }
  public static RogueResEndAward GetRootAsRogueResEndAward(ByteBuffer _bb, RogueResEndAward obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RogueResEndAward __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Index { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SeasonId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Desc { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(10); }
  public int Award { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RogueResEndAward> CreateRogueResEndAward(FlatBufferBuilder builder,
      int id = 0,
      int index = 0,
      int season_id = 0,
      StringOffset descOffset = default(StringOffset),
      int award = 0) {
    builder.StartTable(5);
    RogueResEndAward.AddAward(builder, award);
    RogueResEndAward.AddDesc(builder, descOffset);
    RogueResEndAward.AddSeasonId(builder, season_id);
    RogueResEndAward.AddIndex(builder, index);
    RogueResEndAward.AddId(builder, id);
    return RogueResEndAward.EndRogueResEndAward(builder);
  }

  public static void StartRogueResEndAward(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddIndex(FlatBufferBuilder builder, int index) { builder.AddInt(1, index, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, int seasonId) { builder.AddInt(2, seasonId, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset) { builder.AddOffset(3, descOffset.Value, 0); }
  public static void AddAward(FlatBufferBuilder builder, int award) { builder.AddInt(4, award, 0); }
  public static Offset<WWParser.Defs.RogueResEndAward> EndRogueResEndAward(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RogueResEndAward>(o);
  }
  public RogueResEndAwardT UnPack() {
    var _o = new RogueResEndAwardT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RogueResEndAwardT _o) {
    _o.Id = this.Id;
    _o.Index = this.Index;
    _o.SeasonId = this.SeasonId;
    _o.Desc = this.Desc;
    _o.Award = this.Award;
  }
  public static Offset<WWParser.Defs.RogueResEndAward> Pack(FlatBufferBuilder builder, RogueResEndAwardT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RogueResEndAward>);
    var _desc = _o.Desc == null ? default(StringOffset) : builder.CreateString(_o.Desc);
    return CreateRogueResEndAward(
      builder,
      _o.Id,
      _o.Index,
      _o.SeasonId,
      _desc,
      _o.Award);
  }
}

public class RogueResEndAwardT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("index")]
  public int Index { get; set; }
  [Newtonsoft.Json.JsonProperty("season_id")]
  public int SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("desc")]
  public string Desc { get; set; }
  [Newtonsoft.Json.JsonProperty("award")]
  public int Award { get; set; }

  public RogueResEndAwardT() {
    this.Id = 0;
    this.Index = 0;
    this.SeasonId = 0;
    this.Desc = null;
    this.Award = 0;
  }
}


static public class RogueResEndAwardVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Index*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*SeasonId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*Desc*/, false)
      && verifier.VerifyField(tablePos, 12 /*Award*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
