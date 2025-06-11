namespace EventTicketingSystem.Forms
{
    partial class UserPaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblCard = new Label();
            lblExpiry = new Label();
            lblCVV = new Label();
            lblAmount = new Label();
            txtName = new TextBox();
            txtCardNumber = new TextBox();
            txtExpiry = new TextBox();
            txtCVV = new TextBox();
            txtAmount = new TextBox();
            btnPay = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(110, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payment Portal";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblName
            // 
            lblName.Location = new Point(40, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblCard
            // 
            lblCard.Location = new Point(40, 120);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(100, 23);
            lblCard.TabIndex = 3;
            lblCard.Text = "Card Number:";
            // 
            // lblExpiry
            // 
            lblExpiry.Location = new Point(40, 160);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(100, 23);
            lblExpiry.TabIndex = 5;
            lblExpiry.Text = "Expiry (MM/YYYY):";
            // 
            // lblCVV
            // 
            lblCVV.Location = new Point(40, 200);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(100, 23);
            lblCVV.TabIndex = 7;
            lblCVV.Text = "CVV:";
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(40, 240);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(100, 23);
            lblAmount.TabIndex = 9;
            lblAmount.Text = "Amount (LKR):";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 23);
            txtName.TabIndex = 2;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(150, 120);
            txtCardNumber.MaxLength = 19;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(220, 23);
            txtCardNumber.TabIndex = 4;
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
            txtCardNumber.KeyPress += txtCardNumber_KeyPress;
            // 
            // txtExpiry
            // 
            txtExpiry.Location = new Point(150, 160);
            txtExpiry.MaxLength = 7;
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(220, 23);
            txtExpiry.TabIndex = 6;
            txtExpiry.TextChanged += txtExpiry_TextChanged;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(150, 200);
            txtCVV.MaxLength = 3;
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(220, 23);
            txtCVV.TabIndex = 8;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(150, 240);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(220, 23);
            txtAmount.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.SeaGreen;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(150, 290);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(100, 35);
            btnPay.TabIndex = 11;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(270, 290);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // UserPaymentForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(420, 360);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCard);
            Controls.Add(txtCardNumber);
            Controls.Add(lblExpiry);
            Controls.Add(txtExpiry);
            Controls.Add(lblCVV);
            Controls.Add(txtCVV);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(btnPay);
            Controls.Add(btnBack);
            Name = "UserPaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Payment";
            Load += UserPaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
