using MySql.Data.MySqlClient;

namespace BankManager.models
{
    public class SubCard(MySqlDataReader rdr)
    {
        public string CardID = rdr["CardID"].ToString()!;
        public string CustomerID = rdr["CustomerID"].ToString()!;
        public double CardLimit = double.Parse(rdr["CardLimit"].ToString() ?? "0");
        public int isVerify = int.Parse(rdr["isVerify"].ToString() ?? "0");
        public string RegisterDate = rdr["RegistrationDate"].ToString()!;

        public ListViewItem ToItem()
        {
            ListViewItem item = new ListViewItem
            {
                Text = CardID,
                SubItems =
                {
                    CardLimit.ToString(),
                    intToVerifyStatus(isVerify),
                    RegisterDate,
                }
            };
            return item;
        }

        private string intToVerifyStatus(int i)
        {
            switch (i)
            {
                case 0: return "Unverified";
                case 1: return "Verified";
                default: return "Unknown Status";
            }
        }
    }
}
