using System;
using System.Numerics;

namespace _10_CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            uint days = (uint)Math.Floor(365.2422 * years);
            long hours = (long)days * 24;
            long minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");     
        }
    }
}