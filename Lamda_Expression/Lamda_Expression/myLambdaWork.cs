using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Expression
{
    public delegate int ForLamda(int a, int b);



    public class myLambdaWork
    {

        public void calculate() 
        {

            while (true)
            {
                Console.WriteLine("enter option according to operatioan + * - /");
                string x = Console.ReadLine();
                char check = x[0];
                Console.WriteLine("enter number");
                int a=int.Parse(Console.ReadLine());
                Console.WriteLine("enter number");
                int b = int.Parse(Console.ReadLine());

                switch (check)
                {
                    case '+':
                             ForLamda obj1 = (a, b) => a + b;
                             Console.WriteLine( obj1(a, b));
                        break;
                    case '-':
                             ForLamda obj2 = (a, b) => a - b;
                             Console.WriteLine(obj2(a, b));
                        break;
                    case '*':
                             ForLamda obj3 = (a, b) => a * b;
                             Console.WriteLine(obj3(a, b));
                        break;
                    case '/':
                             ForLamda obj4 = (a, b) => a / b;
                             Console.WriteLine(obj4(a, b));
                        break;
                    default:
                             Console.WriteLine("enter reight option");
                        break;
                
                }


            }
        }


    }
}
