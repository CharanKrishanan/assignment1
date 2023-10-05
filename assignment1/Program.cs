using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Program
    {
        static void swap()

        {
            int a, b;
            Console.WriteLine("enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Now the value of a={a}");
            Console.WriteLine($"Now the value of b={b}");
        }
        static void multiply()
        {
            int a, b,c;
            Console.WriteLine("enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            c= Convert.ToInt32(Console.ReadLine());
            int ans = a * b * c;
            Console.WriteLine(ans);

        }
        static void Calculate()
        {
            int a, b;
            Console.WriteLine("enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            int add = a + b;
            Console.WriteLine($"{a}+{b}={add}");
            int sub = a - b;
            Console.WriteLine($"{a}-{b}={sub}");
            int mul = a * b;
            Console.WriteLine($"{a}x{b}={mul}");
            int div = a / b;
            Console.WriteLine($"{a}/{b}={div}");
            int mod = a % b;
            Console.WriteLine($"{a}mod{b}={mod}");
        }
        static void xy()
        {
            int x, y,z;
            Console.WriteLine("enter first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            z = Convert.ToInt32(Console.ReadLine());
            int a = (x + y) * z;
            int b = (x*y)+(y*z);
            Console.WriteLine($"Result of specified numbers 5, 6 and 7, (x+y).z is {a} and x.y + y.z is {b}");

        }
        static void disp()
        {
            Console.WriteLine("enter a digit:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", n);
            Console.WriteLine("{0}{0}{0}{0}", n);
            Console.WriteLine($"{n} {n} {n} {n}");
            Console.WriteLine($"{n}{n}{n}{n}");
        }
        static void marks()
        {
            int a, b, c;
            Console.WriteLine("enter first subject marks");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second subject marks");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third subject marks");
            c = Convert.ToInt32(Console.ReadLine());
            int total = a + b + c;
            int per = (total * 100) / 300;

            if (per >= 60) 
            {
                Console.WriteLine("first");
            }
            else if (60 > per && per > 45 )
            {
                Console.WriteLine("second");
            }
            else if(per < 45 && per > 35)
            {
                Console.WriteLine("third");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
        static void comp()
        {
            Console.WriteLine("enter first number");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b= Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine($"{a} is maximum");
                Console.WriteLine($"{b}is minimum");
            }
            else
            {
                Console.WriteLine($"{b} is maximum");
                Console.WriteLine($"{a}is minimum");

            }
        }
        static void tempr()
        {
            Console.Write("enter the amount of celsius");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = c + 273;
            Console.WriteLine($"kelvin={k}");
            int f = ((c * 9) / 5) + 32;
            Console.WriteLine($"fahrenheit={f}");
        }
        static void sum()
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a==b)
            {
                int k = 3*(a+b);
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine(a+b);
            }

        }
        static void diff()
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(2*(a-b));
            }
            else
            {
                Console.WriteLine(b-a);
            }

        }
        static void days()
        {
            Console.Write("enter days");
            int a = Convert.ToInt32(Console.ReadLine());
            int y = a / 365;
            int w = a / 7;
            int k = a % 7;
            Console.WriteLine($"no.of years {y} no of weeks {w} remaing days in week{k}");
        }

        static void Main(string[] args)
        {

            //Program.swap();
            //multiply();
            // Calculate();
            //xy();
            //disp();
            //marks();
            //comp();
            //tempr();
            //sum();
            //diff();
            //days();


            Console.Read();
            
        }
    }
}
