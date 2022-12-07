
using System.IO;

namespace TextReader
{
    class Program
    {
        static void Main(string[] args)
        {


            string path = @"C:\Users\nadeemoh\Documents\data.txt";
            if (File.Exists(path))
            {
               Console.WriteLine("File Found");
                
                string data = File.ReadAllText(path);

                Console.WriteLine(data);
            }
            else
            {

                Console.WriteLine(" File Not Found");

            }
        

        }
    }
}