using System.IO;
using System;

namespace ConsoleApplication1
{
    public class FileHandling
    {
        public string BasePath { get;  }
        public string FilePath { get; }

        public FileHandling()
        {
            BasePath = Path.GetFullPath(".");
            FilePath = Path.Combine(BasePath, "history.txt");
            
            Console.WriteLine("File path: " + FilePath);
        }
        
        public string ReadHistory()
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                var content = reader.ReadToEnd();
                return content;
            }
        }
        
        public void WriteHistory(string[] history)
        {
            var content = string.Join(",", history);
            File.WriteAllText(FilePath, content);
        }
    }
}