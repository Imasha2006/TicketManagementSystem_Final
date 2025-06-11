namespace EventTicketingSystem.Forms
{
    partial class EventEntryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEventId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblEventId = new Label();
            lblDate = new Label();
            lblLocation = new Label();
            txtEventId = new TextBox();
            txtLocation = new TextBox();
            dtpDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();

            // Title
            lblTitle.Text = "Add New Event";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(100, 20);
            lblTitle.Size = new Size(200, 30);

            // Event ID Label
            lblEventId.Text = "Event ID:";
            lblEventId.Location = new Point(40, 70);
            lblEventId.Size = new Size(100, 23);

            // Event ID TextBox
            txtEventId.Location = new Point(140, 70);
            txtEventId.Size = new Size(180, 23);

            // Date Label
            lblDate.Text = "Event Date:";
            lblDate.Location = new Point(40, 110);
            lblDate.Size = new Size(100, 23);

            // Date Picker
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(140, 110);
            dtpDate.Size = new Size(200, 23);

            // Location Label
            lblLocation.Text = "Location:";
            lblLocation.Location = new Point(40, 150);
            lblLocation.Size = new Size(100, 23);

            // Location TextBox
            txtLocation.Location = new Point(140, 150);
            txtLocation.Size = new Size(180, 23);

            // Save Button
            btnSave.Text = "Save";
            btnSave.Location = new Point(80, 200);
            btnSave.Size = new Size(90, 30);
            btnSave.Click += btnSave_Click;

            // Cancel Button
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(180, 200);
            btnCancel.Size = new Size(90, 30);
            btnCancel.Click += btnCancel_Click;

            // Form
            this.ClientSize = new Size(380, 270);
            this.BackColor = Color.WhiteSmoke;
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblEventId);
            this.Controls.Add(txtEventId);
            this.Controls.Add(lblDate);
            this.Controls.Add(dtpDate);
            this.Controls.Add(lblLocation);
            this.Controls.Add(txtLocation);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Event Entry";
            this.Load += EventEntryForm_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

