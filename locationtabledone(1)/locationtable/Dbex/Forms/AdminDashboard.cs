using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbex.Forms
{
    public partial class AdminDashboard : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=eventdb;");

        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }
        private void LoadSummary()
        {
            try
            {
                conn.Open();

                // Total revenue (sum of payments.amount)
                string revenueQuery = "SELECT COALESCE(SUM(amount), 0) FROM payments";
                MySqlCommand cmd1 = new MySqlCommand(revenueQuery, conn);
                object revenue = cmd1.ExecuteScalar();
                lblRevenue.Text = "Total Revenue: LKR " + Convert.ToDecimal(revenue).ToString("N2");

                // Events held (count distinct event_ids from tickets where status = 'booked')
                string eventQuery = "SELECT COUNT(DISTINCT event_id) FROM tickets WHERE LOWER(status) = 'booked'";
                MySqlCommand cmd2 = new MySqlCommand(eventQuery, conn);
                object eventCount = cmd2.ExecuteScalar();
                lblEvents.Text = "Events Held: " + Convert.ToInt32(eventCount);

                // Tickets sold (sum quantity from tickets where status = 'booked')
                string ticketQuery = "SELECT COALESCE(SUM(quantity), 0) FROM tickets WHERE LOWER(status) = 'booked'";
                MySqlCommand cmd3 = new MySqlCommand(ticketQuery, conn);
                object tickets = cmd3.ExecuteScalar();
                lblTickets.Text = "Tickets Sold: " + Convert.ToInt32(tickets);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();

        }
    }
}
    
        
    
