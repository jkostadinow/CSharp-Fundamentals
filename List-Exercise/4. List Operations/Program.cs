

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string[] command = Console.ReadLine().Split();

while (command[0] != "End")
{
    if (command[0] == "Add")
    {
        numbers.Add(int.Parse(command[1]));
    }
    else if (command[0] == "Insert")
    {
        int index = int.Parse(command[2]);
        if (index >= 0 && index < numbers.Count)
        {
            numbers.Insert(index, int.Parse(command[1]));
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (command[0] == "Remove")
    {
        int index = int.Parse(command[1]);
        if (index >= 0 && index < numbers.Count)
        {
            numbers.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (command[0] == "Shift")
    {
        if (command[1] == "left")
        {
            int count = int.Parse(command[2]);
            for (int i = 0; i < count; i++)
            {
                int firstElement = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstElement);
            }
        }
        else if (command[1] == "right")
        {
            int count = int.Parse(command[2]);
            for (int i = 0; i < count; i++)
            {
                int lastElement = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastElement);
            }
        }
    }
    command = Console.ReadLine().Split();
}
Console.WriteLine(string.Join(" ", numbers));