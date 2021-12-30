using System;

namespace RegexExample
{
    public class Program
    {
        public IFileReader reader;
        public Program(IFileReader reader) 
        {
            this.reader = reader;
        }
        static void Main(string[] args)
        {
            int[] i = new int[4];

            Console.WriteLine(i[5]);

            //Program p = new Program(null);

            //string path = @"C:\Users\rajes\OneDrive\Desktop\BridgeLabzProjects\RegexExample\RegexExample\TextFile1.txt";

            //var data =p.WriteAllTextFile(path,"Good Evening");

            //Console.WriteLine(data);
            //Pattern p = new Pattern();
            //Console.WriteLine("Please Enter Email");
            //var check = p.ValidateEmail(Console.ReadLine());
            //Console.WriteLine(check);
        }

        public  string ReadTextFile(string path)
        {
            string response;
            if (reader.Exists(path))
            {
                response = reader.ReadAllText(path);
            }
            else
            {
                response = "File Not Found";
            }
            return response;
        }
        public string WriteAllTextFile(string path,string content)
        {
            string response;
            if (reader.Exists(path))
            {
                reader.WriteAllText(path,content);
                response = "Success";
            }
            else
            {
                response = "File Not Found";
            }
            return response;
        }
    }
}
