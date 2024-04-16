using BankManager.models;
using BankManager.service;
using MySql.Data.MySqlClient;

namespace BankManager
{
    public partial class FormCustomer : Form
    {
        Manager? manager;
        Customer customer;
        List<SubAccount> accounts = [];
        SubAccount? selectedAccount;
        List<Transaction> transactions = [];
        List<SubCard> cards = [];

        public FormCustomer(Customer myCustomer)
        {
            customer = myCustomer;
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            label1.Text = customer.FirstName + " " + customer.LastName;
            getManager();
            getAccounts();
            getTransactions();
            getCards();
        }

        private void accountListClick(object sender, MouseEventArgs e)
        {
            string aid = accountListView.SelectedItems[0].Text;
            selectedAccount = accounts.Where((e) => e.AccountID == aid).FirstOrDefault();
            label2.Text = selectedAccount?.AccountID ?? "";
            label3.Text = selectedAccount?.Balance.ToString() ?? "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAccount != null)
                {
                    DBConnect.conn.Open();
                    string query1 = "UPDATE Accounts " +
                        $"SET Balance={selectedAccount?.Balance + (double.Parse(amountBox.Value.ToString()))} " +
                        $"WHERE AccountID = {selectedAccount?.AccountID};";
                    MySqlCommand cmd1 = new MySqlCommand(query1, DBConnect.conn);
                    cmd1.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }
            }
            catch (Exception ex)
            {
                DBConnect.conn.Close();
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
            getAccounts();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAccount != null)
                {
                    DBConnect.conn.Open();
                    string query1 = "UPDATE Accounts " +
                        $"SET Balance={selectedAccount?.Balance - (double.Parse(amountBox.Value.ToString()))} " +
                        $"WHERE AccountID = {selectedAccount?.AccountID};";
                    MySqlCommand cmd1 = new MySqlCommand(query1, DBConnect.conn);
                    cmd1.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                DBConnect.conn.Close();
            }
            getAccounts();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string senderID = comboBox1.Text.Split("-")[0];
                string receiverID = textBox1.Text;
                string price = numericUpDown2.Value.ToString();
                string query0 = $"Select * FROM Accounts WHERE AccountID={receiverID}";
                bool start = false;
                string query1 = "INSERT INTO Transactions (SenderID, ReceiverID, Price) " +
                       $"VALUES ({senderID},{receiverID},{price});";
                string query2 = "UPDATE Accounts " +
                    $"SET Balance = Balance + {price} " +
                    $"WHERE AccountID={receiverID};";
                string query3 = "UPDATE Accounts " +
                    $"SET Balance = Balance - {price} " +
                    $"WHERE AccountID={senderID};";
                DBConnect.conn.Open();
                MySqlCommand cmd0 = new MySqlCommand(query0, DBConnect.conn);
                MySqlDataReader rdr0 = cmd0.ExecuteReader();
                if (rdr0.Read())
                {
                    DBConnect.conn.Close();
                    start = true;
                }
                else
                {
                    start = false;
                    DBConnect.conn.Close();
                    MessageBox.Show($"There is no account with ID={receiverID}");
                }
                if (start)
                {
                    DBConnect.conn.Open();
                    MySqlCommand cmd1 = new MySqlCommand(query1 + query2 + query3, DBConnect.conn);
                    cmd1.ExecuteNonQuery();
                    DBConnect.conn.Close();
                    MessageBox.Show($"Successfully");
                }
            }
            catch (Exception ex)
            {
                DBConnect.conn.Close();
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
            comboBox1.Text = "";
            textBox1.Clear();
            numericUpDown2.Value = 0;
            getAccounts();
            getTransactions();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string cardno = "";
            string limit = limitBox.Value.ToString();
            try
            {
                for (int i = 0; i < 16; i++)
                {
                    cardno += rnd.Next(0, 10).ToString();
                }
                DBConnect.conn.Open();
                string query = "INSERT INTO Cards (CardID, CustomerID,CardLimit,IsVerify) " +
                $"VALUES ('{cardno}',{customer.CustomerID},{limit},0);";
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
                DBConnect.conn.Close();
            }
            catch (Exception ex)
            {
                DBConnect.conn.Close();
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
            getCards();


        }


        void getAccounts()
        {
            accounts.Clear();
            accountListView.Items.Clear();
            comboBox1.Items.Clear();
            selectedAccount = null;
            string query = "SELECT * FROM Accounts " +
                $"WHERE CustomerID={customer.CustomerID}";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    SubAccount account = new SubAccount(rdr);
                    accounts.Add(account);
                    accountListView.Items.Add(account.ToItem());
                    comboBox1.Items.Add(account.ToComboItem());
                }
                DBConnect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
        }
        void getTransactions()
        {

            transactions.Clear();
            transactionListView.Items.Clear();
            string listAccount = "";
            for (int i = 0; i < accounts.Count; i++)
            {
                listAccount += accounts[i].AccountID;
                if (i != accounts.Count - 1)
                {
                    listAccount += ",";
                }
            }
            string query = "SELECT * FROM Transactions " +
                $"WHERE SenderID IN ({listAccount}) " +
                $"OR " +
                $"ReceiverID IN ({listAccount})";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Transaction transaction = new Transaction(rdr);
                    transactions.Add(transaction);
                    transactionListView.Items.Add(transaction.ToItem());
                }
                DBConnect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
        }
        void getCards()
        {
            cards.Clear();
            cardListView.Items.Clear();
            string query = "SELECT * FROM Cards " +
                $"WHERE CustomerID={customer.CustomerID}";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    SubCard card = new SubCard(rdr);
                    cards.Add(card);
                    cardListView.Items.Add(card.ToItem());
                }
                DBConnect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
        }
        void getManager()
        {
            string query = "SELECT * FROM Managers " +
                $"WHERE ManagerID={customer.ManagerID}";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Manager temp = new Manager(rdr);
                    manager = temp;
                }
                DBConnect.conn.Close();
            }
            catch (Exception ex)
            {
                DBConnect.conn.Close();
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
            label8.Text = manager?.FirstName + " " + manager?.LastName;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPassword form = new FormPassword("Customer", customer.CustomerID);
            form.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getAccounts();
            getCards();
            getTransactions();
            getManager();
        }
    }
}
