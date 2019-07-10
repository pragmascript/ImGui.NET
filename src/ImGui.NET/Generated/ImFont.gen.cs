using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFont
    {
        public ImVector IndexAdvanceX;
        public float FallbackAdvanceX;
        public float FontSize;
        public ImVector IndexLookup;
        public ImVector Glyphs;
        public ImFontGlyph* FallbackGlyph;
        public Vector2 DisplayOffset;
        public ImFontAtlas* ContainerAtlas;
        public ImFontConfig* ConfigData;
        public short ConfigDataCount;
        public ushort FallbackChar;
        public float Scale;
        public float Ascent;
        public float Descent;
        public int MetricsTotalSurface;
        public byte DirtyLookupTables;
    }
    public unsafe partial struct ImFontPtr
    {
        public ImFont* NativePtr { get; }
        public ImFontPtr(ImFont* nativePtr) { NativePtr = nativePtr; }
        public ImFontPtr(IntPtr nativePtr) { NativePtr = (ImFont*)nativePtr; }
        public static implicit operator ImFontPtr(ImFont* nativePtr) { return new ImFontPtr(nativePtr); }
        public static implicit operator ImFont* (ImFontPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImFontPtr(IntPtr nativePtr) { return new ImFontPtr(nativePtr); }
        public ImVector<float> IndexAdvanceX => new ImVector<float>(NativePtr->IndexAdvanceX);
        public float* FallbackAdvanceX { get { return (float*) &NativePtr->FallbackAdvanceX; } }
        public float* FontSize { get { return (float*) &NativePtr->FontSize; } }
        public ImVector<ushort> IndexLookup => new ImVector<ushort>(NativePtr->IndexLookup);
        public ImPtrVector<ImFontGlyphPtr> Glyphs => new ImPtrVector<ImFontGlyphPtr>(NativePtr->Glyphs, Unsafe.SizeOf<ImFontGlyph>());
        public ImFontGlyphPtr FallbackGlyph => new ImFontGlyphPtr(NativePtr->FallbackGlyph);
        public Vector2* DisplayOffset { get { return (Vector2*) &NativePtr->DisplayOffset; } }
        public ImFontAtlasPtr ContainerAtlas => new ImFontAtlasPtr(NativePtr->ContainerAtlas);
        public ImFontConfigPtr ConfigData => new ImFontConfigPtr(NativePtr->ConfigData);
        public short* ConfigDataCount { get { return (short*) &NativePtr->ConfigDataCount; } }
        public ushort* FallbackChar { get { return (ushort*) &NativePtr->FallbackChar; } }
        public float* Scale { get { return (float*) &NativePtr->Scale; } }
        public float* Ascent { get { return (float*) &NativePtr->Ascent; } }
        public float* Descent { get { return (float*) &NativePtr->Descent; } }
        public int* MetricsTotalSurface { get { return (int*) &NativePtr->MetricsTotalSurface; } }
        public bool* DirtyLookupTables { get { return (bool*) &NativePtr->DirtyLookupTables; } }
        public void AddGlyph(ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
        {
            ImGuiNative.ImFont_AddGlyph(NativePtr, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
        }
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
        public void BuildLookupTable()
        {
            ImGuiNative.ImFont_BuildLookupTable(NativePtr);
        }
        public void ClearOutputData()
        {
            ImGuiNative.ImFont_ClearOutputData(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImFont_destroy(NativePtr);
        }
        public ImFontGlyphPtr FindGlyph(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyph(NativePtr, c);
            return new ImFontGlyphPtr(ret);
        }
        public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
        {
            ImFontGlyph* ret = ImGuiNative.ImFont_FindGlyphNoFallback(NativePtr, c);
            return new ImFontGlyphPtr(ret);
        }
        public float GetCharAdvance(ushort c)
        {
            float ret = ImGuiNative.ImFont_GetCharAdvance(NativePtr, c);
            return ret;
        }
        public string GetDebugName()
        {
            byte* ret = ImGuiNative.ImFont_GetDebugName(NativePtr);
            return Util.StringFromPtr(ret);
        }
        public void GrowIndex(int new_size)
        {
            ImGuiNative.ImFont_GrowIndex(NativePtr, new_size);
        }
        public bool IsLoaded()
        {
            byte ret = ImGuiNative.ImFont_IsLoaded(NativePtr);
            return ret != 0;
        }
        public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImFont_RenderChar(NativePtr, native_draw_list, size, pos, col, c);
        }
        public void SetFallbackChar(ushort c)
        {
            ImGuiNative.ImFont_SetFallbackChar(NativePtr, c);
        }
    }
}
