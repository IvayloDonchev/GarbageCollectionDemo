using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //Console.WriteLine("{0} / {1} = {2}", 120, 15, calculator.Divide(120, 15));
            //Console.WriteLine("Program finishing");
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine("{0} / {1} = {2}", 120, 15, calculator.Divide(120, 15));
            }
            Console.WriteLine("Program finishing");
        }
    }
}
