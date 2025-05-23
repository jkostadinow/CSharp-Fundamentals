﻿Dictionary<char, int> letters
    = new Dictionary<char, int>();

string input = Console.ReadLine();

foreach (char  currentChar in input)
{
    if (currentChar == ' ')
    {
        continue;
    }

    if (!letters.ContainsKey(currentChar))
    {
        letters[currentChar] = 0;
    }
    letters[currentChar]++;
}

foreach (var kpv in letters)
{
    Console.WriteLine($"{kpv.Key} -> {kpv.Value}");
}