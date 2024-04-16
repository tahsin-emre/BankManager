
using BankManager.models;
using BankManager.service;
using MySql.Data.MySqlClient;

namespace BankManager
{

    public partial class FormManager : Form
    {

        Manager manager;
        List<Customer> customers = [];
        Customer? selectedCustomer;
        List<Account> accounts = [];
        Account? selectedAccount;
        List<Transaction> transactions = [];
        List<Card> cards = [];
        Card? selectedCard;


        public FormManager(Manager myManager)
        {
            manager = myManager;
            InitializeComponent();
        }
        private void FormManager_Load(object sender, EventArgs e)
        {
            label6.Text = $"{manager.FirstName} {manager.LastName}";
            getCustomers();
            getAccounts();
            getTransactions();
            getCards();
        }
        private void customerListClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = customerListView.SelectedItems[0];
            selectedCustomer = customers.Where(x => x.CustomerID.ToString() == item.Text).FirstOrDefault();
            cidBox.Text = selectedCustomer?.CitizenID ?? "";
            fNameBox.Text = selectedCustomer?.FirstName ?? "";
            lNameBox.Text = selectedCustomer?.LastName ?? "";
            emailBox.Text = selectedCustomer?.Email ?? "";
            phoneBox.Text = selectedCustomer?.Phone ?? "";
        }
        private void accountListClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = accountListView.SelectedItems[0];
            selectedAccount = accounts.Where(x => x.AccountID.ToString() == item.Text).FirstOrDefault();
            aidBox.Text = selectedAccount?.AccountID ?? "";
            comboBox1.Text = selectedAccount?.ToComboItem() ?? "";
        }
        private void cardListClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = cardListView.SelectedItems[0];
            selectedCard = cards.Where(x => x.CardID.ToString() == item.Text).FirstOrDefault();
            cardidBox.Text = selectedCard?.CardID ?? "";
            limitBox.Text = selectedCard?.CardLimit.ToString();
        }


        //Customer CRUD Operations
        private void btnNew_Click(object sender, EventArgs e)
        {
            string mid = manager.ManagerID;
            string cid = cidBox.Text;
            string pwd = "password";
            string fname = fNameBox.Text;
            string lname = lNameBox.Text;
            string email = emailBox.Text;
            string phone = phoneBox.Text;
            string query = "INSERT INTO Customers (ManagerID,CitizenID,Pwd,FirstName,LastName,Email,PhoneNumber) " +
                $"VALUES ({mid},'{cid}','{pwd}','{fname}','{lname}','{email}','{phone}');";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                cmd.ExecuteNonQuery();
                DBConnect.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
            getCustomers();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cid = cidBox.Text;
            string fname = fNameBox.Text;
            string lname = lNameBox.Text;
            string email = emailBox.Text;
            string phone = phoneBox.Text;
            string query = "UPDATE Customers " +
                $"SET CitizenID='{cid}',FirstName='{fname}',LastName='{lname}',Email='{email}',PhoneNumber='{phone}' " +
                $"WHERE CustomerID = {selectedCustomer?.CustomerID};";
            if (selectedCustomer != null)
            {
                try
                {
                    DBConnect.conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                    cmd.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong..{ex.Message}");
                }
                getCustomers();
            }
            else
            {
                MessageBox.Show("Select a customer for editing");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Customers " +
                $"WHERE CustomerID={selectedCustomer?.CustomerID}";
            if (selectedCustomer != null)
            {
                try
                {
                    DBConnect.conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                    cmd.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong..{ex.Message}");
                }
                getCustomers();
            }
            else
            {
                MessageBox.Show($"Select a customer for deleting.");
            }
        }

        //Account CRUD Operations
        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            string aid = aidBox.Text;
            Customer? comboSelection = customers.Where(x => x.ToComboItem() == comboBox1.Text).FirstOrDefault();
            string query = "INSERT INTO Accounts (AccountID, CustomerID) " +
                   $"VALUES ({aid},{comboSelection?.CustomerID ?? "0"});";
            if (comboSelection != null)
            {
                try
                {
                    DBConnect.conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                    cmd.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
            getAccounts();
        }
        private void btnUpdAcc_Click(object sender, EventArgs e)
        {
            selectedAccount = accounts.Where(x => x.AccountID == aidBox.Text).FirstOrDefault();
            Customer? comboSelection = customers.Where(x => x.ToComboItem() == comboBox1.Text).FirstOrDefault();
            string query = "UPDATE Accounts " +
                $"SET AccountID={selectedAccount?.AccountID ?? "0"},CustomerID={comboSelection?.CustomerID ?? "0"} " +
                $"WHERE AccountID = {selectedAccount?.AccountID ?? "0"};";
            if (comboSelection != null && selectedAccount != null)
            {
                try
                {
                    DBConnect.conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                    cmd.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
            getAccounts();
        }
        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            selectedAccount = accounts.Where(x => x.AccountID == aidBox.Text).FirstOrDefault();
            Customer? comboSelection = customers.Where(x => x.ToComboItem() == comboBox1.Text).FirstOrDefault();
            string query = "DELETE FROM Accounts " +
                $"WHERE AccountID={selectedAccount?.AccountID ?? "0"};";
            if (comboSelection != null && selectedAccount != null)
            {
                try
                {
                    DBConnect.conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                    cmd.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
            getAccounts();
        }


        //Credit Card CRUD Operations
        private void btnCardUpdate(object sender, EventArgs e)
        {
            string limit = limitBox.Text;
            selectedCard = cards.Where(x => x.CardID == cardidBox.Text).FirstOrDefault();
            string query = "UPDATE Cards " +
                $"SET CardLimit={limit}, IsVerify=1 " +
                $"WHERE CardID = {selectedCard?.CardID ?? "0"};";
            if (selectedCard != null)
            {
                try
                {
                    DBConnect.conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                    cmd.ExecuteNonQuery();
                    DBConnect.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
            getCards();
        }

        //Database Model Read Operations
        void getCustomers()
        {
            customers.Clear();
            customerListView.Items.Clear();
            comboBox1.Items.Clear();
            selectedCustomer = null;
            string query = "SELECT * FROM Customers ";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Customer customer = new Customer(rdr);
                    customers.Add(customer);
                    customerListView.Items.Add(customer.ToListItem());
                    comboBox1.Items.Add(customer.ToComboItem());
                }
                DBConnect.conn.Close();
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
            selectedAccount = null;
            string query = $"SELECT Accounts.*,Customers.FirstName,Customers.LastName,Customers.CitizenID " +
                $"FROM Accounts " +
                $"INNER JOIN Customers " +
                $"ON Accounts.CustomerID = Customers.CustomerID";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Account account = new Account(rdr);
                    accounts.Add(account);
                    accountListView.Items.Add(account.ToItem());
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
            string query = "SELECT * FROM Transactions";
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
            selectedCard = null;
            string query = "SELECT Cards.*, Customers.FirstName, Customers.LastName, Customers.CitizenID " +
                "FROM Cards " +
                "INNER JOIN Customers " +
                "ON Cards.CustomerID = Customers.CustomerID;";
            try
            {
                DBConnect.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnect.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Card card = new Card(rdr);
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPassword form = new FormPassword("Manager", manager.ManagerID);
            form.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getAccounts();
            getCustomers();
            getCards();
            getTransactions();
        }
    }
}
