namespace Dbex
{
    partial class Ticket_User
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEventID = new TextBox();
            txtQuantity = new TextBox();
            cmbTicketType = new ComboBox();
            btnLoadTickets = new Button();
            lblPrice = new Label();
            lblTotal = new Label();
            label6 = new Label();
            backtouserbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 124);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Event ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 172);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Ticket Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 218);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantity :";
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(337, 116);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(244, 23);
            txtEventID.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(337, 215);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(244, 23);
            txtQuantity.TabIndex = 4;
            // 
            // cmbTicketType
            // 
            cmbTicketType.FormattingEnabled = true;
            cmbTicketType.Items.AddRange(new object[] { "VIP", "Genaral" });
            cmbTicketType.Location = new Point(337, 172);
            cmbTicketType.Name = "cmbTicketType";
            cmbTicketType.Size = new Size(244, 23);
            cmbTicketType.TabIndex = 5;
            // 
            // btnLoadTickets
            // 
            btnLoadTickets.Location = new Point(532, 289);
            btnLoadTickets.Name = "btnLoadTickets";
            btnLoadTickets.Size = new Size(104, 23);
            btnLoadTickets.TabIndex = 6;
            btnLoadTickets.Text = "Place Ticket";
            btnLoadTickets.UseVisualStyleBackColor = true;
            btnLoadTickets.Click += btnLoadTickets_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(327, 345);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(125, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "\"Price per ticket: Rs. 0\"";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(324, 387);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(138, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "\"Total Ticket Price : Rs. 0\"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 57);
            label6.Name = "label6";
            label6.Size = new Size(173, 15);
            label6.TabIndex = 9;
            label6.Text = "--Ticket Management System--";
            label6.Click += label6_Click;
            // 
            // backtouserbtn
            // 
            backtouserbtn.Location = new Point(302, 289);
            backtouserbtn.Name = "backtouserbtn";
            backtouserbtn.Size = new Size(75, 23);
            backtouserbtn.TabIndex = 10;
            backtouserbtn.Text = "Back";
            backtouserbtn.UseVisualStyleBackColor = true;
            backtouserbtn.Click += backtouserbtn_Click;
            // 
            // Ticket_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backtouserbtn);
            Controls.Add(label6);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(btnLoadTickets);
            Controls.Add(cmbTicketType);
            Controls.Add(txtQuantity);
            Controls.Add(txtEventID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ticket_User";
            Text = "Ticket_User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEventID;
        private TextBox txtQuantity;
        private ComboBox cmbTicketType;
        private Button btnLoadTickets;
        private Label lblPrice;
        private Label lblTotal;
        private Label label6;
        private Button backtouserbtn;
    }
}