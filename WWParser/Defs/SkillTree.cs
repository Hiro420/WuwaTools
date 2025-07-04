// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SkillTree : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static SkillTree GetRootAsSkillTree(ByteBuffer _bb) { return GetRootAsSkillTree(_bb, new SkillTree()); }
  public static SkillTree GetRootAsSkillTree(ByteBuffer _bb, SkillTree obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SkillTree __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NodeIndex { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int NodeGroup { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ParentNodes(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ParentNodesLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetParentNodesBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetParentNodesBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetParentNodesArray() { return __p.__vector_as_array<int>(10); }
  public int NodeType { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Coordinate { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Condition(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ConditionLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetConditionBytes() { return __p.__vector_as_span<int>(16, 4); }
#else
  public ArraySegment<byte>? GetConditionBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public int[] GetConditionArray() { return __p.__vector_as_array<int>(16); }
  public int SkillId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string PropertyNodeTitle { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPropertyNodeTitleBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetPropertyNodeTitleBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetPropertyNodeTitleArray() { return __p.__vector_as_array<byte>(20); }
  public string PropertyNodeDescribe { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPropertyNodeDescribeBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetPropertyNodeDescribeBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetPropertyNodeDescribeArray() { return __p.__vector_as_array<byte>(22); }
  public string PropertyNodeParam(int j) { int o = __p.__offset(24); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PropertyNodeParamLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string PropertyNodeIcon { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPropertyNodeIconBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetPropertyNodeIconBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetPropertyNodeIconArray() { return __p.__vector_as_array<byte>(26); }
  public WWParser.Defs.ConfigPropValue? Property(int j) { int o = __p.__offset(28); return o != 0 ? (WWParser.Defs.ConfigPropValue?)(new WWParser.Defs.ConfigPropValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PropertyLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
  public WWParser.Defs.DicIntInt? Consume(int j) { int o = __p.__offset(30); return o != 0 ? (WWParser.Defs.DicIntInt?)(new WWParser.Defs.DicIntInt()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ConsumeLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int UnLockCondition { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.SkillTree> CreateSkillTree(FlatBufferBuilder builder,
      int id = 0,
      int node_index = 0,
      int node_group = 0,
      VectorOffset parent_nodesOffset = default(VectorOffset),
      int node_type = 0,
      int coordinate = 0,
      VectorOffset conditionOffset = default(VectorOffset),
      int skill_id = 0,
      StringOffset property_node_titleOffset = default(StringOffset),
      StringOffset property_node_describeOffset = default(StringOffset),
      VectorOffset property_node_paramOffset = default(VectorOffset),
      StringOffset property_node_iconOffset = default(StringOffset),
      VectorOffset propertyOffset = default(VectorOffset),
      VectorOffset consumeOffset = default(VectorOffset),
      int un_lock_condition = 0) {
    builder.StartTable(15);
    SkillTree.AddUnLockCondition(builder, un_lock_condition);
    SkillTree.AddConsume(builder, consumeOffset);
    SkillTree.AddProperty(builder, propertyOffset);
    SkillTree.AddPropertyNodeIcon(builder, property_node_iconOffset);
    SkillTree.AddPropertyNodeParam(builder, property_node_paramOffset);
    SkillTree.AddPropertyNodeDescribe(builder, property_node_describeOffset);
    SkillTree.AddPropertyNodeTitle(builder, property_node_titleOffset);
    SkillTree.AddSkillId(builder, skill_id);
    SkillTree.AddCondition(builder, conditionOffset);
    SkillTree.AddCoordinate(builder, coordinate);
    SkillTree.AddNodeType(builder, node_type);
    SkillTree.AddParentNodes(builder, parent_nodesOffset);
    SkillTree.AddNodeGroup(builder, node_group);
    SkillTree.AddNodeIndex(builder, node_index);
    SkillTree.AddId(builder, id);
    return SkillTree.EndSkillTree(builder);
  }

  public static void StartSkillTree(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex) { builder.AddInt(1, nodeIndex, 0); }
  public static void AddNodeGroup(FlatBufferBuilder builder, int nodeGroup) { builder.AddInt(2, nodeGroup, 0); }
  public static void AddParentNodes(FlatBufferBuilder builder, VectorOffset parentNodesOffset) { builder.AddOffset(3, parentNodesOffset.Value, 0); }
  public static VectorOffset CreateParentNodesVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParentNodesVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParentNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParentNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParentNodesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNodeType(FlatBufferBuilder builder, int nodeType) { builder.AddInt(4, nodeType, 0); }
  public static void AddCoordinate(FlatBufferBuilder builder, int coordinate) { builder.AddInt(5, coordinate, 0); }
  public static void AddCondition(FlatBufferBuilder builder, VectorOffset conditionOffset) { builder.AddOffset(6, conditionOffset.Value, 0); }
  public static VectorOffset CreateConditionVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillId(FlatBufferBuilder builder, int skillId) { builder.AddInt(7, skillId, 0); }
  public static void AddPropertyNodeTitle(FlatBufferBuilder builder, StringOffset propertyNodeTitleOffset) { builder.AddOffset(8, propertyNodeTitleOffset.Value, 0); }
  public static void AddPropertyNodeDescribe(FlatBufferBuilder builder, StringOffset propertyNodeDescribeOffset) { builder.AddOffset(9, propertyNodeDescribeOffset.Value, 0); }
  public static void AddPropertyNodeParam(FlatBufferBuilder builder, VectorOffset propertyNodeParamOffset) { builder.AddOffset(10, propertyNodeParamOffset.Value, 0); }
  public static VectorOffset CreatePropertyNodeParamVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePropertyNodeParamVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropertyNodeParamVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropertyNodeParamVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPropertyNodeParamVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPropertyNodeIcon(FlatBufferBuilder builder, StringOffset propertyNodeIconOffset) { builder.AddOffset(11, propertyNodeIconOffset.Value, 0); }
  public static void AddProperty(FlatBufferBuilder builder, VectorOffset propertyOffset) { builder.AddOffset(12, propertyOffset.Value, 0); }
  public static VectorOffset CreatePropertyVector(FlatBufferBuilder builder, Offset<WWParser.Defs.ConfigPropValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePropertyVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.ConfigPropValue>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropertyVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.ConfigPropValue>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropertyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.ConfigPropValue>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPropertyVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConsume(FlatBufferBuilder builder, VectorOffset consumeOffset) { builder.AddOffset(13, consumeOffset.Value, 0); }
  public static VectorOffset CreateConsumeVector(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, Offset<WWParser.Defs.DicIntInt>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<WWParser.Defs.DicIntInt>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<WWParser.Defs.DicIntInt>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockCondition(FlatBufferBuilder builder, int unLockCondition) { builder.AddInt(14, unLockCondition, 0); }
  public static Offset<WWParser.Defs.SkillTree> EndSkillTree(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.SkillTree>(o);
  }
  public SkillTreeT UnPack() {
    var _o = new SkillTreeT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SkillTreeT _o) {
    _o.Id = this.Id;
    _o.NodeIndex = this.NodeIndex;
    _o.NodeGroup = this.NodeGroup;
    _o.ParentNodes = new List<int>();
    for (var _j = 0; _j < this.ParentNodesLength; ++_j) {_o.ParentNodes.Add(this.ParentNodes(_j));}
    _o.NodeType = this.NodeType;
    _o.Coordinate = this.Coordinate;
    _o.Condition = new List<int>();
    for (var _j = 0; _j < this.ConditionLength; ++_j) {_o.Condition.Add(this.Condition(_j));}
    _o.SkillId = this.SkillId;
    _o.PropertyNodeTitle = this.PropertyNodeTitle;
    _o.PropertyNodeDescribe = this.PropertyNodeDescribe;
    _o.PropertyNodeParam = new List<string>();
    for (var _j = 0; _j < this.PropertyNodeParamLength; ++_j) {_o.PropertyNodeParam.Add(this.PropertyNodeParam(_j));}
    _o.PropertyNodeIcon = this.PropertyNodeIcon;
    _o.Property = new List<WWParser.Defs.ConfigPropValueT>();
    for (var _j = 0; _j < this.PropertyLength; ++_j) {_o.Property.Add(this.Property(_j).HasValue ? this.Property(_j).Value.UnPack() : null);}
    _o.Consume = new List<WWParser.Defs.DicIntIntT>();
    for (var _j = 0; _j < this.ConsumeLength; ++_j) {_o.Consume.Add(this.Consume(_j).HasValue ? this.Consume(_j).Value.UnPack() : null);}
    _o.UnLockCondition = this.UnLockCondition;
  }
  public static Offset<WWParser.Defs.SkillTree> Pack(FlatBufferBuilder builder, SkillTreeT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.SkillTree>);
    var _parent_nodes = default(VectorOffset);
    if (_o.ParentNodes != null) {
      var __parent_nodes = _o.ParentNodes.ToArray();
      _parent_nodes = CreateParentNodesVector(builder, __parent_nodes);
    }
    var _condition = default(VectorOffset);
    if (_o.Condition != null) {
      var __condition = _o.Condition.ToArray();
      _condition = CreateConditionVector(builder, __condition);
    }
    var _property_node_title = _o.PropertyNodeTitle == null ? default(StringOffset) : builder.CreateString(_o.PropertyNodeTitle);
    var _property_node_describe = _o.PropertyNodeDescribe == null ? default(StringOffset) : builder.CreateString(_o.PropertyNodeDescribe);
    var _property_node_param = default(VectorOffset);
    if (_o.PropertyNodeParam != null) {
      var __property_node_param = new StringOffset[_o.PropertyNodeParam.Count];
      for (var _j = 0; _j < __property_node_param.Length; ++_j) { __property_node_param[_j] = builder.CreateString(_o.PropertyNodeParam[_j]); }
      _property_node_param = CreatePropertyNodeParamVector(builder, __property_node_param);
    }
    var _property_node_icon = _o.PropertyNodeIcon == null ? default(StringOffset) : builder.CreateString(_o.PropertyNodeIcon);
    var _property = default(VectorOffset);
    if (_o.Property != null) {
      var __property = new Offset<WWParser.Defs.ConfigPropValue>[_o.Property.Count];
      for (var _j = 0; _j < __property.Length; ++_j) { __property[_j] = WWParser.Defs.ConfigPropValue.Pack(builder, _o.Property[_j]); }
      _property = CreatePropertyVector(builder, __property);
    }
    var _consume = default(VectorOffset);
    if (_o.Consume != null) {
      var __consume = new Offset<WWParser.Defs.DicIntInt>[_o.Consume.Count];
      for (var _j = 0; _j < __consume.Length; ++_j) { __consume[_j] = WWParser.Defs.DicIntInt.Pack(builder, _o.Consume[_j]); }
      _consume = CreateConsumeVector(builder, __consume);
    }
    return CreateSkillTree(
      builder,
      _o.Id,
      _o.NodeIndex,
      _o.NodeGroup,
      _parent_nodes,
      _o.NodeType,
      _o.Coordinate,
      _condition,
      _o.SkillId,
      _property_node_title,
      _property_node_describe,
      _property_node_param,
      _property_node_icon,
      _property,
      _consume,
      _o.UnLockCondition);
  }
}

public class SkillTreeT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public int Id { get; set; }
  [Newtonsoft.Json.JsonProperty("node_index")]
  public int NodeIndex { get; set; }
  [Newtonsoft.Json.JsonProperty("node_group")]
  public int NodeGroup { get; set; }
  [Newtonsoft.Json.JsonProperty("parent_nodes")]
  public List<int> ParentNodes { get; set; }
  [Newtonsoft.Json.JsonProperty("node_type")]
  public int NodeType { get; set; }
  [Newtonsoft.Json.JsonProperty("coordinate")]
  public int Coordinate { get; set; }
  [Newtonsoft.Json.JsonProperty("condition")]
  public List<int> Condition { get; set; }
  [Newtonsoft.Json.JsonProperty("skill_id")]
  public int SkillId { get; set; }
  [Newtonsoft.Json.JsonProperty("property_node_title")]
  public string PropertyNodeTitle { get; set; }
  [Newtonsoft.Json.JsonProperty("property_node_describe")]
  public string PropertyNodeDescribe { get; set; }
  [Newtonsoft.Json.JsonProperty("property_node_param")]
  public List<string> PropertyNodeParam { get; set; }
  [Newtonsoft.Json.JsonProperty("property_node_icon")]
  public string PropertyNodeIcon { get; set; }
  [Newtonsoft.Json.JsonProperty("property")]
  public List<WWParser.Defs.ConfigPropValueT> Property { get; set; }
  [Newtonsoft.Json.JsonProperty("consume")]
  public List<WWParser.Defs.DicIntIntT> Consume { get; set; }
  [Newtonsoft.Json.JsonProperty("un_lock_condition")]
  public int UnLockCondition { get; set; }

  public SkillTreeT() {
    this.Id = 0;
    this.NodeIndex = 0;
    this.NodeGroup = 0;
    this.ParentNodes = null;
    this.NodeType = 0;
    this.Coordinate = 0;
    this.Condition = null;
    this.SkillId = 0;
    this.PropertyNodeTitle = null;
    this.PropertyNodeDescribe = null;
    this.PropertyNodeParam = null;
    this.PropertyNodeIcon = null;
    this.Property = null;
    this.Consume = null;
    this.UnLockCondition = 0;
  }
}


static public class SkillTreeVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*NodeIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*NodeGroup*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*ParentNodes*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 12 /*NodeType*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*Coordinate*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*Condition*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 18 /*SkillId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*PropertyNodeTitle*/, false)
      && verifier.VerifyString(tablePos, 22 /*PropertyNodeDescribe*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 24 /*PropertyNodeParam*/, false)
      && verifier.VerifyString(tablePos, 26 /*PropertyNodeIcon*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 28 /*Property*/, WWParser.Defs.ConfigPropValueVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 30 /*Consume*/, WWParser.Defs.DicIntIntVerify.Verify, false)
      && verifier.VerifyField(tablePos, 32 /*UnLockCondition*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
