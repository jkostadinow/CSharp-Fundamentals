using System;

namespace Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string counry = Console.ReadLine();

            switch (counry)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
