
﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dbex
{
    internal class EventconClass
    {
        static string connectionString = "server=localhost;uid=root;pwd=;database=test";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        public static string AddEvent(string id ,string organizerid,string eventName, string eventDescription, DateTime eventDate, string eventLocation, string mor_ev , string locid)
        {
            
            EventClass eventClass = new EventClass(id,organizerid,eventName,eventDescription,eventDate, eventLocation,mor_ev,locid);
            

            if (id.Equals("") || organizerid.Equals("") || eventName.Equals("") || eventDescription.Equals("") || eventDate.Equals("") || mor_ev.Equals("") || eventLocation.Equals("") || locid.Equals(""))
            {
                return "Please fill all fields";
            }

            try
            {
                Convert.ToInt32(id);
                Convert.ToInt32(organizerid);
                Convert.ToInt32(locid);
            }
            catch (Exception ex)
            {
                return "Id must be a number.";
            }

            if (eventDate.Date <= DateTime.Today)
            {

                return "The date cannot be in the past.";
            }



            if (!AdminConClass.IsTimeAvailable(mor_ev, locid))
            {
                return $"{mor_ev} slot is already booked.";
            }


            // Check if the same organizer already has an event on the same date
            string dateCheckQuery = "SELECT COUNT(*) FROM eventtable WHERE organizerid = @orgid AND Eventdate = @edate";
            conn.Open();
            MySqlCommand dateCheckCmd = new MySqlCommand(dateCheckQuery, conn);
            dateCheckCmd.Parameters.AddWithValue("@orgid", eventClass.Organizerid);
            dateCheckCmd.Parameters.AddWithValue("@edate", eventClass.EventDate.ToString("yyyy-MM-dd"));
            int existingCount = Convert.ToInt32(dateCheckCmd.ExecuteScalar());
            conn.Close();

            if (existingCount > 0)
            {
                return "You already have an event scheduled on this date.";
            }

            //check if locationid is exist or not
            string checklocquery = "SELECT COUNT(*) FROM locationtable WHERE locid = @eventClass.Locid";
            conn.Open();
            MySqlCommand checklocmd = new MySqlCommand(checklocquery, conn);
            checklocmd.Parameters.AddWithValue("@eventClass.Locid", eventClass.Locid);
            int loccount = Convert.ToInt32(checklocmd.ExecuteScalar());
            conn.Close();

            if (loccount > 0)
            {
                //MessageBox.Show("login Successful");
                
            }
            else
            {
                return $"Event {eventClass.Locid} does not exist.";
            }



            //
            string query1 = "Select eventname,Eventdate,eventloc from eventtable WHERE id = @id";
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.Read())
                {
                    string dbename = reader.GetString("eventname");
                    string dbdate = reader.GetString("eventdate");
                    string dbloc = reader.GetString("eventloc");
                    conn.Close();

                    if (dbename.Equals(eventName))
                    {
                        DateTime newdate = eventClass.EventDate;
                        string newloc = eventClass.EventLocation;
                        string newdes = eventClass.EventDescription;
                        string new_mor_ev = eventClass.Mor_ev ;
                        conn.Open();
                        string query2 = "UPDATE eventtable SET Eventdate = @newdate, eventloc = @newloc, eventdes = @newdes,  time = @new_mor_ev  WHERE id = @id";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@newdes", newdes);
                        cmd2.Parameters.AddWithValue("@newdate", newdate);
                        cmd2.Parameters.AddWithValue("@newloc", newloc);
                        cmd2.Parameters.AddWithValue("@new_mor_ev", new_mor_ev);
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();
                        conn.Close();

                        AdminConClass.Setavailablity(eventClass.Mor_ev, locid);
                        return "Event already exists, updated the event";
                    }
                    else
                    {
                        return "Event id and name doesn't match";
                    }
                }
                conn.Close();

                

                conn.Open();
                string edate = eventClass.EventDate.ToString("yyyy-MM-dd");
                string query16 = "INSERT INTO eventtable (id, organizerid, eventname, Eventdate,eventloc,locidev,time,eventdes) VALUES (@eventClass.EventId, @eventClass.Organizerid, @eventClass.EventName, @edate, @eventClass.Eventloc, @locid , @eventClass.Mor_ev, @eventClass.EventDescription)";
                MySqlCommand cmd16 = new MySqlCommand(query16, conn);
                cmd16.Parameters.AddWithValue("@eventClass.EventId", eventClass.EventId);
                cmd16.Parameters.AddWithValue("@eventClass.Organizerid", eventClass.Organizerid);
                cmd16.Parameters.AddWithValue("@eventClass.EventName", eventClass.EventName);
                cmd16.Parameters.AddWithValue("@edate", edate);
                cmd16.Parameters.AddWithValue("@eventClass.Eventloc", eventClass.EventLocation);
                cmd16.Parameters.AddWithValue("@locid", locid);
                cmd16.Parameters.AddWithValue("@eventClass.Mor_ev", eventClass.Mor_ev);
                cmd16.Parameters.AddWithValue("@eventClass.EventDescription", eventClass.EventDescription);
                cmd16.ExecuteNonQuery();
                conn.Close();

                AdminConClass.Setavailablity(eventClass.Mor_ev, locid);
                return "Event added successfully";
            }

        }

        public static string DeleteItem(string id, string eventname)
        {
            if (id.Equals("") || eventname.Equals(""))
            {
                return "Please fill all fields";
            }
            try
            {
                Convert.ToInt32(id);
            }
            catch (Exception ex)
            {
                return "Id must be a number.";
            }

            string query = "SELECT eventname FROM eventtable WHERE id = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@eventname", eventname);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string dbename = reader.GetString("eventname");
                    conn.Close();
                    if (dbename.Equals(eventname))
                    {
                        ChangeLLocationStatus(id);
                        conn.Open();
                        string query1 = "DELETE FROM eventtable WHERE id = @id AND eventname = @eventname";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.Parameters.AddWithValue("@eventname", eventname);
                        cmd1.ExecuteNonQuery();
                        conn.Close();

                        return "Event deleted successfully";
                    }
                    else
                    {
                        return "Event id and name doesn't match";
                    }
                }
                conn.Close();
                return "Event not found";
            }

        }

        public static void ChangeLLocationStatus(string id)
        {
            //string connectionString = "server=localhost;uid=root;pwd=;database=test";
            string locid = "";
            string timeSlot = "";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Get location ID and time slot
                    string query = "SELECT locidev, time FROM eventtable WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                locid = reader["locidev"].ToString();
                                timeSlot = reader["time"].ToString();
                            }
                            else
                            {
                                Debug.WriteLine("No event found for the given id.");
                                return;
                            }
                        }
                    }

                    // Step 2: Update location status
                    string updateQuery = "";
                    if (timeSlot == "morning")
                        updateQuery = "UPDATE locationtable SET morning = 'available' WHERE locid = @locid";
                    else if (timeSlot == "evening")
                        updateQuery = "UPDATE locationtable SET evening = 'available' WHERE locid = @locid";
                    else
                    {
                        Debug.WriteLine("Invalid time slot.");
                        return;
                    }

                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.Add("@locid", MySqlDbType.VarChar).Value = locid;
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static List<string> ViewEvents()
        {
            List<string> items = new List<string>();
            string query = "SELECT * FROM eventtable";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string eventname = reader.GetString("eventname");
                            string eventdate = reader.GetString("Eventdate");
                            string eventloc = reader.GetString("eventloc");
                            string eventdes = reader.GetString("eventdes");
                            items.Add($"{id}       |      {eventname}        |     {eventdate}    |    {eventloc}  | {eventdes}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log error or show message
                    Debug.WriteLine($"Database error: {ex.Message}");
                    return null;
                }
            }

            return items;
        }
    }
}
