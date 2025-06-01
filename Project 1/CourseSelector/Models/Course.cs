using System.Collections.Generic;

namespace CourseSelector.Models
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public List<string> Prerequisites { get; set; } = new List<string>();
        public int SemesterOrder { get; set; } // A rough estimate of when this course is typically taken
        public string Category { get; set; } // "Main" or major category like "Information Systems", "Software Engineering", etc.

        public Course(string courseCode, string courseName, string category = "Main Course", int semesterOrder = 1)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Category = category;
            SemesterOrder = semesterOrder;
        }
    }
}
