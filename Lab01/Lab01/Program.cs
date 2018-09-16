using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (float i = 0; i < Math.PI * 5.0F; i += 0.3F)
            {
                Console.WriteLine("The tan of {0,10:F} = {1,-10:F6}" +
                spaces(Math.Tan(i)) + "*", i, Math.Tan(i));
            }
        }
        private static string spaces(double val)
        {
            val += 11;
            string SpaceString = new String(' ', ((int)(val)) + 10);
            return SpaceString;
        }

    }
}
