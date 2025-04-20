
string[] words = Console.ReadLine().Split();
Dictionary<string, int> counts = new Dictionary<string, int>();

foreach (string word in words)
{
    string wordInLowerCase = word.ToLower();
    if (!counts.ContainsKey(wordInLowerCase))
    {
        counts[wordInLowerCase] = 0;
    }
    counts[wordInLowerCase]++;
}

foreach (var word in counts)
{
    if (word.Value % 2 != 0)
    {
        Console.Write(word.Key + " ");
    }
}