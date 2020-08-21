using CollegeCore.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCore.Infrastructure
{
    public class WorkingDaysHoursCore
    {

        public int saveTimeSlot(TimeSlot timeSlots)
        {

            int count = 0;

            try
            {
                string query = "INSERT INTO college_db.timeslots VALUES ('" + timeSlots.Day_of_the_Week + "','" + timeSlots.Start_Time + "','" + timeSlots.End_Time + "','" + timeSlots.Type + "') ON DUPLICATE KEY UPDATE startTime = VALUES(startTime), endTime = VALUES(endTime), type = VALUES(type);";

                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();
                count = cmd.ExecuteNonQuery();


                con.Close();
            }
            catch (Exception e)
            {
            }


            return count;
        }

        public int saveWorkingDays(List<String> workingDays)
        {
            int count = 0;

            try
            {


                string Query = "DELETE FROM college_db.workingDays where 1=1;";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);

                con.Open();
                count = cmd.ExecuteNonQuery();


                con.Close();

                if (count > -1)
                {

                    foreach (string day in workingDays)
                    {


                        Query = "INSERT INTO college_db.workingDays(dayOfTheWeek) VALUES('" + day + "');";


                        con = new MySqlConnection(DBConnection.ConnectionString);


                        cmd = new MySqlCommand(Query, con);




                        con.Open();
                        count = cmd.ExecuteNonQuery();


                        con.Close();

                        if (count == -1)
                        {
                            break;
                        }


                    }




                }




            }
            catch (Exception ex)
            {

            }

            return count;


        }

        public List<WorkDays> getWorkingDays()
        {

            List<WorkDays> workDays = new List<WorkDays>();

            try
            {



                string Query = "SELECT * FROM college_db.workingDays;";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmd.ExecuteReader();
                List<string> weekdayArray = new List<string>();

                while (myReader.Read())
                {

                    weekdayArray.Add(myReader["dayOfTheWeek"].ToString());

                }



                var daysOfWeek = weekdayArray.ToArray().Select(str => str.ToDayOfWeek()).OrderBy(dow => dow);

                foreach (var day in daysOfWeek)
                {
                    WorkDays workDay = new WorkDays();

                    workDay.Day_of_the_Week = day.ToString();

                    workDays.Add(workDay);
                }

                con.Close();

            }
            catch (Exception ex)
            {

            }

            return workDays;


        }

        public int saveWorkingHours(WorkHours day)
        {

            int count = 0;

            try
            {
                String Query = "UPDATE college_db.workingDays SET startTime='" + day.Start_Time + "', endTime = '" + day.End_Time + "' WHERE dayOfTheWeek = '" + day.Day_of_the_Week + "';";


                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);


                MySqlCommand cmd = new MySqlCommand(Query, con);




                con.Open();
                count = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return count;

        }

        public List<WorkHours> getWorkingHours()
        {

            List<WorkHours> workDays = new List<WorkHours>();

            try
            {



                string Query = "SELECT * FROM college_db.workingDays;";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmd.ExecuteReader();
                List<WorkHours> weekdayArray = new List<WorkHours>();

                while (myReader.Read())
                {

                    WorkHours day = new WorkHours();

                    day.Day_of_the_Week = myReader["dayOfTheWeek"].ToString();
                    day.Start_Time = myReader["startTime"].ToString();
                    day.End_Time = myReader["endTime"].ToString();

                    weekdayArray.Add(day);

                }

                con.Close();


                var daysOfWeek = weekdayArray.ToArray().Select(str => str.Day_of_the_Week.ToDayOfWeek()).OrderBy(dow => dow);

                foreach (var day in daysOfWeek)
                {
                    WorkHours workDay = new WorkHours();

                    workDay.Day_of_the_Week = day.ToString();

                    foreach (WorkHours days in weekdayArray)
                    {
                        if (day.ToString() == days.Day_of_the_Week)
                        {
                            workDay.Start_Time = days.Start_Time;
                            workDay.End_Time = days.End_Time;
                            break;
                        }
                    }



                    workDays.Add(workDay);
                }



            }
            catch (Exception ex)
            {

            }

            return workDays;


        }






        public List<TimeSlot> getTimeSlots()
        {

            List<TimeSlot> workDays = new List<TimeSlot>();

            try
            {



                string Query = "SELECT * FROM college_db.timeslots;";
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmd.ExecuteReader();


                while (myReader.Read())
                {

                    TimeSlot day = new TimeSlot();

                    day.Day_of_the_Week = myReader["dayOfTheWeek"].ToString();
                    day.Start_Time = myReader["startTime"].ToString();
                    day.End_Time = myReader["endTime"].ToString();
                    day.Type = myReader["type"].ToString();

                    workDays.Add(day);

                }

                con.Close();


                workDays.Sort();



            }
            catch (Exception ex)
            {

            }

            return workDays;


        }


        public int removeTimeSlot(TimeSlot timeSlot) 
        {

            int count = 0;

            try 
            {

                String Query = "DELETE FROM college_db.timeslots WHERE startTime='" + timeSlot.Start_Time + "' AND dayOfTheWeek = '" + timeSlot.Day_of_the_Week + "';";


                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);


                MySqlCommand cmd = new MySqlCommand(Query, con);




                con.Open();
                count = cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception e)
            {

            }

            return count;
        }



    }

    public static class ExtensionMethods
    {
        public static DayOfWeek ToDayOfWeek(this string str)
        {
            return (DayOfWeek)Enum.Parse(typeof(DayOfWeek), str);
        }

    }
}
