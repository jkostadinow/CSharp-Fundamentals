

int n = int.Parse(Console.ReadLine());
double maxVolume = 0;
string maxModel = "";

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if (volume > maxVolume)
    {
        maxVolume = volume;
        maxModel = model;
    }
}
Console.WriteLine(maxModel);
