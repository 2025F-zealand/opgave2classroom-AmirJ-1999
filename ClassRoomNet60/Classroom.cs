using System;
using System.Collections.Generic;
using System.Linq;

public class ClassRoom
{
    // Properties
    public string ClassName { get; set; }
    public List<Student> StudentList { get; set; }
    public DateTime SemesterStart { get; set; }

    // Constructor
    public ClassRoom()
    {
        ClassName = "3B";
        StudentList = new List<Student>();
        SemesterStart = DateTime.Now; // Current date and time
    }

    // Method to count students per season using LINQ
    public void CountBirthdaysBySeason()
    {
        var seasonCounts = StudentList
            .GroupBy(s => s.GetSeason()) // Grouping students by season
            .Select(group => new { Season = group.Key, Count = group.Count() }); // Counting students per season

        Console.WriteLine("Number of students born in each season:");
        foreach (var entry in seasonCounts)
        {
            Console.WriteLine($"{entry.Season}: {entry.Count}");
        }
    }
}
