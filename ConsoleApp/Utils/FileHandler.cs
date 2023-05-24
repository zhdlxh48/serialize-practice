using System.IO;

namespace ConsoleApp.Utils
{
    public static class FileHandler
    {
        public static string WriteFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
            return fileName;
        }

        public static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public static string WriteFile(string dirPath, string fileName, string content)
        {
            Directory.CreateDirectory(dirPath);
            return WriteFile(Path.Combine(dirPath, fileName), content);
        }

        public static string ReadFile(string dirPath, string fileName)
        {
            return ReadFile(Path.Combine(dirPath, fileName));
        }
    }
}
