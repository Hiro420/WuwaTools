// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RogueResGrid : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static RogueResGrid GetRootAsRogueResGrid(ByteBuffer _bb) { return GetRootAsRogueResGrid(_bb, new RogueResGrid()); }
  public static RogueResGrid GetRootAsRogueResGrid(ByteBuffer _bb, RogueResGrid obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RogueResGrid __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.RogueResGrid> CreateRogueResGrid(FlatBufferBuilder builder,
      int id = 0) {
    builder.StartTable(1);
    RogueResGrid.AddId(builder, id);
    return RogueResGrid.EndRogueResGrid(builder);
  }

  public static void StartRogueResGrid(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static Offset<WWParser.Defs.RogueResGrid> EndRogueResGrid(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.RogueResGrid>(o);
  }
  public RogueResGridT UnPack() {
    var _o = new RogueResGridT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RogueResGridT _o) {
    _o.Id = this.Id;
  }
  public static Offset<WWParser.Defs.RogueResGrid> Pack(FlatBufferBuilder builder, RogueResGridT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.RogueResGrid>);
    return CreateRogueResGrid(
      builder,
      _o.Id);
  }
}

public class RogueResGridT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }

  public RogueResGridT() {
    this.Id = 0;
  }
}


static public class RogueResGridVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
