
List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
List<string> result = new List<string>();

foreach (string number in numbers)
{
    result.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries));
}
Console.WriteLine(string.Join(" ", result));