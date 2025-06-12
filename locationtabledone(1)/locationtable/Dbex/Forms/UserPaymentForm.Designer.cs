namespace Dbex.Forms
{
    partial class UserPaymentForm
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
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(208, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(88, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payment Portal";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(47, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblCard
            // 
            lblCard.AutoSize = true;
            lblCard.Location = new Point(47, 129);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(82, 15);
            lblCard.TabIndex = 2;
            lblCard.Text = "Card Number:";
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Location = new Point(47, 164);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(108, 15);
            lblExpiry.TabIndex = 3;
            lblExpiry.Text = "Expiry (MM/YYYY):";
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Location = new Point(47, 204);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(32, 15);
            lblCVV.TabIndex = 4;
            lblCVV.Text = "CVV:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(47, 243);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(85, 15);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Amount (LKR):";
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 23);
            txtName.TabIndex = 6;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(168, 121);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(217, 23);
            txtCardNumber.TabIndex = 7;
            // 
            // txtExpiry
            // 
            txtExpiry.Location = new Point(168, 164);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(217, 23);
            txtExpiry.TabIndex = 8;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(168, 204);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(217, 23);
            txtCVV.TabIndex = 9;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(168, 243);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(217, 23);
            txtAmount.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(277, 345);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 11;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(455, 345);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 12;
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
            Controls.Add(btnPay);
            Controls.Add(txtAmount);
            Controls.Add(txtCVV);
            Controls.Add(txtExpiry);
            Controls.Add(txtCardNumber);
            Controls.Add(txtName);
            Controls.Add(lblAmount);
            Controls.Add(lblCVV);
            Controls.Add(lblExpiry);
            Controls.Add(lblCard);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "UserPaymentForm";
            Text = "AdminDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblCard;
        private Label lblExpiry;
        private Label lblCVV;
        private Label lblAmount;
        private TextBox txtName;
        private TextBox txtCardNumber;
        private TextBox txtExpiry;
        private TextBox txtCVV;
        private TextBox txtAmount;
        private Button btnPay;
        private Button btnBack;
    }
}