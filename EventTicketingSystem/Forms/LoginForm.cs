using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EventTicketingSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            new UserPaymentForm().Show();
            this.Hide();
        }

        private void btnOrganizerLogin_Click(object sender, EventArgs e)
        {
            new OrganizerDashboard().Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
