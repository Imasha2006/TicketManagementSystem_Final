namespace Dbex
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
            label4 = new Label();
            username_tb = new TextBox();
            confirmpass_tb = new TextBox();
            newpass_tb = new TextBox();
            exit_btn = new Button();
            reset_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 128);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 181);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 235);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 52);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Reset Password";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(344, 125);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(265, 23);
            username_tb.TabIndex = 4;
            // 
            // confirmpass_tb
            // 
            confirmpass_tb.Location = new Point(344, 227);
            confirmpass_tb.Name = "confirmpass_tb";
            confirmpass_tb.Size = new Size(265, 23);
            confirmpass_tb.TabIndex = 5;
            // 
            // newpass_tb
            // 
            newpass_tb.Location = new Point(344, 173);
            newpass_tb.Name = "newpass_tb";
            newpass_tb.Size = new Size(265, 23);
            newpass_tb.TabIndex = 6;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(402, 348);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 23);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(534, 348);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(75, 23);
            reset_btn.TabIndex = 8;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            // 
            // ForgetpasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reset_btn);
            Controls.Add(exit_btn);
            Controls.Add(newpass_tb);
            Controls.Add(confirmpass_tb);
            Controls.Add(username_tb);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox username_tb;
        private TextBox confirmpass_tb;
        private TextBox newpass_tb;
        private Button exit_btn;
        private Button reset_btn;
    }
}