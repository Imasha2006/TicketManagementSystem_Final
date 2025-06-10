namespace LoginForm
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
            forgetPW_label = new LinkLabel();
            Login_btn = new Button();
            back_btn = new Button();
            signin_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 0;
            label1.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 82);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 161);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(202, 89);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(301, 23);
            username_tb.TabIndex = 3;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(202, 161);
            password_tb.Name = "password_tb";
            password_tb.PasswordChar = '*';
            password_tb.Size = new Size(301, 23);
            password_tb.TabIndex = 4;
            // 
            // forgetPW_label
            // 
            forgetPW_label.AutoSize = true;
            forgetPW_label.Location = new Point(409, 274);
            forgetPW_label.Name = "forgetPW_label";
            forgetPW_label.Size = new Size(94, 15);
            forgetPW_label.TabIndex = 7;
            forgetPW_label.TabStop = true;
            forgetPW_label.Text = "Forget Password";
            forgetPW_label.LinkClicked += forgetPW_label_LinkClicked;
            // 
            // Login_btn
            // 
            Login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_btn.Location = new Point(400, 312);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(103, 34);
            Login_btn.TabIndex = 8;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(300, 312);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 34);
            back_btn.TabIndex = 9;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // signin_btn
            // 
            signin_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signin_btn.Location = new Point(200, 312);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(94, 34);
            signin_btn.TabIndex = 10;
            signin_btn.Text = "Sign in";
            signin_btn.UseVisualStyleBackColor = true;
            signin_btn.Click += signin_btn_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 385);
            Controls.Add(signin_btn);
            Controls.Add(back_btn);
            Controls.Add(Login_btn);
            Controls.Add(forgetPW_label);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "665.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_tb;
        private TextBox password_tb;
        private LinkLabel forgetPW_label;
        private Button Login_btn;
        private Button back_btn;
        private Button signin_btn;
    }
}