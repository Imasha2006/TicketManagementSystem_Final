namespace Dbex
{
    partial class AdminDashboardForm
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            linkLabel4 = new LinkLabel();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(289, 82);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "1.Add/Delete Location";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(286, 122);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(78, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "2.View Events";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(286, 159);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(141, 15);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "3.View Sales and Revenue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 3;
            label1.Text = "Admin Dash Board";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(289, 197);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(80, 15);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "4.View Tickets";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkLabel4);
            Controls.Add(label1);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label1;
        private LinkLabel linkLabel4;
    }
}