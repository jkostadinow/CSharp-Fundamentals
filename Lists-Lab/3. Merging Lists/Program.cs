
//List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
//List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
//List<int> result = new List<int>();

//for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
//{
//    result.Add(firstList[i]);
//    result.Add(secondList[i]);
//}

//if (firstList.Count > secondList.Count)
//{
//    for (int i = Math.Min(secondList.Count, firstList.Count); i < firstList.Count; i++)
//    {
//        result.Add(firstList[i]);
//    }
//}
//else
//{
//    for (int i = Math.Min(secondList.Count , firstList.Count); i < secondList.Count; i++)
//    {
//        result.Add(secondList[i]);
//    }
//}
//Console.WriteLine(string.Join(" ", result));

List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> result = new List<int>();

if (firstList.Count > secondList.Count)
{
	for (int i = 0; i < secondList.Count; i++)
	{
		result.Add(firstList[i]);
        result.Add(secondList[i]);
    }
    for (int i = secondList.Count; i < firstList.Count; i++)
    {
        result.Add(firstList[i]);
    }
}
else
{
    for (int i = 0; i < firstList.Count; i++)
    {
        result.Add(firstList[i]);
        result.Add(secondList[i]);
    }
    for (int i = firstList.Count; i < secondList.Count; i++)
    {
        result.Add(secondList[i]);
    }
}
Console.WriteLine(string.Join(" ", result));