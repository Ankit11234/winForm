using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    private readonly string connectionString = "server=localhost;database=mydatabase;user=root;password=password;";

    public List<MyDataModel> GetRecords()
    {
        List<MyDataModel> records = new List<MyDataModel>();

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM mytable";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MyDataModel record = new MyDataModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Filename = Convert.ToString(reader["Filename"]),
                            Data = Convert.ToString(reader["Data"]),
                            UserName = Convert.ToString(reader["UserName"]),
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                            UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
                        };

                        records.Add(record);
                    }
                }
            }
        }

        return records;
    }

    public void InsertRecord(MyDataModel record)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string query = "INSERT INTO mytable (Filename, Data, UserName) VALUES (@Filename, @Data, @UserName)";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Filename", record.Filename);
                cmd.Parameters.AddWithValue("@Data", record.Data);
                cmd.Parameters.AddWithValue("@UserName", record.UserName);

                cmd.ExecuteNonQuery();
            }
        }
    }

}

public class MyDataModel
{
    public int Id { get; set; }
    public string Filename { get; set; }
    public string Data { get; set; }
    public string UserName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
