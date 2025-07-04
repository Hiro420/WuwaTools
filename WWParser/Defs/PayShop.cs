// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PayShop : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static PayShop GetRootAsPayShop(ByteBuffer _bb) { return GetRootAsPayShop(_bb, new PayShop()); }
  public static PayShop GetRootAsPayShop(ByteBuffer _bb, PayShop obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PayShop __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopTabViewType { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DynamicTabId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Sort { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(12); }
  public int Money(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MoneyLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMoneyBytes() { return __p.__vector_as_span<int>(14, 4); }
#else
  public ArraySegment<byte>? GetMoneyBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public int[] GetMoneyArray() { return __p.__vector_as_array<int>(14); }
  public string Notice { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNoticeBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetNoticeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetNoticeArray() { return __p.__vector_as_array<byte>(16); }
  public bool Enable { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Icon { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(20); }
  public int SortRule { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.PayShop> CreatePayShop(FlatBufferBuilder builder,
      int id = 0,
      int shop_tab_view_type = 0,
      int dynamic_tab_id = 0,
      int sort = 0,
      StringOffset nameOffset = default(StringOffset),
      VectorOffset moneyOffset = default(VectorOffset),
      StringOffset noticeOffset = default(StringOffset),
      bool enable = false,
      StringOffset iconOffset = default(StringOffset),
      int sort_rule = 0) {
    builder.StartTable(10);
    PayShop.AddSortRule(builder, sort_rule);
    PayShop.AddIcon(builder, iconOffset);
    PayShop.AddNotice(builder, noticeOffset);
    PayShop.AddMoney(builder, moneyOffset);
    PayShop.AddName(builder, nameOffset);
    PayShop.AddSort(builder, sort);
    PayShop.AddDynamicTabId(builder, dynamic_tab_id);
    PayShop.AddShopTabViewType(builder, shop_tab_view_type);
    PayShop.AddId(builder, id);
    PayShop.AddEnable(builder, enable);
    return PayShop.EndPayShop(builder);
  }

  public static void StartPayShop(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddShopTabViewType(FlatBufferBuilder builder, int shopTabViewType) { builder.AddInt(1, shopTabViewType, 0); }
  public static void AddDynamicTabId(FlatBufferBuilder builder, int dynamicTabId) { builder.AddInt(2, dynamicTabId, 0); }
  public static void AddSort(FlatBufferBuilder builder, int sort) { builder.AddInt(3, sort, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(4, nameOffset.Value, 0); }
  public static void AddMoney(FlatBufferBuilder builder, VectorOffset moneyOffset) { builder.AddOffset(5, moneyOffset.Value, 0); }
  public static VectorOffset CreateMoneyVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMoneyVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMoneyVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMoneyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMoneyVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNotice(FlatBufferBuilder builder, StringOffset noticeOffset) { builder.AddOffset(6, noticeOffset.Value, 0); }
  public static void AddEnable(FlatBufferBuilder builder, bool enable) { builder.AddBool(7, enable, false); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(8, iconOffset.Value, 0); }
  public static void AddSortRule(FlatBufferBuilder builder, int sortRule) { builder.AddInt(9, sortRule, 0); }
  public static Offset<WWParser.Defs.PayShop> EndPayShop(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.PayShop>(o);
  }
  public PayShopT UnPack() {
    var _o = new PayShopT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PayShopT _o) {
    _o.Id = this.Id;
    _o.ShopTabViewType = this.ShopTabViewType;
    _o.DynamicTabId = this.DynamicTabId;
    _o.Sort = this.Sort;
    _o.Name = this.Name;
    _o.Money = new List<int>();
    for (var _j = 0; _j < this.MoneyLength; ++_j) {_o.Money.Add(this.Money(_j));}
    _o.Notice = this.Notice;
    _o.Enable = this.Enable;
    _o.Icon = this.Icon;
    _o.SortRule = this.SortRule;
  }
  public static Offset<WWParser.Defs.PayShop> Pack(FlatBufferBuilder builder, PayShopT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.PayShop>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _money = default(VectorOffset);
    if (_o.Money != null) {
      var __money = _o.Money.ToArray();
      _money = CreateMoneyVector(builder, __money);
    }
    var _notice = _o.Notice == null ? default(StringOffset) : builder.CreateString(_o.Notice);
    var _icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    return CreatePayShop(
      builder,
      _o.Id,
      _o.ShopTabViewType,
      _o.DynamicTabId,
      _o.Sort,
      _name,
      _money,
      _notice,
      _o.Enable,
      _icon,
      _o.SortRule);
  }
}

public class PayShopT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("shop_tab_view_type")]
  public int ShopTabViewType { get; set; }
  [Newtonsoft.Json.JsonProperty("dynamic_tab_id")]
  public int DynamicTabId { get; set; }
  [Newtonsoft.Json.JsonProperty("sort")]
  public int Sort { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("money")]
  public List<int> Money { get; set; }
  [Newtonsoft.Json.JsonProperty("notice")]
  public string Notice { get; set; }
  [Newtonsoft.Json.JsonProperty("enable")]
  public bool Enable { get; set; }
  [Newtonsoft.Json.JsonProperty("icon")]
  public string Icon { get; set; }
  [Newtonsoft.Json.JsonProperty("sort_rule")]
  public int SortRule { get; set; }

  public PayShopT() {
    this.Id = 0;
    this.ShopTabViewType = 0;
    this.DynamicTabId = 0;
    this.Sort = 0;
    this.Name = null;
    this.Money = null;
    this.Notice = null;
    this.Enable = false;
    this.Icon = null;
    this.SortRule = 0;
  }
}


static public class PayShopVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ShopTabViewType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*DynamicTabId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Sort*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*Name*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*Money*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 16 /*Notice*/, false)
      && verifier.VerifyField(tablePos, 18 /*Enable*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 20 /*Icon*/, false)
      && verifier.VerifyField(tablePos, 22 /*SortRule*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
