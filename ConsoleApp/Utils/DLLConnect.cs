using ConsoleApp.Types;
using System.Runtime.InteropServices;

namespace ConsoleApp.Utils
{
    public static class DLLConnect
    {
        // 참고: https://tttsss77.tistory.com/99

        [DllImport("MayBCppLib.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static double DLL_Sum(double a, double b);

        [DllImport("MayBCppLib.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static void DLL_UpdateTestStructure(ref TestStruct ts, int a, float b, string c);
    }
}
