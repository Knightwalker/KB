using System;

namespace _17_PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}