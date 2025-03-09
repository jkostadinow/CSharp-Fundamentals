string input = Console.ReadLine();
List<Box> boxes = new List<Box>();

while (input != "end")
{
    string[] inputArgs = input.Split();
    string serialNumber = inputArgs[0];
    string itemName = inputArgs[1];
    int quantity = int.Parse(inputArgs[2]);
    double price = double.Parse(inputArgs[3]);
    Item item = new Item
    {
        Name = itemName,
        Price = price
    };
    Box box = new Box
    {
        serialNumber = serialNumber,
        Item = item,
        Quantity = quantity,
        TotalPrice = quantity * price
    };
    boxes.Add(box);
    input = Console.ReadLine();
}
foreach (Box box in boxes.OrderByDescending(x => x.TotalPrice))
{
    Console.WriteLine(box.serialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
    Console.WriteLine($"-- ${box.TotalPrice:F2}");
}


class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Box
{
    public string serialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public double TotalPrice { get; set; }
}