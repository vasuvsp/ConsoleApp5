﻿
namespace ConsoleApp5
{
    public class div
    {
        public static int Divide(int a, int b, out int c)
        {
            if (a > b)
            {
                return c = a / b;
            }
            else
            {
                return c = b / a;
            }
        }
        public static void Main()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Divide(a, b, out c);
            Console.WriteLine(c);
        }
    }
}
