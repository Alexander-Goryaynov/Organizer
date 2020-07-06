namespace Organizer
{
    partial class FormEnter
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
            this.buttonTasks = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTasks
            // 
            this.buttonTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTasks.Location = new System.Drawing.Point(145, 54);
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Size = new System.Drawing.Size(187, 74);
            this.buttonTasks.TabIndex = 0;
            this.buttonTasks.Text = "Задачи";
            this.buttonTasks.UseVisualStyleBackColor = false;
            this.buttonTasks.Click += new System.EventHandler(this.buttonTasks_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNotes.Location = new System.Drawing.Point(145, 149);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(187, 74);
            this.buttonNotes.TabIndex = 1;
            this.buttonNotes.Text = "Заметки";
            this.buttonNotes.UseVisualStyleBackColor = false;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(476, 284);
            this.Controls.Add(this.buttonNotes);
            this.Controls.Add(this.buttonTasks);
            this.Name = "FormEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ежедневник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTasks;
        private System.Windows.Forms.Button buttonNotes;
    }
}