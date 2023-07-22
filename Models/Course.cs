using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public class Course
    {
        public string Code { get; }
        public string Title { get; }
        public double WeeklyHours { get; set; }

        public Course(string code, string title, double weeklyHours)
        {
            Code = code;
            Title = title;
            WeeklyHours = weeklyHours;
        }
    }
}