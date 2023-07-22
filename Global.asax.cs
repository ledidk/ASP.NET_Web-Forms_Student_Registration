using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using Lab8.Models;

namespace Lab8
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FulltimeStudent.MaxWeeklyHours = 16;
            ParttimeStudent.MaxNumOfCourses = 3;
            CoopStudent.MaxWeeklyHours = 4;
            CoopStudent.MaxNumOfCourses = 2;


        }
    }
}