using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawListSplitter
    {
        public int _Current;
        public int _Count;
        public ImVector _Channels;
    }
    public unsafe partial struct ImDrawListSplitterPtr
    {
        public ImDrawListSplitter* NativePtr { get; }
        public ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) { NativePtr = nativePtr; }
        public ImDrawListSplitterPtr(IntPtr nativePtr) { NativePtr = (ImDrawListSplitter*)nativePtr; }
        public static implicit operator ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) { return new ImDrawListSplitterPtr(nativePtr); }
        public static implicit operator ImDrawListSplitter* (ImDrawListSplitterPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImDrawListSplitterPtr(IntPtr nativePtr) { return new ImDrawListSplitterPtr(nativePtr); }
        public int* _Current { get { return (int*) &NativePtr->_Current; } }
        public int* _Count { get { return (int*) &NativePtr->_Count; } }
        public ImPtrVector<ImDrawChannelPtr> _Channels => new ImPtrVector<ImDrawChannelPtr>(NativePtr->_Channels, Unsafe.SizeOf<ImDrawChannel>());
        public void Clear()
        {
            ImGuiNative.ImDrawListSplitter_Clear(NativePtr);
        }
        public void ClearFreeMemory()
        {
            ImGuiNative.ImDrawListSplitter_ClearFreeMemory(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawListSplitter_destroy(NativePtr);
        }
        public void Merge(ImDrawListPtr draw_list)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImDrawListSplitter_Merge(NativePtr, native_draw_list);
        }
        public void SetCurrentChannel(ImDrawListPtr draw_list, int channel_idx)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImDrawListSplitter_SetCurrentChannel(NativePtr, native_draw_list, channel_idx);
        }
        public void Split(ImDrawListPtr draw_list, int count)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImDrawListSplitter_Split(NativePtr, native_draw_list, count);
        }
    }
}
