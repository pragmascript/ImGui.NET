using System.Runtime.InteropServices;

namespace ImGuiNET {
#if false
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vector4 {
        public static Vector4 Zero { get { return new Vector4(0.0f, 0.0f, 0.0f, 0.0f); } }
        public float X;
        public float Y;
        public float Z;
        public float W;
        public Vector4(float x, float y, float z, float w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vector3 {
        public static Vector3 Zero { get { return new Vector3(0.0f, 0.0f, 0.0f); } }
        public float X;
        public float Y;
        public float Z;
        public Vector3(float x, float y, float z) {
            X = x;
            Y = y;
            Z = z;
        }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vector2 {
        public static Vector2 Zero { get { return new Vector2(0.0f, 0.0f); } }
        public float X;
        public float Y;
        public Vector2(float x, float y) {
            X = x;
            Y = y;
        }
    }
#endif
}


