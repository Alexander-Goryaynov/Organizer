namespace Organizer
{
    partial class FormNotes
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonShowNotes = new System.Windows.Forms.Button();
            this.buttonShowCategories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonNewCategory = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonDelCategory = new System.Windows.Forms.Button();
            this.textBoxCategoryNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelNote = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBoxNoteNumber = new System.Windows.Forms.TextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(276, 72);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(512, 463);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // buttonShowNotes
            // 
            this.buttonShowNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShowNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowNotes.Location = new System.Drawing.Point(12, 108);
            this.buttonShowNotes.Name = "buttonShowNotes";
            this.buttonShowNotes.Size = new System.Drawing.Size(258, 23);
            this.buttonShowNotes.TabIndex = 1;
            this.buttonShowNotes.Text = "Показать все заметки";
            this.buttonShowNotes.UseVisualStyleBackColor = false;
            this.buttonShowNotes.Click += new System.EventHandler(this.buttonShowNotes_Click);
            // 
            // buttonShowCategories
            // 
            this.buttonShowCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonShowCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowCategories.Location = new System.Drawing.Point(12, 138);
            this.buttonShowCategories.Name = "buttonShowCategories";
            this.buttonShowCategories.Size = new System.Drawing.Size(258, 23);
            this.buttonShowCategories.TabIndex = 2;
            this.buttonShowCategories.Text = "Показать все категории";
            this.buttonShowCategories.UseVisualStyleBackColor = false;
            this.buttonShowCategories.Click += new System.EventHandler(this.buttonShowCategories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фильтровать по категории";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(203, 42);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(585, 24);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(66, 11);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(722, 22);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonNewCategory
            // 
            this.buttonNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonNewCategory.Location = new System.Drawing.Point(9, 67);
            this.buttonNewCategory.Name = "buttonNewCategory";
            this.buttonNewCategory.Size = new System.Drawing.Size(242, 24);
            this.buttonNewCategory.TabIndex = 7;
            this.buttonNewCategory.Text = "Добавить";
            this.buttonNewCategory.UseVisualStyleBackColor = false;
            this.buttonNewCategory.Click += new System.EventHandler(this.buttonNewCategory_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonDelCategory);
            this.groupBox.Controls.Add(this.textBoxCategoryNumber);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(12, 283);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(258, 97);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Удалить категорию";
            // 
            // buttonDelCategory
            // 
            this.buttonDelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDelCategory.Location = new System.Drawing.Point(10, 56);
            this.buttonDelCategory.Name = "buttonDelCategory";
            this.buttonDelCategory.Size = new System.Drawing.Size(242, 23);
            this.buttonDelCategory.TabIndex = 2;
            this.buttonDelCategory.Text = "Удалить";
            this.buttonDelCategory.UseVisualStyleBackColor = false;
            this.buttonDelCategory.Click += new System.EventHandler(this.buttonDelCategory_Click);
            // 
            // textBoxCategoryNumber
            // 
            this.textBoxCategoryNumber.Location = new System.Drawing.Point(135, 20);
            this.textBoxCategoryNumber.Name = "textBoxCategoryNumber";
            this.textBoxCategoryNumber.Size = new System.Drawing.Size(117, 22);
            this.textBoxCategoryNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер категории";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxCategoryName);
            this.groupBox2.Controls.Add(this.buttonNewCategory);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 102);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить категорию";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(6, 41);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(245, 22);
            this.textBoxCategoryName.TabIndex = 8;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNote.Location = new System.Drawing.Point(12, 398);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(258, 23);
            this.buttonAddNote.TabIndex = 10;
            this.buttonAddNote.Text = "Добавить заметку";
            this.buttonAddNote.UseVisualStyleBackColor = false;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelNote);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.textBoxNoteNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удалить заметку";
            // 
            // buttonDelNote
            // 
            this.buttonDelNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDelNote.Location = new System.Drawing.Point(13, 62);
            this.buttonDelNote.Name = "buttonDelNote";
            this.buttonDelNote.Size = new System.Drawing.Size(238, 23);
            this.buttonDelNote.TabIndex = 2;
            this.buttonDelNote.Text = "Удалить";
            this.buttonDelNote.UseVisualStyleBackColor = false;
            this.buttonDelNote.Click += new System.EventHandler(this.buttonDelNote_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(109, 16);
            this.label.TabIndex = 1;
            this.label.Text = "Номер заметки";
            // 
            // textBoxNoteNumber
            // 
            this.textBoxNoteNumber.Location = new System.Drawing.Point(125, 25);
            this.textBoxNoteNumber.Name = "textBoxNoteNumber";
            this.textBoxNoteNumber.Size = new System.Drawing.Size(126, 22);
            this.textBoxNoteNumber.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(12, 79);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(258, 23);
            this.buttonExport.TabIndex = 12;
            this.buttonExport.Text = "Экспортировать в файл";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowCategories);
            this.Controls.Add(this.buttonShowNotes);
            this.Controls.Add(this.richTextBox);
            this.Name = "FormNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заметки";
            this.Load += new System.EventHandler(this.FormNotes_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonShowNotes;
        private System.Windows.Forms.Button buttonShowCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonNewCategory;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonDelCategory;
        private System.Windows.Forms.TextBox textBoxCategoryNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelNote;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxNoteNumber;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}