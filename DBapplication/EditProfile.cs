using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class EditProfile : Form
    {
        int back;
        private int privillege;
        private string ownerusername;
        Controller controllerobj;
        public EditProfile(string username, int priv)
        {
            back = 0;
            ownerusername = username;
            privillege = priv;
            InitializeComponent();
            controllerobj = new Controller();

            DataTable dt = controllerobj.EditCollege(ownerusername);
            college.DataSource = dt;
            college.DisplayMember = "college name";
            college.ValueMember = "CollegeID";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            back = 1;
            this.Close();
        }
  


        private void updatefaculty()
        {
            DataTable dt = controllerobj.SelectFaculty(college.SelectedValue.ToString());
            faculty.DataSource = dt;
            faculty.DisplayMember = "faculty name";
            faculty.ValueMember = "Faculty-ID";

        }



        private void updateDepartment()
        {
            DataTable dt = controllerobj.SelectDepartment(faculty.SelectedValue.ToString(),college.SelectedValue.ToString());
            department.DataSource = dt;
            department.DisplayMember = "Department name";
            department.ValueMember = "Department-ID";
        }
        private void EditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (back == 1)
            {

                back = 0;
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Owner.Close();
            }
        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void college_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatefaculty();
        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDepartment();
        }

        private void department_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
