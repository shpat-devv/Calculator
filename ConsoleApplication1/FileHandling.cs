using System.IO;

namespace ConsoleApplication1
{
    public class FileHandling
    {
        private string BasePath { get;  }
        private string FilePath { get; }

        public FileHandling()
        {
            BasePath = Path.GetFullPath(".");
            FilePath = Path.Combine(BasePath, "history.txt");
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
            var content = string.Join(",", history); //Join array of strings into single string separated by commas
            File.WriteAllText(FilePath, content);
        }
        
        public void ClearHistory()
        {
            File.WriteAllText(FilePath, "");
        }
    }
}