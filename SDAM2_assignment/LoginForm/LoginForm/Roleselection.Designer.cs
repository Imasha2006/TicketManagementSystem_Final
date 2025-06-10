namespace LoginForm
{
    partial class Roleselection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roleselection));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            admin_btn = new Button();
            user_btn = new Button();
            organizer_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(312, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(555, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 156);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // admin_btn
            // 
            admin_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_btn.Location = new Point(98, 236);
            admin_btn.Name = "admin_btn";
            admin_btn.Size = new Size(76, 32);
            admin_btn.TabIndex = 3;
            admin_btn.Text = "Admin";
            admin_btn.UseVisualStyleBackColor = true;
            admin_btn.Click += admin_btn_Click;
            // 
            // user_btn
            // 
            user_btn.Font = new Font("Segoe UI", 14F);
            user_btn.Location = new Point(347, 236);
            user_btn.Name = "user_btn";
            user_btn.Size = new Size(75, 32);
            user_btn.TabIndex = 4;
            user_btn.Text = "User";
            user_btn.UseVisualStyleBackColor = true;
            user_btn.Click += user_btn_Click;
            // 
            // organizer_btn
            // 
            organizer_btn.Font = new Font("Segoe UI", 14F);
            organizer_btn.Location = new Point(579, 236);
            organizer_btn.Name = "organizer_btn";
            organizer_btn.Size = new Size(109, 32);
            organizer_btn.TabIndex = 5;
            organizer_btn.Text = "Organizer";
            organizer_btn.UseVisualStyleBackColor = true;
            organizer_btn.Click += organizer_btn_Click;
            // 
            // Roleselection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 360);
            Controls.Add(organizer_btn);
            Controls.Add(user_btn);
            Controls.Add(admin_btn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Roleselection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roleselection";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button admin_btn;
        private Button user_btn;
        private Button organizer_btn;
    }
}