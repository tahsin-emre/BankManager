using MySql.Data.MySqlClient;

namespace BankManager.models
{
    internal class Transaction(MySqlDataReader rdr)
    {
        public string TransactionID = rdr["TransactionID"].ToString()!;
        public string SenderID = rdr["SenderID"].ToString()!;
        public string ReceiverID = rdr["ReceiverID"].ToString()!;
        public string Price = rdr["Price"].ToString()!;
        public string ProcessDate = rdr["ProcessDate"].ToString()!;

        public ListViewItem ToItem()
        {
            ListViewItem item = new ListViewItem()
            {
                Text = TransactionID,
                SubItems = {
                    SenderID,
                    ReceiverID,
                    Price,
                    ProcessDate,
                }
            };
            return item;
        }
    }
}
