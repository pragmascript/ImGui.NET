using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontConfig
    {
        public void* FontData;
        public int FontDataSize;
        public byte FontDataOwnedByAtlas;
        public int FontNo;
        public float SizePixels;
        public int OversampleH;
        public int OversampleV;
        public byte PixelSnapH;
        public Vector2 GlyphExtraSpacing;
        public Vector2 GlyphOffset;
        public ushort* GlyphRanges;
        public float GlyphMinAdvanceX;
        public float GlyphMaxAdvanceX;
        public byte MergeMode;
        public uint RasterizerFlags;
        public float RasterizerMultiply;
        public fixed byte Name[40];
        public ImFont* DstFont;
    }
    public unsafe partial struct ImFontConfigPtr
    {
        public ImFontConfig* NativePtr { get; }
        public ImFontConfigPtr(ImFontConfig* nativePtr) { NativePtr = nativePtr; }
        public ImFontConfigPtr(IntPtr nativePtr) { NativePtr = (ImFontConfig*)nativePtr; }
        public static implicit operator ImFontConfigPtr(ImFontConfig* nativePtr) { return new ImFontConfigPtr(nativePtr); }
        public static implicit operator ImFontConfig* (ImFontConfigPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImFontConfigPtr(IntPtr nativePtr) { return new ImFontConfigPtr(nativePtr); }
        public IntPtr FontData { get { return (IntPtr)NativePtr->FontData; } set { NativePtr->FontData = (void*)value; } }
        public int* FontDataSize { get { return (int*) &NativePtr->FontDataSize; } }
        public bool* FontDataOwnedByAtlas { get { return (bool*) &NativePtr->FontDataOwnedByAtlas; } }
        public int* FontNo { get { return (int*) &NativePtr->FontNo; } }
        public float* SizePixels { get { return (float*) &NativePtr->SizePixels; } }
        public int* OversampleH { get { return (int*) &NativePtr->OversampleH; } }
        public int* OversampleV { get { return (int*) &NativePtr->OversampleV; } }
        public bool* PixelSnapH { get { return (bool*) &NativePtr->PixelSnapH; } }
        public Vector2* GlyphExtraSpacing { get { return (Vector2*) &NativePtr->GlyphExtraSpacing; } }
        public Vector2* GlyphOffset { get { return (Vector2*) &NativePtr->GlyphOffset; } }
        public IntPtr GlyphRanges { get { return (IntPtr)NativePtr->GlyphRanges; } set { NativePtr->GlyphRanges = (ushort*)value; } }
        public float* GlyphMinAdvanceX { get { return (float*) &NativePtr->GlyphMinAdvanceX; } }
        public float* GlyphMaxAdvanceX { get { return (float*) &NativePtr->GlyphMaxAdvanceX; } }
        public bool* MergeMode { get { return (bool*) &NativePtr->MergeMode; } }
        public uint* RasterizerFlags { get { return (uint*) &NativePtr->RasterizerFlags; } }
        public float* RasterizerMultiply { get { return (float*) &NativePtr->RasterizerMultiply; } }
        public RangeAccessor<byte> Name => new RangeAccessor<byte>(NativePtr->Name, 40);
        public ImFontPtr DstFont => new ImFontPtr(NativePtr->DstFont);
        public void Destroy()
        {
            ImGuiNative.ImFontConfig_destroy(NativePtr);
        }
    }
}
