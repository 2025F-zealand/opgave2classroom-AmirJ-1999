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

        // Adding students
        myClass.StudentList.Add(new Student("Amir", 5, 1999));   // Spring
        myClass.StudentList.Add(new Student("Samet", 2, 2000));  // Winter
        myClass.StudentList.Add(new Student("Hasnain", 6, 2004)); // Summer
        myClass.StudentList.Add(new Student("test", 13, 9999)); // Test invalid month

        // Printing class info
        Console.WriteLine($"Class name: {myClass.ClassName}");
        Console.WriteLine($"Semester Start: {myClass.SemesterStart.ToShortDateString()}");

        // Printing students
        foreach (Student s in myClass.StudentList)
        {
            Console.WriteLine(s);
        }

        // Calling the method to count birthdays by season
        myClass.CountBirthdaysBySeason();
    }
}