using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DB
{
    private readonly string _connectionString;

    public DB()
    {
        _connectionString = @"Server=DESKTOP-IRVKMUV\MSSQLSERVER01;Database=Lift;Trusted_Connection=True;";
    }

    private SqlConnection GetConnection()
    {
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            return connection;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Database connection error: {ex.Message}");
            return null;
        }
    }

    public DataTable GetLogs()
    {
        var dataTable = new DataTable();
        try
        {
            using (var connection = GetConnection())
            {
                if (connection == null) return dataTable;

                var dataAdapter = new SqlDataAdapter("SELECT Action, Details, Timestamp FROM DataLogs ORDER BY Timestamp DESC", connection);
                dataAdapter.Fill(dataTable);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving logs: {ex.Message}");
        }
        return dataTable;
    }

    public void InsertLog(string action, string details, DataGridView dataGridView)
    {
        try
        {
            using (var connection = GetConnection())
            {
                if (connection == null) return;

                var query = "INSERT INTO DataLogs (Action, Details, Timestamp) VALUES (@Action, @Details, @Timestamp)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Action", action);
                    command.Parameters.AddWithValue("@Details", details);
                    command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                    command.ExecuteNonQuery();
                }
                dataGridView.DataSource = GetLogs();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error inserting log: {ex.Message}");
        }
    }

    public void SaveDataGridViewToDatabase(DataGridView dataGridView)
    {
        try
        {
            using (var connection = GetConnection())
            {
                if (connection == null) return;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    string action = row.Cells["Action"].Value?.ToString() ?? string.Empty;
                    string details = row.Cells["Details"].Value?.ToString() ?? string.Empty;

                    var checkQuery = "SELECT COUNT(*) FROM DataLogs WHERE Action = @Action AND Details = @Details";
                    using (var checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Action", action);
                        checkCommand.Parameters.AddWithValue("@Details", details);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0) continue;
                    }

                    var query = "INSERT INTO DataLogs (Action, Details, Timestamp) VALUES (@Action, @Details, @Timestamp)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Action", action);
                        command.Parameters.AddWithValue("@Details", details);
                        command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("All logs have been saved to the database.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving logs: {ex.Message}");
        }
    }


    private void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        try
        {
            using (var connection = GetConnection())
            {
                if (connection == null) return;

                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error executing command: {ex.Message}");
        }
    }

    public void InitializeDatabase()
    {
        try
        {
            using (var connection = GetConnection())
            {
                if (connection == null) return;

                string query = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DataLogs')
                    CREATE TABLE DataLogs (
                        Id INT IDENTITY PRIMARY KEY,
                        Action NVARCHAR(255),
                        Details NVARCHAR(255),
                        Timestamp DATETIME
                    );";

                ExecuteNonQuery(query);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error initializing database: {ex.Message}");
        }


    }

    public void ClearAllData()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "TRUNCATE TABLE DataLogs;"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }
}
