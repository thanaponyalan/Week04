using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNo = rand.Next(0,9);
            int No;
            Console.Write("Enter Number : ");
            No = int.Parse(Console.ReadLine());
            bool a = randNo > No;
            Console.WriteLine("Random No is greater than Input No : "+a);
            Console.WriteLine("Random No is {0}, Input No is {1}.",randNo,No);
        }
    }
}
