using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !!!");
            Console.WriteLine("**Environment**");
            Console.WriteLine($"Platform: .NET Core");
            Console.WriteLine($"OS: {RuntimeInformation.OSDescription}");
        }
    }
}