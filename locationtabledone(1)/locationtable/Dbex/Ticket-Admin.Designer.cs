namespace Dbex
{
    partial class Ticket_Admin
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
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnViewTickets = new Button();
            adminmenubackbutton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewTickets.Location = new Point(129, 73);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.Size = new Size(544, 244);
            dataGridViewTickets.TabIndex = 0;
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
            btnViewTickets.Location = new Point(586, 352);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(115, 23);
            btnViewTickets.TabIndex = 1;
            btnViewTickets.Text = "View Tickets";
            btnViewTickets.UseVisualStyleBackColor = true;
            btnViewTickets.Click += btnViewTickets_Click;
            // 
            // adminmenubackbutton1
            // 
            adminmenubackbutton1.Location = new Point(266, 352);
            adminmenubackbutton1.Name = "adminmenubackbutton1";
            adminmenubackbutton1.Size = new Size(75, 23);
            adminmenubackbutton1.TabIndex = 2;
            adminmenubackbutton1.Text = "Back";
            adminmenubackbutton1.UseVisualStyleBackColor = true;
            adminmenubackbutton1.Click += adminmenubackbutton1_Click;
            // 
            // Ticket_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adminmenubackbutton1);
            Controls.Add(btnViewTickets);
            Controls.Add(dataGridViewTickets);
            Name = "Ticket_Admin";
            Text = "Ticket_Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTickets;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnViewTickets;
        private Button adminmenubackbutton1;
    }
}