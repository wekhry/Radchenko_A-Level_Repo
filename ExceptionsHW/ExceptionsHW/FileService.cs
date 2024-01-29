using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHW
{
    internal class FileService
    {
        private string logDirectory = "logs";
        public void WriteToFile(string fileName, string content)
        {
            string directory = logDirectory;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string filePath = Path.Combine(directory, fileName);
            File.WriteAllText(filePath, content);

            CleanUpOldFiles(directory);
        }
        private void CleanUpOldFiles(string directory)
        {
            DirectoryInfo di = new DirectoryInfo(directory);
            FileInfo[] files = di.GetFiles("*.txt");
            if (files.Length > 3)
            {
                Array.Sort(files, (x, y) => DateTime.Compare(x.CreationTime, y.CreationTime));
                for (int i = 0; i < files.Length - 3; i++)
                {
                    files[i].Delete();
                }
            }
        }
    }
}
