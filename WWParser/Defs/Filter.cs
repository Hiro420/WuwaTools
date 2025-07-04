// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Filter : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static Filter GetRootAsFilter(ByteBuffer _bb) { return GetRootAsFilter(_bb, new Filter()); }
  public static Filter GetRootAsFilter(ByteBuffer _bb, Filter obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Filter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DataType { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RuleList(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RuleListLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRuleListBytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetRuleListBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetRuleListArray() { return __p.__vector_as_array<int>(8); }
  public bool IsSupportSelectAll { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsShowIcon { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string GridType { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGridTypeBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetGridTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetGridTypeArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<WWParser.Defs.Filter> CreateFilter(FlatBufferBuilder builder,
      int id = 0,
      int data_type = 0,
      VectorOffset rule_listOffset = default(VectorOffset),
      bool is_support_select_all = false,
      bool is_show_icon = false,
      StringOffset grid_typeOffset = default(StringOffset)) {
    builder.StartTable(6);
    Filter.AddGridType(builder, grid_typeOffset);
    Filter.AddRuleList(builder, rule_listOffset);
    Filter.AddDataType(builder, data_type);
    Filter.AddId(builder, id);
    Filter.AddIsShowIcon(builder, is_show_icon);
    Filter.AddIsSupportSelectAll(builder, is_support_select_all);
    return Filter.EndFilter(builder);
  }

  public static void StartFilter(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddDataType(FlatBufferBuilder builder, int dataType) { builder.AddInt(1, dataType, 0); }
  public static void AddRuleList(FlatBufferBuilder builder, VectorOffset ruleListOffset) { builder.AddOffset(2, ruleListOffset.Value, 0); }
  public static VectorOffset CreateRuleListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRuleListVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRuleListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRuleListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRuleListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsSupportSelectAll(FlatBufferBuilder builder, bool isSupportSelectAll) { builder.AddBool(3, isSupportSelectAll, false); }
  public static void AddIsShowIcon(FlatBufferBuilder builder, bool isShowIcon) { builder.AddBool(4, isShowIcon, false); }
  public static void AddGridType(FlatBufferBuilder builder, StringOffset gridTypeOffset) { builder.AddOffset(5, gridTypeOffset.Value, 0); }
  public static Offset<WWParser.Defs.Filter> EndFilter(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.Filter>(o);
  }
  public FilterT UnPack() {
    var _o = new FilterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FilterT _o) {
    _o.Id = this.Id;
    _o.DataType = this.DataType;
    _o.RuleList = new List<int>();
    for (var _j = 0; _j < this.RuleListLength; ++_j) {_o.RuleList.Add(this.RuleList(_j));}
    _o.IsSupportSelectAll = this.IsSupportSelectAll;
    _o.IsShowIcon = this.IsShowIcon;
    _o.GridType = this.GridType;
  }
  public static Offset<WWParser.Defs.Filter> Pack(FlatBufferBuilder builder, FilterT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.Filter>);
    var _rule_list = default(VectorOffset);
    if (_o.RuleList != null) {
      var __rule_list = _o.RuleList.ToArray();
      _rule_list = CreateRuleListVector(builder, __rule_list);
    }
    var _grid_type = _o.GridType == null ? default(StringOffset) : builder.CreateString(_o.GridType);
    return CreateFilter(
      builder,
      _o.Id,
      _o.DataType,
      _rule_list,
      _o.IsSupportSelectAll,
      _o.IsShowIcon,
      _grid_type);
  }
}

public class FilterT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("data_type")]
  public int DataType { get; set; }
  [Newtonsoft.Json.JsonProperty("rule_list")]
  public List<int> RuleList { get; set; }
  [Newtonsoft.Json.JsonProperty("is_support_select_all")]
  public bool IsSupportSelectAll { get; set; }
  [Newtonsoft.Json.JsonProperty("is_show_icon")]
  public bool IsShowIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("grid_type")]
  public string GridType { get; set; }

  public FilterT() {
    this.Id = 0;
    this.DataType = 0;
    this.RuleList = null;
    this.IsSupportSelectAll = false;
    this.IsShowIcon = false;
    this.GridType = null;
  }
}


static public class FilterVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*DataType*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*RuleList*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 10 /*IsSupportSelectAll*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*IsShowIcon*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 14 /*GridType*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
