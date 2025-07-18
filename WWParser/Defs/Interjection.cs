// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Interjection : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static Interjection GetRootAsInterjection(ByteBuffer _bb) { return GetRootAsInterjection(_bb, new Interjection()); }
  public static Interjection GetRootAsInterjection(ByteBuffer _bb, Interjection obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Interjection __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TimberId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int UniversalToneId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string AkEvent { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAkEventBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetAkEventBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetAkEventArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<WWParser.Defs.Interjection> CreateInterjection(FlatBufferBuilder builder,
      int id = 0,
      int timber_id = 0,
      int universal_tone_id = 0,
      StringOffset ak_eventOffset = default(StringOffset)) {
    builder.StartTable(4);
    Interjection.AddAkEvent(builder, ak_eventOffset);
    Interjection.AddUniversalToneId(builder, universal_tone_id);
    Interjection.AddTimberId(builder, timber_id);
    Interjection.AddId(builder, id);
    return Interjection.EndInterjection(builder);
  }

  public static void StartInterjection(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTimberId(FlatBufferBuilder builder, int timberId) { builder.AddInt(1, timberId, 0); }
  public static void AddUniversalToneId(FlatBufferBuilder builder, int universalToneId) { builder.AddInt(2, universalToneId, 0); }
  public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset) { builder.AddOffset(3, akEventOffset.Value, 0); }
  public static Offset<WWParser.Defs.Interjection> EndInterjection(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.Interjection>(o);
  }
  public InterjectionT UnPack() {
    var _o = new InterjectionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(InterjectionT _o) {
    _o.Id = this.Id;
    _o.TimberId = this.TimberId;
    _o.UniversalToneId = this.UniversalToneId;
    _o.AkEvent = this.AkEvent;
  }
  public static Offset<WWParser.Defs.Interjection> Pack(FlatBufferBuilder builder, InterjectionT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.Interjection>);
    var _ak_event = _o.AkEvent == null ? default(StringOffset) : builder.CreateString(_o.AkEvent);
    return CreateInterjection(
      builder,
      _o.Id,
      _o.TimberId,
      _o.UniversalToneId,
      _ak_event);
  }
}

public class InterjectionT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("timber_id")]
  public int TimberId { get; set; }
  [Newtonsoft.Json.JsonProperty("universal_tone_id")]
  public int UniversalToneId { get; set; }
  [Newtonsoft.Json.JsonProperty("ak_event")]
  public string AkEvent { get; set; }

  public InterjectionT() {
    this.Id = 0;
    this.TimberId = 0;
    this.UniversalToneId = 0;
    this.AkEvent = null;
  }
}


static public class InterjectionVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*TimberId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*UniversalToneId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*AkEvent*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
