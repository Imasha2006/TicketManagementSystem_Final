namespace Dbex
{
    partial class Ticket_Organizer
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
            txtEventID = new TextBox();
            txtDeleteTicketID = new TextBox();
            txtNewPrice = new TextBox();
            txtUpdateTicketID = new TextBox();
            txtAvailability = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnUpdatePrice = new Button();
            btnAddTicket = new Button();
            btnDeleteTicket = new Button();
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnViewTickets = new Button();
            cmbType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(224, 59);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(143, 23);
            txtEventID.TabIndex = 0;
            // 
            // txtDeleteTicketID
            // 
            txtDeleteTicketID.Location = new Point(532, 153);
            txtDeleteTicketID.Name = "txtDeleteTicketID";
            txtDeleteTicketID.Size = new Size(143, 23);
            txtDeleteTicketID.TabIndex = 2;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(532, 92);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(143, 23);
            txtNewPrice.TabIndex = 3;
            // 
            // txtUpdateTicketID
            // 
            txtUpdateTicketID.Location = new Point(532, 59);
            txtUpdateTicketID.Name = "txtUpdateTicketID";
            txtUpdateTicketID.Size = new Size(143, 23);
            txtUpdateTicketID.TabIndex = 4;
            // 
            // txtAvailability
            // 
            txtAvailability.Location = new Point(223, 153);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(143, 23);
            txtAvailability.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(223, 124);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(143, 23);
            txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 62);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 8;
            label1.Text = "Event ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 95);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "Ticket Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 59);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Ticket ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 100);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 11;
            label4.Text = "New Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 156);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Ticket ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 156);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 13;
            label6.Text = "Availability:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 127);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 14;
            label7.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(328, 18);
            label8.Name = "label8";
            label8.Size = new Size(173, 15);
            label8.TabIndex = 15;
            label8.Text = "--Ticket Management System--";
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.Location = new Point(574, 124);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(101, 23);
            btnUpdatePrice.TabIndex = 16;
            btnUpdatePrice.Text = "Update Price";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // btnAddTicket
            // 
            btnAddTicket.Location = new Point(225, 190);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(101, 23);
            btnAddTicket.TabIndex = 17;
            btnAddTicket.Text = "Add Ticket";
            btnAddTicket.UseVisualStyleBackColor = true;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(574, 190);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(101, 23);
            btnDeleteTicket.TabIndex = 18;
            btnDeleteTicket.Text = "Delete Ticket";
            btnDeleteTicket.UseVisualStyleBackColor = true;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewTickets.Location = new Point(134, 219);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.Size = new Size(528, 194);
            dataGridViewTickets.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "EventID";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Type";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Availability";
            Column5.Name = "Column5";
            // 
            // btnViewTickets
            // 
            btnViewTickets.Location = new Point(438, 419);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(101, 23);
            btnViewTickets.TabIndex = 20;
            btnViewTickets.Text = "View Tickets";
            btnViewTickets.UseVisualStyleBackColor = true;
            btnViewTickets.Click += btnViewTickets_Click;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "VIP", "Genaral" });
            cmbType.Location = new Point(225, 93);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(141, 23);
            cmbType.TabIndex = 21;
            cmbType.SelectedIndexChanged += cmbTicketType_SelectedIndexChanged;
            // 
            // Ticket_Organizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbType);
            Controls.Add(btnViewTickets);
            Controls.Add(dataGridViewTickets);
            Controls.Add(btnDeleteTicket);
            Controls.Add(btnAddTicket);
            Controls.Add(btnUpdatePrice);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtAvailability);
            Controls.Add(txtUpdateTicketID);
            Controls.Add(txtNewPrice);
            Controls.Add(txtDeleteTicketID);
            Controls.Add(txtEventID);
            Name = "Ticket_Organizer";
            Text = "Ticket_Organizer";
            Load += Ticket_Organizer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEventID;
        private TextBox txtDeleteTicketID;
        private TextBox txtNewPrice;
        private TextBox txtUpdateTicketID;
        private TextBox txtAvailability;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnUpdatePrice;
        private Button btnAddTicket;
        private Button btnDeleteTicket;
        private DataGridView dataGridViewTickets;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnViewTickets;
        private ComboBox cmbType;
    }
}