

string info = Console.ReadLine();
List<Student> students = new List<Student>();

while (info != "end")
{
    string[] data = info.Split();
    string firstName = data[0];
    string lastName = data[1];
    int age = int.Parse(data[2]);
    string homeTown = data[3];

    bool isStudentExisting = false;
    foreach (var student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            isStudentExisting = true;
            student.Age = age;
            student.HomeTown = homeTown;
            break;
        }

    }
    if (!isStudentExisting)
    {
        Student student = new Student();
        student.FirstName = firstName;
        student.LastName = lastName;
        student.Age = age;
        student.HomeTown = homeTown;
        students.Add(student);
    }
    info = Console.ReadLine();
}
string town = Console.ReadLine();
foreach (var student in students)
{
    if (student.HomeTown == town)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}