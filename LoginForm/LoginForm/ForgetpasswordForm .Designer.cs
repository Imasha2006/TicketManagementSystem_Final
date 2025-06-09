namespace LoginForm
{
    partial class ForgetpasswordForm
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
            newpass_tb = new TextBox();
            confirmpass_tb = new TextBox();
            reset_btn = new Button();
            exit_btn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 90);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 137);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 195);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(224, 93);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(278, 23);
            username_tb.TabIndex = 3;
            // 
            // newpass_tb
            // 
            newpass_tb.Location = new Point(224, 137);
            newpass_tb.Name = "newpass_tb";
            newpass_tb.Size = new Size(278, 23);
            newpass_tb.TabIndex = 4;
            // 
            // confirmpass_tb
            // 
            confirmpass_tb.Location = new Point(224, 195);
            confirmpass_tb.Name = "confirmpass_tb";
            confirmpass_tb.Size = new Size(278, 23);
            confirmpass_tb.TabIndex = 5;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(393, 318);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(109, 39);
            reset_btn.TabIndex = 6;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(269, 318);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(108, 39);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 22);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 8;
            label4.Text = "Reset Password";
            // 
            // ForgetpasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 410);
            Controls.Add(label4);
            Controls.Add(exit_btn);
            Controls.Add(reset_btn);
            Controls.Add(confirmpass_tb);
            Controls.Add(newpass_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgetpasswordForm";
            Text = "ForgetpasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_tb;
        private TextBox newpass_tb;
        private TextBox confirmpass_tb;
        private Button reset_btn;
        private Button exit_btn;
        private Label label4;
    }
}