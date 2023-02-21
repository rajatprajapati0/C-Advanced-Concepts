using System;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    public delegate void math(int a, int b);  


    public class Program
    {
        
        public static void Main(string[] args)
        {
            while(true)
            { 
              Console.WriteLine("enter symbol acording to opration + - / *");
              string c=Console.ReadLine();
              Console.Write("enter number 1 :");
                int a=int.Parse(Console.ReadLine());
                Console.Write("enter number 2 :");
                int b = int.Parse(Console.ReadLine());


                char check = c[0];
                switch (check)
                {
                    case '+':
                        math obj = new math(for_delegates.add);
                        obj.Invoke(a, b);

                        break;

                    case '-':
                        obj = new math(for_delegates.substraction);
                        obj.Invoke(a, b);
                        break;

                    case '*':
                        obj = new math(for_delegates.multiplication);
                        obj.Invoke(a, b);

                        break;

                    case '/':
                        obj = new math(for_delegates.division);
                        obj.Invoke(a, b);
                    
                        break;

                    default:
                        Console.WriteLine("enter right input");
                        break;

                }
            }
        }
    }
}