using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A, B, Y;
            Console.WriteLine("      Y = A AND B\t\t      Y = A NAND B");
            Console.WriteLine("-----------------------\t\t-----------------------");
            Console.WriteLine("   A      B\t|  Y\t\t   A      B\t|  Y");
            Console.WriteLine("-----------------------\t\t-----------------------");
            A = false; B = false; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y,!Y);
            A = false; B = true; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y, !Y);
            A = true; B = false; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y, !Y);
            A = true; B = true; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y, !Y);
            Console.WriteLine("-----------------------\t\t-----------------------\n");

            Console.WriteLine("      Y = A OR B\t\t      Y = A NOR B");
            Console.WriteLine("-----------------------\t\t-----------------------");
            Console.WriteLine("   A      B\t|  Y\t\t   A      B\t|  Y");
            Console.WriteLine("-----------------------\t\t-----------------------");
            A = false; B = false; Y = A | B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y,!Y);
            A = false; B = true; Y = A | B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y, !Y);
            A = true; B = false; Y = A | B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y, !Y);
            A = true; B = true; Y = A | B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t\t {0}\t{1}\t| {3}", A, B, Y, !Y);
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("      Y = NOT A\t\t\t      Y = A XOR B");
            Console.WriteLine("-----------------------\t\t-----------------------");
            Console.WriteLine("   A\t|  Y\t\t\t   A      B\t| Y");
            Console.WriteLine("-----------------------\t\t-----------------------");
            B = A = false; Y = !A;
            Console.Write(" {0}\t| {1}\t\t\t", A,Y);
            Y = A ^ B;
            Console.WriteLine(" {0}\t{1}\t| {2}",A,B,Y);
            A = false; B = true; Y = !A;
            Console.Write(" {0}\t| {1}\t\t\t", A, Y);
            Y = A ^ B;
            Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
            A = true; B = false; Y = A ^ B;
            Console.Write(" {0}\t| {1}\t\t\t", A, Y);
            Y = A ^ B;
            Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
            A = B = true; Y = A ^ B;
            Console.Write(" {0}\t| {1}\t\t\t", A, Y);
            Y = A ^ B;
            Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
            Console.WriteLine("-----------------------\t\t-----------------------\n");
        }
    }
}
