
string input = Console.ReadLine();
List<Car> cars = new List<Car>();
List<Truck> trucks = new List<Truck>();

while (input != "end")
{
    string[] data = input.Split('/');
    string type = data[0];
    string brand = data[1];
    string model = data[2];
    int horsePowerOrWeight = int.Parse(data[3]);
    if (type == "Car")
    {
        Car car = new Car();
        car.Brand = brand;
        car.Model = model;
        car.HorsePower = horsePowerOrWeight;
        cars.Add(car);
    }
    else if (type == "Truck")
    {
        Truck truck = new Truck();
        truck.Brand = brand;
        truck.Model = model;
        truck.Weight = horsePowerOrWeight;
        trucks.Add(truck);
    }
    input = Console.ReadLine();
}
if (cars.Count > 0)
{
    Console.WriteLine("Cars:");
    foreach (var car in cars.OrderBy(x => x.Brand))
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}
if (trucks.Count > 0)
{
    Console.WriteLine("Trucks:");
    foreach (var truck in trucks.OrderBy(x => x.Brand))
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}





class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}
