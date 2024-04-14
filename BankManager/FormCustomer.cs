using BankManager.models;

namespace BankManager
{
    public partial class FormCustomer : Form
    {
        Customer customer;
        public FormCustomer(Customer myCustomer)
        {
            customer = myCustomer;
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            label1.Text=customer.FirstName+" "+customer.LastName;
        }
    }
}
