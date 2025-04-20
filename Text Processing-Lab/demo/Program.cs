
string input = Console.ReadLine();

while (input != "end")
{
   string reversedWord = string.Empty;
    for (int i = input.Length - 1; i >= 0; i--)
    {
        reversedWord += input[i];
    }
    Console.WriteLine($"{input} = {reversedWord}");
    input = Console.ReadLine();
}