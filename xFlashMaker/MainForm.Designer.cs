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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Flashcards_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.UnselectAll_Button = new System.Windows.Forms.Button();
            this.SelectAll_Button = new System.Windows.Forms.Button();
            this.ImportFlashcards_FCS_Button = new System.Windows.Forms.Button();
            this.ExportFlashcards_FCS_Button = new System.Windows.Forms.Button();
            this.Term_TextBox = new System.Windows.Forms.TextBox();
            this.CreateFlashcard_Button = new System.Windows.Forms.Button();
            this.Definition_TextBox = new System.Windows.Forms.TextBox();
            this.ImportFlashcards_CSV_Button = new System.Windows.Forms.Button();
            this.ExportFlashcards_CSV_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flashcards_CheckedListBox
            // 
            this.Flashcards_CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Flashcards_CheckedListBox.FormattingEnabled = true;
            this.Flashcards_CheckedListBox.Location = new System.Drawing.Point(11, 237);
            this.Flashcards_CheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.Flashcards_CheckedListBox.Name = "Flashcards_CheckedListBox";
            this.Flashcards_CheckedListBox.Size = new System.Drawing.Size(393, 400);
            this.Flashcards_CheckedListBox.TabIndex = 5;
            // 
            // UnselectAll_Button
            // 
            this.UnselectAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnselectAll_Button.Location = new System.Drawing.Point(210, 194);
            this.UnselectAll_Button.Margin = new System.Windows.Forms.Padding(2);
            this.UnselectAll_Button.Name = "UnselectAll_Button";
            this.UnselectAll_Button.Size = new System.Drawing.Size(194, 39);
            this.UnselectAll_Button.TabIndex = 4;
            this.UnselectAll_Button.Text = "Unselect all";
            this.UnselectAll_Button.UseVisualStyleBackColor = true;
            this.UnselectAll_Button.Click += new System.EventHandler(this.UnselectAll_Button_Click);
            // 
            // SelectAll_Button
            // 
            this.SelectAll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectAll_Button.Location = new System.Drawing.Point(11, 194);
            this.SelectAll_Button.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAll_Button.Name = "SelectAll_Button";
            this.SelectAll_Button.Size = new System.Drawing.Size(195, 39);
            this.SelectAll_Button.TabIndex = 3;
            this.SelectAll_Button.Text = "Select all";
            this.SelectAll_Button.UseVisualStyleBackColor = true;
            this.SelectAll_Button.Click += new System.EventHandler(this.SelectAll_Button_Click);
            // 
            // ImportFlashcards_FCS_Button
            // 
            this.ImportFlashcards_FCS_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImportFlashcards_FCS_Button.Location = new System.Drawing.Point(11, 11);
            this.ImportFlashcards_FCS_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ImportFlashcards_FCS_Button.Name = "ImportFlashcards_FCS_Button";
            this.ImportFlashcards_FCS_Button.Size = new System.Drawing.Size(195, 24);
            this.ImportFlashcards_FCS_Button.TabIndex = 6;
            this.ImportFlashcards_FCS_Button.Text = "Import flashcards from .fcs";
            this.ImportFlashcards_FCS_Button.UseVisualStyleBackColor = true;
            this.ImportFlashcards_FCS_Button.Click += new System.EventHandler(this.ImportFlashcards_FCS_Button_Click);
            // 
            // ExportFlashcards_FCS_Button
            // 
            this.ExportFlashcards_FCS_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportFlashcards_FCS_Button.Location = new System.Drawing.Point(210, 11);
            this.ExportFlashcards_FCS_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ExportFlashcards_FCS_Button.Name = "ExportFlashcards_FCS_Button";
            this.ExportFlashcards_FCS_Button.Size = new System.Drawing.Size(194, 24);
            this.ExportFlashcards_FCS_Button.TabIndex = 7;
            this.ExportFlashcards_FCS_Button.Text = "Export flashcards as .fcs";
            this.ExportFlashcards_FCS_Button.UseVisualStyleBackColor = true;
            this.ExportFlashcards_FCS_Button.Click += new System.EventHandler(this.ExportFlashcards_FCS_Button_Click);
            // 
            // Term_TextBox
            // 
            this.Term_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Term_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Term_TextBox.Location = new System.Drawing.Point(11, 70);
            this.Term_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Term_TextBox.Name = "Term_TextBox";
            this.Term_TextBox.Size = new System.Drawing.Size(393, 32);
            this.Term_TextBox.TabIndex = 0;
            this.Term_TextBox.Text = "Term";
            this.Term_TextBox.Enter += new System.EventHandler(this.Term_TextBox_Enter);
            this.Term_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Term_TextBox_KeyDown);
            this.Term_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Term_TextBox_KeyPress);
            this.Term_TextBox.Leave += new System.EventHandler(this.Term_TextBox_Leave);
            // 
            // CreateFlashcard_Button
            // 
            this.CreateFlashcard_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateFlashcard_Button.Location = new System.Drawing.Point(11, 151);
            this.CreateFlashcard_Button.Margin = new System.Windows.Forms.Padding(2);
            this.CreateFlashcard_Button.Name = "CreateFlashcard_Button";
            this.CreateFlashcard_Button.Size = new System.Drawing.Size(393, 39);
            this.CreateFlashcard_Button.TabIndex = 2;
            this.CreateFlashcard_Button.Text = "Create flashcard";
            this.CreateFlashcard_Button.UseVisualStyleBackColor = true;
            this.CreateFlashcard_Button.Click += new System.EventHandler(this.CreateFlashcard_Button_Click);
            // 
            // Definition_TextBox
            // 
            this.Definition_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Definition_TextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Definition_TextBox.Location = new System.Drawing.Point(11, 112);
            this.Definition_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Definition_TextBox.Name = "Definition_TextBox";
            this.Definition_TextBox.Size = new System.Drawing.Size(393, 32);
            this.Definition_TextBox.TabIndex = 1;
            this.Definition_TextBox.Text = "Definition";
            this.Definition_TextBox.Enter += new System.EventHandler(this.Definition_TextBox_Enter);
            this.Definition_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Definition_TextBox_KeyDown);
            this.Definition_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Definition_TextBox_KeyPress);
            this.Definition_TextBox.Leave += new System.EventHandler(this.Definition_TextBox_Leave);
            // 
            // ImportFlashcards_CSV_Button
            // 
            this.ImportFlashcards_CSV_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImportFlashcards_CSV_Button.Location = new System.Drawing.Point(11, 39);
            this.ImportFlashcards_CSV_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ImportFlashcards_CSV_Button.Name = "ImportFlashcards_CSV_Button";
            this.ImportFlashcards_CSV_Button.Size = new System.Drawing.Size(195, 24);
            this.ImportFlashcards_CSV_Button.TabIndex = 8;
            this.ImportFlashcards_CSV_Button.Text = "Import flashcards from .csv";
            this.ImportFlashcards_CSV_Button.UseVisualStyleBackColor = true;
            this.ImportFlashcards_CSV_Button.Click += new System.EventHandler(this.ImportFlashcards_CSV_Button_Click);
            // 
            // ExportFlashcards_CSV_Button
            // 
            this.ExportFlashcards_CSV_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportFlashcards_CSV_Button.Location = new System.Drawing.Point(210, 39);
            this.ExportFlashcards_CSV_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ExportFlashcards_CSV_Button.Name = "ExportFlashcards_CSV_Button";
            this.ExportFlashcards_CSV_Button.Size = new System.Drawing.Size(194, 24);
            this.ExportFlashcards_CSV_Button.TabIndex = 9;
            this.ExportFlashcards_CSV_Button.Text = "Export flashcards as .csv";
            this.ExportFlashcards_CSV_Button.UseVisualStyleBackColor = true;
            this.ExportFlashcards_CSV_Button.Click += new System.EventHandler(this.ExportFlashcards_CSV_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(415, 648);
            this.Controls.Add(this.ExportFlashcards_CSV_Button);
            this.Controls.Add(this.ImportFlashcards_CSV_Button);
            this.Controls.Add(this.Definition_TextBox);
            this.Controls.Add(this.CreateFlashcard_Button);
            this.Controls.Add(this.Term_TextBox);
            this.Controls.Add(this.ImportFlashcards_FCS_Button);
            this.Controls.Add(this.ExportFlashcards_FCS_Button);
            this.Controls.Add(this.SelectAll_Button);
            this.Controls.Add(this.UnselectAll_Button);
            this.Controls.Add(this.Flashcards_CheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button ImportFlashcards_FCS_Button;
        private System.Windows.Forms.Button ExportFlashcards_FCS_Button;
        private System.Windows.Forms.TextBox Term_TextBox;
        private System.Windows.Forms.Button CreateFlashcard_Button;
        private System.Windows.Forms.TextBox Definition_TextBox;
        private System.Windows.Forms.Button ImportFlashcards_CSV_Button;
        private System.Windows.Forms.Button ExportFlashcards_CSV_Button;
    }
}

