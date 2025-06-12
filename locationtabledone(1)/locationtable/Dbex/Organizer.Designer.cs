namespace Dbex
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
            username_btn = new TextBox();
            organizerid_btn = new TextBox();
            password_btn = new TextBox();
            back_btn = new Button();
            Login_btn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 125);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 174);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 227);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Organizer ID ";
            // 
            // username_btn
            // 
            username_btn.Location = new Point(283, 122);
            username_btn.Name = "username_btn";
            username_btn.Size = new Size(283, 23);
            username_btn.TabIndex = 3;
            // 
            // organizerid_btn
            // 
            organizerid_btn.Location = new Point(283, 224);
            organizerid_btn.Name = "organizerid_btn";
            organizerid_btn.Size = new Size(283, 23);
            organizerid_btn.TabIndex = 4;
            // 
            // password_btn
            // 
            password_btn.Location = new Point(283, 171);
            password_btn.Name = "password_btn";
            password_btn.Size = new Size(283, 23);
            password_btn.TabIndex = 5;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(371, 299);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 6;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click_1;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(465, 299);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(75, 23);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 50);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "ORGANIZER";
            // 
            // Organizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Login_btn);
            Controls.Add(back_btn);
            Controls.Add(password_btn);
            Controls.Add(organizerid_btn);
            Controls.Add(username_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Organizer";
            Text = "Organizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_btn;
        private TextBox organizerid_btn;
        private TextBox password_btn;
        private Button back_btn;
        private Button Login_btn;
        private Label label4;
    }
}