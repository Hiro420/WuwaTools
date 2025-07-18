// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PhantomGain : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static PhantomGain GetRootAsPhantomGain(ByteBuffer _bb) { return GetRootAsPhantomGain(_bb, new PhantomGain()); }
  public static PhantomGain GetRootAsPhantomGain(ByteBuffer _bb, PhantomGain obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PhantomGain __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MonsterInfoId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ActivityId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int UnLockReward { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Sort { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(14); }
  public string TexPhantom { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTexPhantomBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetTexPhantomBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetTexPhantomArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<WWParser.Defs.PhantomGain> CreatePhantomGain(FlatBufferBuilder builder,
      int id = 0,
      int monster_info_id = 0,
      int activity_id = 0,
      int un_lock_reward = 0,
      int sort = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset tex_phantomOffset = default(StringOffset)) {
    builder.StartTable(7);
    PhantomGain.AddTexPhantom(builder, tex_phantomOffset);
    PhantomGain.AddName(builder, nameOffset);
    PhantomGain.AddSort(builder, sort);
    PhantomGain.AddUnLockReward(builder, un_lock_reward);
    PhantomGain.AddActivityId(builder, activity_id);
    PhantomGain.AddMonsterInfoId(builder, monster_info_id);
    PhantomGain.AddId(builder, id);
    return PhantomGain.EndPhantomGain(builder);
  }

  public static void StartPhantomGain(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddMonsterInfoId(FlatBufferBuilder builder, int monsterInfoId) { builder.AddInt(1, monsterInfoId, 0); }
  public static void AddActivityId(FlatBufferBuilder builder, int activityId) { builder.AddInt(2, activityId, 0); }
  public static void AddUnLockReward(FlatBufferBuilder builder, int unLockReward) { builder.AddInt(3, unLockReward, 0); }
  public static void AddSort(FlatBufferBuilder builder, int sort) { builder.AddInt(4, sort, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(5, nameOffset.Value, 0); }
  public static void AddTexPhantom(FlatBufferBuilder builder, StringOffset texPhantomOffset) { builder.AddOffset(6, texPhantomOffset.Value, 0); }
  public static Offset<WWParser.Defs.PhantomGain> EndPhantomGain(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.PhantomGain>(o);
  }
  public PhantomGainT UnPack() {
    var _o = new PhantomGainT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PhantomGainT _o) {
    _o.Id = this.Id;
    _o.MonsterInfoId = this.MonsterInfoId;
    _o.ActivityId = this.ActivityId;
    _o.UnLockReward = this.UnLockReward;
    _o.Sort = this.Sort;
    _o.Name = this.Name;
    _o.TexPhantom = this.TexPhantom;
  }
  public static Offset<WWParser.Defs.PhantomGain> Pack(FlatBufferBuilder builder, PhantomGainT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.PhantomGain>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _tex_phantom = _o.TexPhantom == null ? default(StringOffset) : builder.CreateString(_o.TexPhantom);
    return CreatePhantomGain(
      builder,
      _o.Id,
      _o.MonsterInfoId,
      _o.ActivityId,
      _o.UnLockReward,
      _o.Sort,
      _name,
      _tex_phantom);
  }
}

public class PhantomGainT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("monster_info_id")]
  public int MonsterInfoId { get; set; }
  [Newtonsoft.Json.JsonProperty("activity_id")]
  public int ActivityId { get; set; }
  [Newtonsoft.Json.JsonProperty("un_lock_reward")]
  public int UnLockReward { get; set; }
  [Newtonsoft.Json.JsonProperty("sort")]
  public int Sort { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("tex_phantom")]
  public string TexPhantom { get; set; }

  public PhantomGainT() {
    this.Id = 0;
    this.MonsterInfoId = 0;
    this.ActivityId = 0;
    this.UnLockReward = 0;
    this.Sort = 0;
    this.Name = null;
    this.TexPhantom = null;
  }
}


static public class PhantomGainVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MonsterInfoId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ActivityId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*UnLockReward*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Sort*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 14 /*Name*/, false)
      && verifier.VerifyString(tablePos, 16 /*TexPhantom*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
