using ConsoleApp.Types;
using ConsoleApp.Utils;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = DLLConnect.DLL_Sum(2d, 4d);

            Console.WriteLine("The sum is " + sum.ToString());

            var ts = new TestStruct();
            DLLConnect.DLL_UpdateTestStructure(ref ts, 1, 2.3f, "Hello World!");

            Console.WriteLine(ts.ToString());

            TestClass tc = new TestClass();
            tc.a = 1;
            tc.b = 2.3f;
            tc.c = "Hello World!";

            var dirPath = "test\\path\\";
            var fileName = "test.txt";

            IFormatter fmtr = new BinaryFormatter();

            Stream writeStrm = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

            fmtr.Serialize(writeStrm, tc);
            writeStrm.Close();

            Stream readStrm = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var obj = (TestClass)fmtr.Deserialize(readStrm);
            readStrm.Close();

            Console.WriteLine(obj.ToString());

            FileHandler.WriteFile(dirPath, fileName, tc.ToString());
            var content = FileHandler.ReadFile(dirPath, fileName);

            Console.WriteLine(content);
        }
    }
}
