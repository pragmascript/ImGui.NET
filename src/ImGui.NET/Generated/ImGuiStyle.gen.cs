using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStyle
    {
        public float Alpha;
        public Vector2 WindowPadding;
        public float WindowRounding;
        public float WindowBorderSize;
        public Vector2 WindowMinSize;
        public Vector2 WindowTitleAlign;
        public float ChildRounding;
        public float ChildBorderSize;
        public float PopupRounding;
        public float PopupBorderSize;
        public Vector2 FramePadding;
        public float FrameRounding;
        public float FrameBorderSize;
        public Vector2 ItemSpacing;
        public Vector2 ItemInnerSpacing;
        public Vector2 TouchExtraPadding;
        public float IndentSpacing;
        public float ColumnsMinSpacing;
        public float ScrollbarSize;
        public float ScrollbarRounding;
        public float GrabMinSize;
        public float GrabRounding;
        public Vector2 ButtonTextAlign;
        public Vector2 DisplayWindowPadding;
        public Vector2 DisplaySafeAreaPadding;
        public float MouseCursorScale;
        public byte AntiAliasedLines;
        public byte AntiAliasedFill;
        public float CurveTessellationTol;
        public Vector4 Colors_0;
        public Vector4 Colors_1;
        public Vector4 Colors_2;
        public Vector4 Colors_3;
        public Vector4 Colors_4;
        public Vector4 Colors_5;
        public Vector4 Colors_6;
        public Vector4 Colors_7;
        public Vector4 Colors_8;
        public Vector4 Colors_9;
        public Vector4 Colors_10;
        public Vector4 Colors_11;
        public Vector4 Colors_12;
        public Vector4 Colors_13;
        public Vector4 Colors_14;
        public Vector4 Colors_15;
        public Vector4 Colors_16;
        public Vector4 Colors_17;
        public Vector4 Colors_18;
        public Vector4 Colors_19;
        public Vector4 Colors_20;
        public Vector4 Colors_21;
        public Vector4 Colors_22;
        public Vector4 Colors_23;
        public Vector4 Colors_24;
        public Vector4 Colors_25;
        public Vector4 Colors_26;
        public Vector4 Colors_27;
        public Vector4 Colors_28;
        public Vector4 Colors_29;
        public Vector4 Colors_30;
        public Vector4 Colors_31;
        public Vector4 Colors_32;
        public Vector4 Colors_33;
        public Vector4 Colors_34;
        public Vector4 Colors_35;
        public Vector4 Colors_36;
        public Vector4 Colors_37;
        public Vector4 Colors_38;
        public Vector4 Colors_39;
        public Vector4 Colors_40;
        public Vector4 Colors_41;
        public Vector4 Colors_42;
    }
    public unsafe partial struct ImGuiStylePtr
    {
        public ImGuiStyle* NativePtr { get; }
        public ImGuiStylePtr(ImGuiStyle* nativePtr) => NativePtr = nativePtr;
        public ImGuiStylePtr(IntPtr nativePtr) => NativePtr = (ImGuiStyle*)nativePtr;
        public static implicit operator ImGuiStylePtr(ImGuiStyle* nativePtr) => new ImGuiStylePtr(nativePtr);
        public static implicit operator ImGuiStyle* (ImGuiStylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStylePtr(IntPtr nativePtr) => new ImGuiStylePtr(nativePtr);
        public float* Alpha => (float*) &NativePtr->Alpha;
        public Vector2* WindowPadding => (Vector2*) &NativePtr->WindowPadding;
        public float* WindowRounding => (float*) &NativePtr->WindowRounding;
        public float* WindowBorderSize => (float*) &NativePtr->WindowBorderSize;
        public Vector2* WindowMinSize => (Vector2*) &NativePtr->WindowMinSize;
        public Vector2* WindowTitleAlign => (Vector2*) &NativePtr->WindowTitleAlign;
        public float* ChildRounding => (float*) &NativePtr->ChildRounding;
        public float* ChildBorderSize => (float*) &NativePtr->ChildBorderSize;
        public float* PopupRounding => (float*) &NativePtr->PopupRounding;
        public float* PopupBorderSize => (float*) &NativePtr->PopupBorderSize;
        public Vector2* FramePadding => (Vector2*) &NativePtr->FramePadding;
        public float* FrameRounding => (float*) &NativePtr->FrameRounding;
        public float* FrameBorderSize => (float*) &NativePtr->FrameBorderSize;
        public Vector2* ItemSpacing => (Vector2*) &NativePtr->ItemSpacing;
        public Vector2* ItemInnerSpacing => (Vector2*) &NativePtr->ItemInnerSpacing;
        public Vector2* TouchExtraPadding => (Vector2*) &NativePtr->TouchExtraPadding;
        public float* IndentSpacing => (float*) &NativePtr->IndentSpacing;
        public float* ColumnsMinSpacing => (float*) &NativePtr->ColumnsMinSpacing;
        public float* ScrollbarSize => (float*) &NativePtr->ScrollbarSize;
        public float* ScrollbarRounding => (float*) &NativePtr->ScrollbarRounding;
        public float* GrabMinSize => (float*) &NativePtr->GrabMinSize;
        public float* GrabRounding => (float*) &NativePtr->GrabRounding;
        public Vector2* ButtonTextAlign => (Vector2*) &NativePtr->ButtonTextAlign;
        public Vector2* DisplayWindowPadding => (Vector2*) &NativePtr->DisplayWindowPadding;
        public Vector2* DisplaySafeAreaPadding => (Vector2*) &NativePtr->DisplaySafeAreaPadding;
        public float* MouseCursorScale => (float*) &NativePtr->MouseCursorScale;
        public Bool8* AntiAliasedLines => (Bool8*) &NativePtr->AntiAliasedLines;
        public Bool8* AntiAliasedFill => (Bool8*) &NativePtr->AntiAliasedFill;
        public float* CurveTessellationTol => (float*) &NativePtr->CurveTessellationTol;
        public RangeAccessor<Vector4> Colors => new RangeAccessor<Vector4>(&NativePtr->Colors_0, 43);
        public void ScaleAllSizes(float scale_factor)
        {
            ImGuiNative.ImGuiStyle_ScaleAllSizes(NativePtr, scale_factor);
        }
    }
}
