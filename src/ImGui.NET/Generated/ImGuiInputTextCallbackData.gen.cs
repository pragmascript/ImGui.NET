using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiInputTextCallbackData
    {
        public ImGuiInputTextFlags EventFlag;
        public ImGuiInputTextFlags Flags;
        public void* UserData;
        public ushort EventChar;
        public ImGuiKey EventKey;
        public byte* Buf;
        public int BufTextLen;
        public int BufSize;
        public byte BufDirty;
        public int CursorPos;
        public int SelectionStart;
        public int SelectionEnd;
    }
    public unsafe partial struct ImGuiInputTextCallbackDataPtr
    {
        public ImGuiInputTextCallbackData* NativePtr { get; }
        public ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) { NativePtr = nativePtr; }
        public ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) { NativePtr = (ImGuiInputTextCallbackData*)nativePtr; }
        public static implicit operator ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) { return new ImGuiInputTextCallbackDataPtr(nativePtr); }
        public static implicit operator ImGuiInputTextCallbackData* (ImGuiInputTextCallbackDataPtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) { return new ImGuiInputTextCallbackDataPtr(nativePtr); }
        public ImGuiInputTextFlags* EventFlag { get { return (ImGuiInputTextFlags*) &NativePtr->EventFlag; } }
        public ImGuiInputTextFlags* Flags { get { return (ImGuiInputTextFlags*) &NativePtr->Flags; } }
        public IntPtr UserData { get { return (IntPtr)NativePtr->UserData; } set { NativePtr->UserData = (void*)value; } }
        public ushort* EventChar { get { return (ushort*) &NativePtr->EventChar; } }
        public ImGuiKey* EventKey { get { return (ImGuiKey*) &NativePtr->EventKey; } }
        public IntPtr Buf { get { return (IntPtr)NativePtr->Buf; } set { NativePtr->Buf = (byte*)value; } }
        public int* BufTextLen { get { return (int*) &NativePtr->BufTextLen; } }
        public int* BufSize { get { return (int*) &NativePtr->BufSize; } }
        public Bool8* BufDirty { get { return (Bool8*) &NativePtr->BufDirty; } }
        public int* CursorPos { get { return (int*) &NativePtr->CursorPos; } }
        public int* SelectionStart { get { return (int*) &NativePtr->SelectionStart; } }
        public int* SelectionEnd { get { return (int*) &NativePtr->SelectionEnd; } }
        public void DeleteChars(int pos, int bytes_count)
        {
            ImGuiNative.ImGuiInputTextCallbackData_DeleteChars(NativePtr, pos, bytes_count);
        }
        public bool HasSelection()
        {
            byte ret = ImGuiNative.ImGuiInputTextCallbackData_HasSelection(NativePtr);
            return ret != 0;
        }
        public void InsertChars(int pos, string text)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            byte* native_text_end = null;
            ImGuiNative.ImGuiInputTextCallbackData_InsertChars(NativePtr, pos, native_text, native_text_end);
        }
    }
}
