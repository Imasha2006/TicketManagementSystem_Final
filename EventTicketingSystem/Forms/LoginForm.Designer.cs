namespace EventTicketingSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnUserLogin;
        private Button btnOrganizerLogin;
        private Button btnAdminLogin;
        //private PictureBox picUser;
        //private PictureBox picOrganizer;
        //private PictureBox picAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Event Ticketing Login";
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 245, 240);
            this.Load += new System.EventHandler(this.LoginForm_Load);

            // Title
            Label lblTitle = new Label
            {
                Text = "Select Your Role",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 30),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(800, 50),
                Location = new Point(0, 30)
            };

            Label lblSub = new Label
            {
                Text = "Choose your access level to continue",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(70, 70, 70),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(800, 30),
                Location = new Point(0, 70)
            };

   

            // Buttons
            btnUserLogin = new Button
            {
                Text = "Login as User",
                Size = new Size(140, 40),
                Location = new Point(135, 210),
                BackColor = Color.Teal,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnUserLogin.FlatAppearance.BorderSize = 0;
            btnUserLogin.Click += btnUserLogin_Click;

            btnOrganizerLogin = new Button
            {
                Text = "Login as Organizer",
                Size = new Size(140, 40),
                Location = new Point(345, 210),
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnOrganizerLogin.FlatAppearance.BorderSize = 0;
            btnOrganizerLogin.Click += btnOrganizerLogin_Click;

            btnAdminLogin = new Button
            {
                Text = "Login as Admin",
                Size = new Size(140, 40),
                Location = new Point(555, 210),
                BackColor = Color.Crimson,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnAdminLogin.FlatAppearance.BorderSize = 0;
            btnAdminLogin.Click += btnAdminLogin_Click;

            // Footer note
            Label lblHint = new Label
            {
                Text = "Please select a role to continue",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(800, 30),
                Location = new Point(0, 270)
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblSub);
            //this.Controls.Add(picUser);
            //this.Controls.Add(picOrganizer);
            //this.Controls.Add(picAdmin);
            this.Controls.Add(btnUserLogin);
            this.Controls.Add(btnOrganizerLogin);
            this.Controls.Add(btnAdminLogin);
            this.Controls.Add(lblHint);
        }
    }
}
