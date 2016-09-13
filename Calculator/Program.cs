using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Operation A = new Operation();
                Console.WriteLine("Результат: \n" + A.NewOperation() + "\n");
            }
        }
    }
}
