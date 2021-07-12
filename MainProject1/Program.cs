using System;
using Lib1;

namespace MainProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib1 = new Lib1Class1();
            Console.WriteLine($"Lib1 DoWork(): {lib1.DoWork()}");
        }
    }
}