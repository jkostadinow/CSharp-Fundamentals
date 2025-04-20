
string input = Console.ReadLine();
string result = string.Empty;

while (input != "end")
{
    
    for (int i = input.Length - 1; i >= 0; i--)
    {
        result += input[i];
    }
    Console.WriteLine($"{input} = {result}");
    result = string.Empty;
    input = Console.ReadLine();

}
