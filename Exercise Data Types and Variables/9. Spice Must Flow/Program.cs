

int startingYield = int.Parse(Console.ReadLine());
int days = 0;
int totalAmount = 0;

while (startingYield >= 100)
{
    totalAmount += startingYield;
    startingYield -= 10;
    totalAmount -= 26;
    days++;
   
}
if (days > 0)
{
        totalAmount -= 26;
} 
Console.WriteLine(days);
Console.WriteLine(totalAmount);