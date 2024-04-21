using BankManager.service;

namespace BankManager
{
    public partial class FormPassword : Form
    {
        string type;
        string userid;
        public FormPassword(string type, string userid)
        {
            InitializeComponent();
            this.type = type;
            this.userid = userid;
            this.ForeColor = AppTheme.foreColor;
            this.BackColor = AppTheme.backColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"UPDATE {type}s " +
                $"SET Pwd='{textBox1.Text}' " +
                $"WHERE {type}ID={userid}";
                DBService.Execute(query);
                MessageBox.Show("Successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong.. {ex.Message}");
            }
        }
    }
}
