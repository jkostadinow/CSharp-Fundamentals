using System;

namespace Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                if (day == "weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (day == "holiday")
                {
                    Console.WriteLine("5$");
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (day == "weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (day == "weekend")
                {
                    Console.WriteLine("20$");
                }
                else if (day == "holiday")
                {
                    Console.WriteLine("12$");
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (day == "weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (day == "holiday")
                {
                    Console.WriteLine("10$");
                }

            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
