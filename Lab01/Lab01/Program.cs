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
            Console.WriteLine("Enter the following information..");
            Console.Write("Name : ");
            Name = Console.ReadLine();
            Console.Write("Lastname : ");
            sName = Console.ReadLine();
            Console.Write("ID : ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("GPA : ");
            GPA = double.Parse(Console.ReadLine());
            Console.WriteLine("\nThis is result..\nName : "+Name+"\nLastname : "+sName+"\nID : "+ID+"\nGPA : {0:F2}",GPA);
        }
    }
}
