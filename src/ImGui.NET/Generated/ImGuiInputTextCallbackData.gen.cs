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
        public ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextCallbackData*)nativePtr;
        public static implicit operator ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => new ImGuiInputTextCallbackDataPtr(nativePtr);
        public static implicit operator ImGuiInputTextCallbackData* (ImGuiInputTextCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => new ImGuiInputTextCallbackDataPtr(nativePtr);
        public ImGuiInputTextFlags* EventFlag => (ImGuiInputTextFlags*) &NativePtr->EventFlag;
        public ImGuiInputTextFlags* Flags => (ImGuiInputTextFlags*) &NativePtr->Flags;
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ushort* EventChar => (ushort*) &NativePtr->EventChar;
        public ImGuiKey* EventKey => (ImGuiKey*) &NativePtr->EventKey;
        public IntPtr Buf { get => (IntPtr)NativePtr->Buf; set => NativePtr->Buf = (byte*)value; }
        public int* BufTextLen => (int*) &NativePtr->BufTextLen;
        public int* BufSize => (int*) &NativePtr->BufSize;
        public Bool8* BufDirty => (Bool8*) &NativePtr->BufDirty;
        public int* CursorPos => (int*) &NativePtr->CursorPos;
        public int* SelectionStart => (int*) &NativePtr->SelectionStart;
        public int* SelectionEnd => (int*) &NativePtr->SelectionEnd;
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
        public void InsertChars(int pos, string text, string text_end)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            ImGuiNative.ImGuiInputTextCallbackData_InsertChars(NativePtr, pos, native_text, native_text_end);
        }
    }
}
