
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
bool isChanged = false;

while (true)
{
    string[] command = Console.ReadLine().Split();
    if (command[0] == "end")
    {
        break;
    }
    else if (command[0] == "Add")
    {
        numbers.Add(int.Parse(command[1]));
        isChanged = true;
    }
    else if (command[0] == "Remove")
    {
        numbers.Remove(int.Parse(command[1]));
        isChanged = true;
    }
    else if (command[0] == "RemoveAt")
    {
        numbers.RemoveAt(int.Parse(command[1]));
        isChanged = true;
    }
    else if (command[0] == "Insert")
    {
        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
        isChanged = true;
    }
    else if (command[0] == "Contains")
    {
        if (numbers.Contains(int.Parse(command[1])))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command[0] == "PrintEven")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
    }
    else if (command[0] == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
    }
    else if (command[0] == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (command[0] == "Filter")
    {
        if (command[1] == "<")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(command[2]))));
        }
        else if (command[1] == ">")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(command[2]))));
        }
        else if (command[1] == ">=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(command[2]))));
        }
        else if (command[1] == "<=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(command[2]))));
        }
    }
}
if (isChanged)
{
    Console.WriteLine(string.Join(" ", numbers));
}