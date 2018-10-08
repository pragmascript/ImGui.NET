using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct CustomRect
    {
        public uint ID;
        public ushort Width;
        public ushort Height;
        public ushort X;
        public ushort Y;
        public float GlyphAdvanceX;
        public Vector2 GlyphOffset;
        public ImFont* Font;
    }
    public unsafe partial struct CustomRectPtr
    {
        public CustomRect* NativePtr { get; }
        public CustomRectPtr(CustomRect* nativePtr) { NativePtr = nativePtr; }
        public CustomRectPtr(IntPtr nativePtr) { NativePtr = (CustomRect*)nativePtr; }
        public static implicit operator CustomRectPtr(CustomRect* nativePtr) { return new CustomRectPtr(nativePtr); }
        public static implicit operator CustomRect* (CustomRectPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator CustomRectPtr(IntPtr nativePtr) { return new CustomRectPtr(nativePtr); }
        public uint* ID { get { return (uint*) &NativePtr->ID; } }
        public ushort* Width { get { return (ushort*) &NativePtr->Width; } }
        public ushort* Height { get { return (ushort*) &NativePtr->Height; } }
        public ushort* X { get { return (ushort*) &NativePtr->X; } }
        public ushort* Y { get { return (ushort*) &NativePtr->Y; } }
        public float* GlyphAdvanceX { get { return (float*) &NativePtr->GlyphAdvanceX; } }
        public Vector2* GlyphOffset { get { return (Vector2*) &NativePtr->GlyphOffset; } }
        public ImFontPtr Font => new ImFontPtr(NativePtr->Font);
        public bool IsPacked()
        {
            byte ret = ImGuiNative.CustomRect_IsPacked(NativePtr);
            return ret != 0;
        }
    }
}
