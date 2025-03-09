
List<string> products = new List<string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    products.Add(Console.ReadLine());
}
products.Sort();
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");
}