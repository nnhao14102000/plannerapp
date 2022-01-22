using System.IO;

namespace PlannerApp.Shared.Models
{
    public class FormFile
    {
        public FormFile(string fileName, Stream fileStream)
        {
            FileName = fileName;
            FileStream = fileStream;
        }

        public string FileName { get; set; }
        public Stream FileStream { get; set; }
    }
}
