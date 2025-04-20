

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
int bombNumber = bomb[0];
int power = bomb[1];

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNumber)
    {
        int startIndex = i - power;
        int endIndex = i + power;
        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if (endIndex > numbers.Count - 1)
        {
            endIndex = numbers.Count - 1;
        }
        int count = endIndex - startIndex + 1;
        numbers.RemoveRange(startIndex, count);
        i = 0;
    }
}
Console.WriteLine(numbers.Sum());