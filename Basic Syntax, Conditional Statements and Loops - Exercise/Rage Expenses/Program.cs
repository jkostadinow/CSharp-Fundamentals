int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int counterGameForBrokenHeadset = 0;
int counterGameForBrokenMouse = 0;
int counterGameForBrokenKeyboard = 0;

bool headsetBroken = false;
bool mouseBroken = false;

double price = 0;
for (int i = 1; i <= lostGamesCount; i++)
{
    counterGameForBrokenHeadset++;
    counterGameForBrokenMouse++;
    if (counterGameForBrokenHeadset == 2)
    {
        headsetBroken = true;
        counterGameForBrokenHeadset = 0;
        price += headsetPrice;
    }
    else
    {
        headsetBroken = false;
    }
    if (counterGameForBrokenMouse == 3)
    {
        mouseBroken = true;
        counterGameForBrokenMouse = 0;
        price += mousePrice;
    }
    else
    {
        mouseBroken = false;
    }
    if (headsetBroken && mouseBroken)
    {
        headsetBroken = false;
        mouseBroken = false;
        counterGameForBrokenKeyboard++;
        price += keyboardPrice;
    }
    if (counterGameForBrokenKeyboard == 2)
    {
        counterGameForBrokenKeyboard = 0;
        price += displayPrice;
    }

}
Console.WriteLine($"Rage expenses: {price:f2} lv.");