using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            //integer
            int i = int.MaxValue;
            int i2 = int.MinValue;
            Console.WriteLine(i);
            Console.WriteLine(i2);

            //float
            float f = float.MaxValue;
            float f2 = float.MinValue;
            Console.WriteLine(f);
            Console.WriteLine(f2);

            //double
            double d =  double.MaxValue;
            double d2 = double.MinValue;
            Console.WriteLine(d);
            Console.WriteLine(d2);

            //long
            long l = long.MaxValue;
            long l2 = long.MinValue;
            Console.WriteLine(l);
            Console.WriteLine(l2);

            //short
            short s = short.MaxValue;
            short s2 = short.MinValue;
            Console.WriteLine(s);
            Console.WriteLine(s2);

            //sbyte
            sbyte sb = sbyte.MaxValue;
            sbyte sb2 = sbyte.MinValue;
            Console.WriteLine(sb);
            Console.WriteLine(sb2);

            //ulong
            ulong ul = ulong.MaxValue;
            ulong ul2 = ulong.MinValue;
            Console.WriteLine(ul);
            Console.WriteLine(ul2);

            //byte
            byte b = byte.MaxValue;
            byte b2 = byte.MinValue;
            Console.WriteLine(b);
            Console.WriteLine(b2);

            //infinity and NaN
            double x = double.PositiveInfinity;
            double y = double.NegativeInfinity;
            double z = double.NaN;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            float x2 = float.PositiveInfinity;
            float y2 = float.NegativeInfinity;
            float z2 = float.NaN;
            Console.WriteLine(x2);
            Console.WriteLine(y2);
            Console.WriteLine(z2);

            //overflow
            Console.WriteLine(i + 1);
            Console.WriteLine(l + 1);
            Console.WriteLine(s + 1);
            Console.WriteLine(b + 1);







        }
    }
}
