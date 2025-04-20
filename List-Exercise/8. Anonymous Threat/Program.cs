

List<string> input = Console.ReadLine().Split().ToList();
string command = Console.ReadLine();

while (command != "3:1")
{
    string[] commandArgs = command.Split();
    string action = commandArgs[0];
    if (action == "merge")
    {
        int startIndex = int.Parse(commandArgs[1]);
        int endIndex = int.Parse(commandArgs[2]);
        if (startIndex < 0 || startIndex > input.Count - 1)
        {
            startIndex = 0;
        }
        if (endIndex > input.Count - 1)
        {
            endIndex = input.Count - 1;
        }
        string merged = string.Empty;
        for (int i = startIndex; i <= endIndex; i++)
        {
            merged += input[i];
        }
        input.RemoveRange(startIndex, endIndex - startIndex + 1);
        input.Insert(startIndex, merged);
    }
    else if (action == "divide")
    {
        int index = int.Parse(commandArgs[1]);
        int partitions = int.Parse(commandArgs[2]);
        string element = input[index];
        input.RemoveAt(index);
        int partitionSize = element.Length / partitions;
        List<string> substrings = new List<string>();
        for (int i = 0; i < partitions; i++)
        {
            if (i == partitions - 1)
            {
                substrings.Add(element.Substring(i * partitionSize));
            }
            else
            {
                substrings.Add(element.Substring(i * partitionSize, partitionSize));
            }
        }
        input.InsertRange(index, substrings);
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", input));