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
    public partial class OrganizerDashboard : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=eventdb;");

        public OrganizerDashboard()
        {
            InitializeComponent();
        }
        private void OrganizerDashboard_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }
        private void LoadPayments()
        {
            try
            {
                conn.Open();

                string query = "SELECT id, name, amount, payment_date FROM payments";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPayments.AutoGenerateColumns = false;
                dgvPayments.Columns.Clear();

                // Add columns manually
                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "id",
                    HeaderText = "Payment ID",
                    Name = "id"
                });

                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "name",
                    HeaderText = "Name",
                    Name = "name"
                });

                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "amount",
                    HeaderText = "Amount",
                    Name = "amount"
                });

                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "payment_date",
                    HeaderText = "Payment Date",
                    Name = "payment_date"
                });

                //dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                //{
                //DataPropertyName = "event_id",
                // HeaderText = "Event ID",
                // Name = "event_id"
                //s });

                dgvPayments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnCheckEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventId.Text))
            {
                MessageBox.Show("Please enter an Event ID.");
                return;
            }

            if (!int.TryParse(txtEventId.Text, out int eventId))
            {
                MessageBox.Show("Invalid Event ID.");
                return;
            }

            try
            {
                conn.Open();

                // Count tickets
                string ticketQuery = "SELECT SUM(quantity) FROM tickets WHERE event_id = @id AND status = 'Booked'";
                MySqlCommand cmdTickets = new MySqlCommand(ticketQuery, conn);
                cmdTickets.Parameters.AddWithValue("@id", eventId);
                object tickets = cmdTickets.ExecuteScalar();
                int totalTickets = tickets != DBNull.Value ? Convert.ToInt32(tickets) : 0;

                // Count event existence from events table instead of payments
                string eventQuery = "SELECT COUNT(*) FROM events WHERE id = @id";
                MySqlCommand cmdEvent = new MySqlCommand(eventQuery, conn);
                cmdEvent.Parameters.AddWithValue("@id", eventId);
                object result = cmdEvent.ExecuteScalar();
                int eventExists = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                lblEventResult.Text = $"Event Count: {eventExists}\nTickets Sold: {totalTickets}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking event: " + ex.Message);
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
        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Add any logic for cell clicks here if needed
        }

        private void txtEventId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
