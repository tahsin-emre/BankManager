using BankManager.service;
using MySql.Data.MySqlClient;

namespace BankManager
{
    public partial class FormPassword : Form
    {
        string type;
        string userid;
        public FormPassword(string type, string userid)
        {
            InitializeComponent();
            this.type = type;
            this.userid = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE {type}s " +
                $"SET Pwd='{textBox1.Text}' " +
                $"WHERE {type}ID={userid}";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
                DBConnect.conn.Close();
                MessageBox.Show("Successfully");
                this.Close();

            }
            catch (Exception ex)
            {
                DBConnect.conn.Close();
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
        }
    }
}
