namespace LoginForm
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
            label2 = new Label();
            label3 = new Label();
            username_tb = new TextBox();
            password_tb = new TextBox();
            Register_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 89);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 176);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(250, 89);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(274, 23);
            username_tb.TabIndex = 4;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(250, 176);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(274, 23);
            password_tb.TabIndex = 5;
            // 
            // Register_btn
            // 
            Register_btn.Location = new Point(428, 261);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(96, 33);
            Register_btn.TabIndex = 6;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(291, 261);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(96, 33);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 378);
            Controls.Add(exit_btn);
            Controls.Add(Register_btn);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "RegisterUser";
            Text = "RegisterUser";
            Load += RegisterUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox username_tb;
        private TextBox password_tb;
        private Button Register_btn;
        private Button exit_btn;
    }
}