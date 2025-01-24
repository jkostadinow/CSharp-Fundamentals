

string[] input = Console.ReadLine().Split().ToArray();


for (int i = 0; i < input.Length / 2; i++)
{
    string firstElement = input[i];
    string secondElement = input[input.Length - 1 - i];

    input[i] = secondElement;
    input[input.Length - 1 - i] = firstElement;
}

for (int i = 0; i < input.Length; i++)
{
    Console.Write(input[i] + " ");
}

