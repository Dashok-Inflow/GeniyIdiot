using System.IO;
using System.Text;

namespace ГенийИдиотClassLibrary1
{
    public class FileProvider
    {
        public static bool CheckFile(string fileName)
        {
            return File.Exists(fileName);
        }

        public static void Append(string fileName, string value)
        {
            using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                sw.WriteLine(value);
            }
        }

        public static void Replace(string fileName, string value)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.WriteLine(value);
            }
        }

        public static string GetValue(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                var value=sr.ReadToEnd();
                return value;
            }
        }

        public static void Clear(string fileName)
        {
            File.WriteAllText(fileName,string.Empty);
        }
    }
}