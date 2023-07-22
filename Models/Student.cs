using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }
        public List<Course> RegisteredCourses { get; }
        
        public Student(string name)
        {
            Name = name;
            Random rnd = new Random();
            Id = rnd.Next(911111, 999999);
            RegisteredCourses = new List<Course>();
            // add new student to list of class student - full time , pART TIME - coop

        }

        public virtual void RegisterCourses(List<Course>selectedCourses)
        {
            RegisteredCourses.Clear();

            RegisteredCourses.AddRange(selectedCourses);
            
            /*foreach(var c in selectedCourses)
            {
                RegisteredCourses.Add(c);
            }*/
        }

        public int TotalWeeklyHours()
        {
            double totalWeeklyHours = 0;

             foreach(var total in RegisteredCourses )
            {

                totalWeeklyHours += total.WeeklyHours;
            }

            return (int)totalWeeklyHours ;

        }






        
    }




}