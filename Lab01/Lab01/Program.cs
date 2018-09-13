using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            const double lightSpeed = 186000d;   // miles per second
            Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
            const double mileTokm = 1.609344;
            Console.WriteLine("Light speed = {0} km Per second", lightSpeed * mileTokm);
            const double ToSunDistance = 5945900000d;  // miles
            Console.WriteLine("ToSunDistance = {0} km", ToSunDistance);
            double ToSunTimeOfLight = (ToSunDistance/mileTokm) / lightSpeed;  // miles
            Console.WriteLine("ToSunTimeOfLight = {0} seconds", ToSunTimeOfLight);
            Console.WriteLine("ToSunTimeOfLight = {0} minutes", ToSunTimeOfLight / 60d);
            Console.WriteLine("ToSunTimeOfLight = {0} A.U.",toAU(ToSunDistance));
        }

        static double toAU(double distance)
        {
            return 0.000000006685 * distance;
        }
    }
}
