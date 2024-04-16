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

        public ListViewItem ToListItem()
        {
            var item = new ListViewItem()
            {
                Text = CustomerID,
                SubItems = {
                    CitizenID,
                    FirstName,
                    LastName,
                    Email,
                    Phone,
                    RegisterationDate,
                    ManagerID
                }
            };
            return item;
        }

        public string ToComboItem()
        {
            var item = $"{FirstName} {LastName} {CitizenID}";
            return item;
        }

    }
}
