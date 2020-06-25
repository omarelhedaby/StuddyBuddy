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
    public partial class Delete_coursesT : Form
    {
        int back_DELETE;
        Controller controllerobj;
        private int privillege;
        private string ownerusername;

        public Delete_coursesT(string username, int priv)
        {
            back_DELETE = 0;
            ownerusername = username;
            privillege = priv;
            InitializeComponent();
            controllerobj = new Controller();
            DataTable dt = controllerobj.selectcourses_teacher(ownerusername);
            comboBox1.DisplayMember = "course name";
            comboBox1.ValueMember = "Course-ID";
            comboBox1.DataSource = dt;
        }

        private void Delete_coursesT_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (back_DELETE == 1)
            {
                back_DELETE = 0;
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Owner.Close();
            }
        }

        private void back3_Click(object sender, EventArgs e)
        {
            Owner.Show();
            back_DELETE = 1;
            this.Close();
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) //validation part
            {
                MessageBox.Show("NO COURSES TO DELETE");
            }
            else
            {
                int r = controllerobj.DeleteCourseT(ownerusername, Convert.ToInt32(comboBox1.SelectedValue));
                if (r > 0)
                {
                    MessageBox.Show("COURSE is deleted successfully");
                    updateCombobox_after_deletion();
                }
                else
                    MessageBox.Show("Error in deleting course");
            }
        }

        public void updateCombobox_after_deletion()
        {
            DataTable dt = controllerobj.selectcourses_teacher(ownerusername);

            comboBox1.DisplayMember = "course name";
            comboBox1.ValueMember = "Course-ID";
            comboBox1.DataSource = dt;

            if (dt == null)
            {
                label1.Text = "NO COURSES TO DELETE";
            }
            else
            {
                label1.Text = "CHOOSE COURSE :";
            }
            comboBox1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
