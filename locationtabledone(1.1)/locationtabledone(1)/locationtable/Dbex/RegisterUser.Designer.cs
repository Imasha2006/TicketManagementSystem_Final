namespace Dbex
{
    partial class RegisterUser
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
            Button exit_btn;
            label1 = new Label();
            label2 = new Label();
            username_tb = new TextBox();
            password_tb = new TextBox();
            Register_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(374, 291);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 23);
            exit_btn.TabIndex = 4;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 122);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 186);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(265, 119);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(237, 23);
            username_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(265, 183);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(237, 23);
            password_tb.TabIndex = 3;
            // 
            // Register_btn
            // 
            Register_btn.Location = new Point(498, 291);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(75, 23);
            Register_btn.TabIndex = 5;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click_1;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Register_btn);
            Controls.Add(exit_btn);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterUser";
            Text = "RegisterUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_tb;
        private TextBox password_tb;
        private Button Register_btn;
    }
}