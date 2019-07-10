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
        public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) { NativePtr = nativePtr; }
        public ImGuiListClipperPtr(IntPtr nativePtr) { NativePtr = (ImGuiListClipper*)nativePtr; }
        public static implicit operator ImGuiListClipperPtr(ImGuiListClipper* nativePtr) { return new ImGuiListClipperPtr(nativePtr); }
        public static implicit operator ImGuiListClipper* (ImGuiListClipperPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImGuiListClipperPtr(IntPtr nativePtr) { return new ImGuiListClipperPtr(nativePtr); }
        public float* StartPosY { get { return (float*) &NativePtr->StartPosY; } }
        public float* ItemsHeight { get { return (float*) &NativePtr->ItemsHeight; } }
        public int* ItemsCount { get { return (int*) &NativePtr->ItemsCount; } }
        public int* StepNo { get { return (int*) &NativePtr->StepNo; } }
        public int* DisplayStart { get { return (int*) &NativePtr->DisplayStart; } }
        public int* DisplayEnd { get { return (int*) &NativePtr->DisplayEnd; } }
        public void Begin(int items_count)
        {
            float items_height = -1.0f;
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public void Begin(int items_count, float items_height)
        {
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiListClipper_destroy(NativePtr);
        }
        public void End()
        {
            ImGuiNative.ImGuiListClipper_End(NativePtr);
        }
        public bool Step()
        {
            byte ret = ImGuiNative.ImGuiListClipper_Step(NativePtr);
            return ret != 0;
        }
    }
}
