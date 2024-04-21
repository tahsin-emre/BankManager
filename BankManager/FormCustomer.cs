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
        List<Transaction> transactions = [];
        List<SubCard> cards = [];
        SubAccount? selectedAccount;
        public FormCustomer(Customer myCustomer)
        {
            customer = myCustomer;
            InitializeComponent();
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            changeTheme();
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
                    string query = "UPDATE Accounts " +
                       $"SET Balance={selectedAccount?.Balance + (double.Parse(amountBox.Value.ToString()))} " +
                       $"WHERE AccountID = {selectedAccount?.AccountID};";
                    DBService.Execute(query);
                    getAccounts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAccount != null)
                {
                    string query = "UPDATE Accounts " +
                        $"SET Balance={selectedAccount?.Balance - (double.Parse(amountBox.Value.ToString()))} " +
                        $"WHERE AccountID = {selectedAccount?.AccountID};";
                    DBService.Execute(query);
                    getAccounts();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string senderID = comboBox1.Text.Split("-")[0];
                string receiverID = textBox1.Text;
                string price = numericUpDown2.Value.ToString();
                bool start = false;
                string query0 = $"Select * FROM Accounts WHERE AccountID={receiverID}";
                MySqlDataReader rdr = DBService.Read(query0);
                start = rdr.Read();
                DBService.conn.Close();
                if (start)
                {
                    string query1 = "INSERT INTO Transactions (SenderID, ReceiverID, Price) " +
                       $"VALUES ({senderID},{receiverID},{price});";
                    string query2 = "UPDATE Accounts " +
                        $"SET Balance = Balance + {price} " +
                        $"WHERE AccountID={receiverID};";
                    string query3 = "UPDATE Accounts " +
                        $"SET Balance = Balance - {price} " +
                        $"WHERE AccountID={senderID};";
                    DBService.Execute(query1 + query2 + query3);
                    MessageBox.Show($"Successfully");
                }
                else
                {
                    MessageBox.Show($"There is no account with ID={receiverID}");
                }
            }
            catch (Exception ex)
            {
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
                string query = "INSERT INTO Cards (CardID, CustomerID,CardLimit,IsVerify) " +
                $"VALUES ('{cardno}',{customer.CustomerID},{limit},0);";
                DBService.Execute(query);
                getCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
        }
        void getAccounts()
        {
            accounts.Clear();
            accountListView.Items.Clear();
            comboBox1.Items.Clear();
            selectedAccount = null;
            label2.Text = "";
            label3.Text = "";
 
            try
            {
                string query = "SELECT * FROM Accounts " +
                 $"WHERE CustomerID={customer.CustomerID}";
                MySqlDataReader rdr = DBService.Read(query);
                while (rdr.Read())
                {
                    SubAccount account = new SubAccount(rdr);
                    accounts.Add(account);
                    accountListView.Items.Add(account.ToItem());
                    comboBox1.Items.Add(account.ToComboItem());
                }
                DBService.conn.Close();
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
            try
            {
                string query = "SELECT * FROM Transactions " +
                $"WHERE SenderID IN ({listAccount}) " +
                $"OR " +
                $"ReceiverID IN ({listAccount})";
                MySqlDataReader rdr = DBService.Read(query);
                while (rdr.Read())
                {
                    Transaction transaction = new Transaction(rdr);
                    transactions.Add(transaction);
                    transactionListView.Items.Add(transaction.ToItem());
                }
                DBService.conn.Close();
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
            try
            {
                string query = "SELECT * FROM Cards " +
                 $"WHERE CustomerID={customer.CustomerID}";
                MySqlDataReader rdr = DBService.Read(query);
                while (rdr.Read())
                {
                    SubCard card = new SubCard(rdr);
                    cards.Add(card);
                    cardListView.Items.Add(card.ToItem());
                }
                DBService.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
        }
        void getManager()
        {
            try
            {
                string query = "SELECT * FROM Managers " +
                $"WHERE ManagerID={customer.ManagerID}";
                MySqlDataReader rdr = DBService.Read(query);
                while (rdr.Read())
                {
                    manager = new Manager(rdr);
                }
                label8.Text = manager!.FirstName + " " + manager!.LastName;
                DBService.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
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
        void changeTheme()
        {
            this.ForeColor = AppTheme.foreColor;
            this.BackColor = AppTheme.backColor;
            tabPage1.ForeColor = AppTheme.foreColor;
            tabPage1.BackColor = AppTheme.backColor;
            tabPage2.ForeColor = AppTheme.foreColor;
            tabPage2.BackColor = AppTheme.backColor;
            tabPage3.ForeColor = AppTheme.foreColor;
            tabPage3.BackColor = AppTheme.backColor;
            accountListView.BackColor = AppTheme.backColor;
            accountListView.ForeColor = AppTheme.foreColor;
            transactionListView.BackColor = AppTheme.backColor;
            transactionListView.ForeColor = AppTheme.foreColor;
            cardListView.BackColor = AppTheme.backColor;
            cardListView.ForeColor = AppTheme.foreColor;

        }
        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppTheme.setDay();
            changeTheme();
        }
        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppTheme.setNight();
            changeTheme();
        }
    }
}
