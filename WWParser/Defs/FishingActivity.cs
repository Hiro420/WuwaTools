// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FishingActivity : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static FishingActivity GetRootAsFishingActivity(ByteBuffer _bb) { return GetRootAsFishingActivity(_bb, new FishingActivity()); }
  public static FishingActivity GetRootAsFishingActivity(ByteBuffer _bb, FishingActivity obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FishingActivity __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ActivityId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TimeQuantumId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MilestonItemId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PreviewWeaponId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RecommendQuestId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RecommendQuestLinkList(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RecommendQuestLinkListLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRecommendQuestLinkListBytes() { return __p.__vector_as_span<int>(14, 4); }
#else
  public ArraySegment<byte>? GetRecommendQuestLinkListBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public int[] GetRecommendQuestLinkListArray() { return __p.__vector_as_array<int>(14); }
  public string RecommendQuestLabel { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRecommendQuestLabelBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetRecommendQuestLabelBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetRecommendQuestLabelArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<WWParser.Defs.FishingActivity> CreateFishingActivity(FlatBufferBuilder builder,
      int activity_id = 0,
      int time_quantum_id = 0,
      int mileston_item_id = 0,
      int preview_weapon_id = 0,
      int recommend_quest_id = 0,
      VectorOffset recommend_quest_link_listOffset = default(VectorOffset),
      StringOffset recommend_quest_labelOffset = default(StringOffset)) {
    builder.StartTable(7);
    FishingActivity.AddRecommendQuestLabel(builder, recommend_quest_labelOffset);
    FishingActivity.AddRecommendQuestLinkList(builder, recommend_quest_link_listOffset);
    FishingActivity.AddRecommendQuestId(builder, recommend_quest_id);
    FishingActivity.AddPreviewWeaponId(builder, preview_weapon_id);
    FishingActivity.AddMilestonItemId(builder, mileston_item_id);
    FishingActivity.AddTimeQuantumId(builder, time_quantum_id);
    FishingActivity.AddActivityId(builder, activity_id);
    return FishingActivity.EndFishingActivity(builder);
  }

  public static void StartFishingActivity(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(0, activityId, 0); }
  public static void AddTimeQuantumId(FlatBufferBuilder builder, int timeQuantumId) { builder.AddInt(1, timeQuantumId, 0); }
  public static void AddMilestonItemId(FlatBufferBuilder builder, int milestonItemId) { builder.AddInt(2, milestonItemId, 0); }
  public static void AddPreviewWeaponId(FlatBufferBuilder builder, int previewWeaponId) { builder.AddInt(3, previewWeaponId, 0); }
  public static void AddRecommendQuestId(FlatBufferBuilder builder, int recommendQuestId) { builder.AddInt(4, recommendQuestId, 0); }
  public static void AddRecommendQuestLinkList(FlatBufferBuilder builder, VectorOffset recommendQuestLinkListOffset) { builder.AddOffset(5, recommendQuestLinkListOffset.Value, 0); }
  public static VectorOffset CreateRecommendQuestLinkListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRecommendQuestLinkListVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecommendQuestLinkListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecommendQuestLinkListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRecommendQuestLinkListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRecommendQuestLabel(FlatBufferBuilder builder, StringOffset recommendQuestLabelOffset) { builder.AddOffset(6, recommendQuestLabelOffset.Value, 0); }
  public static Offset<WWParser.Defs.FishingActivity> EndFishingActivity(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.FishingActivity>(o);
  }
  public FishingActivityT UnPack() {
    var _o = new FishingActivityT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FishingActivityT _o) {
    _o.ActivityId = this.ActivityId;
    _o.TimeQuantumId = this.TimeQuantumId;
    _o.MilestonItemId = this.MilestonItemId;
    _o.PreviewWeaponId = this.PreviewWeaponId;
    _o.RecommendQuestId = this.RecommendQuestId;
    _o.RecommendQuestLinkList = new List<int>();
    for (var _j = 0; _j < this.RecommendQuestLinkListLength; ++_j) {_o.RecommendQuestLinkList.Add(this.RecommendQuestLinkList(_j));}
    _o.RecommendQuestLabel = this.RecommendQuestLabel;
  }
  public static Offset<WWParser.Defs.FishingActivity> Pack(FlatBufferBuilder builder, FishingActivityT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.FishingActivity>);
    var _recommend_quest_link_list = default(VectorOffset);
    if (_o.RecommendQuestLinkList != null) {
      var __recommend_quest_link_list = _o.RecommendQuestLinkList.ToArray();
      _recommend_quest_link_list = CreateRecommendQuestLinkListVector(builder, __recommend_quest_link_list);
    }
    var _recommend_quest_label = _o.RecommendQuestLabel == null ? default(StringOffset) : builder.CreateString(_o.RecommendQuestLabel);
    return CreateFishingActivity(
      builder,
      _o.ActivityId,
      _o.TimeQuantumId,
      _o.MilestonItemId,
      _o.PreviewWeaponId,
      _o.RecommendQuestId,
      _recommend_quest_link_list,
      _recommend_quest_label);
  }
}

public class FishingActivityT
{
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("time_quantum_id")]
  public int TimeQuantumId { get; set; }
  [Newtonsoft.Json.JsonProperty("mileston_item_id")]
  public int MilestonItemId { get; set; }
  [Newtonsoft.Json.JsonProperty("preview_weapon_id")]
  public int PreviewWeaponId { get; set; }
  [Newtonsoft.Json.JsonProperty("recommend_quest_id")]
  public int RecommendQuestId { get; set; }
  [Newtonsoft.Json.JsonProperty("recommend_quest_link_list")]
  public List<int> RecommendQuestLinkList { get; set; }
  [Newtonsoft.Json.JsonProperty("recommend_quest_label")]
  public string RecommendQuestLabel { get; set; }

  public FishingActivityT() {
    this.ActivityId = 0;
    this.TimeQuantumId = 0;
    this.MilestonItemId = 0;
    this.PreviewWeaponId = 0;
    this.RecommendQuestId = 0;
    this.RecommendQuestLinkList = null;
    this.RecommendQuestLabel = null;
  }
}


static public class FishingActivityVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*TimeQuantumId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*MilestonItemId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*PreviewWeaponId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*RecommendQuestId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RecommendQuestLinkList*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 16 /*RecommendQuestLabel*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
