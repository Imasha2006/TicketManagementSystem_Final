using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EventTicketingSystem.Forms
{
    public partial class TicketSaleForm : Form
    {
        private int normalRemaining = 30;
        private int vipRemaining = 20;

        public TicketSaleForm()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string ticketType = cmbTicketType.Text;
            int quantity = (int)numQuantity.Value;

            if (!int.TryParse(txtEventId.Text, out int eventId))
            {
                MessageBox.Show("Please enter a valid numeric Event ID.");
                return;
            }

            if (string.IsNullOrEmpty(userName) || ticketType == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (ticketType == "Normal" && quantity > normalRemaining)
            {
                MessageBox.Show("Not enough Normal tickets available.");
                return;
            }

            if (ticketType == "VIP" && quantity > vipRemaining)
            {
                MessageBox.Show("Not enough VIP tickets available.");
                return;
            }

            int pricePerTicket = ticketType == "Normal" ? 2000 : 5000;
            int total = quantity * pricePerTicket;

            try
            {
                string connStr = "server=localhost;user=root;password=;database=eventdb;";
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Check if event ID exists
                    var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM events WHERE id = @id", conn);
                    checkCmd.Parameters.AddWithValue("@id", eventId);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists == 0)
                    {
                        MessageBox.Show("Event ID not found. Please enter a valid one.");
                        return;
                    }

                    var cmd = new MySqlCommand(
                        "INSERT INTO tickets (event_id, user_name, ticket_type, quantity, status) VALUES (@e, @n, @t, @q, 'Booked')",
                        conn);
                    cmd.Parameters.AddWithValue("@e", eventId);
                    cmd.Parameters.AddWithValue("@n", userName);
                    cmd.Parameters.AddWithValue("@t", ticketType);
                    cmd.Parameters.AddWithValue("@q", quantity);
                    cmd.ExecuteNonQuery();
                }

                // Redirect to payment
                UserPaymentForm paymentForm = new UserPaymentForm(userName, total);
                paymentForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking ticket: " + ex.Message);
            }
        }

        private void TicketSaleForm_Load(object sender, EventArgs e)
        {
            // Optional: future dropdown support
        }
    }
}
