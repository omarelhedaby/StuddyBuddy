using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

//checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
        public int getidfromuserandpriv(string username, int priv)
        {
            if (priv == 2)
            {
                string query = "Select [Teacher-ID] from teacher where teacher.username='" + username + "';";
                return (int)dbMan.ExecuteScalar(query);
            }
            else if (priv == 3)
            {

                string query = "Select [Student-ID] from student where student.username='" + username + "';";
                return (int)dbMan.ExecuteScalar(query);

            }
            return 0;
        }
        public int CheckPassword_Basic(string username, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT priv from Users_basic where username = '" + username + "' and password='" + password + "';";            
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable SelectCollege()
        {
            string query = "SELECT * FROM COLLEGE;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectFaculty(string s)
        {
            string query = "SELECT * FROM Faculty Where [College-ID] = " + s + " ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepartment(string s, string s2)
        {
            string query = "SELECT [Department-ID],[Department Name] FROM Department Where [Faculty-ID] ="+ s+ "and [College-ID]= " + s2 + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable selectsr(string s)
        {
            
                string query = "select distinct [S Request T].[Student-ID],  username from   [S Request T],student where [S Request T].[Teacher-ID]=(select teacher.[Teacher-ID] from Teacher where username='" + s + "') and Student.[Student-ID]=[S Request T].[Student-ID] ;";
                return dbMan.ExecuteReader(query);
           
            
        }

        public DataTable selectstudentbyid(int id) // return the info of student and the name of department,faculty,college enrolled in
        {

            string query = "select [First name] ,[Last Name],Age,Gender,Phone#,city,District,Score,[Department Name],[Faculty Name],[College Name]  from Student,Department,Faculty,College where Student.[Department-ID]=Department.[Department-ID] and Student.[College-ID]=college.CollegeID and Student.[Faculty-ID]=Faculty.[Faculty-ID]" +
                " and student.[Student-ID]=" + id + ";";
             return dbMan.ExecuteReader(query);
        }

        public DataTable selectcoursenamebyidfromsrt(int sid,string ownerusername) // that the student takes
        {

      //   string query = "Select [-ID] from student where student.username='" + username + "';";
      //    return (string)dbMan.ExecuteScalar(query);
            int tid = getidfromuserandpriv(ownerusername, 2);
            string query="select [Course Name],courseid from Courses,[S Request T] where courses.[Course-ID]=[S Request T].courseid and [S Request T].[Student-ID]="+sid+ "and [S Request T].[Teacher-ID]=" +tid+ ";";

            return dbMan.ExecuteReader(query);
        }

        public DataTable selectcoursenamebyidfromstos(int sid, string ownerusername) //all courses  that the student takes
        {
            
            int tid = getidfromuserandpriv(ownerusername, 2);
            string query = "select [Course Name],courseid from Courses,stos where courses.[Course-ID]=stos.courseid and stos.studentid=" + sid + "and stos.teacherid=" + tid + ";";

            return dbMan.ExecuteReader(query);
        }

        public int deletefromsrt(int id,int courseid)
        {
            string query = "delete from [S Request T] where [Student-ID]=" + id + "and courseid="+ courseid +";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletefromstos(int id,int courseid)
        {
            string query = "delete from stos where studentid=" + id + "and courseid="+ courseid +";";
            return dbMan.ExecuteNonQuery(query);
        }  

        public int insertintostos(int sid, string ownerusername,int cid)
        {

          int tid=  getidfromuserandpriv(ownerusername,2);
          string query = "Insert into STOS(studentid,teacherid,courseid) Values(" + sid + "," + tid +","+ cid +");";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable selectstos(string s, int cid)
        {

            string query = "select studentid,username from Student,STOS  where studentid=[Student-ID] and courseid=" + cid + ";";
            return dbMan.ExecuteReader(query);   
           
        }


        /// ///////////////////////////////////////////////////////////////shorouk//////////////////////////////////////////////////////////////////////////////

        public DataTable selectcourses(string username)
        {
            int tid = getidfromuserandpriv(username, 2);
            string query = "SELECT [Course Name],[Course-ID] FROM Courses c WHERE NOT EXISTS(SELECT [Course-ID] FROM [Courses T] WHERE [Teacher-ID]=" + tid + "and c.[Course-ID]= [Course-ID] ); ";
            return dbMan.ExecuteReader(query);
            //hena by select el courses el msh mawgoda 3ndo 3ashan y add haga gdeda matzhrolsh el hagat el 3ndo check it hatta fe query fe sql
        }

        public int InsertCourseT(string ownerusername, int cid)
        {
            int tid = getidfromuserandpriv(ownerusername, 2);
            string query = " INSERT INTO [Courses T] VALUES (" + tid + "," + cid + ");";
            return dbMan.ExecuteNonQuery(query);
            //insert selected courses by a teacher  into Course T
        }

        public DataTable getallcoursesIDofteacher(string username) 
        {
            string query = "SELECT [Course Name] FROM Courses  c where  exists(SELECT * FROM [Courses T] t WHERE c.[Course-ID]=t.[Course-ID] and[Teacher-ID]=(SELECT [Teacher-ID] FROM Teacher WHERE username='" + username + "'));";
            return dbMan.ExecuteReader(query);
            //get all id of coursees related to teacher
        }

        public DataTable selectteachercourses(string ownerusername) 
        {
            int tid = getidfromuserandpriv(ownerusername, 2);
            string query = "select courses.[Course-ID] , [Course Name] from [Courses T],Courses where Courses.[Course-ID]= [Courses T].[Course-ID] and [Courses T].[Teacher-ID]=" + tid + "; ";
            return dbMan.ExecuteReader(query);
            // return all courses of teacher
        }

        public DataTable selectcourses_teacher(string username)
        {
            int tid = getidfromuserandpriv(username, 2);
            string query = "SELECT [Course Name],[Course-ID] FROM Courses c WHERE EXISTS(SELECT [Course-ID] FROM [Courses T] WHERE [Teacher-ID]=" + tid + "and c.[Course-ID]= [Course-ID] ); ";
            return dbMan.ExecuteReader(query);
            //hena by select el courses el msh mawgoda 3ndo 3ashan y add haga gdeda matzhrolsh el hagat el 3ndo check it hatta fe query fe sql
        }

        public int DeleteCourseT(string ownerusername, int cid)
        {
            int tid = getidfromuserandpriv(ownerusername, 2);
            string query = "delete from [Courses T] where [Teacher-ID]="+tid+" and [Course-ID]="+cid+";";
            return dbMan.ExecuteNonQuery(query);
            //delete selected courses by a teacher  into Course T
        }

        public DataTable EditCollege(string ownerusername)
        {
            int tid = getidfromuserandpriv(ownerusername, 2);
            string query = "SELECT [College Name],CollegeID FROM College c WHERE NOT EXISTS(SELECT [College-ID] FROM Teacher WHERE [Teacher-ID]="+tid+" and c.CollegeID= [College-ID] );";
            return dbMan.ExecuteReader(query);
        }

        /////////////////////////////////////////////////////////////end ///////////////////////////////////////////////////////////////////////////////////////

    }
}
