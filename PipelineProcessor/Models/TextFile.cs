using System.IO;
using Prism.Mvvm;

namespace PipelineProcessor.Models
{
    public class TextFile : BindableBase
    {
        public TextFile(string path, string val = "")
        {
            FileInfo = new FileInfo(path);
            if (string.IsNullOrWhiteSpace(val) && FileInfo.Exists)
            {
                using var reader = new StreamReader(FileInfo.OpenRead());
                Value = reader.ReadToEnd();
                return;
            }

            Value = val;
        }

        public FileInfo FileInfo { get; set; }

        public string Value { get; set; }
    }
}