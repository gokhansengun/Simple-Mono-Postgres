﻿using System;

namespace UniversityRegistrationSystem.Model
{
    public class Course
    {
        public string CourseId { get; set; }
        public int Credit { get; set; }
        public string Department { get; set; }
        public string Instructor { get; set; }
        public int Year { get; set; }
        public int Season { get; set; }
    }
}
