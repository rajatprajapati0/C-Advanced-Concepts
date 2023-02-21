using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class delegates
    {
        internal static void  add(int a, int b) 
        {
            var result = a + b;
            Console.WriteLine("Result:"+result);
        
        }
        internal static void multiplication(int a, int b)
        {
            var result = a * b;
            Console.WriteLine("Result:"+result);


        }
        internal static void substraction(int a, int b)
        {
            var result = a - b;
            Console.WriteLine("Result:"+result);


        }

        internal static void division(int a, int b)
        {
            var result = a / b;
            Console.WriteLine("Result:"+result);


        }

    }
}
