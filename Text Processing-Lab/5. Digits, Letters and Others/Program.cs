

string input = Console.ReadLine();
string digits = string.Empty;
string letters = string.Empty;
string specialChars = string.Empty;

foreach (char ch in input)
{
    if (char.IsDigit(ch))
    {
        digits += ch;
    }
    else if (char.IsLetter(ch)) 
    {
        letters += ch;
    }
    else
    {
        specialChars += ch;
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(specialChars);