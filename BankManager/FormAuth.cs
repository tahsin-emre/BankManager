using BankManager.models;
using BankManager.service;
using MySql.Data.MySqlClient;


namespace BankManager
{
    public partial class FormAuth : Form
    {
        AppTheme theme = new AppTheme();
        public FormAuth() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = textBox1.Text;
            string pwd = textBox2.Text;
            string query = $"SELECT * FROM Managers WHERE UserName='{uid}' AND Pwd='{pwd}'";
            MySqlDataReader reader = DBService.Read(query);
            if (reader.Read())
            {
                Manager myManager = new Manager(reader);
                FormManager formManager = new FormManager(myManager);
                this.Hide();
                DBService.conn.Close();
                formManager.ShowDialog();
                textBox2.Clear();
                this.Show();
            }
            else
            {
                DBService.conn.Close();
                MessageBox.Show("Authantication is not successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string cid = textBox3.Text;
            string pwd = textBox4.Text;
            string query = $"SELECT * FROM Customers WHERE CitizenID='{cid}' AND Pwd='{pwd}'";
            MySqlDataReader reader = DBService.Read(query);
            if (reader.Read())
            {
                Customer myCustomer = new Customer(reader);
                FormCustomer formCustomer = new FormCustomer(myCustomer);
                this.Hide();
                DBService.conn.Close();
                formCustomer.ShowDialog();
                textBox4.Clear();
                this.Show();
            }
            else
            {
                DBService.conn.Close();
                MessageBox.Show("Authantication is not successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                AppTheme.setDay();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                AppTheme.setNight();
            }
            changeTheme();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            changeTheme();
        }

        void changeTheme()
        {
            this.ForeColor = AppTheme.foreColor;
            this.BackColor = AppTheme.backColor;
            tabPage1.ForeColor = AppTheme.foreColor;
            tabPage1.BackColor = AppTheme.backColor;
            tabPage2.ForeColor = AppTheme.foreColor;
            tabPage2.BackColor = AppTheme.backColor;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
