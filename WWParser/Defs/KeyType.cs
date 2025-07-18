// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct KeyType : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static KeyType GetRootAsKeyType(ByteBuffer _bb) { return GetRootAsKeyType(_bb, new KeyType()); }
  public static KeyType GetRootAsKeyType(ByteBuffer _bb, KeyType obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public KeyType __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TypeId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string IconSpritePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconSpritePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIconSpritePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIconSpritePathArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<WWParser.Defs.KeyType> CreateKeyType(FlatBufferBuilder builder,
      int type_id = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset icon_sprite_pathOffset = default(StringOffset)) {
    builder.StartTable(3);
    KeyType.AddIconSpritePath(builder, icon_sprite_pathOffset);
    KeyType.AddName(builder, nameOffset);
    KeyType.AddTypeId(builder, type_id);
    return KeyType.EndKeyType(builder);
  }

  public static void StartKeyType(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddTypeId(FlatBufferBuilder builder, int typeId) { builder.AddInt(0, typeId, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddIconSpritePath(FlatBufferBuilder builder, StringOffset iconSpritePathOffset) { builder.AddOffset(2, iconSpritePathOffset.Value, 0); }
  public static Offset<WWParser.Defs.KeyType> EndKeyType(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.KeyType>(o);
  }
  public KeyTypeT UnPack() {
    var _o = new KeyTypeT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(KeyTypeT _o) {
    _o.TypeId = this.TypeId;
    _o.Name = this.Name;
    _o.IconSpritePath = this.IconSpritePath;
  }
  public static Offset<WWParser.Defs.KeyType> Pack(FlatBufferBuilder builder, KeyTypeT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.KeyType>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _icon_sprite_path = _o.IconSpritePath == null ? default(StringOffset) : builder.CreateString(_o.IconSpritePath);
    return CreateKeyType(
      builder,
      _o.TypeId,
      _name,
      _icon_sprite_path);
  }
}

public class KeyTypeT
{
  [Newtonsoft.Json.JsonProperty("type_id")]
  public int TypeId { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("icon_sprite_path")]
  public string IconSpritePath { get; set; }

  public KeyTypeT() {
    this.TypeId = 0;
    this.Name = null;
    this.IconSpritePath = null;
  }
}


static public class KeyTypeVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TypeId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyString(tablePos, 8 /*IconSpritePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
