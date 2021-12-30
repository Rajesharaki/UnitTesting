using System;
using System.Collections.Generic;
using System.Text;

namespace RegexExample
{
    public class Demo : IFileReader
    {
        public bool Exists(string Path)
        {
            throw new NotImplementedException();
        }

        public string ReadAllText(string Path)
        {
            throw new NotImplementedException();
        }

        public void WriteAllText(string Path, string Content)
        {
            throw new NotImplementedException();
        }
    }
}
