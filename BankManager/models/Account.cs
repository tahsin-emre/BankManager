
using MySql.Data.MySqlClient;

namespace BankManager.models
{
    internal class Account(MySqlDataReader rdr)
    {
        public string AccountID = rdr["AccountID"].ToString()!;
        public string CustomerID = rdr["CustomerID"].ToString()!;
        public double Balance = double.Parse(rdr["Balance"].ToString()??"0");
        public string RegisterDate = rdr["RegistrationDate"].ToString()!;
        public string FirstName = rdr["FirstName"]?.ToString()??"";
        public string LastName = rdr["LastName"]?.ToString()??"";
        public string CitizenID = rdr["CitizenID"]?.ToString()??"";


        public ListViewItem ToItem()
        {
            ListViewItem item = new ListViewItem()
            {
                Text = AccountID,
                SubItems =
                {
                    Balance.ToString(),
                    RegisterDate,
                    CustomerID,
                    FirstName,
                    LastName,
                    CitizenID
                }
            };
           
            return item;
        }

        public string ToComboItem()
        {
            var item = $"{FirstName} {LastName} {CitizenID}";
            return item;
        }

        public string ToCombo2Item()
        {
            var item = $"{AccountID} {Balance}";
            return item;
        }
    }
}
