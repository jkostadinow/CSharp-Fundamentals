﻿

int numberOfLines = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < numberOfLines; i++)
{
    char letter = char.Parse(Console.ReadLine());
    sum += letter;
}
Console.WriteLine($"The sum equals: {sum}");