﻿

using System.Numerics;

int numberOfSnowballs = int.Parse(Console.ReadLine());
BigInteger maxSnowballValue = 0;
int maxSnowballSnow = 0;
int maxSnowballTime = 0;
int maxSnowballQuality = 0;

for (int i = 0; i < numberOfSnowballs; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

    if (snowballValue > maxSnowballValue)
    {
        maxSnowballValue = snowballValue;
        maxSnowballSnow = snowballSnow;
        maxSnowballTime = snowballTime;
        maxSnowballQuality = snowballQuality;
    }
   
} 
Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");