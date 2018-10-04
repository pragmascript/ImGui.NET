using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiListClipper
    {
        public float StartPosY;
        public float ItemsHeight;
        public int ItemsCount;
        public int StepNo;
        public int DisplayStart;
        public int DisplayEnd;
    }
    public unsafe partial struct ImGuiListClipperPtr
    {
        public ImGuiListClipper* NativePtr { get; }
        public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => NativePtr = nativePtr;
        public ImGuiListClipperPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipper*)nativePtr;
        public static implicit operator ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => new ImGuiListClipperPtr(nativePtr);
        public static implicit operator ImGuiListClipper* (ImGuiListClipperPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiListClipperPtr(IntPtr nativePtr) => new ImGuiListClipperPtr(nativePtr);
        public float* StartPosY => (float*) &NativePtr->StartPosY;
        public float* ItemsHeight => (float*) &NativePtr->ItemsHeight;
        public int* ItemsCount => (int*) &NativePtr->ItemsCount;
        public int* StepNo => (int*) &NativePtr->StepNo;
        public int* DisplayStart => (int*) &NativePtr->DisplayStart;
        public int* DisplayEnd => (int*) &NativePtr->DisplayEnd;
        public void End()
        {
            ImGuiNative.ImGuiListClipper_End(NativePtr);
        }
        public void Begin(int items_count)
        {
            float items_height = -1.0f;
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public void Begin(int items_count, float items_height)
        {
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public bool Step()
        {
            byte ret = ImGuiNative.ImGuiListClipper_Step(NativePtr);
            return ret != 0;
        }
    }
}
