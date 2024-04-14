
using BankManager.models;
using BankManager.service;
using MySql.Data.MySqlClient;

namespace BankManager
{

    public partial class FormManager : Form
    {

        Manager manager;
        List<Customer> customers = [];
        List<Account> accounts = [];
        List<Transaction> transactions = [];
        int selectedCustomerID = 0;
        int selectedAccountID = 0;

        public FormManager(Manager myManager)
        {
            manager = myManager;
            InitializeComponent();
        }
        private void FormManager_Load(object sender, EventArgs e)
        {
            label6.Text = $"{manager.FirstName} {manager.LastName}";
            listView1.Select();
            getTables();
        }
        private void getTables()
        {
            customers.Clear();
            accounts.Clear();
            transactions.Clear();
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            comboBox1.Items.Clear();
            DBConnect.conn.Open();
            string query1 = "SELECT * from Customers";
            MySqlCommand cmd1 = new MySqlCommand(query1, DBConnect.conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                Customer customer = new Customer(rdr1);
                customers.Add(customer);
                listView1.Items.Add(customer.toItem());
                comboBox1.Items.Add(customer.FirstName + " " + customer.LastName + " " + customer.CitizenID);
            }
            listView1.Items.Add(new ListViewItem());
            DBConnect.conn.Close();
            DBConnect.conn.Open();
            string query2 = "SELECT Accounts.*,Customers.FirstName,Customers.LastName, Customers.CitizenID " +
                "from Accounts " +
                "INNER JOIN Customers " +
                "ON Accounts.CustomerID = Customers.CustomerID;";
            MySqlCommand cmd2 = new MySqlCommand(query2, DBConnect.conn);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                Account account = new Account(rdr2);
                accounts.Add(account);
                listView2.Items.Add(account.toItem());
            }
            DBConnect.conn.Close();
            DBConnect.conn.Open();
            string query3 = "SELECT * FROM Transactions;";
            MySqlCommand cmd3 = new MySqlCommand(query3, DBConnect.conn);
            MySqlDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read())
            {
                Transaction transaction = new Transaction(rdr3);
                transactions.Add(transaction);
                listView3.Items.Add(transaction.toItem());
            }
            DBConnect.conn.Close();
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            selectedCustomerID = int.Parse(item.Text);
            textBox1.Text = item.SubItems[1].Text;
            textBox2.Text = item.SubItems[2].Text;
            textBox3.Text = item.SubItems[3].Text;
            textBox4.Text = item.SubItems[4].Text;
            textBox5.Text = item.SubItems[5].Text;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            string query = "INSERT INTO Customers (ManagerID,CitizenID,Pwd,FirstName,LastName,Email,PhoneNumber) VALUES " +
                $"({manager.ManagerID},'{textBox1.Text}','password','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong..");
            }
            DBConnect.conn.Close();
            getTables();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getTables();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            string query = "UPDATE Customers " +
                $"SET CitizenID='{textBox1.Text}',FirstName='{textBox2.Text}',LastName='{textBox3.Text}',Email='{textBox4.Text}',PhoneNumber='{textBox5.Text}' " +
                $"Where CustomerID = {selectedCustomerID};";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong..{ex.Message}");
            }
            DBConnect.conn.Close();
            getTables();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            string query = "DELETE FROM Customers " +
                $"WHERE CustomerID={selectedCustomerID}";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong..{ex.Message}");
            }
            DBConnect.conn.Close();
            getTables();
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView2.SelectedItems[0];
            selectedAccountID = int.Parse(item.Text);
            Account selectedAccount = accounts.Where(a => a.AccountID == item.Text).First();
            textBox6.Text = item.Text;
            comboBox1.Text = selectedAccount.FirstName+" "+selectedAccount.LastName+" "+selectedAccount.CitizenID;
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            List<Customer> list = customers;
            Customer selectedCustomer = list.Where(x => (x.FirstName + " " + x.LastName + " " + x.CitizenID) == comboBox1.Text).First();
            DBConnect.conn.Open();
            string query = "INSERT INTO Accounts (AccountID, CustomerID) " +
                $"VALUES ({textBox6.Text},{selectedCustomer.CustomerID});";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong..");
            }
            DBConnect.conn.Close();
            getTables();
        }

        private void btnUpdAcc_Click(object sender, EventArgs e)
        {
            List<Customer> list = customers;
            Customer selectedCustomer = list.Where(x => (x.FirstName + " " + x.LastName + " " + x.CitizenID) == comboBox1.Text).First();
            DBConnect.conn.Open();
            string query = "UPDATE Accounts " +
                $"SET AccountID={textBox6.Text},CustomerID={selectedCustomer.CustomerID} " +
                $"WHERE AccountID = {selectedAccountID};";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong..{ex.Message}");
            }
            DBConnect.conn.Close();
            getTables();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            DBConnect.conn.Open();
            string query = "DELETE FROM Accounts " +
                $"WHERE AccountID={selectedAccountID}";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong..{ex.Message}");
            }
            DBConnect.conn.Close();
            getTables();
        }
    }
}
