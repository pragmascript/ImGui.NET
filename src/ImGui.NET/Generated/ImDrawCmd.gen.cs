using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawCmd
    {
        public uint ElemCount;
        public Vector4 ClipRect;
        public IntPtr TextureId;
        public IntPtr UserCallback;
        public void* UserCallbackData;
    }
    public unsafe partial struct ImDrawCmdPtr
    {
        public ImDrawCmd* NativePtr { get; }
        public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
        public ImDrawCmdPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmd*)nativePtr;
        public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) => new ImDrawCmdPtr(nativePtr);
        public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawCmdPtr(IntPtr nativePtr) => new ImDrawCmdPtr(nativePtr);
        public uint* ElemCount => (uint*) &NativePtr->ElemCount;
        public Vector4* ClipRect => (Vector4*) &NativePtr->ClipRect;
        public IntPtr* TextureId => (IntPtr*) &NativePtr->TextureId;
        public IntPtr* UserCallback => (IntPtr*) &NativePtr->UserCallback;
        public IntPtr UserCallbackData { get => (IntPtr)NativePtr->UserCallbackData; set => NativePtr->UserCallbackData = (void*)value; }
    }
}
