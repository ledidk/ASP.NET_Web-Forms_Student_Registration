using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public class Helper
    {

        public static List<Course> GetAvailableCourses()
        {
            List<Course> courses = new List<Course>();

            Course course = new Course("CST8282", "Introduction to Database Systems", 4);
            courses.Add(course);

            course = new Course("CST8253", "Web Programming II", 2);

            courses.Add(course);

            course = new Course("CST8256", "Web Programming Language I", 5);

            courses.Add(course);

            course = new Course("CST8255", "Web Imaging and Animations", 2);

            courses.Add(course);

            course = new Course("CST8254", "Network Operating System", 1);

            courses.Add(course);

            course = new Course("CST2200", "Data Warehouse Design", 3);

            courses.Add(course);

            course = new Course("CST2240", "Advance Database topics", 1);

            courses.Add(course);

            return courses;
        }

        public static Course GetCourseByCode(string code)
        {
            foreach (Course b in GetAvailableCourses())
            {
                if (b.Code == code)
                {
                    return b;
                }
            }
            return null;
        }
    }
}
