using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiIO
    {
        public ImGuiConfigFlags ConfigFlags;
        public ImGuiBackendFlags BackendFlags;
        public Vector2 DisplaySize;
        public float DeltaTime;
        public float IniSavingRate;
        public byte* IniFilename;
        public byte* LogFilename;
        public float MouseDoubleClickTime;
        public float MouseDoubleClickMaxDist;
        public float MouseDragThreshold;
        public fixed int KeyMap[21];
        public float KeyRepeatDelay;
        public float KeyRepeatRate;
        public void* UserData;
        public ImFontAtlas* Fonts;
        public float FontGlobalScale;
        public byte FontAllowUserScaling;
        public ImFont* FontDefault;
        public Vector2 DisplayFramebufferScale;
        public Vector2 DisplayVisibleMin;
        public Vector2 DisplayVisibleMax;
        public byte MouseDrawCursor;
        public byte ConfigMacOSXBehaviors;
        public byte ConfigInputTextCursorBlink;
        public byte ConfigResizeWindowsFromEdges;
        public IntPtr GetClipboardTextFn;
        public IntPtr SetClipboardTextFn;
        public void* ClipboardUserData;
        public IntPtr ImeSetInputScreenPosFn;
        public void* ImeWindowHandle;
        public void* RenderDrawListsFnUnused;
        public Vector2 MousePos;
        public fixed byte MouseDown[5];
        public float MouseWheel;
        public float MouseWheelH;
        public byte KeyCtrl;
        public byte KeyShift;
        public byte KeyAlt;
        public byte KeySuper;
        public fixed byte KeysDown[512];
        public fixed ushort InputCharacters[17];
        public fixed float NavInputs[21];
        public byte WantCaptureMouse;
        public byte WantCaptureKeyboard;
        public byte WantTextInput;
        public byte WantSetMousePos;
        public byte WantSaveIniSettings;
        public byte NavActive;
        public byte NavVisible;
        public float Framerate;
        public int MetricsRenderVertices;
        public int MetricsRenderIndices;
        public int MetricsRenderWindows;
        public int MetricsActiveWindows;
        public int MetricsActiveAllocations;
        public Vector2 MouseDelta;
        public Vector2 MousePosPrev;
        public Vector2 MouseClickedPos_0;
        public Vector2 MouseClickedPos_1;
        public Vector2 MouseClickedPos_2;
        public Vector2 MouseClickedPos_3;
        public Vector2 MouseClickedPos_4;
        public fixed double MouseClickedTime[5];
        public fixed byte MouseClicked[5];
        public fixed byte MouseDoubleClicked[5];
        public fixed byte MouseReleased[5];
        public fixed byte MouseDownOwned[5];
        public fixed float MouseDownDuration[5];
        public fixed float MouseDownDurationPrev[5];
        public Vector2 MouseDragMaxDistanceAbs_0;
        public Vector2 MouseDragMaxDistanceAbs_1;
        public Vector2 MouseDragMaxDistanceAbs_2;
        public Vector2 MouseDragMaxDistanceAbs_3;
        public Vector2 MouseDragMaxDistanceAbs_4;
        public fixed float MouseDragMaxDistanceSqr[5];
        public fixed float KeysDownDuration[512];
        public fixed float KeysDownDurationPrev[512];
        public fixed float NavInputsDownDuration[21];
        public fixed float NavInputsDownDurationPrev[21];
    }
    public unsafe partial struct ImGuiIOPtr
    {
        public ImGuiIO* NativePtr { get; }
        public ImGuiIOPtr(ImGuiIO* nativePtr) { NativePtr = nativePtr; }
        public ImGuiIOPtr(IntPtr nativePtr) { NativePtr = (ImGuiIO*)nativePtr; }
        public static implicit operator ImGuiIOPtr(ImGuiIO* nativePtr) { return new ImGuiIOPtr(nativePtr); }
        public static implicit operator ImGuiIO* (ImGuiIOPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImGuiIOPtr(IntPtr nativePtr) { return new ImGuiIOPtr(nativePtr); }
        public ImGuiConfigFlags* ConfigFlags { get { return (ImGuiConfigFlags*) &NativePtr->ConfigFlags; } }
        public ImGuiBackendFlags* BackendFlags { get { return (ImGuiBackendFlags*) &NativePtr->BackendFlags; } }
        public Vector2* DisplaySize { get { return (Vector2*) &NativePtr->DisplaySize; } }
        public float* DeltaTime { get { return (float*) &NativePtr->DeltaTime; } }
        public float* IniSavingRate { get { return (float*) &NativePtr->IniSavingRate; } }
        public NullTerminatedString IniFilename => new NullTerminatedString(NativePtr->IniFilename);
        public NullTerminatedString LogFilename => new NullTerminatedString(NativePtr->LogFilename);
        public float* MouseDoubleClickTime { get { return (float*) &NativePtr->MouseDoubleClickTime; } }
        public float* MouseDoubleClickMaxDist { get { return (float*) &NativePtr->MouseDoubleClickMaxDist; } }
        public float* MouseDragThreshold { get { return (float*) &NativePtr->MouseDragThreshold; } }
        public RangeAccessor<int> KeyMap => new RangeAccessor<int>(NativePtr->KeyMap, 21);
        public float* KeyRepeatDelay { get { return (float*) &NativePtr->KeyRepeatDelay; } }
        public float* KeyRepeatRate { get { return (float*) &NativePtr->KeyRepeatRate; } }
        public IntPtr UserData { get { return (IntPtr)NativePtr->UserData; } set { NativePtr->UserData = (void*)value; } }
        public ImFontAtlasPtr Fonts => new ImFontAtlasPtr(NativePtr->Fonts);
        public float* FontGlobalScale { get { return (float*) &NativePtr->FontGlobalScale; } }
        public Bool8* FontAllowUserScaling { get { return (Bool8*) &NativePtr->FontAllowUserScaling; } }
        public ImFontPtr FontDefault => new ImFontPtr(NativePtr->FontDefault);
        public Vector2* DisplayFramebufferScale { get { return (Vector2*) &NativePtr->DisplayFramebufferScale; } }
        public Vector2* DisplayVisibleMin { get { return (Vector2*) &NativePtr->DisplayVisibleMin; } }
        public Vector2* DisplayVisibleMax { get { return (Vector2*) &NativePtr->DisplayVisibleMax; } }
        public Bool8* MouseDrawCursor { get { return (Bool8*) &NativePtr->MouseDrawCursor; } }
        public Bool8* ConfigMacOSXBehaviors { get { return (Bool8*) &NativePtr->ConfigMacOSXBehaviors; } }
        public Bool8* ConfigInputTextCursorBlink { get { return (Bool8*) &NativePtr->ConfigInputTextCursorBlink; } }
        public Bool8* ConfigResizeWindowsFromEdges { get { return (Bool8*) &NativePtr->ConfigResizeWindowsFromEdges; } }
        public IntPtr* GetClipboardTextFn { get { return (IntPtr*) &NativePtr->GetClipboardTextFn; } }
        public IntPtr* SetClipboardTextFn { get { return (IntPtr*) &NativePtr->SetClipboardTextFn; } }
        public IntPtr ClipboardUserData { get { return (IntPtr)NativePtr->ClipboardUserData; } set { NativePtr->ClipboardUserData = (void*)value; } }
        public IntPtr* ImeSetInputScreenPosFn { get { return (IntPtr*) &NativePtr->ImeSetInputScreenPosFn; } }
        public IntPtr ImeWindowHandle { get { return (IntPtr)NativePtr->ImeWindowHandle; } set { NativePtr->ImeWindowHandle = (void*)value; } }
        public IntPtr RenderDrawListsFnUnused { get { return (IntPtr)NativePtr->RenderDrawListsFnUnused; } set { NativePtr->RenderDrawListsFnUnused = (void*)value; } }
        public Vector2* MousePos { get { return (Vector2*) &NativePtr->MousePos; } }
        public RangeAccessor<Bool8> MouseDown => new RangeAccessor<Bool8>(NativePtr->MouseDown, 5);
        public float* MouseWheel { get { return (float*) &NativePtr->MouseWheel; } }
        public float* MouseWheelH { get { return (float*) &NativePtr->MouseWheelH; } }
        public Bool8* KeyCtrl { get { return (Bool8*) &NativePtr->KeyCtrl; } }
        public Bool8* KeyShift { get { return (Bool8*) &NativePtr->KeyShift; } }
        public Bool8* KeyAlt { get { return (Bool8*) &NativePtr->KeyAlt; } }
        public Bool8* KeySuper { get { return (Bool8*) &NativePtr->KeySuper; } }
        public RangeAccessor<Bool8> KeysDown => new RangeAccessor<Bool8>(NativePtr->KeysDown, 512);
        public RangeAccessor<ushort> InputCharacters => new RangeAccessor<ushort>(NativePtr->InputCharacters, 17);
        public RangeAccessor<float> NavInputs => new RangeAccessor<float>(NativePtr->NavInputs, 21);
        public Bool8* WantCaptureMouse { get { return (Bool8*) &NativePtr->WantCaptureMouse; } }
        public Bool8* WantCaptureKeyboard { get { return (Bool8*) &NativePtr->WantCaptureKeyboard; } }
        public Bool8* WantTextInput { get { return (Bool8*) &NativePtr->WantTextInput; } }
        public Bool8* WantSetMousePos { get { return (Bool8*) &NativePtr->WantSetMousePos; } }
        public Bool8* WantSaveIniSettings { get { return (Bool8*) &NativePtr->WantSaveIniSettings; } }
        public Bool8* NavActive { get { return (Bool8*) &NativePtr->NavActive; } }
        public Bool8* NavVisible { get { return (Bool8*) &NativePtr->NavVisible; } }
        public float* Framerate { get { return (float*) &NativePtr->Framerate; } }
        public int* MetricsRenderVertices { get { return (int*) &NativePtr->MetricsRenderVertices; } }
        public int* MetricsRenderIndices { get { return (int*) &NativePtr->MetricsRenderIndices; } }
        public int* MetricsRenderWindows { get { return (int*) &NativePtr->MetricsRenderWindows; } }
        public int* MetricsActiveWindows { get { return (int*) &NativePtr->MetricsActiveWindows; } }
        public int* MetricsActiveAllocations { get { return (int*) &NativePtr->MetricsActiveAllocations; } }
        public Vector2* MouseDelta { get { return (Vector2*) &NativePtr->MouseDelta; } }
        public Vector2* MousePosPrev { get { return (Vector2*) &NativePtr->MousePosPrev; } }
        public RangeAccessor<Vector2> MouseClickedPos => new RangeAccessor<Vector2>(&NativePtr->MouseClickedPos_0, 5);
        public RangeAccessor<double> MouseClickedTime => new RangeAccessor<double>(NativePtr->MouseClickedTime, 5);
        public RangeAccessor<Bool8> MouseClicked => new RangeAccessor<Bool8>(NativePtr->MouseClicked, 5);
        public RangeAccessor<Bool8> MouseDoubleClicked => new RangeAccessor<Bool8>(NativePtr->MouseDoubleClicked, 5);
        public RangeAccessor<Bool8> MouseReleased => new RangeAccessor<Bool8>(NativePtr->MouseReleased, 5);
        public RangeAccessor<Bool8> MouseDownOwned => new RangeAccessor<Bool8>(NativePtr->MouseDownOwned, 5);
        public RangeAccessor<float> MouseDownDuration => new RangeAccessor<float>(NativePtr->MouseDownDuration, 5);
        public RangeAccessor<float> MouseDownDurationPrev => new RangeAccessor<float>(NativePtr->MouseDownDurationPrev, 5);
        public RangeAccessor<Vector2> MouseDragMaxDistanceAbs => new RangeAccessor<Vector2>(&NativePtr->MouseDragMaxDistanceAbs_0, 5);
        public RangeAccessor<float> MouseDragMaxDistanceSqr => new RangeAccessor<float>(NativePtr->MouseDragMaxDistanceSqr, 5);
        public RangeAccessor<float> KeysDownDuration => new RangeAccessor<float>(NativePtr->KeysDownDuration, 512);
        public RangeAccessor<float> KeysDownDurationPrev => new RangeAccessor<float>(NativePtr->KeysDownDurationPrev, 512);
        public RangeAccessor<float> NavInputsDownDuration => new RangeAccessor<float>(NativePtr->NavInputsDownDuration, 21);
        public RangeAccessor<float> NavInputsDownDurationPrev => new RangeAccessor<float>(NativePtr->NavInputsDownDurationPrev, 21);
        public void AddInputCharactersUTF8(string utf8_chars)
        {
            int utf8_chars_byteCount = Encoding.UTF8.GetByteCount(utf8_chars);
            byte* native_utf8_chars = stackalloc byte[utf8_chars_byteCount + 1];
            fixed (char* utf8_chars_ptr = utf8_chars)
            {
                int native_utf8_chars_offset = Encoding.UTF8.GetBytes(utf8_chars_ptr, utf8_chars.Length, native_utf8_chars, utf8_chars_byteCount);
                native_utf8_chars[native_utf8_chars_offset] = 0;
            }
            ImGuiNative.ImGuiIO_AddInputCharactersUTF8(NativePtr, native_utf8_chars);
        }
        public void ClearInputCharacters()
        {
            ImGuiNative.ImGuiIO_ClearInputCharacters(NativePtr);
        }
        public void AddInputCharacter(ushort c)
        {
            ImGuiNative.ImGuiIO_AddInputCharacter(NativePtr, c);
        }
    }
}
