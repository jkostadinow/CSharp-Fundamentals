

List<string> list = Console.ReadLine().Split(", ").ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "course start")
{
    string[] command = input.Split(":");

    list = SoftUniCoursePlanning(list, command);
}
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{i + 1}.{list[i]}");
}

static List<string> SoftUniCoursePlanning(List<string> list, string[] command)
{
    switch (command[0])
    {
        case "Add":
            list = Add(list, command);
            break;
        case "Insert":
            list = Insert(list, command);
            break;
        case "Remove":
            list = Remove(list, command);
            break;
        case "Swap":
            list = Swap(list, command);
            break;
        case "Exercise":
            list = Exercise(list, command);
            break;

        default:
            break;
    }
    return list;
}

static List<string> Exercise(List<string> list, string[] command)
{
    string lessonTitle = command[1];
    if (list.Contains(lessonTitle) && !list.Contains(lessonTitle + "-Exercise"))
    {
        int index = list.IndexOf(lessonTitle);
        list.Insert(index + 1, lessonTitle + "-Exercise");
    }
    else if (!list.Contains(lessonTitle))
    {
        list.Add(lessonTitle);
        list.Add(lessonTitle + "-Exercise");
    }
    return list;
}

static List<string> Swap(List<string> list, string[] command)
{
    string firstLesson = command[1];
    string secondLesson = command[2];
    string firstLessonExercise = firstLesson + "-Exercise";
    string secondLessonExercise = secondLesson + "-Exercise";
    if (list.Contains(firstLesson) && list.Contains(secondLesson))
    {
        int firstIndex = list.IndexOf(firstLesson);
        int secondIndex = list.IndexOf(secondLesson);
        list[firstIndex] = secondLesson;
        list[secondIndex] = firstLesson;
        if (list.Contains(firstLessonExercise) && list.Contains(secondLessonExercise))
        {
            int firstExerciseIndex = list.IndexOf(firstLessonExercise);
            int secondExerciseIndex = list.IndexOf(secondLessonExercise);
            list[firstExerciseIndex] = secondLessonExercise;
            list[secondExerciseIndex] = firstLessonExercise;
        }
        else if (list.Contains(firstLessonExercise))
        {
            int firstExerciseIndex = list.IndexOf(firstLessonExercise);
            list.Insert(secondIndex + 1, firstLessonExercise);
            list.RemoveAt(firstExerciseIndex);
        }
        else if (list.Contains(secondLessonExercise))
        {
            int secondExerciseIndex = list.IndexOf(secondLessonExercise);
            list.Insert(firstIndex + 1, secondLessonExercise);
            list.RemoveAt(secondExerciseIndex);
        }
    }
    return list;
}

static List<string> Remove(List<string> list, string[] command)
{
    string lessonTitle = command[1];
    string lessonExercise = lessonTitle + "-Exercise";
    if (list.Contains(lessonTitle))
    {
        list.Remove(lessonTitle);
    }
    if (list.Contains(lessonExercise))
    {
        list.Remove(lessonExercise);
    }
    return list;
}

static List<string> Insert(List<string> list, string[] command)
{
    string lessonTitle = command[1];
    string lessonExercise = lessonTitle + "-Exercise";
    string position = command[2];
    int index = int.Parse(position);
    if (!list.Contains(lessonTitle))
    {
        list.Insert(index, lessonTitle);
    }
    if (!list.Contains(lessonExercise))
    {
        list.Insert(index + 1, lessonExercise);
    }
    return list;
}

static List<string> Add(List<string> list, string[] command)
{
    string lessonTitle = command[1];
    string lessonExercise = lessonTitle + "-Exercise";
    if (!list.Contains(lessonTitle))
    {
        list.Add(lessonTitle);
    }
    if (!list.Contains(lessonExercise))
    {
        list.Add(lessonExercise);
    }
    return list;
}