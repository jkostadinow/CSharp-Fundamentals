

using System.Diagnostics.CodeAnalysis;

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] condensed = new int[0];


for (int i = 0; i < numbers.Length - 1; i++)
{
    condensed = numbers;

    for (int j = 0; j < condensed.Length - 1 - i; j++)
    {
        condensed[j] = numbers[j] + numbers[j + 1];
    }
    numbers = condensed;


}
Console.WriteLine(numbers[0]);