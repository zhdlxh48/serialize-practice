using System.Runtime.InteropServices;

namespace ConsoleApp.Types
{
    public struct TestStruct
    {
        public int a;

        public float b;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string c;

        public override string ToString()
        {
            return $"a: {a}, b: {b}, c: {c}";
        }
    }
}
