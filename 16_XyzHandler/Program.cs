using System;
using System.IO;
namespace XyzHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || string.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("No file name given.");
            }
            else
            {
                string fileName = args[0];
                if (File.Exists(fileName))
                {
                    Console.WriteLine(File.ReadAllText(fileName));
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}