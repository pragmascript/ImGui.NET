using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFont
    {
        public float FontSize;
        public float Scale;
        public Vector2 DisplayOffset;
        public ImVector/*<ImFontGlyph>*/ Glyphs;
        public ImVector/*<float>*/ IndexAdvanceX;
        public ImVector/*<unsigned short>*/ IndexLookup;
        public ImFontGlyph* FallbackGlyph;
        public float FallbackAdvanceX;
        public ushort FallbackChar;
        public short ConfigDataCount;
        public ImFontConfig* ConfigData;
        public ImFontAtlas* ContainerAtlas;
        public float Ascent;
        public float Descent;
        public byte DirtyLookupTables;
        public int MetricsTotalSurface;
    }
    public unsafe partial struct ImFontPtr
    {
        public ImFont* NativePtr { get; }
        public ImFontPtr(ImFont* nativePtr) { NativePtr = nativePtr; }
        public ImFontPtr(IntPtr nativePtr) { NativePtr = (ImFont*)nativePtr; }
        public static implicit operator ImFontPtr(ImFont* nativePtr) { return new ImFontPtr(nativePtr); }
        public static implicit operator ImFont* (ImFontPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImFontPtr(IntPtr nativePtr) { return new ImFontPtr(nativePtr); }
        public float* FontSize { get { return (float*) &NativePtr->FontSize; } }
        public float* Scale { get { return (float*) &NativePtr->Scale; } }
        public Vector2* DisplayOffset { get { return (Vector2*) &NativePtr->DisplayOffset; } }
        public ImPtrVector<ImFontGlyphPtr> Glyphs => new ImPtrVector<ImFontGlyphPtr>(NativePtr->Glyphs, Unsafe.SizeOf<ImFontGlyph>());
        public ImVector<float> IndexAdvanceX => new ImVector<float>(NativePtr->IndexAdvanceX);
        public ImVector<ushort> IndexLookup => new ImVector<ushort>(NativePtr->IndexLookup);
        public ImFontGlyphPtr FallbackGlyph => new ImFontGlyphPtr(NativePtr->FallbackGlyph);
        public float* FallbackAdvanceX { get { return (float*) &NativePtr->FallbackAdvanceX; } }
        public ushort* FallbackChar { get { return (ushort*) &NativePtr->FallbackChar; } }
        public short* ConfigDataCount { get { return (short*) &NativePtr->ConfigDataCount; } }
        public ImFontConfigPtr ConfigData => new ImFontConfigPtr(NativePtr->ConfigData);
        public ImFontAtlasPtr ContainerAtlas => new ImFontAtlasPtr(NativePtr->ContainerAtlas);
        public float* Ascent { get { return (float*) &NativePtr->Ascent; } }
        public float* Descent { get { return (float*) &NativePtr->Descent; } }
        public Bool8* DirtyLookupTables { get { return (Bool8*) &NativePtr->DirtyLookupTables; } }
        public int* MetricsTotalSurface { get { return (int*) &NativePtr->MetricsTotalSurface; } }
        public void AddRemapChar(ushort dst, ushort src)
        {
            byte overwrite_dst = 1;
            ImGuiNative.ImFont_AddRemapChar(NativePtr, dst, src, overwrite_dst);
        }
        public void AddRemapChar(ushort dst, ushort src, bool overwrite_dst)
        {
            byte native_overwrite_dst = overwrite_dst ? (byte)1 : (byte)0;
            ImGuiNative.ImFont_AddRemapChar(NativePtr, dst, src, native_overwrite_dst);
        }
        public void AddGlyph(ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
        {
            ImGuiNative.ImFont_AddGlyph(NativePtr, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
        }
        public void GrowIndex(int new_size)
        {
            ImGuiNative.ImFont_GrowIndex(NativePtr, new_size);
        }
        public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyphNoFallback(NativePtr, c);
            return new ImFontGlyphPtr(ret);
        }
        public bool IsLoaded()
        {
            byte ret = ImGuiNative.ImFont_IsLoaded(NativePtr);
            return ret != 0;
        }
        public float GetCharAdvance(ushort c)
        {
            float ret = ImGuiNative.ImFont_GetCharAdvance(NativePtr, c);
            return ret;
        }
        public void SetFallbackChar(ushort c)
        {
            ImGuiNative.ImFont_SetFallbackChar(NativePtr, c);
        }
        public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImFont_RenderChar(NativePtr, native_draw_list, size, pos, col, c);
        }
        public ImFontGlyphPtr FindGlyph(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyph(NativePtr, c);
            return new ImFontGlyphPtr(ret);
        }
        public string GetDebugName()
        {
            byte* ret = ImGuiNative.ImFont_GetDebugName(NativePtr);
            return Util.StringFromPtr(ret);
        }
        public void BuildLookupTable()
        {
            ImGuiNative.ImFont_BuildLookupTable(NativePtr);
        }
        public void ClearOutputData()
        {
            ImGuiNative.ImFont_ClearOutputData(NativePtr);
        }
    }
}
