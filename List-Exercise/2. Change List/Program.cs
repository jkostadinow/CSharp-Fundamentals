

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


while (true)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        break;
    }
    string[] command = input.Split();
    if (command[0] == "Delete")
    {
        int number = int.Parse(command[1]);
        numbers.RemoveAll(n => n == number);
    }
    else if (command[0] == "Insert")
    {

        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
}
Console.WriteLine(string.Join(" ", numbers));