

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string[] command = Console.ReadLine().Split();
    if (command[0] == "end")
    {
        break;
    }
    if (command[0] == "Add")
    {
        numbers.Add(int.Parse(command[1]));
    }
    else if (command[0] == "Remove")
    {
        numbers.Remove(int.Parse(command[1]));
    }
    else if (command[0] == "RemoveAt")
    {
        numbers.RemoveAt(int.Parse(command[1]));
    }
    else if (command[0] == "Insert")
    {
        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
}
Console.WriteLine(string.Join(" ", numbers));