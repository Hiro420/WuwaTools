// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GamepadKey : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static GamepadKey GetRootAsGamepadKey(ByteBuffer _bb) { return GetRootAsGamepadKey(_bb, new GamepadKey()); }
  public static GamepadKey GetRootAsGamepadKey(ByteBuffer _bb, GamepadKey obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GamepadKey __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string KeyName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetKeyNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetKeyNameArray() { return __p.__vector_as_array<byte>(6); }
  public string KeyDescription { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyDescriptionBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetKeyDescriptionBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetKeyDescriptionArray() { return __p.__vector_as_array<byte>(8); }
  public string KeyDisplayName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyDisplayNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetKeyDisplayNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetKeyDisplayNameArray() { return __p.__vector_as_array<byte>(10); }
  public string KeyIconPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyIconPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetKeyIconPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetKeyIconPathArray() { return __p.__vector_as_array<byte>(12); }
  public string PsKeyIconPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPsKeyIconPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetPsKeyIconPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetPsKeyIconPathArray() { return __p.__vector_as_array<byte>(14); }
  public string BackBoneKeyIconPath { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBackBoneKeyIconPathBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetBackBoneKeyIconPathBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetBackBoneKeyIconPathArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<WWParser.Defs.GamepadKey> CreateGamepadKey(FlatBufferBuilder builder,
      int id = 0,
      StringOffset key_nameOffset = default(StringOffset),
      StringOffset key_descriptionOffset = default(StringOffset),
      StringOffset key_display_nameOffset = default(StringOffset),
      StringOffset key_icon_pathOffset = default(StringOffset),
      StringOffset ps_key_icon_pathOffset = default(StringOffset),
      StringOffset back_bone_key_icon_pathOffset = default(StringOffset)) {
    builder.StartTable(7);
    GamepadKey.AddBackBoneKeyIconPath(builder, back_bone_key_icon_pathOffset);
    GamepadKey.AddPsKeyIconPath(builder, ps_key_icon_pathOffset);
    GamepadKey.AddKeyIconPath(builder, key_icon_pathOffset);
    GamepadKey.AddKeyDisplayName(builder, key_display_nameOffset);
    GamepadKey.AddKeyDescription(builder, key_descriptionOffset);
    GamepadKey.AddKeyName(builder, key_nameOffset);
    GamepadKey.AddId(builder, id);
    return GamepadKey.EndGamepadKey(builder);
  }

  public static void StartGamepadKey(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddKeyName(FlatBufferBuilder builder, StringOffset keyNameOffset) { builder.AddOffset(1, keyNameOffset.Value, 0); }
  public static void AddKeyDescription(FlatBufferBuilder builder, StringOffset keyDescriptionOffset) { builder.AddOffset(2, keyDescriptionOffset.Value, 0); }
  public static void AddKeyDisplayName(FlatBufferBuilder builder, StringOffset keyDisplayNameOffset) { builder.AddOffset(3, keyDisplayNameOffset.Value, 0); }
  public static void AddKeyIconPath(FlatBufferBuilder builder, StringOffset keyIconPathOffset) { builder.AddOffset(4, keyIconPathOffset.Value, 0); }
  public static void AddPsKeyIconPath(FlatBufferBuilder builder, StringOffset psKeyIconPathOffset) { builder.AddOffset(5, psKeyIconPathOffset.Value, 0); }
  public static void AddBackBoneKeyIconPath(FlatBufferBuilder builder, StringOffset backBoneKeyIconPathOffset) { builder.AddOffset(6, backBoneKeyIconPathOffset.Value, 0); }
  public static Offset<WWParser.Defs.GamepadKey> EndGamepadKey(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.GamepadKey>(o);
  }
  public GamepadKeyT UnPack() {
    var _o = new GamepadKeyT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GamepadKeyT _o) {
    _o.Id = this.Id;
    _o.KeyName = this.KeyName;
    _o.KeyDescription = this.KeyDescription;
    _o.KeyDisplayName = this.KeyDisplayName;
    _o.KeyIconPath = this.KeyIconPath;
    _o.PsKeyIconPath = this.PsKeyIconPath;
    _o.BackBoneKeyIconPath = this.BackBoneKeyIconPath;
  }
  public static Offset<WWParser.Defs.GamepadKey> Pack(FlatBufferBuilder builder, GamepadKeyT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.GamepadKey>);
    var _key_name = _o.KeyName == null ? default(StringOffset) : builder.CreateString(_o.KeyName);
    var _key_description = _o.KeyDescription == null ? default(StringOffset) : builder.CreateString(_o.KeyDescription);
    var _key_display_name = _o.KeyDisplayName == null ? default(StringOffset) : builder.CreateString(_o.KeyDisplayName);
    var _key_icon_path = _o.KeyIconPath == null ? default(StringOffset) : builder.CreateString(_o.KeyIconPath);
    var _ps_key_icon_path = _o.PsKeyIconPath == null ? default(StringOffset) : builder.CreateString(_o.PsKeyIconPath);
    var _back_bone_key_icon_path = _o.BackBoneKeyIconPath == null ? default(StringOffset) : builder.CreateString(_o.BackBoneKeyIconPath);
    return CreateGamepadKey(
      builder,
      _o.Id,
      _key_name,
      _key_description,
      _key_display_name,
      _key_icon_path,
      _ps_key_icon_path,
      _back_bone_key_icon_path);
  }
}

public class GamepadKeyT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("key_name")]
  public string KeyName { get; set; }
  [Newtonsoft.Json.JsonProperty("key_description")]
  public string KeyDescription { get; set; }
  [Newtonsoft.Json.JsonProperty("key_display_name")]
  public string KeyDisplayName { get; set; }
  [Newtonsoft.Json.JsonProperty("key_icon_path")]
  public string KeyIconPath { get; set; }
  [Newtonsoft.Json.JsonProperty("ps_key_icon_path")]
  public string PsKeyIconPath { get; set; }
  [Newtonsoft.Json.JsonProperty("back_bone_key_icon_path")]
  public string BackBoneKeyIconPath { get; set; }

  public GamepadKeyT() {
    this.Id = 0;
    this.KeyName = null;
    this.KeyDescription = null;
    this.KeyDisplayName = null;
    this.KeyIconPath = null;
    this.PsKeyIconPath = null;
    this.BackBoneKeyIconPath = null;
  }
}


static public class GamepadKeyVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*KeyName*/, false)
      && verifier.VerifyString(tablePos, 8 /*KeyDescription*/, false)
      && verifier.VerifyString(tablePos, 10 /*KeyDisplayName*/, false)
      && verifier.VerifyString(tablePos, 12 /*KeyIconPath*/, false)
      && verifier.VerifyString(tablePos, 14 /*PsKeyIconPath*/, false)
      && verifier.VerifyString(tablePos, 16 /*BackBoneKeyIconPath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
