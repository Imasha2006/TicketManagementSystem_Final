namespace Dbex
{
    partial class User
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
            signin_btn = new Button();
            back_btn = new Button();
            Login_btn = new Button();
            forgetPW_label = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 123);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 176);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 55);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "User";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(394, 118);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(213, 23);
            username_tb.TabIndex = 3;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(394, 176);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(213, 23);
            password_tb.TabIndex = 4;
            // 
            // signin_btn
            // 
            signin_btn.Location = new Point(343, 303);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(75, 23);
            signin_btn.TabIndex = 5;
            signin_btn.Text = "Sign in";
            signin_btn.UseVisualStyleBackColor = true;
            signin_btn.Click += signin_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(437, 303);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 6;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click_1;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(532, 303);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(75, 23);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click_1;
            // 
            // forgetPW_label
            // 
            forgetPW_label.AutoSize = true;
            forgetPW_label.Location = new Point(513, 274);
            forgetPW_label.Name = "forgetPW_label";
            forgetPW_label.Size = new Size(94, 15);
            forgetPW_label.TabIndex = 9;
            forgetPW_label.TabStop = true;
            forgetPW_label.Text = "Forget Password";
            forgetPW_label.LinkClicked += forgetPW_label_LinkClicked_1;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(forgetPW_label);
            Controls.Add(Login_btn);
            Controls.Add(back_btn);
            Controls.Add(signin_btn);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "User";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_tb;
        private TextBox password_tb;
        private Button signin_btn;
        private Button back_btn;
        private Button Login_btn;
        private LinkLabel forgetPW_label;
    }
}