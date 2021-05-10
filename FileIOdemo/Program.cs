using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOdemo
{
    class Program
    {
       static void Main(string[] args)
        {
            FileExists();
            ReadallLines();
            ReadAllText();
            //FileCopy();
          //  DeleteFile();
            ReadFromStreamReader();
        }
        public static void FileExists()
        {
            string path = @"C:\Users\Aishwarya\source\repos\FileIOdemo\FileIOdemo\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exist");
                Console.Read();
            }
        }
        public static void ReadallLines()
        {
            string path = @"C:\Users\Aishwarya\source\repos\FileIOdemo\FileIOdemo\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadKey();
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\Aishwarya\source\repos\FileIOdemo\FileIOdemo\Example.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }
        //Copy Method
        public static void FileCopy()
        {
            string path = @"C:\Users\Aishwarya\source\repos\FileIOdemo\FileIOdemo\Example.txt";
            string copypath = @"C:\Users\Aishwarya\source\repos\FileIOdemo\FileIOdemo\Sample.txt";
            File.Copy(path,copypath);
            Console.ReadKey();
        }
        //delete method
        public static void DeleteFile()
        {
            string path = @"C:\Users\Aishwarya\source\repos\FileIOdemo\FileIOdemo\Sample.txt";
            File.Delete(path);
            Console.ReadKey();
        }
        //Adding Stream Reader Data
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\Aishwarya\source\repos\FileIOdemo\FileIOdemo\Example.txt";
            using(StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while((s = sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }
}

