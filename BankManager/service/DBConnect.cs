
using MySql.Data.MySqlClient;
using System.Data;

namespace BankManager.service
{
    public class DBConnect
    {
        public static string server = "server=tahsinemre.com;port=3306;database=tahsinemre_bank;user=tahsinemre_manager;password=Admin.1881;";
        public static MySqlConnection conn = new MySqlConnection(server);
    }
}
