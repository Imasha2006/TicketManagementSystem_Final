namespace EventTicketingSystem.Forms
{
    partial class TicketSaleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle, lblEventId, lblUser, lblType, lblQty;
        private System.Windows.Forms.TextBox txtEventId, txtUserName;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnProceed;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblEventId = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            lblQty = new System.Windows.Forms.Label();

            txtEventId = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            cmbTicketType = new System.Windows.Forms.ComboBox();
            numQuantity = new System.Windows.Forms.NumericUpDown();
            btnProceed = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(numQuantity)).BeginInit();
            SuspendLayout();

            // Title
            lblTitle.Text = "Book Tickets";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(100, 15);
            lblTitle.Size = new System.Drawing.Size(200, 30);

            // Event ID
            lblEventId.Text = "Event ID:";
            lblEventId.Location = new System.Drawing.Point(40, 55);
            txtEventId.Location = new System.Drawing.Point(140, 55);
            txtEventId.Size = new System.Drawing.Size(180, 23);

            // Name
            lblUser.Text = "Your Name:";
            lblUser.Location = new System.Drawing.Point(40, 90);
            txtUserName.Location = new System.Drawing.Point(140, 90);
            txtUserName.Size = new System.Drawing.Size(180, 23);

            // Type
            lblType.Text = "Ticket Type:";
            lblType.Location = new System.Drawing.Point(40, 125);
            cmbTicketType.Location = new System.Drawing.Point(140, 125);
            cmbTicketType.Items.AddRange(new object[] { "Normal", "VIP" });
            cmbTicketType.Size = new System.Drawing.Size(180, 23);

            // Quantity
            lblQty.Text = "Quantity:";
            lblQty.Location = new System.Drawing.Point(40, 160);
            numQuantity.Location = new System.Drawing.Point(140, 160);
            numQuantity.Minimum = 1;
            numQuantity.Maximum = 10;
            numQuantity.Value = 1;
            numQuantity.Size = new System.Drawing.Size(120, 23);

            // Button
            btnProceed.Text = "Continue to Payment";
            btnProceed.BackColor = System.Drawing.Color.Teal;
            btnProceed.ForeColor = System.Drawing.Color.White;
            btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProceed.FlatAppearance.BorderSize = 0;
            btnProceed.Location = new System.Drawing.Point(100, 210);
            btnProceed.Size = new System.Drawing.Size(160, 35);
            btnProceed.Click += new System.EventHandler(this.btnProceed_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblEventId);
            this.Controls.Add(txtEventId);
            this.Controls.Add(lblUser);
            this.Controls.Add(txtUserName);
            this.Controls.Add(lblType);
            this.Controls.Add(cmbTicketType);
            this.Controls.Add(lblQty);
            this.Controls.Add(numQuantity);
            this.Controls.Add(btnProceed);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Sale";
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.TicketSaleForm_Load);

            ((System.ComponentModel.ISupportInitialize)(numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


