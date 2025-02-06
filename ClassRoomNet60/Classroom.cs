using System;
using System.Collections.Generic;

public class ClassRoom
{   // Properties
    public string ClassName { get; set; }
    public List<Student> StudentList { get; set; }
    public DateTime SemesterStart { get; set; }

    // Constructor
    public ClassRoom()
    {
        ClassName = "Shababs klassen";
        StudentList = new List<Student>();
        SemesterStart = DateTime.Now; // Current date and time
    }
}
