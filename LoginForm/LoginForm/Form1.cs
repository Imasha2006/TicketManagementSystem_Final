
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Roleselection rs = new Roleselection();
            rs.Show();
            this.Hide();
        }

        private void Adminlogin_btn_Click(object sender, EventArgs e)
        {
            string adminId = AdminID_tb.Text.Trim();
            string username = username_tb.Text.Trim();
            string password = password_tb.Text.Trim();

            string connStr = "server=localhost;user=root;database=admin;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_admin WHERE adminID = @id AND username = @uname AND password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", adminId);
                        cmd.Parameters.AddWithValue("@uname", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful.");
                                // Optionally open admin dashboard here
                                // new AdminDashboard().Show();
                                // this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("User not found. Please check your credentials.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}

