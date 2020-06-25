using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Register : Form
    {

        
        Controller controllerObj;

        public Register()
        {

            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCollege();
            college.DataSource = dt;
            college.DisplayMember = "college name";
            college.ValueMember = "CollegeID";

            DataTable dt2 = controllerObj.SelectFaculty(college.SelectedValue.ToString());
            faculty.DataSource = dt2;
            faculty.DisplayMember = "faculty name";
            faculty.ValueMember = "Faculty-ID";


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectFaculty(college.SelectedValue.ToString());
            faculty.DataSource = dt;
            faculty.DisplayMember = "faculty name";
            faculty.ValueMember = "Faculty-ID";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectDepartment(faculty.SelectedValue.ToString(), college.SelectedValue.ToString());
            department.DataSource = dt;
            department.DisplayMember = "faculty name";
            department.ValueMember = "Faculty-ID";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label10.Hide();
            priceperhour.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {



            label10.Show();
            priceperhour.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
