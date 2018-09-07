using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, sName;
            int ID;
            double GPA;
            Console.Write("Name : ");
            Name = Console.ReadLine();
            Console.Write("Lastname : ");
            sName = Console.ReadLine();
            Console.Write("ID : ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("GPA : ");
            GPA = double.Parse(Console.ReadLine());
        }
    }
}
