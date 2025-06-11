namespace EventTicketingSystem.Forms
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblRevenue;
        private Label lblEvents;
        private Label lblTickets;
        private Button btnBack;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblRevenue = new Label();
            lblEvents = new Label();
            lblTickets = new Label();
            btnBack = new Button();
            lblTitle = new Label();

            // Form settings
            this.Text = "Admin Dashboard";
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;

            lblTitle.Text = "Admin Summary";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Size = new Size(400, 40);
            lblTitle.Location = new Point(20, 30);
            lblRevenue.Text = "Total Revenue:";
            lblRevenue.Font = new Font("Segoe UI", 12);
            lblRevenue.Location = new Point(200, 80);
            lblRevenue.AutoSize = true;

            lblEvents.Text = "Total Events:";
            lblEvents.Font = new Font("Segoe UI", 12);
            lblEvents.Location = new Point(200, 120);
            lblEvents.AutoSize = true;

            lblTickets.Text = "Tickets Booked:";
            lblTickets.Font = new Font("Segoe UI", 12);
            lblTickets.Location = new Point(200, 160);
            lblTickets.AutoSize = true;


            btnBack.Text = "Back";
            btnBack.Size = new Size(80, 35);
            btnBack.Location = new Point(500, 30);
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += btnBack_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblRevenue);
            this.Controls.Add(lblEvents);
            this.Controls.Add(lblTickets);
            this.Controls.Add(btnBack);
            this.Load += AdminDashboard_Load;
        }
    }
}

