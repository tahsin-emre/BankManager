
using MySql.Data.MySqlClient;

namespace BankManager.models
{
    internal class SubAccount(MySqlDataReader rdr)
    {
        public string AccountID = rdr["AccountID"].ToString()!;
        public string CustomerID = rdr["CustomerID"].ToString()!;
        public double Balance = double.Parse(rdr["Balance"].ToString() ?? "0");
        public string RegisterDate = rdr["RegistrationDate"].ToString()!;

        public ListViewItem ToItem()
        {
            ListViewItem item = new ListViewItem()
            {
                Text = AccountID,
                SubItems =
                {
                    Balance.ToString(),
                    RegisterDate,
                    CustomerID
                }
            };

            return item;
        }
        public string ToComboItem()
        {
            var item = $"{AccountID}-Balance:{Balance}";
            return item;
        }
    }
}
