using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiPayload
    {
        public void* Data;
        public int DataSize;
        public uint SourceId;
        public uint SourceParentId;
        public int DataFrameCount;
        public fixed byte DataType[33];
        public byte Preview;
        public byte Delivery;
    }
    public unsafe partial struct ImGuiPayloadPtr
    {
        public ImGuiPayload* NativePtr { get; }
        public ImGuiPayloadPtr(ImGuiPayload* nativePtr) => NativePtr = nativePtr;
        public ImGuiPayloadPtr(IntPtr nativePtr) => NativePtr = (ImGuiPayload*)nativePtr;
        public static implicit operator ImGuiPayloadPtr(ImGuiPayload* nativePtr) => new ImGuiPayloadPtr(nativePtr);
        public static implicit operator ImGuiPayload* (ImGuiPayloadPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiPayloadPtr(IntPtr nativePtr) => new ImGuiPayloadPtr(nativePtr);
        public IntPtr Data { get => (IntPtr)NativePtr->Data; set => NativePtr->Data = (void*)value; }
        public int* DataSize => (int*) &NativePtr->DataSize;
        public uint* SourceId => (uint*) &NativePtr->SourceId;
        public uint* SourceParentId => (uint*) &NativePtr->SourceParentId;
        public int* DataFrameCount => (int*) &NativePtr->DataFrameCount;
        public RangeAccessor<byte> DataType => new RangeAccessor<byte>(NativePtr->DataType, 33);
        public Bool8* Preview => (Bool8*) &NativePtr->Preview;
        public Bool8* Delivery => (Bool8*) &NativePtr->Delivery;
        public void Clear()
        {
            ImGuiNative.ImGuiPayload_Clear(NativePtr);
        }
        public bool IsPreview()
        {
            byte ret = ImGuiNative.ImGuiPayload_IsPreview(NativePtr);
            return ret != 0;
        }
        public bool IsDataType(string type)
        {
            int type_byteCount = Encoding.UTF8.GetByteCount(type);
            byte* native_type = stackalloc byte[type_byteCount + 1];
            fixed (char* type_ptr = type)
            {
                int native_type_offset = Encoding.UTF8.GetBytes(type_ptr, type.Length, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            byte ret = ImGuiNative.ImGuiPayload_IsDataType(NativePtr, native_type);
            return ret != 0;
        }
        public bool IsDelivery()
        {
            byte ret = ImGuiNative.ImGuiPayload_IsDelivery(NativePtr);
            return ret != 0;
        }
    }
}
