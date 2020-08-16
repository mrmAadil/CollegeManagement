using CollegeCore.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCore.Infrastructure
{
    public class StudentCore
    {
        public void insertYearSem(StudentModel objstudent)
        {
            try
            {
                string Query = "Insert into college_db.year_sem(year,semester) values('" + objstudent.Year + "','" + objstudent.Semester + "')";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                con.Close();

            }catch(Exception ex)
            {

            }
        }

        public List<StudentModel> getYearSem()
        {
            List<StudentModel> listStudent = new List<StudentModel>();
            try
            {
                string Query = "Select year,semester from college_db.year_sem";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    StudentModel objStudent = new StudentModel();
                    objStudent.Year = myReader["year"].ToString();
                    objStudent.Semester = myReader["semester"].ToString();
                    listStudent.Add(objStudent);
                }
            }
            catch (Exception ex)
            {
                
            }

            return listStudent;
        }

        public void updateYearSem(StudentModel objstudent,StudentModel objPrevStd)
        {
            try
            {
                string Query = "Update college_db.year_sem SET year = '"+objstudent.Year+"' , semester = '"+objstudent.Semester+ "' where year = '" + objPrevStd.Year + "' and semester = '"+objPrevStd.Semester+"'";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                con.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteYearSem(StudentModel objStudent) 
        {
            try
            {
                string Query = "Delete from college_db.year_sem where year = '"+objStudent.Year+"' and semester = '"+objStudent.Semester+"'";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                con.Close();

            }
            catch (Exception ex)
            {

            }
        }

    }
}
