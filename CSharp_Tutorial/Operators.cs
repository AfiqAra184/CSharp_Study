using System;

namespace CSharp_Tutorial
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            //Arithmetic
            int x = 3, y = 5, z = 11;
            Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);

            //Assignment
            x++;
            y += x;
            z -= x;
            Console.WriteLine("x ++ is " + x + ", y += x is " + y + ", z -= x is " + z);
            
            x *= 3;
            y /= 3;
            z %= 3;
            Console.WriteLine("x *= 3 is " + x + ", y /= 3 is " + y + ", z %= 3 is " + z);

            int a, b, c, d, e;
            a = b = c = d = e = 5;
            Console.WriteLine("a, b, c, d, e = 5");

            //5 in binary is 0101
            //3 in binary is 0011
            a &= 3; //0101 AND 0011 = 0001
            b |= 3; //0101 OR 0011 = 0111
            c ^= 3; //0101 XOR 0011 = 0110
            d >>= 3; //0101 shifted right 3 times = 0000
            e <<= 3; //0101 shifted left 3 times = 101000
            Console.WriteLine("a is " + a + ", b is " + b + ", c is " + c + ", d is " + d + ", e is " + e);

            //Comparison
            Console.WriteLine("Returns " + (x == y) + " for x == y");
            Console.WriteLine("Returns " + (x != y) + " for x != y");
            Console.WriteLine("Returns " + (x > y) + " for x > y");
            Console.WriteLine("Returns " + (x < y) + " for x < y");
            Console.WriteLine("Returns " + (x >= 12) + " for x >= 12 ");
            Console.WriteLine("Returns " + (x <= y) + " for x <= 13 ");

        }
    }
}
