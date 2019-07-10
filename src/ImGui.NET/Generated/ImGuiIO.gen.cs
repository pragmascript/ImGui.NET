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
        public byte MouseDrawCursor;
        public byte ConfigMacOSXBehaviors;
        public byte ConfigInputTextCursorBlink;
        public byte ConfigWindowsResizeFromEdges;
        public byte ConfigWindowsMoveFromTitleBarOnly;
        public byte* BackendPlatformName;
        public byte* BackendRendererName;
        public void* BackendPlatformUserData;
        public void* BackendRendererUserData;
        public void* BackendLanguageUserData;
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
        public fixed float NavInputs[22];
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
        public fixed byte MouseDownWasDoubleClick[5];
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
        public fixed float NavInputsDownDuration[22];
        public fixed float NavInputsDownDurationPrev[22];
        public ImVector InputQueueCharacters;
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
        public bool* FontAllowUserScaling { get { return (bool*) &NativePtr->FontAllowUserScaling; } }
        public ImFontPtr FontDefault => new ImFontPtr(NativePtr->FontDefault);
        public Vector2* DisplayFramebufferScale { get { return (Vector2*) &NativePtr->DisplayFramebufferScale; } }
        public bool* MouseDrawCursor { get { return (bool*) &NativePtr->MouseDrawCursor; } }
        public bool* ConfigMacOSXBehaviors { get { return (bool*) &NativePtr->ConfigMacOSXBehaviors; } }
        public bool* ConfigInputTextCursorBlink { get { return (bool*) &NativePtr->ConfigInputTextCursorBlink; } }
        public bool* ConfigWindowsResizeFromEdges { get { return (bool*) &NativePtr->ConfigWindowsResizeFromEdges; } }
        public bool* ConfigWindowsMoveFromTitleBarOnly { get { return (bool*) &NativePtr->ConfigWindowsMoveFromTitleBarOnly; } }
        public NullTerminatedString BackendPlatformName => new NullTerminatedString(NativePtr->BackendPlatformName);
        public NullTerminatedString BackendRendererName => new NullTerminatedString(NativePtr->BackendRendererName);
        public IntPtr BackendPlatformUserData { get { return (IntPtr)NativePtr->BackendPlatformUserData; } set { NativePtr->BackendPlatformUserData = (void*)value; } }
        public IntPtr BackendRendererUserData { get { return (IntPtr)NativePtr->BackendRendererUserData; } set { NativePtr->BackendRendererUserData = (void*)value; } }
        public IntPtr BackendLanguageUserData { get { return (IntPtr)NativePtr->BackendLanguageUserData; } set { NativePtr->BackendLanguageUserData = (void*)value; } }
        public IntPtr* GetClipboardTextFn { get { return (IntPtr*) &NativePtr->GetClipboardTextFn; } }
        public IntPtr* SetClipboardTextFn { get { return (IntPtr*) &NativePtr->SetClipboardTextFn; } }
        public IntPtr ClipboardUserData { get { return (IntPtr)NativePtr->ClipboardUserData; } set { NativePtr->ClipboardUserData = (void*)value; } }
        public IntPtr* ImeSetInputScreenPosFn { get { return (IntPtr*) &NativePtr->ImeSetInputScreenPosFn; } }
        public IntPtr ImeWindowHandle { get { return (IntPtr)NativePtr->ImeWindowHandle; } set { NativePtr->ImeWindowHandle = (void*)value; } }
        public IntPtr RenderDrawListsFnUnused { get { return (IntPtr)NativePtr->RenderDrawListsFnUnused; } set { NativePtr->RenderDrawListsFnUnused = (void*)value; } }
        public Vector2* MousePos { get { return (Vector2*) &NativePtr->MousePos; } }
        public RangeAccessor<bool> MouseDown => new RangeAccessor<bool>(NativePtr->MouseDown, 5);
        public float* MouseWheel { get { return (float*) &NativePtr->MouseWheel; } }
        public float* MouseWheelH { get { return (float*) &NativePtr->MouseWheelH; } }
        public bool* KeyCtrl { get { return (bool*) &NativePtr->KeyCtrl; } }
        public bool* KeyShift { get { return (bool*) &NativePtr->KeyShift; } }
        public bool* KeyAlt { get { return (bool*) &NativePtr->KeyAlt; } }
        public bool* KeySuper { get { return (bool*) &NativePtr->KeySuper; } }
        public RangeAccessor<bool> KeysDown => new RangeAccessor<bool>(NativePtr->KeysDown, 512);
        public RangeAccessor<float> NavInputs => new RangeAccessor<float>(NativePtr->NavInputs, 22);
        public bool* WantCaptureMouse { get { return (bool*) &NativePtr->WantCaptureMouse; } }
        public bool* WantCaptureKeyboard { get { return (bool*) &NativePtr->WantCaptureKeyboard; } }
        public bool* WantTextInput { get { return (bool*) &NativePtr->WantTextInput; } }
        public bool* WantSetMousePos { get { return (bool*) &NativePtr->WantSetMousePos; } }
        public bool* WantSaveIniSettings { get { return (bool*) &NativePtr->WantSaveIniSettings; } }
        public bool* NavActive { get { return (bool*) &NativePtr->NavActive; } }
        public bool* NavVisible { get { return (bool*) &NativePtr->NavVisible; } }
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
        public RangeAccessor<bool> MouseClicked => new RangeAccessor<bool>(NativePtr->MouseClicked, 5);
        public RangeAccessor<bool> MouseDoubleClicked => new RangeAccessor<bool>(NativePtr->MouseDoubleClicked, 5);
        public RangeAccessor<bool> MouseReleased => new RangeAccessor<bool>(NativePtr->MouseReleased, 5);
        public RangeAccessor<bool> MouseDownOwned => new RangeAccessor<bool>(NativePtr->MouseDownOwned, 5);
        public RangeAccessor<bool> MouseDownWasDoubleClick => new RangeAccessor<bool>(NativePtr->MouseDownWasDoubleClick, 5);
        public RangeAccessor<float> MouseDownDuration => new RangeAccessor<float>(NativePtr->MouseDownDuration, 5);
        public RangeAccessor<float> MouseDownDurationPrev => new RangeAccessor<float>(NativePtr->MouseDownDurationPrev, 5);
        public RangeAccessor<Vector2> MouseDragMaxDistanceAbs => new RangeAccessor<Vector2>(&NativePtr->MouseDragMaxDistanceAbs_0, 5);
        public RangeAccessor<float> MouseDragMaxDistanceSqr => new RangeAccessor<float>(NativePtr->MouseDragMaxDistanceSqr, 5);
        public RangeAccessor<float> KeysDownDuration => new RangeAccessor<float>(NativePtr->KeysDownDuration, 512);
        public RangeAccessor<float> KeysDownDurationPrev => new RangeAccessor<float>(NativePtr->KeysDownDurationPrev, 512);
        public RangeAccessor<float> NavInputsDownDuration => new RangeAccessor<float>(NativePtr->NavInputsDownDuration, 22);
        public RangeAccessor<float> NavInputsDownDurationPrev => new RangeAccessor<float>(NativePtr->NavInputsDownDurationPrev, 22);
        public ImVector<ushort> InputQueueCharacters => new ImVector<ushort>(NativePtr->InputQueueCharacters);
        public void AddInputCharacter(ushort c)
        {
            ImGuiNative.ImGuiIO_AddInputCharacter(NativePtr, c);
        }
        public void AddInputCharactersUTF8(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            ImGuiNative.ImGuiIO_AddInputCharactersUTF8(NativePtr, native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
        }
        public void ClearInputCharacters()
        {
            ImGuiNative.ImGuiIO_ClearInputCharacters(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiIO_destroy(NativePtr);
        }
    }
}
