
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace BankManager.models
{
    internal class Account(MySqlDataReader rdr)
    {
        public string AccountID = rdr["AccountID"].ToString()!;
        public string CustomerID = rdr["CustomerID"].ToString()!;
        public double balance = double.Parse(rdr["Balance"].ToString()??"0");
        public string RegisterDate = rdr["RegistrationDate"].ToString()!;
        public string FirstName = rdr["FirstName"].ToString()!;
        public string LastName = rdr["LastName"].ToString()!;
        public string CitizenID = rdr["CitizenID"].ToString()!;


        public ListViewItem toItem()
        {
            ListViewItem item = new ListViewItem();
            item.Text = AccountID;
            item.SubItems.Add(CustomerID);
            item.SubItems.Add(balance.ToString());
            item.SubItems.Add(RegisterDate);
            item.SubItems.Add(FirstName);
            item.SubItems.Add(LastName);
            item.SubItems.Add(CitizenID);
            return item;
        }
    }
}
