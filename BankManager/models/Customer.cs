using MySql.Data.MySqlClient;

namespace BankManager.models
{
    public class Customer(MySqlDataReader rdr)
    {
        public string CustomerID = rdr["CustomerID"].ToString()!;
        public string ManagerID = rdr["ManagerID"].ToString()!;
        public string CitizenID = rdr["CitizenID"].ToString()!;
        public string FirstName = rdr["FirstName"].ToString()!;
        public string LastName = rdr["LastName"].ToString()!;
        public string Email = rdr["Email"].ToString()!;
        public string Phone = rdr["PhoneNumber"].ToString()!;
        public string RegisterationDate = rdr["RegistrationDate"].ToString()!;

        public ListViewItem toItem()
        {
            ListViewItem item=new ListViewItem();
            item.Text = CustomerID;
            //item.SubItems.Add(CustomerID);
            item.SubItems.Add(CitizenID);
            item.SubItems.Add(FirstName);
            item.SubItems.Add(LastName);
            item.SubItems.Add(Email);
            item.SubItems.Add(Phone);
            item.SubItems.Add(RegisterationDate);
            item.SubItems.Add(ManagerID);
            return item;
        }
    
    }
}
