// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SubtitleText : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static SubtitleText GetRootAsSubtitleText(ByteBuffer _bb) { return GetRootAsSubtitleText(_bb, new SubtitleText()); }
  public static SubtitleText GetRootAsSubtitleText(ByteBuffer _bb, SubtitleText obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SubtitleText __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RowName { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string DatatableName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDatatableNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDatatableNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDatatableNameArray() { return __p.__vector_as_array<byte>(8); }
  public int CharacterName { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RoleId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Subtitles1 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Subtitles2 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Subtitles3 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Subtitles4 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Subtitles5 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Option1 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Option2 { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Option3 { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Option4 { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Option5 { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Audio1 { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudio1Bytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetAudio1Bytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetAudio1Array() { return __p.__vector_as_array<byte>(34); }
  public string Audio2 { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudio2Bytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetAudio2Bytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetAudio2Array() { return __p.__vector_as_array<byte>(36); }
  public string Audio3 { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudio3Bytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetAudio3Bytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetAudio3Array() { return __p.__vector_as_array<byte>(38); }
  public string Audio4 { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudio4Bytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetAudio4Bytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetAudio4Array() { return __p.__vector_as_array<byte>(40); }
  public string Audio5 { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudio5Bytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetAudio5Bytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetAudio5Array() { return __p.__vector_as_array<byte>(42); }
  public string OsList { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOsListBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetOsListBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetOsListArray() { return __p.__vector_as_array<byte>(44); }

  public static Offset<WWParser.Defs.SubtitleText> CreateSubtitleText(FlatBufferBuilder builder,
      int id = 0,
      int row_name = 0,
      StringOffset datatable_nameOffset = default(StringOffset),
      int character_name = 0,
      int role_id = 0,
      int subtitles1 = 0,
      int subtitles2 = 0,
      int subtitles3 = 0,
      int subtitles4 = 0,
      int subtitles5 = 0,
      int option1 = 0,
      int option2 = 0,
      int option3 = 0,
      int option4 = 0,
      int option5 = 0,
      StringOffset audio1Offset = default(StringOffset),
      StringOffset audio2Offset = default(StringOffset),
      StringOffset audio3Offset = default(StringOffset),
      StringOffset audio4Offset = default(StringOffset),
      StringOffset audio5Offset = default(StringOffset),
      StringOffset os_listOffset = default(StringOffset)) {
    builder.StartTable(21);
    SubtitleText.AddOsList(builder, os_listOffset);
    SubtitleText.AddAudio5(builder, audio5Offset);
    SubtitleText.AddAudio4(builder, audio4Offset);
    SubtitleText.AddAudio3(builder, audio3Offset);
    SubtitleText.AddAudio2(builder, audio2Offset);
    SubtitleText.AddAudio1(builder, audio1Offset);
    SubtitleText.AddOption5(builder, option5);
    SubtitleText.AddOption4(builder, option4);
    SubtitleText.AddOption3(builder, option3);
    SubtitleText.AddOption2(builder, option2);
    SubtitleText.AddOption1(builder, option1);
    SubtitleText.AddSubtitles5(builder, subtitles5);
    SubtitleText.AddSubtitles4(builder, subtitles4);
    SubtitleText.AddSubtitles3(builder, subtitles3);
    SubtitleText.AddSubtitles2(builder, subtitles2);
    SubtitleText.AddSubtitles1(builder, subtitles1);
    SubtitleText.AddRoleId(builder, role_id);
    SubtitleText.AddCharacterName(builder, character_name);
    SubtitleText.AddDatatableName(builder, datatable_nameOffset);
    SubtitleText.AddRowName(builder, row_name);
    SubtitleText.AddId(builder, id);
    return SubtitleText.EndSubtitleText(builder);
  }

  public static void StartSubtitleText(FlatBufferBuilder builder) { builder.StartTable(21); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddRowName(FlatBufferBuilder builder, int rowName) { builder.AddInt(1, rowName, 0); }
  public static void AddDatatableName(FlatBufferBuilder builder, StringOffset datatableNameOffset) { builder.AddOffset(2, datatableNameOffset.Value, 0); }
  public static void AddCharacterName(FlatBufferBuilder builder, int characterName) { builder.AddInt(3, characterName, 0); }
  public static void AddRoleId(FlatBufferBuilder builder, int roleId) { builder.AddInt(4, roleId, 0); }
  public static void AddSubtitles1(FlatBufferBuilder builder, int subtitles1) { builder.AddInt(5, subtitles1, 0); }
  public static void AddSubtitles2(FlatBufferBuilder builder, int subtitles2) { builder.AddInt(6, subtitles2, 0); }
  public static void AddSubtitles3(FlatBufferBuilder builder, int subtitles3) { builder.AddInt(7, subtitles3, 0); }
  public static void AddSubtitles4(FlatBufferBuilder builder, int subtitles4) { builder.AddInt(8, subtitles4, 0); }
  public static void AddSubtitles5(FlatBufferBuilder builder, int subtitles5) { builder.AddInt(9, subtitles5, 0); }
  public static void AddOption1(FlatBufferBuilder builder, int option1) { builder.AddInt(10, option1, 0); }
  public static void AddOption2(FlatBufferBuilder builder, int option2) { builder.AddInt(11, option2, 0); }
  public static void AddOption3(FlatBufferBuilder builder, int option3) { builder.AddInt(12, option3, 0); }
  public static void AddOption4(FlatBufferBuilder builder, int option4) { builder.AddInt(13, option4, 0); }
  public static void AddOption5(FlatBufferBuilder builder, int option5) { builder.AddInt(14, option5, 0); }
  public static void AddAudio1(FlatBufferBuilder builder, StringOffset audio1Offset) { builder.AddOffset(15, audio1Offset.Value, 0); }
  public static void AddAudio2(FlatBufferBuilder builder, StringOffset audio2Offset) { builder.AddOffset(16, audio2Offset.Value, 0); }
  public static void AddAudio3(FlatBufferBuilder builder, StringOffset audio3Offset) { builder.AddOffset(17, audio3Offset.Value, 0); }
  public static void AddAudio4(FlatBufferBuilder builder, StringOffset audio4Offset) { builder.AddOffset(18, audio4Offset.Value, 0); }
  public static void AddAudio5(FlatBufferBuilder builder, StringOffset audio5Offset) { builder.AddOffset(19, audio5Offset.Value, 0); }
  public static void AddOsList(FlatBufferBuilder builder, StringOffset osListOffset) { builder.AddOffset(20, osListOffset.Value, 0); }
  public static Offset<WWParser.Defs.SubtitleText> EndSubtitleText(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.SubtitleText>(o);
  }
  public SubtitleTextT UnPack() {
    var _o = new SubtitleTextT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SubtitleTextT _o) {
    _o.Id = this.Id;
    _o.RowName = this.RowName;
    _o.DatatableName = this.DatatableName;
    _o.CharacterName = this.CharacterName;
    _o.RoleId = this.RoleId;
    _o.Subtitles1 = this.Subtitles1;
    _o.Subtitles2 = this.Subtitles2;
    _o.Subtitles3 = this.Subtitles3;
    _o.Subtitles4 = this.Subtitles4;
    _o.Subtitles5 = this.Subtitles5;
    _o.Option1 = this.Option1;
    _o.Option2 = this.Option2;
    _o.Option3 = this.Option3;
    _o.Option4 = this.Option4;
    _o.Option5 = this.Option5;
    _o.Audio1 = this.Audio1;
    _o.Audio2 = this.Audio2;
    _o.Audio3 = this.Audio3;
    _o.Audio4 = this.Audio4;
    _o.Audio5 = this.Audio5;
    _o.OsList = this.OsList;
  }
  public static Offset<WWParser.Defs.SubtitleText> Pack(FlatBufferBuilder builder, SubtitleTextT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.SubtitleText>);
    var _datatable_name = _o.DatatableName == null ? default(StringOffset) : builder.CreateString(_o.DatatableName);
    var _audio1 = _o.Audio1 == null ? default(StringOffset) : builder.CreateString(_o.Audio1);
    var _audio2 = _o.Audio2 == null ? default(StringOffset) : builder.CreateString(_o.Audio2);
    var _audio3 = _o.Audio3 == null ? default(StringOffset) : builder.CreateString(_o.Audio3);
    var _audio4 = _o.Audio4 == null ? default(StringOffset) : builder.CreateString(_o.Audio4);
    var _audio5 = _o.Audio5 == null ? default(StringOffset) : builder.CreateString(_o.Audio5);
    var _os_list = _o.OsList == null ? default(StringOffset) : builder.CreateString(_o.OsList);
    return CreateSubtitleText(
      builder,
      _o.Id,
      _o.RowName,
      _datatable_name,
      _o.CharacterName,
      _o.RoleId,
      _o.Subtitles1,
      _o.Subtitles2,
      _o.Subtitles3,
      _o.Subtitles4,
      _o.Subtitles5,
      _o.Option1,
      _o.Option2,
      _o.Option3,
      _o.Option4,
      _o.Option5,
      _audio1,
      _audio2,
      _audio3,
      _audio4,
      _audio5,
      _os_list);
  }
}

public class SubtitleTextT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("row_name")]
  public int RowName { get; set; }
  [Newtonsoft.Json.JsonProperty("datatable_name")]
  public string DatatableName { get; set; }
  [Newtonsoft.Json.JsonProperty("character_name")]
  public int CharacterName { get; set; }
  [Newtonsoft.Json.JsonProperty("role_id")]
  public int RoleId { get; set; }
  [Newtonsoft.Json.JsonProperty("subtitles1")]
  public int Subtitles1 { get; set; }
  [Newtonsoft.Json.JsonProperty("subtitles2")]
  public int Subtitles2 { get; set; }
  [Newtonsoft.Json.JsonProperty("subtitles3")]
  public int Subtitles3 { get; set; }
  [Newtonsoft.Json.JsonProperty("subtitles4")]
  public int Subtitles4 { get; set; }
  [Newtonsoft.Json.JsonProperty("subtitles5")]
  public int Subtitles5 { get; set; }
  [Newtonsoft.Json.JsonProperty("option1")]
  public int Option1 { get; set; }
  [Newtonsoft.Json.JsonProperty("option2")]
  public int Option2 { get; set; }
  [Newtonsoft.Json.JsonProperty("option3")]
  public int Option3 { get; set; }
  [Newtonsoft.Json.JsonProperty("option4")]
  public int Option4 { get; set; }
  [Newtonsoft.Json.JsonProperty("option5")]
  public int Option5 { get; set; }
  [Newtonsoft.Json.JsonProperty("audio1")]
  public string Audio1 { get; set; }
  [Newtonsoft.Json.JsonProperty("audio2")]
  public string Audio2 { get; set; }
  [Newtonsoft.Json.JsonProperty("audio3")]
  public string Audio3 { get; set; }
  [Newtonsoft.Json.JsonProperty("audio4")]
  public string Audio4 { get; set; }
  [Newtonsoft.Json.JsonProperty("audio5")]
  public string Audio5 { get; set; }
  [Newtonsoft.Json.JsonProperty("os_list")]
  public string OsList { get; set; }

  public SubtitleTextT() {
    this.Id = 0;
    this.RowName = 0;
    this.DatatableName = null;
    this.CharacterName = 0;
    this.RoleId = 0;
    this.Subtitles1 = 0;
    this.Subtitles2 = 0;
    this.Subtitles3 = 0;
    this.Subtitles4 = 0;
    this.Subtitles5 = 0;
    this.Option1 = 0;
    this.Option2 = 0;
    this.Option3 = 0;
    this.Option4 = 0;
    this.Option5 = 0;
    this.Audio1 = null;
    this.Audio2 = null;
    this.Audio3 = null;
    this.Audio4 = null;
    this.Audio5 = null;
    this.OsList = null;
  }
}


static public class SubtitleTextVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*RowName*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*DatatableName*/, false)
      && verifier.VerifyField(tablePos, 10 /*CharacterName*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*RoleId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*Subtitles1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Subtitles2*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*Subtitles3*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*Subtitles4*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*Subtitles5*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*Option1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*Option2*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*Option3*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*Option4*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*Option5*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 34 /*Audio1*/, false)
      && verifier.VerifyString(tablePos, 36 /*Audio2*/, false)
      && verifier.VerifyString(tablePos, 38 /*Audio3*/, false)
      && verifier.VerifyString(tablePos, 40 /*Audio4*/, false)
      && verifier.VerifyString(tablePos, 42 /*Audio5*/, false)
      && verifier.VerifyString(tablePos, 44 /*OsList*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
