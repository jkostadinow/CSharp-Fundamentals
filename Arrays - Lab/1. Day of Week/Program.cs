



string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int numberOfDay = int.Parse(Console.ReadLine());

if (numberOfDay >= 1 && numberOfDay <= 7)
{
    Console.WriteLine(daysOfWeek[numberOfDay - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}