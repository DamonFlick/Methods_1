using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, and I'll add two to it! \n");
            Console.WriteLine("\n" + Operations.addTwo(Convert.ToInt32(Console.ReadLine())));


            Console.WriteLine("Enter a number, and I'll multiply it by two! \n ");
            Console.WriteLine("\n" + Operations.multTwo(Convert.ToInt32(Console.ReadLine())));
           

            Console.WriteLine("Enter a number, and I'll divide it by two! \n ");
            Console.WriteLine("\n" + Operations.divTwo( Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
