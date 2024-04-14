using MySql.Data.MySqlClient;

namespace BankManager.models
{
    public class Manager(MySqlDataReader reader)
    {
        public string ManagerID = reader["ManagerID"].ToString()!;
        public string Pwd = reader["Pwd"].ToString()!;
        public string UserName = reader["UserName"].ToString()!;
        public string FirstName = reader["FirstName"].ToString()!;
        public string LastName = reader["LastName"].ToString()!;
        public string RegistrationDate = reader["RegistrationDate"].ToString()!;


        public ListViewItem toItem()
        {
            ListViewItem item = new ListViewItem();
            item.Text = ManagerID;
            item.SubItems.Add(UserName);
            item.SubItems.Add(Pwd);
            item.SubItems.Add(FirstName);
            item.SubItems.Add(LastName);
            item.SubItems.Add(RegistrationDate);
            return item;
        }
    }


}
