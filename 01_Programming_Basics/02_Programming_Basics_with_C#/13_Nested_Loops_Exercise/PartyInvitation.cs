using System;
using System.Linq;

namespace NestedLoopsExercises
{
    class Program
    {
        static void Main()
        {
            string name = string.Empty;

            bool isValid = true;

            double totalNamesCount = 0;
            double validNamesCount = 0;
            double invalidNamesCount = 0;

            while ((name = Console.ReadLine()) != "Statistic")
            {
                isValid = true;
                totalNamesCount++;

                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsLetter(name[i]))
                    {
                        Console.WriteLine("Invalid name!");
                        invalidNamesCount++;
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    validNamesCount++;

                    name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower();

                    Console.WriteLine(name);
                }
            }

            double peopleComingPercent = (validNamesCount / totalNamesCount) * 100;

            double peopleNotComingPercent = (invalidNamesCount / totalNamesCount) * 100;

            Console.WriteLine($"Valid names are {peopleComingPercent:F2}% from {totalNamesCount} names.");
            Console.WriteLine($"Invalid names are {peopleNotComingPercent:F2}% from {totalNamesCount} names.");
        }
    }
}
