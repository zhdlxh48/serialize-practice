using System;
using System.Runtime.InteropServices;

namespace MayBLib
{
    public class TestClass
    {
        [DllImport("MayBCppLib.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static double DLL_Sum(double a, double b);
    }
}
