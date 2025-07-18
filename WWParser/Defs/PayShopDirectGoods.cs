// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PayShopDirectGoods : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static PayShopDirectGoods GetRootAsPayShopDirectGoods(ByteBuffer _bb) { return GetRootAsPayShopDirectGoods(_bb, new PayShopDirectGoods()); }
  public static PayShopDirectGoods GetRootAsPayShopDirectGoods(ByteBuffer _bb, PayShopDirectGoods obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PayShopDirectGoods __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int GoodsId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PayId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.PayShopDirectGoods> CreatePayShopDirectGoods(FlatBufferBuilder builder,
      int goods_id = 0,
      int pay_id = 0) {
    builder.StartTable(2);
    PayShopDirectGoods.AddPayId(builder, pay_id);
    PayShopDirectGoods.AddGoodsId(builder, goods_id);
    return PayShopDirectGoods.EndPayShopDirectGoods(builder);
  }

  public static void StartPayShopDirectGoods(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddGoodsId(FlatBufferBuilder builder, int goodsId) { builder.AddInt(0, goodsId, 0); }
  public static void AddPayId(FlatBufferBuilder builder, int payId) { builder.AddInt(1, payId, 0); }
  public static Offset<WWParser.Defs.PayShopDirectGoods> EndPayShopDirectGoods(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.PayShopDirectGoods>(o);
  }
  public PayShopDirectGoodsT UnPack() {
    var _o = new PayShopDirectGoodsT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PayShopDirectGoodsT _o) {
    _o.GoodsId = this.GoodsId;
    _o.PayId = this.PayId;
  }
  public static Offset<WWParser.Defs.PayShopDirectGoods> Pack(FlatBufferBuilder builder, PayShopDirectGoodsT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.PayShopDirectGoods>);
    return CreatePayShopDirectGoods(
      builder,
      _o.GoodsId,
      _o.PayId);
  }
}

public class PayShopDirectGoodsT
{
  [Newtonsoft.Json.JsonProperty("goods_id")]
  public int GoodsId { get; set; }
  [Newtonsoft.Json.JsonProperty("pay_id")]
  public int PayId { get; set; }

  public PayShopDirectGoodsT() {
    this.GoodsId = 0;
    this.PayId = 0;
  }
}


static public class PayShopDirectGoodsVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*GoodsId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*PayId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
