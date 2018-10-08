using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontGlyph
    {
        public ushort Codepoint;
        public float AdvanceX;
        public float X0;
        public float Y0;
        public float X1;
        public float Y1;
        public float U0;
        public float V0;
        public float U1;
        public float V1;
    }
    public unsafe partial struct ImFontGlyphPtr
    {
        public ImFontGlyph* NativePtr { get; }
        public ImFontGlyphPtr(ImFontGlyph* nativePtr) { NativePtr = nativePtr; }
        public ImFontGlyphPtr(IntPtr nativePtr) { NativePtr = (ImFontGlyph*)nativePtr; }
        public static implicit operator ImFontGlyphPtr(ImFontGlyph* nativePtr) { return new ImFontGlyphPtr(nativePtr); }
        public static implicit operator ImFontGlyph* (ImFontGlyphPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImFontGlyphPtr(IntPtr nativePtr) { return new ImFontGlyphPtr(nativePtr); }
        public ushort* Codepoint { get { return (ushort*) &NativePtr->Codepoint; } }
        public float* AdvanceX { get { return (float*) &NativePtr->AdvanceX; } }
        public float* X0 { get { return (float*) &NativePtr->X0; } }
        public float* Y0 { get { return (float*) &NativePtr->Y0; } }
        public float* X1 { get { return (float*) &NativePtr->X1; } }
        public float* Y1 { get { return (float*) &NativePtr->Y1; } }
        public float* U0 { get { return (float*) &NativePtr->U0; } }
        public float* V0 { get { return (float*) &NativePtr->V0; } }
        public float* U1 { get { return (float*) &NativePtr->U1; } }
        public float* V1 { get { return (float*) &NativePtr->V1; } }
    }
}
