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
        public uint VtxOffset;
        public uint IdxOffset;
        public IntPtr UserCallback;
        public void* UserCallbackData;
    }
    public unsafe partial struct ImDrawCmdPtr
    {
        public ImDrawCmd* NativePtr { get; }
        public ImDrawCmdPtr(ImDrawCmd* nativePtr) { NativePtr = nativePtr; }
        public ImDrawCmdPtr(IntPtr nativePtr) { NativePtr = (ImDrawCmd*)nativePtr; }
        public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) { return new ImDrawCmdPtr(nativePtr); }
        public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImDrawCmdPtr(IntPtr nativePtr) { return new ImDrawCmdPtr(nativePtr); }
        public uint* ElemCount { get { return (uint*) &NativePtr->ElemCount; } }
        public Vector4* ClipRect { get { return (Vector4*) &NativePtr->ClipRect; } }
        public IntPtr* TextureId { get { return (IntPtr*) &NativePtr->TextureId; } }
        public uint* VtxOffset { get { return (uint*) &NativePtr->VtxOffset; } }
        public uint* IdxOffset { get { return (uint*) &NativePtr->IdxOffset; } }
        public IntPtr* UserCallback { get { return (IntPtr*) &NativePtr->UserCallback; } }
        public IntPtr UserCallbackData { get { return (IntPtr)NativePtr->UserCallbackData; } set { NativePtr->UserCallbackData = (void*)value; } }
        public void Destroy()
        {
            ImGuiNative.ImDrawCmd_destroy(NativePtr);
        }
    }
}
