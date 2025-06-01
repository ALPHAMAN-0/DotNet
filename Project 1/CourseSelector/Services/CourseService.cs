using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CourseSelector.Models;
using Microsoft.AspNetCore.Hosting;

namespace CourseSelector.Services
{
    public class CourseService
    {
        private List<Course> _courses = new List<Course>();
        private readonly IWebHostEnvironment _environment;

        public CourseService(IWebHostEnvironment environment)
        {
            _environment = environment;
            InitializeCourses();
            LoadPrerequisitesFromFile();
        }

        public List<Course> GetAllCourses()
        {
            return _courses;
        }

        public List<string> GetAllCategories()
        {
            return _courses.Select(c => c.Category).Distinct().ToList();
        }

        public List<Course> GetAvailableCourses(List<string> completedCourses)
        {
            var availableCourses = new List<Course>();

            foreach (var course in _courses)
            {
                // Skip courses that are already completed
                if (completedCourses.Contains(course.CourseCode))
                    continue;

                // Check if all prerequisites are met
                bool allPrerequisitesMet = true;
                foreach (var prerequisite in course.Prerequisites)
                {
                    if (!completedCourses.Contains(prerequisite))
                    {
                        allPrerequisitesMet = false;
                        break;
                    }
                }

                if (allPrerequisitesMet)
                {
                    availableCourses.Add(course);
                }
            }

            // Sort by category first, then by course code
            return availableCourses
                .OrderBy(c => c.Category == "Main Course" ? 0 : 1)  // Put Main courses first
                .ThenBy(c => c.Category)
                .ThenBy(c => c.CourseCode)
                .ToList();
        }

        private void InitializeCourses()
        {
            // Main Courses
            _courses.Add(new Course("MAT1102", "Differential Calculus & Co-Ordinate Geometry"));
            _courses.Add(new Course("PHY1101", "Physics 1"));
            _courses.Add(new Course("PHY1102", "Physics 1 Lab"));
            _courses.Add(new Course("ENG1101", "English Reading Skills & Public Speaking"));
            _courses.Add(new Course("CSC1101", "Introduction to Computer Studies"));
            _courses.Add(new Course("CSC1102", "Introduction to Programming"));
            _courses.Add(new Course("CSC1103", "Introduction to Programming Lab"));
            _courses.Add(new Course("CSC1204", "Discrete Mathematics"));
            _courses.Add(new Course("MAT1205", "Integral Calculus & Ordinary Differential Equations"));
            _courses.Add(new Course("CSC1205", "Object Oriented Programming 1"));
            _courses.Add(new Course("PHY1203", "Physics 2"));
            _courses.Add(new Course("PHY1204", "Physics 2 Lab"));
            _courses.Add(new Course("ENG1202", "English Writing Skills & Communications"));
            _courses.Add(new Course("COE2101", "Introduction to Electrical Circuits"));
            _courses.Add(new Course("COE2102", "Introduction to Electrical Circuits Lab"));
            _courses.Add(new Course("CHEM1101", "Chemistry"));
            _courses.Add(new Course("MAT2101", "Complex Variable, Laplace & Z-Transformation"));
            _courses.Add(new Course("CSC2106", "Data Structure"));
            _courses.Add(new Course("CSC2107", "Data Structure Lab"));
            _courses.Add(new Course("CSC2108", "Introduction to Database"));
            _courses.Add(new Course("BBA1102", "Principles of Accounting"));
            _courses.Add(new Course("EEE2103", "Electronic Devices"));
            _courses.Add(new Course("EEE2104", "Electronic Devices Lab"));
            _courses.Add(new Course("BAE2101", "Computer Aided Design & Drafting"));
            _courses.Add(new Course("CSC2211", "Algorithms"));
            _courses.Add(new Course("MAT2202", "Matrices, Vectors, Fourier Analysis"));
            _courses.Add(new Course("CSC2210", "Object Oriented Programming 2"));
            _courses.Add(new Course("CSC2209", "Object Oriented Analysis and Design"));
            _courses.Add(new Course("BAS2101", "Bangladesh Studies"));
            _courses.Add(new Course("EEE3101", "Digital Logic and Circuits"));
            _courses.Add(new Course("EEE3102", "Digital Logic and Circuits Lab"));
            _courses.Add(new Course("MAT3103", "Computational Statistics and Probability"));
            _courses.Add(new Course("CSC3113", "Theory of Computation"));
            _courses.Add(new Course("ECO3150", "Principles of Economics"));
            _courses.Add(new Course("ENG2103", "Business Communication"));
            _courses.Add(new Course("MAT3101", "Numerical Methods for Science and Engineering"));
            _courses.Add(new Course("COE3103", "Data Communication"));
            _courses.Add(new Course("COE3104", "Microprocessor and Embedded Systems"));
            _courses.Add(new Course("CSC3112", "Software Engineering"));
            _courses.Add(new Course("CSC3217", "Artificial Intelligence and Expert System"));
            _courses.Add(new Course("COE3206", "Computer Networks"));
            _courses.Add(new Course("COE3205", "Computer Organization and Architecture"));
            _courses.Add(new Course("CSC3214", "Operating System"));
            _courses.Add(new Course("CSC3215", "Web Technologies"));
            _courses.Add(new Course("EEE2216", "Engineering Ethics"));
            _courses.Add(new Course("CSC3216", "Compiler Design"));
            _courses.Add(new Course("CSC4118", "Computer Graphics"));
            _courses.Add(new Course("MGT3202", "Engineering Management"));
            _courses.Add(new Course("CSC4197", "Research Methodology"));
            _courses.Add(new Course("CSC4299", "Thesis"));

            // Major in Information Systems
            string infoSystems = "Major in Information Systems";
            _courses.Add(new Course("CSC4181", "Advanced Database Management System", infoSystems));
            _courses.Add(new Course("MIS3101", "Management Information System", infoSystems));
            _courses.Add(new Course("MIS4011", "Enterprise Resource Planning", infoSystems));
            _courses.Add(new Course("CSC4285", "Data Warehouse and Data Mining", infoSystems));
            _courses.Add(new Course("CSC4182", "Human Computer Interaction", infoSystems));
            _courses.Add(new Course("MIS4014", "Business Intelligence and Decision Support Systems", infoSystems));
            _courses.Add(new Course("CSC4180", "Introduction to Data Science", infoSystems));
            _courses.Add(new Course("CSC4183", "Cyber Laws & Information Security", infoSystems));
            _courses.Add(new Course("MIS4007", "Digital Marketing", infoSystems));
            _courses.Add(new Course("MIS4012", "E-Commerce, E-Governance & E-Series", infoSystems));

            // Major in Software Engineering
            string softwareEng = "Major in Software Engineering";
            _courses.Add(new Course("CSC4270", "Software Development Project Management", softwareEng));
            _courses.Add(new Course("CSC4160", "Software Requirement Engineering", softwareEng));
            _courses.Add(new Course("CSC4271", "Software Quality and Testing", softwareEng));
            _courses.Add(new Course("CSC4162", "Programming in Python", softwareEng));
            _courses.Add(new Course("CSC4274", "Virtual Reality Systems Design", softwareEng));
            _courses.Add(new Course("CSC4163", "Advanced Programming with Java", softwareEng));
            _courses.Add(new Course("CSC4164", "Advanced Programming with .NET", softwareEng));
            _courses.Add(new Course("CSC4161", "Advanced Programming in Web Technology", softwareEng));
            _courses.Add(new Course("CSC4272", "Mobile Application Development", softwareEng));
            _courses.Add(new Course("CSC4273", "Software Architecture and Design Patterns", softwareEng));

            // Major in Computational Theory
            string compTheory = "Major in Computational Theory";
            _courses.Add(new Course("CSC4125", "Computer Science Mathematics", compTheory));
            _courses.Add(new Course("CSC4126", "Basic Graph Theory", compTheory));
            _courses.Add(new Course("CSC4127", "Advanced Algorithm Techniques", compTheory));
            _courses.Add(new Course("CSC4233", "Natural Language Processing", compTheory));
            _courses.Add(new Course("CSC4128", "Linear Programming", compTheory));
            _courses.Add(new Course("CSC4231", "Parallel Computing", compTheory));
            _courses.Add(new Course("CSC4232", "Machine Learning", compTheory));

            // Major in Computer Engineering
            string compEng = "Major in Computer Engineering";
            _courses.Add(new Course("BAE1201", "Basic Mechanical Engineering", compEng));
            _courses.Add(new Course("EEE3103", "Digital Signal Processing", compEng));
            _courses.Add(new Course("EEE4217", "VLSI Circuit Design", compEng));
            _courses.Add(new Course("EEE2213", "Signals & Linear System", compEng));
            _courses.Add(new Course("COE4128", "Digital System Design", compEng));
            _courses.Add(new Course("COE4231", "Image Processing", compEng));
            _courses.Add(new Course("COE4129", "Multimedia Systems", compEng));
            _courses.Add(new Course("COE4230", "Simulation & Modeling", compEng));
            _courses.Add(new Course("COE4126", "Advanced Computer Networks", compEng));
            _courses.Add(new Course("COE4232", "Network Security", compEng));
            _courses.Add(new Course("COE4125", "Advanced Operating System", compEng));
            _courses.Add(new Course("EEE4233", "Digital Design with System [Verilog, VHDL & FPGAs]", compEng));
            _courses.Add(new Course("COE4235", "Robotics Engineering", compEng));
            _courses.Add(new Course("EEE4209", "Telecommunications Engineering", compEng));
            _courses.Add(new Course("COE4127", "Network Resource Management & Organization", compEng));
            _courses.Add(new Course("COE4233", "Wireless Sensor Networks", compEng));
            _courses.Add(new Course("EEE4241", "Industrial Electronics, Drives & Instrumentation", compEng));
        }

        private void LoadPrerequisitesFromFile()
        {
            try
            {
                string filePath = Path.Combine(_environment.ContentRootPath, "prereq.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    // Skip header line
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        string[] parts = line.Split('\t');
                        if (parts.Length >= 3)
                        {
                            string courseCode = parts[0].Trim();
                            string prerequisites = parts[2].Trim();

                            var course = FindCourse(courseCode);
                            if (course != null && prerequisites != "Nil" && prerequisites != "-")
                            {
                                // Clear existing prerequisites that might have been set in code
                                course.Prerequisites.Clear();

                                // Add prerequisites from file
                                string[] prereqList = prerequisites.Split(',');
                                foreach (var prereq in prereqList)
                                {
                                    string trimmedPrereq = prereq.Trim();
                                    if (!string.IsNullOrEmpty(trimmedPrereq))
                                    {
                                        course.Prerequisites.Add(trimmedPrereq);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error loading prerequisites: {ex.Message}");
            }
        }

        private Course FindCourse(string courseCode)
        {
            return _courses.FirstOrDefault(c => c.CourseCode == courseCode) ??
                   new Course(courseCode, "Unknown Course"); // Return a placeholder if not found
        }
    }
}
