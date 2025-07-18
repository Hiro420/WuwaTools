// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AnimalHandBook : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static AnimalHandBook GetRootAsAnimalHandBook(ByteBuffer _bb) { return GetRootAsAnimalHandBook(_bb, new AnimalHandBook()); }
  public static AnimalHandBook GetRootAsAnimalHandBook(ByteBuffer _bb, AnimalHandBook obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AnimalHandBook __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MeshId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public float Scale(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ScaleLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetScaleBytes() { return __p.__vector_as_span<float>(10, 4); }
#else
  public ArraySegment<byte>? GetScaleBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public float[] GetScaleArray() { return __p.__vector_as_array<float>(10); }
  public float Position(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int PositionLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetPositionBytes() { return __p.__vector_as_span<float>(12, 4); }
#else
  public ArraySegment<byte>? GetPositionBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public float[] GetPositionArray() { return __p.__vector_as_array<float>(12); }
  public float Rotator(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int RotatorLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetRotatorBytes() { return __p.__vector_as_span<float>(14, 4); }
#else
  public ArraySegment<byte>? GetRotatorBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public float[] GetRotatorArray() { return __p.__vector_as_array<float>(14); }
  public string StandAnim { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStandAnimBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetStandAnimBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetStandAnimArray() { return __p.__vector_as_array<byte>(16); }
  public string Icon { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(18); }
  public string TypeDescrtption { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTypeDescrtptionBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetTypeDescrtptionBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetTypeDescrtptionArray() { return __p.__vector_as_array<byte>(20); }
  public string Place { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPlaceBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetPlaceBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetPlaceArray() { return __p.__vector_as_array<byte>(22); }
  public string Descrtption { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescrtptionBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetDescrtptionBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetDescrtptionArray() { return __p.__vector_as_array<byte>(24); }
  public int DropItemId(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DropItemIdLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetDropItemIdBytes() { return __p.__vector_as_span<int>(26, 4); }
#else
  public ArraySegment<byte>? GetDropItemIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public int[] GetDropItemIdArray() { return __p.__vector_as_array<int>(26); }

  public static Offset<WWParser.Defs.AnimalHandBook> CreateAnimalHandBook(FlatBufferBuilder builder,
      int id = 0,
      int mesh_id = 0,
      StringOffset nameOffset = default(StringOffset),
      VectorOffset scaleOffset = default(VectorOffset),
      VectorOffset positionOffset = default(VectorOffset),
      VectorOffset rotatorOffset = default(VectorOffset),
      StringOffset stand_animOffset = default(StringOffset),
      StringOffset iconOffset = default(StringOffset),
      StringOffset type_descrtptionOffset = default(StringOffset),
      StringOffset placeOffset = default(StringOffset),
      StringOffset descrtptionOffset = default(StringOffset),
      VectorOffset drop_item_idOffset = default(VectorOffset)) {
    builder.StartTable(12);
    AnimalHandBook.AddDropItemId(builder, drop_item_idOffset);
    AnimalHandBook.AddDescrtption(builder, descrtptionOffset);
    AnimalHandBook.AddPlace(builder, placeOffset);
    AnimalHandBook.AddTypeDescrtption(builder, type_descrtptionOffset);
    AnimalHandBook.AddIcon(builder, iconOffset);
    AnimalHandBook.AddStandAnim(builder, stand_animOffset);
    AnimalHandBook.AddRotator(builder, rotatorOffset);
    AnimalHandBook.AddPosition(builder, positionOffset);
    AnimalHandBook.AddScale(builder, scaleOffset);
    AnimalHandBook.AddName(builder, nameOffset);
    AnimalHandBook.AddMeshId(builder, mesh_id);
    AnimalHandBook.AddId(builder, id);
    return AnimalHandBook.EndAnimalHandBook(builder);
  }

  public static void StartAnimalHandBook(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddMeshId(FlatBufferBuilder builder, int meshId) { builder.AddInt(1, meshId, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddScale(FlatBufferBuilder builder, VectorOffset scaleOffset) { builder.AddOffset(3, scaleOffset.Value, 0); }
  public static VectorOffset CreateScaleVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateScaleVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScaleVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScaleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartScaleVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPosition(FlatBufferBuilder builder, VectorOffset positionOffset) { builder.AddOffset(4, positionOffset.Value, 0); }
  public static VectorOffset CreatePositionVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePositionVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPositionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRotator(FlatBufferBuilder builder, VectorOffset rotatorOffset) { builder.AddOffset(5, rotatorOffset.Value, 0); }
  public static VectorOffset CreateRotatorVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRotatorVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotatorVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotatorVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRotatorVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStandAnim(FlatBufferBuilder builder, StringOffset standAnimOffset) { builder.AddOffset(6, standAnimOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(7, iconOffset.Value, 0); }
  public static void AddTypeDescrtption(FlatBufferBuilder builder, StringOffset typeDescrtptionOffset) { builder.AddOffset(8, typeDescrtptionOffset.Value, 0); }
  public static void AddPlace(FlatBufferBuilder builder, StringOffset placeOffset) { builder.AddOffset(9, placeOffset.Value, 0); }
  public static void AddDescrtption(FlatBufferBuilder builder, StringOffset descrtptionOffset) { builder.AddOffset(10, descrtptionOffset.Value, 0); }
  public static void AddDropItemId(FlatBufferBuilder builder, VectorOffset dropItemIdOffset) { builder.AddOffset(11, dropItemIdOffset.Value, 0); }
  public static VectorOffset CreateDropItemIdVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDropItemIdVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDropItemIdVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDropItemIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDropItemIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<WWParser.Defs.AnimalHandBook> EndAnimalHandBook(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.AnimalHandBook>(o);
  }
  public AnimalHandBookT UnPack() {
    var _o = new AnimalHandBookT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AnimalHandBookT _o) {
    _o.Id = this.Id;
    _o.MeshId = this.MeshId;
    _o.Name = this.Name;
    _o.Scale = new List<float>();
    for (var _j = 0; _j < this.ScaleLength; ++_j) {_o.Scale.Add(this.Scale(_j));}
    _o.Position = new List<float>();
    for (var _j = 0; _j < this.PositionLength; ++_j) {_o.Position.Add(this.Position(_j));}
    _o.Rotator = new List<float>();
    for (var _j = 0; _j < this.RotatorLength; ++_j) {_o.Rotator.Add(this.Rotator(_j));}
    _o.StandAnim = this.StandAnim;
    _o.Icon = this.Icon;
    _o.TypeDescrtption = this.TypeDescrtption;
    _o.Place = this.Place;
    _o.Descrtption = this.Descrtption;
    _o.DropItemId = new List<int>();
    for (var _j = 0; _j < this.DropItemIdLength; ++_j) {_o.DropItemId.Add(this.DropItemId(_j));}
  }
  public static Offset<WWParser.Defs.AnimalHandBook> Pack(FlatBufferBuilder builder, AnimalHandBookT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.AnimalHandBook>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _scale = default(VectorOffset);
    if (_o.Scale != null) {
      var __scale = _o.Scale.ToArray();
      _scale = CreateScaleVector(builder, __scale);
    }
    var _position = default(VectorOffset);
    if (_o.Position != null) {
      var __position = _o.Position.ToArray();
      _position = CreatePositionVector(builder, __position);
    }
    var _rotator = default(VectorOffset);
    if (_o.Rotator != null) {
      var __rotator = _o.Rotator.ToArray();
      _rotator = CreateRotatorVector(builder, __rotator);
    }
    var _stand_anim = _o.StandAnim == null ? default(StringOffset) : builder.CreateString(_o.StandAnim);
    var _icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _type_descrtption = _o.TypeDescrtption == null ? default(StringOffset) : builder.CreateString(_o.TypeDescrtption);
    var _place = _o.Place == null ? default(StringOffset) : builder.CreateString(_o.Place);
    var _descrtption = _o.Descrtption == null ? default(StringOffset) : builder.CreateString(_o.Descrtption);
    var _drop_item_id = default(VectorOffset);
    if (_o.DropItemId != null) {
      var __drop_item_id = _o.DropItemId.ToArray();
      _drop_item_id = CreateDropItemIdVector(builder, __drop_item_id);
    }
    return CreateAnimalHandBook(
      builder,
      _o.Id,
      _o.MeshId,
      _name,
      _scale,
      _position,
      _rotator,
      _stand_anim,
      _icon,
      _type_descrtption,
      _place,
      _descrtption,
      _drop_item_id);
  }
}

public class AnimalHandBookT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("mesh_id")]
  public int MeshId { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("scale")]
  public List<float> Scale { get; set; }
  [Newtonsoft.Json.JsonProperty("position")]
  public List<float> Position { get; set; }
  [Newtonsoft.Json.JsonProperty("rotator")]
  public List<float> Rotator { get; set; }
  [Newtonsoft.Json.JsonProperty("stand_anim")]
  public string StandAnim { get; set; }
  [Newtonsoft.Json.JsonProperty("icon")]
  public string Icon { get; set; }
  [Newtonsoft.Json.JsonProperty("type_descrtption")]
  public string TypeDescrtption { get; set; }
  [Newtonsoft.Json.JsonProperty("place")]
  public string Place { get; set; }
  [Newtonsoft.Json.JsonProperty("descrtption")]
  public string Descrtption { get; set; }
  [Newtonsoft.Json.JsonProperty("drop_item_id")]
  public List<int> DropItemId { get; set; }

  public AnimalHandBookT() {
    this.Id = 0;
    this.MeshId = 0;
    this.Name = null;
    this.Scale = null;
    this.Position = null;
    this.Rotator = null;
    this.StandAnim = null;
    this.Icon = null;
    this.TypeDescrtption = null;
    this.Place = null;
    this.Descrtption = null;
    this.DropItemId = null;
  }
}


static public class AnimalHandBookVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MeshId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*Scale*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*Position*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*Rotator*/, 4 /*float*/, false)
      && verifier.VerifyString(tablePos, 16 /*StandAnim*/, false)
      && verifier.VerifyString(tablePos, 18 /*Icon*/, false)
      && verifier.VerifyString(tablePos, 20 /*TypeDescrtption*/, false)
      && verifier.VerifyString(tablePos, 22 /*Place*/, false)
      && verifier.VerifyString(tablePos, 24 /*Descrtption*/, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*DropItemId*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
