using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawData
    {
        public byte Valid;
        public ImDrawList** CmdLists;
        public int CmdListsCount;
        public int TotalIdxCount;
        public int TotalVtxCount;
        public Vector2 DisplayPos;
        public Vector2 DisplaySize;
        public Vector2 FramebufferScale;
    }
    public unsafe partial struct ImDrawDataPtr
    {
        public ImDrawData* NativePtr { get; }
        public ImDrawDataPtr(ImDrawData* nativePtr) { NativePtr = nativePtr; }
        public ImDrawDataPtr(IntPtr nativePtr) { NativePtr = (ImDrawData*)nativePtr; }
        public static implicit operator ImDrawDataPtr(ImDrawData* nativePtr) { return new ImDrawDataPtr(nativePtr); }
        public static implicit operator ImDrawData* (ImDrawDataPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImDrawDataPtr(IntPtr nativePtr) { return new ImDrawDataPtr(nativePtr); }
        public bool* Valid { get { return (bool*) &NativePtr->Valid; } }
        public IntPtr CmdLists { get { return (IntPtr)NativePtr->CmdLists; } set { NativePtr->CmdLists = (ImDrawList**)value; } }
        public int* CmdListsCount { get { return (int*) &NativePtr->CmdListsCount; } }
        public int* TotalIdxCount { get { return (int*) &NativePtr->TotalIdxCount; } }
        public int* TotalVtxCount { get { return (int*) &NativePtr->TotalVtxCount; } }
        public Vector2* DisplayPos { get { return (Vector2*) &NativePtr->DisplayPos; } }
        public Vector2* DisplaySize { get { return (Vector2*) &NativePtr->DisplaySize; } }
        public Vector2* FramebufferScale { get { return (Vector2*) &NativePtr->FramebufferScale; } }
        public void Clear()
        {
            ImGuiNative.ImDrawData_Clear(NativePtr);
        }
        public void DeIndexAllBuffers()
        {
            ImGuiNative.ImDrawData_DeIndexAllBuffers(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawData_destroy(NativePtr);
        }
        public void ScaleClipRects(Vector2 fb_scale)
        {
            ImGuiNative.ImDrawData_ScaleClipRects(NativePtr, fb_scale);
        }
    }
}
