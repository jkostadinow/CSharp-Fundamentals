string userName = Console.ReadLine();
string expectedPassword = new string(userName.Reverse().ToArray());
int loginAttepts = 0;

while (true)
{
    string providedPassword = Console.ReadLine();
    if (providedPassword == expectedPassword)
    {
        Console.WriteLine($"User {userName} logged in.");
        return;
    }
    else
    {
        loginAttepts++;
        Console.WriteLine("Incorrect password. Try again.");
    }
    if (loginAttepts == 3)
    {
        Console.WriteLine($"User {userName} blocked!");
        break;
    }
}

