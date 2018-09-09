using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : \tbyte\tchar\tbool\tsbyte\tshort\tushort\tuint");
            Console.WriteLine("Size :\t\t" + sizeof(byte)+'\t'+sizeof(char) + '\t' +sizeof(bool) + '\t' +sizeof(sbyte) + '\t' +sizeof(short) + '\t' +sizeof(ushort) + '\t' +sizeof(uint));
            Console.WriteLine("Minimum Value :\t" + byte.MinValue + '\t' +(int)char.MinValue + '\t'+'\t' +sbyte.MinValue + '\t' +short.MinValue + '\t' +ushort.MinValue + '\t' +uint.MinValue);
            Console.WriteLine("Maximum Value :" + byte.MaxValue + '\t' + (int)char.MaxValue + '\t' + '\t' + sbyte.MaxValue + '\t' + short.MaxValue + '\t' + ushort.MaxValue + '\t' + uint.MaxValue);

            Console.WriteLine("\nData type : \tfloat\t\tdouble\t\t\tdecimal\t\t\t\tlong\t\t\t\tulong");
            Console.WriteLine("Size :\t\t" + sizeof(float) + "\t\t" + sizeof(double) + "\t\t\t" + sizeof(decimal) + "\t\t\t\t" + sizeof(long) + "\t\t\t\t" + sizeof(ulong));
            Console.WriteLine("Minimum Value :\t" + float.MinValue + "\t" + double.MinValue + '\t' + decimal.MinValue + '\t' + long.MinValue + '\t' + ulong.MinValue);
            Console.WriteLine("Maximum Value :\t"+ float.MaxValue + '\t' + double.MaxValue + '\t' + decimal.MaxValue + '\t' + long.MaxValue + '\t' + ulong.MaxValue);

        }
    }
}
