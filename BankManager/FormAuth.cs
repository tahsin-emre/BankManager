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
            MySqlCommand cmd = new MySqlCommand($"select * from Managers where UserName='{uid}' and Pwd='{pwd}'", DBConnect.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            textBox1.Clear();
            textBox2.Clear();
            if (reader.Read())
            {
                Manager myManager = new Manager(reader);
                FormManager formManager = new FormManager(myManager);
                this.Hide();
                DBConnect.conn.Close();
                formManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
                DBConnect.conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;
            cmd = new MySqlCommand("Select * from Managers", DBConnect.conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Manager manager = new Manager(reader);
                listView1.Items.Add(manager.toItem());
            }
            DBConnect.conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;
            cmd = new MySqlCommand("Select * from Customers", DBConnect.conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer(reader);
                listView2.Items.Add(customer.toItem());
            }
            DBConnect.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            string cid = textBox3.Text;
            string pwd = textBox4.Text;
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Customers where CitizenID='{cid}' and Pwd='{pwd}'", DBConnect.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            textBox3.Clear();
            textBox4.Clear();
            if (reader.Read())
            {
                Customer myCustomer = new Customer(reader);
                FormCustomer formCustomer = new FormCustomer(myCustomer);
                this.Hide();
                DBConnect.conn.Close();
                formCustomer.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong CitizenshipID or Password");
                DBConnect.conn.Close();
            }
        }
    }
}
