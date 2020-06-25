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
    public partial class Form1 : Form
    {
        public int _privilege;
        public int id;
        private string username;
       public Form1(int privilage,string username1)
        {
           InitializeComponent();
           username = username1;
           id = 0;
           this._privilege = privilage;
           // if (privilege == )
           // {
           //    this.notification.Enabled = false;
           // }
        }

       public Form1()
       {


       }

        public string getusername()
        {
            return username;

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            new MyCourses(username, _privilege).Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
               new notification(username,_privilege).Show(this);
                this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            Owner.Show();
        }

        private void addCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void mysession_Click(object sender, EventArgs e)
        {
            new mysessions(username, _privilege).Show(this);
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("STINDER                                                is an APP to Help Teachers and Students connect with each other , find their studbuddy,and receiving help from each other.                                                     How to Use                                                                            Terms and conditions ");
        }

        private void editSpotsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditProfile(username, _privilege).Show(this);
            this.Hide();
        }
        
    }
}




