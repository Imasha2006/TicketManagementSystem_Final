﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbex
{
    public partial class DeleteEventForm : Form
    {
        public DeleteEventForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EventconClass.DeleteItem(deleteeventidtextBox.Text, deleteeventnametextBox.Text));
            // Clear the text boxes after deletion
            deleteeventidtextBox.Clear();
            deleteeventnametextBox.Clear();
        }

        private void deleteeventnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrganizerMenuEventForm menuForm = new OrganizerMenuEventForm();
            menuForm.Show();
            this.Hide();
        }

        private void DeleteEventForm_Load(object sender, EventArgs e)
        {

        }
    }
}
