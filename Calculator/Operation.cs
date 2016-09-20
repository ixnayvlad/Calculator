using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operation
    {
        Operators operation = new Operators();
        int a;
        int b;
        char operationChar;
        int result;

        public int NewOperation()
        {
            result = 0;
            Console.WriteLine("Первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Операция:");
            operationChar = Console.ReadLine()[0];
            
            switch (operationChar)
            {
            case '+': result = operation.Sum(a, b); break;
            case '-': result = operation.Sub(a, b); break;
            case '*': result = operation.Mul(a, b); break;
            case '/': result = operation.Div(a, b); break;
            }
            
            
            return result;
        }
    }
}
