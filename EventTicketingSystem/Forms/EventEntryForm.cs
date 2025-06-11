using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace EventTicketingSystem.Forms
{
    public partial class EventEntryForm : Form
    {
        public EventEntryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEventId.Text == "" || txtLocation.Text == "" || dtpDate.Value == null)
            {
                MessageBox.Show("Please fill all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = "server=localhost;user=root;password=;database=eventdb;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO events (id, date, location) VALUES (@id, @date, @location)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEventId.Text));
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Event saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving event: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventEntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
