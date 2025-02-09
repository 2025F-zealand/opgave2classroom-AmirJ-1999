class Program
{
    static void Main()
    {
        // Creating a new classroom instance
        ClassRoom myClass = new ClassRoom
        {
            ClassName = "3B",
            SemesterStart = new DateTime(2024, 2, 24) // Setting semester start date
        };

        // Adding myself and my classmates to the class
        myClass.StudentList.Add(new Student("Amir", 5, 1999));  // Myself
        myClass.StudentList.Add(new Student("Samet", 2, 20000)); // Classmate 1
        myClass.StudentList.Add(new Student("Hasnain", 6, 2004)); // Classmate 2

        // Printing out the class name and semester start date
        Console.WriteLine($"Class name: {myClass.ClassName}");
        Console.WriteLine($"Semester Start: {myClass.SemesterStart.ToShortDateString()}");
        // Printing out the students in the class
        foreach (Student s in myClass.StudentList)
        {
            Console.WriteLine(s);
        }
    }
}