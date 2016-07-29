using System;
namespace ConsoleApp64Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.Is64BitProcess)
            {
                Console.WriteLine("Process is 64-bits!");
            }
            else
            {
                Console.WriteLine("Process is NOT 64-bits!");
            }
            Console.ReadKey();
        }
    }
}