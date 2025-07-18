// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct OverlayMap : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static OverlayMap GetRootAsOverlayMap(ByteBuffer _bb) { return GetRootAsOverlayMap(_bb, new OverlayMap()); }
  public static OverlayMap GetRootAsOverlayMap(ByteBuffer _bb, OverlayMap obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public OverlayMap __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int OverlayMapId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MapId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GravityFlip { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)1; } }
  public string MapAddress { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMapAddressBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetMapAddressBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetMapAddressArray() { return __p.__vector_as_array<byte>(10); }
  public int MapPos(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MapPosLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMapPosBytes() { return __p.__vector_as_span<int>(12, 4); }
#else
  public ArraySegment<byte>? GetMapPosBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetMapPosArray() { return __p.__vector_as_array<int>(12); }
  public int Rotation { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WidthHeight(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int WidthHeightLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetWidthHeightBytes() { return __p.__vector_as_span<int>(16, 4); }
#else
  public ArraySegment<byte>? GetWidthHeightBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public int[] GetWidthHeightArray() { return __p.__vector_as_array<int>(16); }

  public static Offset<WWParser.Defs.OverlayMap> CreateOverlayMap(FlatBufferBuilder builder,
      int overlay_map_id = 0,
      int map_id = 0,
      int gravity_flip = 1,
      StringOffset map_addressOffset = default(StringOffset),
      VectorOffset map_posOffset = default(VectorOffset),
      int rotation = 0,
      VectorOffset width_heightOffset = default(VectorOffset)) {
    builder.StartTable(7);
    OverlayMap.AddWidthHeight(builder, width_heightOffset);
    OverlayMap.AddRotation(builder, rotation);
    OverlayMap.AddMapPos(builder, map_posOffset);
    OverlayMap.AddMapAddress(builder, map_addressOffset);
    OverlayMap.AddGravityFlip(builder, gravity_flip);
    OverlayMap.AddMapId(builder, map_id);
    OverlayMap.AddOverlayMapId(builder, overlay_map_id);
    return OverlayMap.EndOverlayMap(builder);
  }

  public static void StartOverlayMap(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddOverlayMapId(FlatBufferBuilder builder, int overlayMapId) { builder.AddInt(0, overlayMapId, 0); }
  public static void AddMapId(FlatBufferBuilder builder, int mapId) { builder.AddInt(1, mapId, 0); }
  public static void AddGravityFlip(FlatBufferBuilder builder, int gravityFlip) { builder.AddInt(2, gravityFlip, 1); }
  public static void AddMapAddress(FlatBufferBuilder builder, StringOffset mapAddressOffset) { builder.AddOffset(3, mapAddressOffset.Value, 0); }
  public static void AddMapPos(FlatBufferBuilder builder, VectorOffset mapPosOffset) { builder.AddOffset(4, mapPosOffset.Value, 0); }
  public static VectorOffset CreateMapPosVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMapPosVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMapPosVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMapPosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMapPosVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRotation(FlatBufferBuilder builder, int rotation) { builder.AddInt(5, rotation, 0); }
  public static void AddWidthHeight(FlatBufferBuilder builder, VectorOffset widthHeightOffset) { builder.AddOffset(6, widthHeightOffset.Value, 0); }
  public static VectorOffset CreateWidthHeightVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateWidthHeightVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWidthHeightVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWidthHeightVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartWidthHeightVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.OverlayMap> EndOverlayMap(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.OverlayMap>(o);
  }
  public OverlayMapT UnPack() {
    var _o = new OverlayMapT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(OverlayMapT _o) {
    _o.OverlayMapId = this.OverlayMapId;
    _o.MapId = this.MapId;
    _o.GravityFlip = this.GravityFlip;
    _o.MapAddress = this.MapAddress;
    _o.MapPos = new List<int>();
    for (var _j = 0; _j < this.MapPosLength; ++_j) {_o.MapPos.Add(this.MapPos(_j));}
    _o.Rotation = this.Rotation;
    _o.WidthHeight = new List<int>();
    for (var _j = 0; _j < this.WidthHeightLength; ++_j) {_o.WidthHeight.Add(this.WidthHeight(_j));}
  }
  public static Offset<WWParser.Defs.OverlayMap> Pack(FlatBufferBuilder builder, OverlayMapT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.OverlayMap>);
    var _map_address = _o.MapAddress == null ? default(StringOffset) : builder.CreateString(_o.MapAddress);
    var _map_pos = default(VectorOffset);
    if (_o.MapPos != null) {
      var __map_pos = _o.MapPos.ToArray();
      _map_pos = CreateMapPosVector(builder, __map_pos);
    }
    var _width_height = default(VectorOffset);
    if (_o.WidthHeight != null) {
      var __width_height = _o.WidthHeight.ToArray();
      _width_height = CreateWidthHeightVector(builder, __width_height);
    }
    return CreateOverlayMap(
      builder,
      _o.OverlayMapId,
      _o.MapId,
      _o.GravityFlip,
      _map_address,
      _map_pos,
      _o.Rotation,
      _width_height);
  }
}

public class OverlayMapT
{
  [Newtonsoft.Json.JsonProperty("overlay_map_id")]
  public int OverlayMapId { get; set; }
  [Newtonsoft.Json.JsonProperty("map_id")]
  public int MapId { get; set; }
  [Newtonsoft.Json.JsonProperty("gravity_flip")]
  public int GravityFlip { get; set; }
  [Newtonsoft.Json.JsonProperty("map_address")]
  public string MapAddress { get; set; }
  [Newtonsoft.Json.JsonProperty("map_pos")]
  public List<int> MapPos { get; set; }
  [Newtonsoft.Json.JsonProperty("rotation")]
  public int Rotation { get; set; }
  [Newtonsoft.Json.JsonProperty("width_height")]
  public List<int> WidthHeight { get; set; }

  public OverlayMapT() {
    this.OverlayMapId = 0;
    this.MapId = 0;
    this.GravityFlip = 1;
    this.MapAddress = null;
    this.MapPos = null;
    this.Rotation = 0;
    this.WidthHeight = null;
  }
}


static public class OverlayMapVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*OverlayMapId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MapId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*GravityFlip*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*MapAddress*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*MapPos*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 14 /*Rotation*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*WidthHeight*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
