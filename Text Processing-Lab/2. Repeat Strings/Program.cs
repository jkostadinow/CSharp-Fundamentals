
string[] input = Console.ReadLine().Split(' ');

string result = string.Empty;
foreach (string str in input)
{
    int length = str.Length;
    for (int i = 0; i < length; i++)
    {
        result += str;
    }   
}
Console.WriteLine(result);