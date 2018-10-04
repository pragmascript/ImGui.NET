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
    }
    public unsafe partial struct ImDrawDataPtr
    {
        public ImDrawData* NativePtr { get; }
        public ImDrawDataPtr(ImDrawData* nativePtr) => NativePtr = nativePtr;
        public ImDrawDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawData*)nativePtr;
        public static implicit operator ImDrawDataPtr(ImDrawData* nativePtr) => new ImDrawDataPtr(nativePtr);
        public static implicit operator ImDrawData* (ImDrawDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawDataPtr(IntPtr nativePtr) => new ImDrawDataPtr(nativePtr);
        public Bool8* Valid => (Bool8*) &NativePtr->Valid;
        public IntPtr CmdLists { get => (IntPtr)NativePtr->CmdLists; set => NativePtr->CmdLists = (ImDrawList**)value; }
        public int* CmdListsCount => (int*) &NativePtr->CmdListsCount;
        public int* TotalIdxCount => (int*) &NativePtr->TotalIdxCount;
        public int* TotalVtxCount => (int*) &NativePtr->TotalVtxCount;
        public Vector2* DisplayPos => (Vector2*) &NativePtr->DisplayPos;
        public Vector2* DisplaySize => (Vector2*) &NativePtr->DisplaySize;
        public void ScaleClipRects(Vector2 sc)
        {
            ImGuiNative.ImDrawData_ScaleClipRects(NativePtr, sc);
        }
        public void DeIndexAllBuffers()
        {
            ImGuiNative.ImDrawData_DeIndexAllBuffers(NativePtr);
        }
        public void Clear()
        {
            ImGuiNative.ImDrawData_Clear(NativePtr);
        }
    }
}
