

string[] bannedWords = Console.ReadLine().Split(", ");
string textToFilter = Console.ReadLine();
foreach (string word in bannedWords)
{
    string replacement = new string('*', word.Length);
    textToFilter = textToFilter.Replace(word, replacement);
}
Console.WriteLine(textToFilter);

