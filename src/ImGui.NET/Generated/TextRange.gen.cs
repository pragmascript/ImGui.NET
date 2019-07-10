using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct TextRange
    {
        public byte* b;
        public byte* e;
    }
    public unsafe partial struct TextRangePtr
    {
        public TextRange* NativePtr { get; }
        public TextRangePtr(TextRange* nativePtr) { NativePtr = nativePtr; }
        public TextRangePtr(IntPtr nativePtr) { NativePtr = (TextRange*)nativePtr; }
        public static implicit operator TextRangePtr(TextRange* nativePtr) { return new TextRangePtr(nativePtr); }
        public static implicit operator TextRange* (TextRangePtr wrappedPtr) { return wrappedPtr.NativePtr; }
        public static implicit operator TextRangePtr(IntPtr nativePtr) { return new TextRangePtr(nativePtr); }
        public IntPtr b { get { return (IntPtr)NativePtr->b; } set { NativePtr->b = (byte*)value; } }
        public IntPtr e { get { return (IntPtr)NativePtr->e; } set { NativePtr->e = (byte*)value; } }
        public string begin()
        {
            byte* ret = ImGuiNative.TextRange_begin(NativePtr);
            return Util.StringFromPtr(ret);
        }
        public void Destroy()
        {
            ImGuiNative.TextRange_destroy(NativePtr);
        }
        public bool empty()
        {
            byte ret = ImGuiNative.TextRange_empty(NativePtr);
            return ret != 0;
        }
        public string end()
        {
            byte* ret = ImGuiNative.TextRange_end(NativePtr);
            return Util.StringFromPtr(ret);
        }
        public void split(byte separator, out ImVector @out)
        {
            fixed (ImVector* native_out = &@out)
            {
                ImGuiNative.TextRange_split(NativePtr, separator, native_out);
            }
        }
    }
}
