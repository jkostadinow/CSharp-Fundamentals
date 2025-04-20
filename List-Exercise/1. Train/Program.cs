

List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());

while (true)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        break;
    }
    string[] command = input.Split();
    if (command[0] == "Add")
    {
        wagons.Add(int.Parse(command[1]));
    }
    else
    {
        int passengers = int.Parse(command[0]);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengers <= maxCapacity)
            {
                wagons[i] += passengers;
                break;
            }
        }
    }
}
Console.WriteLine(string.Join(" ", wagons));