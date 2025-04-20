
int numberOfCommands = int.Parse(Console.ReadLine());

List<string> guestsList = new List<string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] command = Console.ReadLine().Split();
    string name = command[0];
    if (command.Length == 3)
    {
        if (guestsList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guestsList.Add(name);
        }
    }
    else if (command.Length == 4)
    {
        if (!guestsList.Contains(name))
        {
            Console.WriteLine($"{name} is not in the list!");
        }
        else
        {
            guestsList.Remove(name);
        }
    }
}
Console.WriteLine(string.Join(Environment.NewLine, guestsList));

