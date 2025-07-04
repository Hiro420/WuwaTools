// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace WWParser.Defs
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct IntVector2D : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_2_10(); }
  public static IntVector2D GetRootAsIntVector2D(ByteBuffer _bb) { return GetRootAsIntVector2D(_bb, new IntVector2D()); }
  public static IntVector2D GetRootAsIntVector2D(ByteBuffer _bb, IntVector2D obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public IntVector2D __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<WWParser.Defs.IntVector2D> CreateIntVector2D(FlatBufferBuilder builder,
      int x = 0,
      int y = 0) {
    builder.StartTable(2);
    IntVector2D.AddY(builder, y);
    IntVector2D.AddX(builder, x);
    return IntVector2D.EndIntVector2D(builder);
  }

  public static void StartIntVector2D(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddX(FlatBufferBuilder builder, int x) { builder.AddInt(0, x, 0); }
  public static void AddY(FlatBufferBuilder builder, int y) { builder.AddInt(1, y, 0); }
  public static Offset<WWParser.Defs.IntVector2D> EndIntVector2D(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<WWParser.Defs.IntVector2D>(o);
  }
  public IntVector2DT UnPack() {
    var _o = new IntVector2DT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(IntVector2DT _o) {
    _o.X = this.X;
    _o.Y = this.Y;
  }
  public static Offset<WWParser.Defs.IntVector2D> Pack(FlatBufferBuilder builder, IntVector2DT _o) {
    if (_o == null) return default(Offset<WWParser.Defs.IntVector2D>);
    return CreateIntVector2D(
      builder,
      _o.X,
      _o.Y);
  }
}

public class IntVector2DT
{
  [Newtonsoft.Json.JsonProperty("x")]
  public int X { get; set; }
  [Newtonsoft.Json.JsonProperty("y")]
  public int Y { get; set; }

  public IntVector2DT() {
    this.X = 0;
    this.Y = 0;
  }
}


static public class IntVector2DVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Y*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
