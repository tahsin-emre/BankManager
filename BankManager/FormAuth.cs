using BankManager.models;
using BankManager.service;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace BankManager
{
    public partial class FormAuth : Form
    {

        public FormAuth() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            string uid = textBox1.Text;
            string pwd = textBox2.Text;
            string query = $"SELECT * FROM Managers WHERE UserName='{uid}' AND Pwd='{pwd}'";
            MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Manager myManager = new Manager(reader);
                FormManager formManager = new FormManager(myManager);
                this.Hide();
                DBConnect.conn.Close();
                formManager.ShowDialog();
                textBox2.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                DBConnect.conn.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            string cid = textBox3.Text;
            string pwd = textBox4.Text;
            string query = $"SELECT * FROM Customers WHERE CitizenID='{cid}' AND Pwd='{pwd}'";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    Customer myCustomer = new Customer(reader);
                    FormCustomer formCustomer = new FormCustomer(myCustomer);
                    this.Hide();
                    DBConnect.conn.Close();
                    formCustomer.ShowDialog();
                    textBox4.Clear();
                    this.Show();
                } 
                else {
                    DBConnect.conn.Close();
                    MessageBox.Show("Wrong CitizenshipID or Password");
                }
               
            }
            catch (Exception ex)
            {
                DBConnect.conn.Close();
                MessageBox.Show($"Something Went Wrong {ex.Message}");
            }          
        }
    }
}
