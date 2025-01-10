

int n = int.Parse(Console.ReadLine());
int waterTank = 255;
int waterIn = 0;

for (int i = 0; i < n; i++)
{
    int water = int.Parse(Console.ReadLine());
    if (waterIn + water > waterTank)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        waterIn += water;
    }
}
Console.WriteLine(waterIn);
