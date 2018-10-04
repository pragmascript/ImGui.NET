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
        public ImFontGlyphPtr(ImFontGlyph* nativePtr) => NativePtr = nativePtr;
        public ImFontGlyphPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyph*)nativePtr;
        public static implicit operator ImFontGlyphPtr(ImFontGlyph* nativePtr) => new ImFontGlyphPtr(nativePtr);
        public static implicit operator ImFontGlyph* (ImFontGlyphPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontGlyphPtr(IntPtr nativePtr) => new ImFontGlyphPtr(nativePtr);
        public ushort* Codepoint => (ushort*) &NativePtr->Codepoint;
        public float* AdvanceX => (float*) &NativePtr->AdvanceX;
        public float* X0 => (float*) &NativePtr->X0;
        public float* Y0 => (float*) &NativePtr->Y0;
        public float* X1 => (float*) &NativePtr->X1;
        public float* Y1 => (float*) &NativePtr->Y1;
        public float* U0 => (float*) &NativePtr->U0;
        public float* V0 => (float*) &NativePtr->V0;
        public float* U1 => (float*) &NativePtr->U1;
        public float* V1 => (float*) &NativePtr->V1;
    }
}
