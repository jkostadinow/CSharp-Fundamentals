List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

foreach (int number in numbers)
{
    if (!counts.ContainsKey(number))
    {
        counts[number] = 0;
    }
    counts[number]++;
}
foreach (var number in counts)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}


