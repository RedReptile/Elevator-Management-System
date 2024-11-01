using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Elevator_Management_System
{
    internal class DB
    {
        private readonly string connectionString = @"Server=DESKTOP-IRVKMUV\MSSQLSERVER01;Database=Lift;Trusted_Connection=True;";

        // Method to insert a new log into DataLogs table
        public void InsertLog(string action, string details)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DataLogs (Action, Details) VALUES (@Action, @Details)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.Parameters.AddWithValue("@Details", details);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable LoadLogs()
        {
            DataTable logsTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Action, Details, Timestamp FROM DataLogs order by Timestamp desc;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(logsTable);
                    }
                }
            }

            return logsTable;
        }

        


    }
}
