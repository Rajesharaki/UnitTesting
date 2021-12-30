using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RegexExample
{
    public class FileReader: IFileReader
    {
        public bool Exists(string Path)
        {
            var response = File.Exists(Path);
            return response;
        }

        public string ReadAllText(string Path)
        {
           var response= File.ReadAllText(Path);
           return response;
        }

        public void WriteAllText(string Path,string Content)
        {
            File.WriteAllText(Path,Content);
        }
    }
}
