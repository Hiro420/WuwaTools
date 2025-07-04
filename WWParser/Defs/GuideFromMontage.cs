// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GuideFromMontage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static GuideFromMontage GetRootAsGuideFromMontage(ByteBuffer _bb) { return GetRootAsGuideFromMontage(_bb, new GuideFromMontage()); }
  public static GuideFromMontage GetRootAsGuideFromMontage(ByteBuffer _bb, GuideFromMontage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GuideFromMontage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int EventGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GuideGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.GuideFromMontage> CreateGuideFromMontage(FlatBufferBuilder builder,
      int event_group_id = 0,
      int guide_group_id = 0) {
    builder.StartTable(2);
    GuideFromMontage.AddGuideGroupId(builder, guide_group_id);
    GuideFromMontage.AddEventGroupId(builder, event_group_id);
    return GuideFromMontage.EndGuideFromMontage(builder);
  }

  public static void StartGuideFromMontage(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddEventGroupId(FlatBufferBuilder builder, int eventGroupId) { builder.AddInt(0, eventGroupId, 0); }
  public static void AddGuideGroupId(FlatBufferBuilder builder, int guideGroupId) { builder.AddInt(1, guideGroupId, 0); }
  public static Offset<WWParser.Defs.GuideFromMontage> EndGuideFromMontage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.GuideFromMontage>(o);
  }
  public GuideFromMontageT UnPack() {
    var _o = new GuideFromMontageT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GuideFromMontageT _o) {
    _o.EventGroupId = this.EventGroupId;
    _o.GuideGroupId = this.GuideGroupId;
  }
  public static Offset<WWParser.Defs.GuideFromMontage> Pack(FlatBufferBuilder builder, GuideFromMontageT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.GuideFromMontage>);
    return CreateGuideFromMontage(
      builder,
      _o.EventGroupId,
      _o.GuideGroupId);
  }
}

public class GuideFromMontageT
{
  [Newtonsoft.Json.JsonProperty("event_group_id")]
  public int EventGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("guide_group_id")]
  public int GuideGroupId { get; set; }

  public GuideFromMontageT() {
    this.EventGroupId = 0;
    this.GuideGroupId = 0;
  }
}


static public class GuideFromMontageVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventGroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*GuideGroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
