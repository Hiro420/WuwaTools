// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PhantomWildItem : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static PhantomWildItem GetRootAsPhantomWildItem(ByteBuffer _bb) { return GetRootAsPhantomWildItem(_bb, new PhantomWildItem()); }
  public static PhantomWildItem GetRootAsPhantomWildItem(ByteBuffer _bb, PhantomWildItem obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PhantomWildItem __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ItemId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.PhantomWildItem> CreatePhantomWildItem(FlatBufferBuilder builder,
      int item_id = 0) {
    builder.StartTable(1);
    PhantomWildItem.AddItemId(builder, item_id);
    return PhantomWildItem.EndPhantomWildItem(builder);
  }

  public static void StartPhantomWildItem(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddItemId(FlatBufferBuilder builder, int itemId) { builder.AddInt(0, itemId, 0); }
  public static Offset<WWParser.Defs.PhantomWildItem> EndPhantomWildItem(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.PhantomWildItem>(o);
  }
  public PhantomWildItemT UnPack() {
    var _o = new PhantomWildItemT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PhantomWildItemT _o) {
    _o.ItemId = this.ItemId;
  }
  public static Offset<WWParser.Defs.PhantomWildItem> Pack(FlatBufferBuilder builder, PhantomWildItemT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.PhantomWildItem>);
    return CreatePhantomWildItem(
      builder,
      _o.ItemId);
  }
}

public class PhantomWildItemT
{
  [Newtonsoft.Json.JsonProperty("item_id")]
  public int ItemId { get; set; }

  public PhantomWildItemT() {
    this.ItemId = 0;
  }
}


static public class PhantomWildItemVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ItemId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
