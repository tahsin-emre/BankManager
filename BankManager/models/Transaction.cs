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


        public ListViewItem toItem()
        {
            ListViewItem item = new ListViewItem();
            item.Text = TransactionID;
            item.SubItems.Add(SenderID);
            item.SubItems.Add(ReceiverID);
            item.SubItems.Add(Price);
            item.SubItems.Add(ProcessDate);
            return item;
        }
    }
}
