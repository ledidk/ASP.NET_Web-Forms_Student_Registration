using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public class FulltimeStudent : Student
    {
        public static int MaxWeeklyHours { get; set; }
        public FulltimeStudent(string name)
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
                throw new InvalidOperationException("Your Selection exceeds the maximum weekly hours: 16 ");

            }
            else
            {
                 
                base.RegisterCourses(selectedCourses);

                //throw new InvalidOperationException($"Selected student has registere {totalCourses} Courses, {totalWeeklyHours} Weekly hours ");
                
            }



        }
        public override string ToString()
        {

            return $"{Id} - {Name} (Full time)";
        }





    }
}