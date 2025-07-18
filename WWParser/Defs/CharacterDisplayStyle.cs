// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterDisplayStyle : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static CharacterDisplayStyle GetRootAsCharacterDisplayStyle(ByteBuffer _bb) { return GetRootAsCharacterDisplayStyle(_bb, new CharacterDisplayStyle()); }
  public static CharacterDisplayStyle GetRootAsCharacterDisplayStyle(ByteBuffer _bb, CharacterDisplayStyle obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterDisplayStyle __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string IllustrationAsset { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIllustrationAssetBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetIllustrationAssetBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetIllustrationAssetArray() { return __p.__vector_as_array<byte>(6); }
  public string CharacterName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCharacterNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetCharacterNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetCharacterNameArray() { return __p.__vector_as_array<byte>(8); }
  public string Description { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.CharacterDisplayStyle> CreateCharacterDisplayStyle(FlatBufferBuilder builder,
      int id = 0,
      StringOffset illustration_assetOffset = default(StringOffset),
      StringOffset character_nameOffset = default(StringOffset),
      StringOffset descriptionOffset = default(StringOffset)) {
    builder.StartTable(4);
    CharacterDisplayStyle.AddDescription(builder, descriptionOffset);
    CharacterDisplayStyle.AddCharacterName(builder, character_nameOffset);
    CharacterDisplayStyle.AddIllustrationAsset(builder, illustration_assetOffset);
    CharacterDisplayStyle.AddId(builder, id);
    return CharacterDisplayStyle.EndCharacterDisplayStyle(builder);
  }

  public static void StartCharacterDisplayStyle(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddIllustrationAsset(FlatBufferBuilder builder, StringOffset illustrationAssetOffset) { builder.AddOffset(1, illustrationAssetOffset.Value, 0); }
  public static void AddCharacterName(FlatBufferBuilder builder, StringOffset characterNameOffset) { builder.AddOffset(2, characterNameOffset.Value, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset) { builder.AddOffset(3, descriptionOffset.Value, 0); }
  public static Offset<WWParser.Defs.CharacterDisplayStyle> EndCharacterDisplayStyle(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.CharacterDisplayStyle>(o);
  }
  public CharacterDisplayStyleT UnPack() {
    var _o = new CharacterDisplayStyleT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterDisplayStyleT _o) {
    _o.Id = this.Id;
    _o.IllustrationAsset = this.IllustrationAsset;
    _o.CharacterName = this.CharacterName;
    _o.Description = this.Description;
  }
  public static Offset<WWParser.Defs.CharacterDisplayStyle> Pack(FlatBufferBuilder builder, CharacterDisplayStyleT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.CharacterDisplayStyle>);
    var _illustration_asset = _o.IllustrationAsset == null ? default(StringOffset) : builder.CreateString(_o.IllustrationAsset);
    var _character_name = _o.CharacterName == null ? default(StringOffset) : builder.CreateString(_o.CharacterName);
    var _description = _o.Description == null ? default(StringOffset) : builder.CreateString(_o.Description);
    return CreateCharacterDisplayStyle(
      builder,
      _o.Id,
      _illustration_asset,
      _character_name,
      _description);
  }
}

public class CharacterDisplayStyleT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("illustration_asset")]
  public string IllustrationAsset { get; set; }
  [Newtonsoft.Json.JsonProperty("character_name")]
  public string CharacterName { get; set; }
  [Newtonsoft.Json.JsonProperty("description")]
  public string Description { get; set; }

  public CharacterDisplayStyleT() {
    this.Id = 0;
    this.IllustrationAsset = null;
    this.CharacterName = null;
    this.Description = null;
  }
}


static public class CharacterDisplayStyleVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*IllustrationAsset*/, false)
      && verifier.VerifyString(tablePos, 8 /*CharacterName*/, false)
      && verifier.VerifyString(tablePos, 10 /*Description*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
