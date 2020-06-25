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
    public partial class notification : Form1
    {
        int back; // responsible for closing without closing the owner 
        private int  priviliage;
        private string username1;
        Controller controllerobj;

        public notification( string username2,int priv)
        {
            back = 0;
            priviliage = priv;
            username1 = username2;
            InitializeComponent();
            controllerobj= new Controller();
            updatelistbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            back = 1;
            this.Close();
        }

        private void updatelistbox()
        {
            // check the privilage here 
            DataTable dt = controllerobj.selectsr(username1);
            
                listBox1.DisplayMember = "Username";
                listBox1.ValueMember = "student-id";
                listBox1.DataSource = dt;
            
            if (dt == null)
            {
                label1.Text = "NO one requested you";
                label2.Text = " ";
            }
            else
            {
                label1.Text = "People who requested YOU";
                label2.Text = " double click on the username to show more details";
            }
            listBox1.Refresh();
        }
        
        private void f(object sender, EventArgs e)
        {

        }

        private void notification_FormClosed(object sender, FormClosedEventArgs e)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            
            int studentid = (int)listBox1.SelectedValue;   
            viewinfostudent studentinfo = new viewinfostudent(studentid,priviliage,username1);
            studentinfo.Show(this);



        }

        private void refresh_Click(object sender, EventArgs e)
        {
            updatelistbox();
        }




    }
}
