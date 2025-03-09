
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();
bool isChange = false;

while (input != "end")
{
    string[] tokens = input.Split();
    
    if (tokens[0] == "Add")
    {
        isChange = true;
        numbers.Add(int.Parse(tokens[1]));
    }
    else if (tokens[0] == "Remove")
    {
        isChange = true;
        numbers.Remove(int.Parse(tokens[1]));
    }
    else if (tokens[0] == "RemoveAt")
    {
        isChange = true;
        numbers.RemoveAt(int.Parse(tokens[1]));
    }
    else if (tokens[0] == "Insert")
    {
        isChange = true;
        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
    }
    else if (tokens[0] == "Contains")
    {
        if (numbers.Contains(int.Parse(tokens[1])))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (tokens[0] == "PrintEven")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
    }
    else if (tokens[0] == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
    }
    else if (tokens[0] == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (tokens[0] == "Filter")
    {
        if (tokens[1] == "<")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(tokens[2]))));
        }
        else if (tokens[1] == ">")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(tokens[2]))));
        }
        else if (tokens[1] == ">=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(tokens[2]))));
        }
        else if (tokens[1] == "<=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(tokens[2]))));
        }
    }
    input = Console.ReadLine();
}
if (isChange) 
{
Console.WriteLine(string.Join(" ", numbers));
}