using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            a = 10;
            b = 20;
            x = 5;
            y = 2;
            Console.WriteLine("1. {0} + {1} = {2}",a,b,a+b);
            Console.WriteLine("2. {0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("3. {0} * {1} = {2}", x, b, x * b);
            Console.WriteLine("4. {0} / {1} = {2}", y, a, y / a);
            Console.WriteLine("5. {0} % {1} = {2}", b, y, b % y);
            Console.WriteLine("6. {0}", y+10%x);
            Console.WriteLine("7. {0}", a/3*5);
            Console.WriteLine("8. {0}", 9/2*a);
            Console.WriteLine("9. {0} % {1} = {2}", y, 8, y%8);
            Console.WriteLine("10. {0}",100*x+y%2-a);
        }
    }
}
