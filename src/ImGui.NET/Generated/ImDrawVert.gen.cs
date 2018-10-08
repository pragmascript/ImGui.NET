using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawVert
    {
        public Vector2 pos;
        public Vector2 uv;
        public uint col;
    }
    public unsafe partial struct ImDrawVertPtr
    {
        public ImDrawVert* NativePtr { get; }
        public ImDrawVertPtr(ImDrawVert* nativePtr) { NativePtr = nativePtr; }
        public ImDrawVertPtr(IntPtr nativePtr) { NativePtr = (ImDrawVert*)nativePtr; }
        public static implicit operator ImDrawVertPtr(ImDrawVert* nativePtr) { return new ImDrawVertPtr(nativePtr); }
        public static implicit operator ImDrawVert* (ImDrawVertPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImDrawVertPtr(IntPtr nativePtr) { return new ImDrawVertPtr(nativePtr); }
        public Vector2* pos { get { return (Vector2*) &NativePtr->pos; } }
        public Vector2* uv { get { return (Vector2*) &NativePtr->uv; } }
        public uint* col { get { return (uint*) &NativePtr->col; } }
    }
}
