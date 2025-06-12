namespace Dbex.Forms
{
    partial class OrganizerDashboard
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
            dgvPayments = new DataGridView();
            txtEventId = new TextBox();
            btnCheckEvent = new Button();
            lblEventResult = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(47, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(109, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payments Received";
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(47, 69);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.Size = new Size(566, 245);
            dgvPayments.TabIndex = 1;
            // 
            // txtEventId
            // 
            txtEventId.Location = new Point(67, 348);
            txtEventId.Name = "txtEventId";
            txtEventId.PlaceholderText = "Enter Event ID";
            txtEventId.Size = new Size(100, 23);
            txtEventId.TabIndex = 2;
            // 
            // btnCheckEvent
            // 
            btnCheckEvent.Location = new Point(278, 348);
            btnCheckEvent.Name = "btnCheckEvent";
            btnCheckEvent.Size = new Size(109, 23);
            btnCheckEvent.TabIndex = 3;
            btnCheckEvent.Text = "Check Event";
            btnCheckEvent.UseVisualStyleBackColor = true;
            btnCheckEvent.Click += btnCheckEvent_Click;
            // 
            // lblEventResult
            // 
            lblEventResult.AutoSize = true;
            lblEventResult.Location = new Point(474, 341);
            lblEventResult.Name = "lblEventResult";
            lblEventResult.Size = new Size(75, 30);
            lblEventResult.TabIndex = 4;
            lblEventResult.Text = "Event Count:\nTickets Sold:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(538, 27);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // OrganizerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lblEventResult);
            Controls.Add(btnCheckEvent);
            Controls.Add(txtEventId);
            Controls.Add(dgvPayments);
            Controls.Add(lblTitle);
            Name = "OrganizerDashboard";
            Text = "OrganizerDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvPayments;
        private TextBox txtEventId;
        private Button btnCheckEvent;
        private Label lblEventResult;
        private Button btnBack;
    }
}