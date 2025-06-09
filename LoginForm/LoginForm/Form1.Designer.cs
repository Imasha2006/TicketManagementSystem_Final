namespace LoginForm
{
    partial class Form1
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
            Adminlogin_btn = new Button();
            back_btn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 122);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 182);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 234);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Admin ID";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(235, 128);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(332, 23);
            username_tb.TabIndex = 3;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(235, 182);
            password_tb.Name = "password_tb";
            password_tb.PasswordChar = '*';
            password_tb.Size = new Size(332, 23);
            password_tb.TabIndex = 4;
            // 
            // AdminID_tb
            // 
            AdminID_tb.Location = new Point(235, 239);
            AdminID_tb.Name = "AdminID_tb";
            AdminID_tb.Size = new Size(332, 23);
            AdminID_tb.TabIndex = 5;
            AdminID_tb.TextChanged += textBox3_TextChanged;
            // 
            // Adminlogin_btn
            // 
            Adminlogin_btn.Location = new Point(468, 292);
            Adminlogin_btn.Name = "Adminlogin_btn";
            Adminlogin_btn.Size = new Size(99, 30);
            Adminlogin_btn.TabIndex = 6;
            Adminlogin_btn.Text = "Login";
            Adminlogin_btn.UseVisualStyleBackColor = true;
            Adminlogin_btn.Click += Adminlogin_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(351, 292);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(99, 30);
            back_btn.TabIndex = 7;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(295, 42);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 8;
            label4.Text = "ADMIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 377);
            Controls.Add(label4);
            Controls.Add(back_btn);
            Controls.Add(Adminlogin_btn);
            Controls.Add(AdminID_tb);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_tb;
        private TextBox password_tb;
        private TextBox AdminID_tb;
        private Button Adminlogin_btn;
        private Button back_btn;
        private Label label4;
    }
}