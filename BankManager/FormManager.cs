
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
        List<Card> cards = [];
        Customer? selectedCustomer;
        Account? selectedAccount;
        Card? selectedCard;
        public FormManager(Manager myManager)
        {
            manager = myManager;
            InitializeComponent();
        }
        private void FormManager_Load(object sender, EventArgs e)
        {
            changeTheme();
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
                DBService.Execute(query);
                getCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }

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
                    DBService.Execute(query);
                    getCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong..{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Select a customer for update");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                try
                {
                    string query = "DELETE FROM Customers " +
                    $"WHERE CustomerID={selectedCustomer?.CustomerID}";
                    DBService.Execute(query);
                    getCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong..{ex.Message}");
                }
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
            if (comboSelection != null)
            {
                try
                {
                    string query = "INSERT INTO Accounts (AccountID, CustomerID) " +
                      $"VALUES ({aid},{comboSelection.CustomerID ?? "0"});";
                    DBService.Execute(query);
                    getAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
        }
        private void btnUpdAcc_Click(object sender, EventArgs e)
        {
            selectedAccount = accounts.Where(x => x.AccountID == aidBox.Text).FirstOrDefault();
            Customer? comboSelection = customers.Where(x => x.ToComboItem() == comboBox1.Text).FirstOrDefault();
            if (comboSelection != null && selectedAccount != null)
            {
                try
                {
                    string query = "UPDATE Accounts " +
                    $"SET AccountID={selectedAccount?.AccountID ?? "0"},CustomerID={comboSelection?.CustomerID ?? "0"} " +
                    $"WHERE AccountID = {selectedAccount?.AccountID ?? "0"};";
                    DBService.Execute(query);
                    getAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
        }
        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            selectedAccount = accounts.Where(x => x.AccountID == aidBox.Text).FirstOrDefault();
            Customer? comboSelection = customers.Where(x => x.ToComboItem() == comboBox1.Text).FirstOrDefault();
            if (comboSelection != null && selectedAccount != null)
            {
                try
                {
                    string query = "DELETE FROM Accounts " +
                    $"WHERE AccountID={selectedAccount?.AccountID ?? "0"};";
                    DBService.Execute(query);
                    getAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
        }


        //Credit Card CRUD Operations
        private void btnCardUpdate(object sender, EventArgs e)
        {
            string limit = limitBox.Text;
            selectedCard = cards.Where(x => x.CardID == cardidBox.Text).FirstOrDefault();
            if (selectedCard != null)
            {
                try
                {
                    string query = "UPDATE Cards " +
                      $"SET CardLimit={limit}, IsVerify=1 " +
                      $"WHERE CardID = {selectedCard?.CardID ?? "0"};";
                    DBService.Execute(query);
                    getCards();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something Went Wrong.. {ex.Message}");
                }
            }
        }

        //Database Model Read Operations
        void getCustomers()
        {
            customers.Clear();
            customerListView.Items.Clear();
            comboBox1.Items.Clear();
            selectedCustomer = null;
            try
            {
                string query = "SELECT * FROM Customers ";
                MySqlDataReader rdr = DBService.Read(query);
                while (rdr.Read())
                {
                    Customer customer = new Customer(rdr);
                    customers.Add(customer);
                    customerListView.Items.Add(customer.ToListItem());
                    comboBox1.Items.Add(customer.ToComboItem());
                }
                DBService.conn.Close();
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
            try
            {
                string query = $"SELECT Accounts.*,Customers.FirstName,Customers.LastName,Customers.CitizenID " +
                    $"FROM Accounts " +
                    $"INNER JOIN Customers " +
                    $"ON Accounts.CustomerID = Customers.CustomerID";
                MySqlDataReader rdr = DBService.Read(query);
                while (rdr.Read())
                {
                    Account account = new Account(rdr);
                    accounts.Add(account);
                    accountListView.Items.Add(account.ToItem());
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
            try
            {
                string query = "SELECT * FROM Transactions";
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
            selectedCard = null;
            try
            {
                string query = "SELECT Cards.*, Customers.FirstName, Customers.LastName, Customers.CitizenID " +
               "FROM Cards " +
               "INNER JOIN Customers " +
               "ON Cards.CustomerID = Customers.CustomerID;";
                MySqlDataReader rdr = DBService.Read(query);
                while (rdr.Read())
                {
                    Card card = new Card(rdr);
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
            tabPage4.ForeColor = AppTheme.foreColor;
            tabPage4.BackColor = AppTheme.backColor;
            customerListView.BackColor = AppTheme.backColor;
            customerListView.ForeColor = AppTheme.foreColor;
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
