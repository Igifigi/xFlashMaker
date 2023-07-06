namespace xFlashMaker
{
    partial class MainForm
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
            this.Flashcards_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.UnselectAll_Button = new System.Windows.Forms.Button();
            this.SelectAll_Button = new System.Windows.Forms.Button();
            this.ImportFlashcards_Button = new System.Windows.Forms.Button();
            this.ExportFlashcards_Button = new System.Windows.Forms.Button();
            this.Term_TextBox = new System.Windows.Forms.TextBox();
            this.CreateFlashcard_Button = new System.Windows.Forms.Button();
            this.Definition_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Flashcards_CheckedListBox
            // 
            this.Flashcards_CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Flashcards_CheckedListBox.FormattingEnabled = true;
            this.Flashcards_CheckedListBox.Location = new System.Drawing.Point(12, 407);
            this.Flashcards_CheckedListBox.Name = "Flashcards_CheckedListBox";
            this.Flashcards_CheckedListBox.Size = new System.Drawing.Size(806, 704);
            this.Flashcards_CheckedListBox.TabIndex = 5;
            // 
            // UnselectAll_Button
            // 
            this.UnselectAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnselectAll_Button.Location = new System.Drawing.Point(418, 326);
            this.UnselectAll_Button.Name = "UnselectAll_Button";
            this.UnselectAll_Button.Size = new System.Drawing.Size(400, 75);
            this.UnselectAll_Button.TabIndex = 4;
            this.UnselectAll_Button.Text = "Unselect all";
            this.UnselectAll_Button.UseVisualStyleBackColor = true;
            this.UnselectAll_Button.Click += new System.EventHandler(this.UnselectAll_Button_Click);
            // 
            // SelectAll_Button
            // 
            this.SelectAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectAll_Button.Location = new System.Drawing.Point(12, 326);
            this.SelectAll_Button.Name = "SelectAll_Button";
            this.SelectAll_Button.Size = new System.Drawing.Size(400, 75);
            this.SelectAll_Button.TabIndex = 3;
            this.SelectAll_Button.Text = "Select all";
            this.SelectAll_Button.UseVisualStyleBackColor = true;
            this.SelectAll_Button.Click += new System.EventHandler(this.SelectAll_Button_Click);
            // 
            // ImportFlashcards_Button
            // 
            this.ImportFlashcards_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImportFlashcards_Button.Location = new System.Drawing.Point(12, 12);
            this.ImportFlashcards_Button.Name = "ImportFlashcards_Button";
            this.ImportFlashcards_Button.Size = new System.Drawing.Size(400, 75);
            this.ImportFlashcards_Button.TabIndex = 6;
            this.ImportFlashcards_Button.Text = "Import flashcards";
            this.ImportFlashcards_Button.UseVisualStyleBackColor = true;
            this.ImportFlashcards_Button.Click += new System.EventHandler(this.ImportFlashcards_Button_Click);
            // 
            // ExportFlashcards_Button
            // 
            this.ExportFlashcards_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportFlashcards_Button.Location = new System.Drawing.Point(418, 12);
            this.ExportFlashcards_Button.Name = "ExportFlashcards_Button";
            this.ExportFlashcards_Button.Size = new System.Drawing.Size(400, 75);
            this.ExportFlashcards_Button.TabIndex = 7;
            this.ExportFlashcards_Button.Text = "Export flashcards";
            this.ExportFlashcards_Button.UseVisualStyleBackColor = true;
            this.ExportFlashcards_Button.Click += new System.EventHandler(this.ExportFlashcards_Button_Click);
            // 
            // Term_TextBox
            // 
            this.Term_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Term_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Term_TextBox.Location = new System.Drawing.Point(19, 100);
            this.Term_TextBox.Margin = new System.Windows.Forms.Padding(10);
            this.Term_TextBox.Name = "Term_TextBox";
            this.Term_TextBox.Size = new System.Drawing.Size(792, 56);
            this.Term_TextBox.TabIndex = 0;
            this.Term_TextBox.Text = "Term";
            this.Term_TextBox.Enter += new System.EventHandler(this.Term_TextBox_Enter);
            this.Term_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Term_TextBox_KeyDown);
            this.Term_TextBox.Leave += new System.EventHandler(this.Term_TextBox_Leave);
            // 
            // CreateFlashcard_Button
            // 
            this.CreateFlashcard_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateFlashcard_Button.Location = new System.Drawing.Point(12, 245);
            this.CreateFlashcard_Button.Name = "CreateFlashcard_Button";
            this.CreateFlashcard_Button.Size = new System.Drawing.Size(806, 75);
            this.CreateFlashcard_Button.TabIndex = 2;
            this.CreateFlashcard_Button.Text = "Create flashcard";
            this.CreateFlashcard_Button.UseVisualStyleBackColor = true;
            this.CreateFlashcard_Button.Click += new System.EventHandler(this.CreateFlashcard_Button_Click);
            // 
            // Definition_TextBox
            // 
            this.Definition_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Definition_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Definition_TextBox.Location = new System.Drawing.Point(19, 176);
            this.Definition_TextBox.Margin = new System.Windows.Forms.Padding(10);
            this.Definition_TextBox.Name = "Definition_TextBox";
            this.Definition_TextBox.Size = new System.Drawing.Size(792, 56);
            this.Definition_TextBox.TabIndex = 1;
            this.Definition_TextBox.Text = "Definition";
            this.Definition_TextBox.Enter += new System.EventHandler(this.Definition_TextBox_Enter);
            this.Definition_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Definition_TextBox_KeyDown);
            this.Definition_TextBox.Leave += new System.EventHandler(this.Definition_TextBox_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(830, 1136);
            this.Controls.Add(this.Definition_TextBox);
            this.Controls.Add(this.CreateFlashcard_Button);
            this.Controls.Add(this.Term_TextBox);
            this.Controls.Add(this.ImportFlashcards_Button);
            this.Controls.Add(this.ExportFlashcards_Button);
            this.Controls.Add(this.SelectAll_Button);
            this.Controls.Add(this.UnselectAll_Button);
            this.Controls.Add(this.Flashcards_CheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "xFlash Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox Flashcards_CheckedListBox;
        private System.Windows.Forms.Button UnselectAll_Button;
        private System.Windows.Forms.Button SelectAll_Button;
        private System.Windows.Forms.Button ImportFlashcards_Button;
        private System.Windows.Forms.Button ExportFlashcards_Button;
        private System.Windows.Forms.TextBox Term_TextBox;
        private System.Windows.Forms.Button CreateFlashcard_Button;
        private System.Windows.Forms.TextBox Definition_TextBox;
    }
}

