string info = Console.ReadLine();
List<Box> boxes = new List<Box>();

while (info != "end")
{
    string[] data = info.Split();
    string serialNumber = data[0];
    string itemName = data[1];
    int itemQuantity = int.Parse(data[2]);
    double itemPrice = double.Parse(data[3]);

    Item item = new Item();
    item.Name = itemName;
    item.Price = itemPrice;

    Box box = new Box();
    box.SerialNumber = serialNumber;
    box.Item = item;
    box.ItemQuantity = itemQuantity;
    box.PriceForABox = itemQuantity * itemPrice;

    boxes.Add(box);

    info = Console.ReadLine();
}

foreach (var box in boxes.OrderByDescending(x => x.PriceForABox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForABox:F2}");
}




class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public double PriceForABox { get; set; }
}

class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}