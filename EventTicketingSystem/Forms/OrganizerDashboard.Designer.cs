namespace EventTicketingSystem.Forms
{
    partial class OrganizerDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Button btnCheckEvent;
        private System.Windows.Forms.Label lblEventResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.btnCheckEvent = new System.Windows.Forms.Button();
            this.lblEventResult = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();

            // dgvPayments
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.Location = new System.Drawing.Point(20, 60);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.Size = new System.Drawing.Size(740, 280);
            this.dgvPayments.TabIndex = 0;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);

            // btnBack
            this.btnBack.Text = "Back";
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(680, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // lblTitle
            this.lblTitle.Text = "Payments Received";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 2;

            // txtEventId
            this.txtEventId.PlaceholderText = "Enter Event ID";
            this.txtEventId.Location = new System.Drawing.Point(20, 360);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(120, 23);
            this.txtEventId.TabIndex = 3;

            // btnCheckEvent
            this.btnCheckEvent.Text = "Check Event";
            this.btnCheckEvent.BackColor = System.Drawing.Color.Teal;
            this.btnCheckEvent.ForeColor = System.Drawing.Color.White;
            this.btnCheckEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckEvent.FlatAppearance.BorderSize = 0;
            this.btnCheckEvent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckEvent.Location = new System.Drawing.Point(150, 358);
            this.btnCheckEvent.Name = "btnCheckEvent";
            this.btnCheckEvent.Size = new System.Drawing.Size(100, 27);
            this.btnCheckEvent.TabIndex = 4;
            this.btnCheckEvent.Click += new System.EventHandler(this.btnCheckEvent_Click);

            // lblEventResult
            this.lblEventResult.Text = "Event Count:\nTickets Sold:";
            this.lblEventResult.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblEventResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEventResult.Location = new System.Drawing.Point(270, 363);
            this.lblEventResult.Name = "lblEventResult";
            this.lblEventResult.AutoSize = true;
            this.lblEventResult.TabIndex = 5;

            // OrganizerDashboard (Form)
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEventId);
            this.Controls.Add(this.btnCheckEvent);
            this.Controls.Add(this.lblEventResult);
            this.Name = "OrganizerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer Dashboard";
            this.Load += new System.EventHandler(this.OrganizerDashboard_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
