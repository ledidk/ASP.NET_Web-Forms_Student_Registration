using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public class ParttimeStudent : Student
    {
        public static int MaxNumOfCourses { get; set; }
        public ParttimeStudent(string name)
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

            if (selectedCourses.Count > MaxNumOfCourses)
            {
                throw new InvalidOperationException("You selection exceeds the maximum number of course: 3");

            }
            else
            {
   
                
                base.RegisterCourses(selectedCourses);
                //throw new InvalidOperationException($"Selected student has registere {totalCourses} Courses, {totalWeeklyHours} Weekly hours ");
            }

        }

        public override string ToString()
        {

            return $"{Id} - {Name} (Part time)";
        }

    }


}