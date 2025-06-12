namespace Dbex.Forms
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblRevenue = new Label();
            lblEvents = new Label();
            lblTickets = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(33, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(97, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Summary";
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Location = new Point(202, 130);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(83, 15);
            lblRevenue.TabIndex = 1;
            lblRevenue.Text = "Total Revenue:";
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.Location = new Point(202, 182);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(72, 15);
            lblEvents.TabIndex = 2;
            lblEvents.Text = "Total Events:";
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(202, 228);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(89, 15);
            lblTickets.TabIndex = 3;
            lblTickets.Text = "Tickets Booked:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(658, 34);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // UserPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lblTickets);
            Controls.Add(lblEvents);
            Controls.Add(lblRevenue);
            Controls.Add(lblTitle);
            Name = "UserPaymentForm";
            Text = "UserPaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRevenue;
        private Label lblEvents;
        private Label lblTickets;
        private Button btnBack;
    }
}