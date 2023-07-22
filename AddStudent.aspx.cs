using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab8.Models;

namespace Lab8
{
    public partial class AddStudent : System.Web.UI.Page
    {

        public static List<Student> students = new List<Student>();

        protected void Page_Load(object sender, EventArgs e)
        {



            if (Session["students"] == null)
            {
                // Add the student object to session state.
                Session["students"] = students;
            }
            else
            {
                students = (List<Student>)Session["students"];
            }
            StudentTableNames();


        }

        protected void btn_Add(object sender, System.EventArgs e)
        {

            string studentName = lblStudentName.Text;
            string studentTypeValue = drpType.SelectedValue;

            if (!studentName.Equals("") && studentTypeValue.Equals("0"))
            {
                students.Add(new FulltimeStudent(studentName));

            }
            else if (!studentName.Equals("") && studentTypeValue.Equals("1"))
            {
                students.Add(new ParttimeStudent(studentName));
            }
            else if (!studentName.Equals("") && studentTypeValue.Equals("2"))
            {
                students.Add(new CoopStudent(studentName));
            }
            else
            {

            }


            StudentTableNames();




        }
        protected void StudentTableNames()
        {

            tblStudents.Rows.Clear();


            TableRow rowNew = new TableRow();
            tblStudents.Rows.Add(rowNew);
            TableCell cell = new TableCell();
            rowNew.Cells.Add(cell);
            cell.Text = "Id";

            cell = new TableCell();
            rowNew.Cells.Add(cell);
            cell.Text = "Name";

            if (students.Count > 0)
            {
                //adding items into the tabble
                foreach (Student s in students)
                {

                    rowNew = new TableRow();
                    tblStudents.Rows.Add(rowNew);

                    cell = new TableCell();
                    rowNew.Cells.Add(cell);
                    cell.Text = s.Id.ToString();

                    cell = new TableCell();
                    rowNew.Cells.Add(cell);
                    cell.Text = s.Name;
                }
            }
            else
            {
                rowNew = new TableRow();
                tblStudents.Rows.Add(rowNew);

                cell = new TableCell();
                rowNew.Cells.Add(cell);
                cell.Text = "";

                cell = new TableCell();
                rowNew.Cells.Add(cell);
                cell.Text = "No student Yet !";
                cell.Style["color"] = "red";
            }


        }



    }
}