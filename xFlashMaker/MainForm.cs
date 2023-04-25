﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xFlashMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Term_TextBox_Enter(object sender, EventArgs e)
        {
            if (Term_TextBox.Text == "Term")
                Term_TextBox.Text = string.Empty;
            Term_TextBox.ForeColor = Color.Black;
        }

        private void Term_TextBox_Leave(object sender, EventArgs e)
        {
            if (Term_TextBox.Text == string.Empty)
                Term_TextBox.Text = "Term";
            Term_TextBox.ForeColor = SystemColors.GrayText;
        }

        private void Definition_TextBox_Enter(object sender, EventArgs e)
        {
            if (Definition_TextBox.Text == "Definition")
                Definition_TextBox.Text = string.Empty;
            Definition_TextBox.ForeColor = Color.Black;
        }

        private void Definition_TextBox_Leave(object sender, EventArgs e)
        {
            if (Definition_TextBox.Text == string.Empty)
                Definition_TextBox.Text = "Definition";
            Definition_TextBox.ForeColor = SystemColors.GrayText;
        }
    }
}
