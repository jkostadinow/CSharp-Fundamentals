﻿

double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]} => {(int)Math.Round(array[i], MidpointRounding.AwayFromZero)}");
}