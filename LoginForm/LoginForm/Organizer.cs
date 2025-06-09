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

namespace LoginForm
{
    public partial class Organizer : Form
    {
        public Organizer()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Roleselection rs = new Roleselection();
            rs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//login button
        {
            
        
            string organizerId = organizerid_btn.Text;
            string username = username_btn.Text;
            string password = password_btn.Text;

            string connStr = "server=localhost;user=root;database=organizer;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM tbl_organizer WHERE organizerID = @id AND username = @uname AND password = @pass";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", organizerId);
                cmd.Parameters.AddWithValue("@uname", username);
                cmd.Parameters.AddWithValue("@pass", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login successful.");
                    // Show organizer dashboard or next form
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
