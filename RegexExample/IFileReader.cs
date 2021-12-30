using System;
using System.Collections.Generic;
using System.Text;

namespace RegexExample
{
    public interface IFileReader
    {
        public bool Exists(string Path);
        public string ReadAllText(string Path);
        public void WriteAllText(string Path, string Content);
    }
}
