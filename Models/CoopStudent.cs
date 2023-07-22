using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public class CoopStudent : Student
    {

        public static int MaxWeeklyHours { get; set; }
        public static int MaxNumOfCourses { get; set; }

        public CoopStudent(string name)
            : base(name)
        {

        }

        public override void RegisterCourses(List<Course> selectedCourses)
        {

            double totalWeeklyHours = 0;
            int totalCourses = 0;

            foreach (var total in selectedCourses)
            {

                totalWeeklyHours += total.WeeklyHours;
                totalCourses++;
            }

            if (totalWeeklyHours > MaxWeeklyHours)
            {
                throw new InvalidOperationException("Your selection exceeds the maximum weekly hours: 4");

            }
            else if (selectedCourses.Count > MaxNumOfCourses)
            {
                throw new InvalidOperationException("Your selection exceeds the maximum number of courses: 2");
            }
            else if(selectedCourses.Count < 1)
            {
                throw new InvalidOperationException("You need to select at least one course");
            }
            else
            {
                base.RegisterCourses(selectedCourses);
                //throw new InvalidOperationException($"Selected student has registere {totalCourses} Courses, {totalWeeklyHours} Weekly hours ");
                
            }

        }

        public override string ToString()
        {

            return $"{Id} - {Name} (Coop)";
        }
    }
}