
string[] words = Console.ReadLine().Split();
Random random = new Random();
for (int i = 0; i < words.Length; i++)
{
    int randomIndex = random.Next(words.Length);
    string temp = words[i];
    words[i] = words[randomIndex];
    words[randomIndex] = temp;
}
Console.WriteLine(string.Join(Environment.NewLine, words));