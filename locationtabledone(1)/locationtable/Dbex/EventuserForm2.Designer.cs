namespace Dbex
{
    partial class EventuserForm2
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
            vieweventuserlistBox1 = new ListBox();
            bookticketbutton1 = new Button();
            label1 = new Label();
            vieweventUserbutton1 = new Button();
            SuspendLayout();
            // 
            // vieweventuserlistBox1
            // 
            vieweventuserlistBox1.FormattingEnabled = true;
            vieweventuserlistBox1.Location = new Point(142, 71);
            vieweventuserlistBox1.Name = "vieweventuserlistBox1";
            vieweventuserlistBox1.Size = new Size(552, 304);
            vieweventuserlistBox1.TabIndex = 0;
            // 
            // bookticketbutton1
            // 
            bookticketbutton1.Location = new Point(591, 400);
            bookticketbutton1.Name = "bookticketbutton1";
            bookticketbutton1.Size = new Size(94, 29);
            bookticketbutton1.TabIndex = 1;
            bookticketbutton1.Text = "Book Ticket";
            bookticketbutton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 24);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 2;
            label1.Text = "View Event And Book your Event";
            // 
            // vieweventUserbutton1
            // 
            vieweventUserbutton1.Location = new Point(148, 395);
            vieweventUserbutton1.Name = "vieweventUserbutton1";
            vieweventUserbutton1.Size = new Size(142, 29);
            vieweventUserbutton1.TabIndex = 3;
            vieweventUserbutton1.Text = "View Events";
            vieweventUserbutton1.UseVisualStyleBackColor = true;
            vieweventUserbutton1.Click += vieweventUserbutton1_Click;
            // 
            // EventuserForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vieweventUserbutton1);
            Controls.Add(label1);
            Controls.Add(bookticketbutton1);
            Controls.Add(vieweventuserlistBox1);
            Name = "EventuserForm2";
            Text = "EventuserForm2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox vieweventuserlistBox1;
        private Button bookticketbutton1;
        private Label label1;
        private Button vieweventUserbutton1;
    }
}