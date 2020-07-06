using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class FormCreateNote : Form
    {
        private DataStorage storage;
        public FormCreateNote()
        {
            InitializeComponent();
            storage = DataStorage.GetInstance();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem.Equals("НЕ ВЫБРАНА") ||
                string.IsNullOrEmpty(richTextBox.Text))
            {
                MessageBox.Show("Введите текст и укажите категорию");
                return;
            }
            storage.Notes.Add(new Models.Note
            {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                Text = richTextBox.Text,
                Tags = textBoxTags.Text
            });
            Close();
        }

        private void FormCreateNote_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("НЕ ВЫБРАНА");
            comboBoxCategory.Items.AddRange(storage.Categories.ToArray());
            comboBoxCategory.SelectedItem = "НЕ ВЫБРАНА";
        }
    }
}
