// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LinkParam : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static LinkParam GetRootAsLinkParam(ByteBuffer _bb) { return GetRootAsLinkParam(_bb, new LinkParam()); }
  public static LinkParam GetRootAsLinkParam(ByteBuffer _bb, LinkParam obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LinkParam __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InstSubTypeList(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int InstSubTypeListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetInstSubTypeListBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetInstSubTypeListBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetInstSubTypeListArray() { return __p.__vector_as_array<int>(6); }

  public static Offset<WWParser.Defs.LinkParam> CreateLinkParam(FlatBufferBuilder builder,
      int id = 0,
      VectorOffset inst_sub_type_listOffset = default(VectorOffset)) {
    builder.StartTable(2);
    LinkParam.AddInstSubTypeList(builder, inst_sub_type_listOffset);
    LinkParam.AddId(builder, id);
    return LinkParam.EndLinkParam(builder);
  }

  public static void StartLinkParam(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddInstSubTypeList(FlatBufferBuilder builder, VectorOffset instSubTypeListOffset) { builder.AddOffset(1, instSubTypeListOffset.Value, 0); }
  public static VectorOffset CreateInstSubTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInstSubTypeListVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInstSubTypeListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInstSubTypeListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInstSubTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.LinkParam> EndLinkParam(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.LinkParam>(o);
  }
  public LinkParamT UnPack() {
    var _o = new LinkParamT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LinkParamT _o) {
    _o.Id = this.Id;
    _o.InstSubTypeList = new List<int>();
    for (var _j = 0; _j < this.InstSubTypeListLength; ++_j) {_o.InstSubTypeList.Add(this.InstSubTypeList(_j));}
  }
  public static Offset<WWParser.Defs.LinkParam> Pack(FlatBufferBuilder builder, LinkParamT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.LinkParam>);
    var _inst_sub_type_list = default(VectorOffset);
    if (_o.InstSubTypeList != null) {
      var __inst_sub_type_list = _o.InstSubTypeList.ToArray();
      _inst_sub_type_list = CreateInstSubTypeListVector(builder, __inst_sub_type_list);
    }
    return CreateLinkParam(
      builder,
      _o.Id,
      _inst_sub_type_list);
  }
}

public class LinkParamT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("inst_sub_type_list")]
  public List<int> InstSubTypeList { get; set; }

  public LinkParamT() {
    this.Id = 0;
    this.InstSubTypeList = null;
  }
}


static public class LinkParamVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*InstSubTypeList*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
