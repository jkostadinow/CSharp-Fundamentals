﻿


int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int evenSum = 0;
int oddSum = 0;

foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}

Console.WriteLine(evenSum - oddSum);