﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xFlashMaker;

namespace xFlashMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Flashcard> flashcards = new List<Flashcard>();

        private void update_flashcards()
        {
            Flashcards_CheckedListBox.Items.Clear();
            Flashcards_CheckedListBox.Items.AddRange(flashcards.ToArray());
        }

        private void create_flashcard()
        {
            if (
                Term_TextBox.Text == "Term" || 
                Definition_TextBox.Text == "Definition" ||
                Term_TextBox.Text == "" ||
                Definition_TextBox.Text == ""
                )
                return;
            flashcards.Add(new Flashcard(Term_TextBox.Text, Definition_TextBox.Text));

            Term_TextBox.Text = string.Empty;
            Definition_TextBox.Text = string.Empty;
            Term_TextBox.Text = "Term";
            Term_TextBox.ForeColor = SystemColors.GrayText;
            Definition_TextBox.Text = "Definition";
            Definition_TextBox.ForeColor = SystemColors.GrayText;

            update_flashcards();
            Term_TextBox.Focus();
        }

        private void CreateFlashcard_Button_Click(object sender, EventArgs e)
        {
            create_flashcard();
        }
        private void ExportFlashcards_Button_Click(object sender, EventArgs e)
        {
            if (Flashcards_CheckedListBox.CheckedItems.Count < 1)
                return;
            FileManager.export_flashcards(Flashcards_CheckedListBox.CheckedItems.Cast<Flashcard>().ToList());
        }

        #region Textbox management

        private void Term_TextBox_Enter(object sender, EventArgs e)
        {
            if (Term_TextBox.Text == "Term")
            {
                Term_TextBox.Text = string.Empty;
                Term_TextBox.ForeColor = Color.Black;
            }
        }

        private void Term_TextBox_Leave(object sender, EventArgs e)
        {
            if (Term_TextBox.Text == string.Empty)
            {
                Term_TextBox.Text = "Term";
                Term_TextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void Definition_TextBox_Enter(object sender, EventArgs e)
        {
            if (Definition_TextBox.Text == "Definition")
            {
                Definition_TextBox.Text = string.Empty;
                Definition_TextBox.ForeColor = Color.Black;
            }
        }

        private void Definition_TextBox_Leave(object sender, EventArgs e)
        {
            if (Definition_TextBox.Text == string.Empty)
            {
                Definition_TextBox.Text = "Definition";
                Definition_TextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void Term_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                Definition_TextBox.Focus();
        }

        private void Definition_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
                create_flashcard();
        }

        #endregion
    }
}
