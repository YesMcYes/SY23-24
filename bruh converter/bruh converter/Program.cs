using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put a number here NOW");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num * 2);
            Console.ReadLine();
        }
    }
}
