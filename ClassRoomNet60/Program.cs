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
        myClass.StudentList.Add(new Student("Amir", 5, 99));  // Myself
        myClass.StudentList.Add(new Student("Sameet", 2, 00)); // Classmate 1
        myClass.StudentList.Add(new Student("Hasnain", 6, 04)); // Classmate 2
    }
}