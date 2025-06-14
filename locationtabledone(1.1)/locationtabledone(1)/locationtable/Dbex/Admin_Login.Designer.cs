namespace Dbex
{
    partial class Admin_Login
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
            username_tb = new TextBox();
            password_tb = new TextBox();
            AdminID_tb = new TextBox();
            back_btn = new Button();
            Adminlogin_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 127);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 177);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 226);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "AdminID";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(351, 119);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(209, 23);
            username_tb.TabIndex = 4;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(351, 169);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(209, 23);
            password_tb.TabIndex = 5;
            // 
            // AdminID_tb
            // 
            AdminID_tb.Location = new Point(351, 226);
            AdminID_tb.Name = "AdminID_tb";
            AdminID_tb.Size = new Size(209, 23);
            AdminID_tb.TabIndex = 6;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(476, 338);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 7;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click_1;
            // 
            // Adminlogin_btn
            // 
            Adminlogin_btn.Location = new Point(636, 338);
            Adminlogin_btn.Name = "Adminlogin_btn";
            Adminlogin_btn.Size = new Size(75, 23);
            Adminlogin_btn.TabIndex = 8;
            Adminlogin_btn.Text = "Login";
            Adminlogin_btn.UseVisualStyleBackColor = true;
            Adminlogin_btn.Click += Adminlogin_btn_Click_1;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Adminlogin_btn);
            Controls.Add(back_btn);
            Controls.Add(AdminID_tb);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Login";
            Text = "Admin_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox username_tb;
        private TextBox password_tb;
        private TextBox AdminID_tb;
        private Button back_btn;
        private Button Adminlogin_btn;
    }
}