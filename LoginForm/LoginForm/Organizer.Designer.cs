namespace LoginForm
{
    partial class Organizer
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
            label4 = new Label();
            username_btn = new TextBox();
            password_btn = new TextBox();
            organizerid_btn = new TextBox();
            Login_btn = new Button();
            back_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 26);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "ORGANIZER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 111);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 167);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 216);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 3;
            label4.Text = "Organizer ID ";
            // 
            // username_btn
            // 
            username_btn.Location = new Point(208, 118);
            username_btn.Name = "username_btn";
            username_btn.Size = new Size(291, 23);
            username_btn.TabIndex = 4;
            // 
            // password_btn
            // 
            password_btn.Location = new Point(208, 167);
            password_btn.Name = "password_btn";
            password_btn.PasswordChar = '*';
            password_btn.Size = new Size(291, 23);
            password_btn.TabIndex = 5;
            // 
            // organizerid_btn
            // 
            organizerid_btn.Location = new Point(208, 221);
            organizerid_btn.Name = "organizerid_btn";
            organizerid_btn.Size = new Size(291, 23);
            organizerid_btn.TabIndex = 6;
            organizerid_btn.TextChanged += textBox3_TextChanged;
            // 
            // Login_btn
            // 
            Login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_btn.Location = new Point(407, 297);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(92, 31);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += button1_Click;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(299, 297);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(92, 31);
            back_btn.TabIndex = 8;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // Organizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 391);
            Controls.Add(back_btn);
            Controls.Add(Login_btn);
            Controls.Add(organizerid_btn);
            Controls.Add(password_btn);
            Controls.Add(username_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Organizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox username_btn;
        private TextBox password_btn;
        private TextBox organizerid_btn;
        private Button Login_btn;
        private Button back_btn;
    }
}