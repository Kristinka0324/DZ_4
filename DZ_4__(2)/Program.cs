using System;
using System.Linq;

namespace DZ_4___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Sum());
            Console.ReadKey();

        }
    }
}
