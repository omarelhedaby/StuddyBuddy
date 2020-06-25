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
    public partial class viewinfostudent :  Form
    {
        private int studentid;
        Controller controllerobj;
       private string  ownerusername;
       private int privelage;
       int opened;
        public viewinfostudent(int id,int priv,string owner,int opened1=0)
        {
            opened = opened1;

            controllerobj= new Controller();
            studentid = id;
            InitializeComponent();
            privelage=priv;
            ownerusername = owner;


            DataRow drow = controllerobj.selectstudentbyid(id).Rows[0];
            string name1="";
            name1 = (string) drow["First name"] +(string) drow["last name"];     
            comboBox1.ValueMember = "courseid";
            comboBox1.DisplayMember = "course name";

            DataTable dt;
            if (opened == 0)
            {

                 dt = controllerobj.selectcoursenamebyidfromsrt(studentid, ownerusername);
                 rate1.Hide();
                 rate.Hide();
            }
            else
            {
                 dt = controllerobj.selectcoursenamebyidfromstos(studentid,ownerusername);
                 label11.Text = "Choose the Subject You want to end the Session For";
                 accept.Hide();
                 decline.Text = "End session";
                 rate1.Hide();  // rate is only showed withing students student can only rate student and vice versa
                 rate.Hide();
            }
            comboBox1.DataSource = dt;

            name.Text = name1;
            age.Text = drow["age"].ToString();
            gender.Text = (string) drow["gender"];
            city.Text = (string)drow["city"];
            district.Text = (string)drow["district"];

            Phone.Text = drow["Phone#"].ToString();
            score.Text = drow["score"].ToString();
            collegename.Text = (string)drow["College Name"];
            facultyname.Text = (string)drow["Faculty Name"];
            departmentname.Text = (string)drow["Department Name"];
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void accept_Click(object sender, EventArgs e)
        {
            int s=0;
            if (privelage == 2) /// i am a TEACHER
            {
                s = controllerobj.insertintostos(studentid, ownerusername,(int) comboBox1.SelectedValue);
                controllerobj.deletefromsrt(studentid,(int)comboBox1.SelectedValue);
            }
            else if (privelage == 3) // i am a astudent 
            {
                // here suppose insertintossos
                // here delete from srs

            }
          


            if (s > 0)
            {

                MessageBox.Show("Accepted Successfuly");

                    this.Close();


            }
            else
            {
                MessageBox.Show("Error in Accepting");



            }
         
           
        }

        private void decline_Click(object sender, EventArgs e)
        {


            if (opened == 0)
            {
                int p = controllerobj.deletefromsrt(studentid, (int)comboBox1.SelectedValue);
                if (p > 0)
                {
                    MessageBox.Show("Declined Successfuly");
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Error in Declining");


                }
            }
            else
            { // here it is in stos which is in the open session we can delete it from open session and add it it to closed sessions(optional for us)

                int p = controllerobj.deletefromstos(studentid, (int)comboBox1.SelectedValue);
                if (p > 0)
                {
                    MessageBox.Show("Session Ended Successfuly");
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Error in Session  Ending");


                }

                



            }
           
            

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
