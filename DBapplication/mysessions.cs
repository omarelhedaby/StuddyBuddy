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

    public partial class  mysessions : Form
    {
        private int privillege;
        private string ownerusername;
        int back;
        Controller controllerobj;

        public mysessions(string username,int priv)
        {
            back = 0;
            
            ownerusername = username;
            privillege = priv;
            InitializeComponent();
            controllerobj = new Controller();
            DataTable dt= controllerobj.selectteachercourses(ownerusername);
            comboBox1.DisplayMember = "course name";
            comboBox1.ValueMember = "Course-ID";
            comboBox1.DataSource = dt;
            updatesessions();
        }

        public void updatesessions()
        {

            DataTable dt = controllerobj.selectstos(ownerusername,(int) comboBox1.SelectedValue);
           
                listBox1.DisplayMember = "Username";
                listBox1.ValueMember = "studentid";
                listBox1.DataSource = dt;
            

            if (dt == null)
            {
                label3.Text = "NO OPENED SESSions Check youe notifciation";
                label2.Text = " ";

            }
            else
            {

                label3.Text = "Opened Sessions with";
                label2.Text = " Double Click on the username for more info or to end the session";
            }
            listBox1.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            back = 1;
            this.Close();
        }

        private void mysessions_FormClosed(object sender, FormClosedEventArgs e)
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

        private void opened_Click(object sender, EventArgs e)
        {
         //   new openedsessions(privillege,ownerusername).Show(this);
        }

        private void closed_Click(object sender, EventArgs e)
        {
         //   new closedsessions(privillege, ownerusername).Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatesessions();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int studentid = (int) listBox1.SelectedValue;
            viewinfostudent studentinfo = new viewinfostudent(studentid, privillege, ownerusername,1);
            studentinfo.Show(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mysessions_Load(object sender, EventArgs e)
        {

        }


    }
}
