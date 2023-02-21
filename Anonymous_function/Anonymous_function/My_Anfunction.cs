using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_function
{
   public  delegate void myDelegate(int a, int b);

    class My_Anfunction
    {
        public void Calculate()
        {

            myDelegate obj1 = delegate (int a, int b)
            {
                var result = a + b;
                Console.WriteLine(result);              
            
            };
            myDelegate obj2= delegate (int a, int b)
            {
                var result = a - b;
                Console.WriteLine(result);

            };

            myDelegate obj3= delegate (int a, int b)
            {
                var result = a * b;
                Console.WriteLine(result);


            };
            myDelegate obj4 = delegate (int a, int b)
            {
                var result = a / b;
                Console.WriteLine(result);

            };
            Console.WriteLine("enter symbol according to opretion + - * /");
            string a=Console.ReadLine();
            char check = a[0];
            Console.WriteLine("enter number");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number");

            int y = int.Parse(Console.ReadLine());

            switch (check)
            {
                case'+':
                    obj1(x, y);
                    break;
                case '-':
                    obj2(x, y);
                    break;
                case '*':
                    obj3(x, y);
                    break;
                case '/':
                    obj4(x, y);
                    break;
                default: Console.WriteLine("enter right option");
                    break;
            }



        }
        
    }
}
