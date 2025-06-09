namespace Dbex
{
    partial class AddLocationForm2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            locnameaddtextBox = new TextBox();
            locadressaddtextBox = new TextBox();
            locowneraddtextBox = new TextBox();
            addlocadbutton1 = new Button();
            addlocbackbutton2 = new Button();
            label2 = new Label();
            label6 = new Label();
            deletelocidtextBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 140);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "1.Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 212);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "2.Adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 294);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "3.Owner Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 63);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Add Location";
            // 
            // locnameaddtextBox
            // 
            locnameaddtextBox.Location = new Point(151, 140);
            locnameaddtextBox.Name = "locnameaddtextBox";
            locnameaddtextBox.Size = new Size(125, 27);
            locnameaddtextBox.TabIndex = 5;
            // 
            // locadressaddtextBox
            // 
            locadressaddtextBox.Location = new Point(151, 212);
            locadressaddtextBox.Name = "locadressaddtextBox";
            locadressaddtextBox.Size = new Size(125, 27);
            locadressaddtextBox.TabIndex = 7;
            // 
            // locowneraddtextBox
            // 
            locowneraddtextBox.Location = new Point(151, 291);
            locowneraddtextBox.Name = "locowneraddtextBox";
            locowneraddtextBox.Size = new Size(125, 27);
            locowneraddtextBox.TabIndex = 8;
            // 
            // addlocadbutton1
            // 
            addlocadbutton1.Location = new Point(78, 375);
            addlocadbutton1.Name = "addlocadbutton1";
            addlocadbutton1.Size = new Size(94, 29);
            addlocadbutton1.TabIndex = 9;
            addlocadbutton1.Text = "Add Location";
            addlocadbutton1.UseVisualStyleBackColor = true;
            addlocadbutton1.Click += addlocadbutton1_Click;
            // 
            // addlocbackbutton2
            // 
            addlocbackbutton2.Location = new Point(543, 375);
            addlocbackbutton2.Name = "addlocbackbutton2";
            addlocbackbutton2.Size = new Size(168, 29);
            addlocbackbutton2.TabIndex = 10;
            addlocbackbutton2.Text = "Back to AdminDash Board";
            addlocbackbutton2.UseVisualStyleBackColor = true;
            addlocbackbutton2.Click += addlocbackbutton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 63);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 11;
            label2.Text = "Delete Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 136);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 12;
            label6.Text = "1.ID";
            // 
            // deletelocidtextBox1
            // 
            deletelocidtextBox1.Location = new Point(600, 133);
            deletelocidtextBox1.Name = "deletelocidtextBox1";
            deletelocidtextBox1.Size = new Size(125, 27);
            deletelocidtextBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(590, 208);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddLocationForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(deletelocidtextBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(addlocbackbutton2);
            Controls.Add(addlocadbutton1);
            Controls.Add(locowneraddtextBox);
            Controls.Add(locadressaddtextBox);
            Controls.Add(locnameaddtextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AddLocationForm2";
            Text = "AddLocationForm2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox locnameaddtextBox;
        private TextBox locadressaddtextBox;
        private TextBox locowneraddtextBox;
        private Button addlocadbutton1;
        private Button addlocbackbutton2;
        private Label label2;
        private Label label6;
        private TextBox deletelocidtextBox1;
        private Button button1;
    }
}