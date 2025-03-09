


Console.WriteLine("Length: ");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Width: ");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Heigth: ");
double heigth = double.Parse(Console.ReadLine());
double V = (length + width + heigth) / 3;
Console.WriteLine($"Pyramid Volume: {V:f2}");
