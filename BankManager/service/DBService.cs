
using MySql.Data.MySqlClient;

namespace BankManager.service
{
    public class DBService
    {
        public static string domain = "domain.com";
        public static string pass = "secret_password";
        public static string db = "tahsinemre_bank";
        public static string user = "tahsinemre_manager";
        public static string connectionstring = $"server={domain};" +
            "port=3306;" +
            $"database={db};" +
            $"user={user};" +
            $"password={pass};";
        public static MySqlConnection conn = new MySqlConnection(connectionstring);

        public static void Execute(string query) {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       
        public static MySqlDataReader Read(string query) {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query,conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
