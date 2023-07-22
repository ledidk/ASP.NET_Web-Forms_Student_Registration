using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab8.Models;

namespace Lab8
{
    public partial class RegisterCourse : System.Web.UI.Page
    {
        public static List<Student> students = new List<Student>();

        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (this.IsPostBack == false)
            {
                foreach (Course b in Helper.GetAvailableCourses())
                {
                    chklst.Items.Add(new ListItem(b.Title + " " + "-" + " " + b.WeeklyHours.ToString() + " " + "hours/week", b.Code));
                }
            }

                if (Session["students"] == null)
            {
                // Add the student object to session state.
                Session["students"] = students;
            }
            else
            {
                students = (List<Student>)Session["students"];
            }
            foreach(Student student in students)
            {
                drplst.Items.Add(new ListItem(student.ToString(), count.ToString()));
                //drplst.Items.Add(new ListItem(student.ToString(), student.Id.ToString()));
                count ++;
            }


        }

        protected void cmd_submit(object sender, System.EventArgs e)
        {
            //list to hold selected courses and hours
            List<Course> coursess = new List<Course>();

            lblErrorMsg.Visible = false;

            lblResult.Visible = false;


            //loop to add course by its value in our coursess list of cmd_submit method
            foreach (ListItem course in chklst.Items)
            {
                if (course.Selected)

                {
                    //adding courses by targeting its value in selected checklist
                    coursess.Add(Helper.GetCourseByCode(course.Value));
            
                }
            }

            try
            {
                //throw class error if there is not valid 

                students[int.Parse(drplst.SelectedValue)].RegisterCourses(coursess);

                double totalWeeklyHours = 0;
                int totalCourses = 0;

                foreach (var total in coursess)
                {

                    totalWeeklyHours += total.WeeklyHours;
                    totalCourses++;
                }
                lblResultMsg.Visible = true;
                lblResultMsg.Style["color"] = "blue"; // styling result msg
                lblResultMsg.Text = $"Selected student has registere {totalCourses} Courses, {totalWeeklyHours} Weekly hours ";


            }
            catch(Exception exception)
            {
                //print throw invalid exception erro msg

                lblErrorMsg.Visible = true;
                lblResultMsg.Visible = false; //result set back to false

                lblErrorMsg.Style["color"] = "red"; //styling error msg
                lblErrorMsg.Text = exception.Message;

            }




        }

        protected void drplst_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem course in chklst.Items)
            {
                if (course.Selected)
                {
               
                }
            }
        }
    }
}