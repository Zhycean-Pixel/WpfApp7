using MySql.Data.MySqlClient;

public class DatabaseService
{
    private string _connStr = "Server=localhost;Database=udi_system;Uid=root;Pwd=BCROBOT888;";

    public void SaveUser(string username, string password)
    {
        using (var conn = new MySqlConnection(_connStr))
        {
            conn.Open();
            string sql = "INSERT INTO users (username, password) VALUES (@name, @pwd)";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.ExecuteNonQuery();
            }
        }
    }
}