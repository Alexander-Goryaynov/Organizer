using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class FormNotes : Form
    {
        private DataStorage storage;
        public FormNotes()
        {
            InitializeComponent();
            storage = DataStorage.GetInstance();
        }

        private void buttonShowCategories_Click(object sender, EventArgs e)
        {
            PrintAllCategories();
        }

        private void buttonShowNotes_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("СПИСОК ВСЕХ ЗАМЕТОК");
            sb.AppendLine();
            var i = 1;
            foreach (var note in storage.Notes)
            {
                sb.AppendLine($"Номер: {i}");
                sb.AppendLine($"Категория: {note.CategoryName}");
                sb.AppendLine($"Метки: {note.Tags}");
                sb.AppendLine($"Текст: {note.Text}");
                sb.AppendLine("---------------------------------");
                i++;
            }
            richTextBox.Text = sb.ToString();
        }

        private void PrintAllCategories()
        {
            var sb = new StringBuilder();
            sb.AppendLine("СПИСОК ВСЕХ КАТЕГОРИЙ");
            sb.AppendLine();
            for (int i = 0; i < storage.Categories.Count; i++)
            {
                sb.Append($"{i + 1} -> {storage.Categories[i]}");
                sb.AppendLine();
            }
            richTextBox.Text = sb.ToString();
        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCategoryName.Text))
            {
                MessageBox.Show("Заполните название категории");
                return;
            }
            if (storage.Categories.Contains(textBoxCategoryName.Text))
            {
                MessageBox.Show("Категория с таким названием уже существует");
                return;
            }
            storage.Categories.Add(textBoxCategoryName.Text);
            textBoxCategoryName.Text = "";            
            LoadCategoriesComboBox();
            PrintAllCategories();
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            buttonShowNotes_Click(sender, e);
            LoadCategoriesComboBox();
        }

        private void LoadCategoriesComboBox()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("ВСЕ КАТЕГОРИИ");
            comboBoxCategory.Items.AddRange(storage.Categories.ToArray());
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonDelCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCategoryNumber.Text))
            {
                MessageBox.Show("Не указан номер удаляемой категории");
                return;
            }
            var i = Convert.ToInt32(textBoxCategoryNumber.Text) - 1;
            if (i >= 0 && i < storage.Categories.Count)
            {
                if (MessageBox.Show($"Удалить категорию \"{storage.Categories[i]}\"?" +
                    $" \nВсе заметки из этой категории также будут удалены!",
                    "Удаление", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    for (int j = 0; j < storage.Notes.Count; j++)
                    {
                        if (storage.Notes[j].CategoryName.Equals(storage.Categories[i]))
                        {
                            storage.Notes.RemoveAt(j);
                            j--;
                        }
                    }
                    storage.Categories.RemoveAt(i);
                    MessageBox.Show("Удалено");
                }
                textBoxCategoryNumber.Text = "";
                buttonShowNotes_Click(sender, e);
                LoadCategoriesComboBox();
            }
            else
            {
                MessageBox.Show("Неверный номер удаляемой категории");
            }
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            if (storage.Categories.Count == 0)
            {
                MessageBox.Show("Список категорий пуст. Добавьте категорию");
                return;
            }
            var form = new FormCreateNote();
            form.ShowDialog();
            buttonShowNotes_Click(sender, e);
        }

        private void buttonDelNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNoteNumber.Text))
            {
                MessageBox.Show("Не указан номер удаляемой заметки");
                return;
            }
            var i = Convert.ToInt32(textBoxNoteNumber.Text) - 1;
            if (i >= 0 && i < storage.Notes.Count)
            {
                if (MessageBox.Show("Удалить заметку?", "Удаление", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    storage.Notes.RemoveAt(i);
                    MessageBox.Show("Удалено");
                }
                textBoxNoteNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный номер заметки");
            }
            buttonShowNotes_Click(sender, e);
        }

        private void PrintSearchResult(object sender, EventArgs e)
        {
            var phrase = textBoxSearch.Text.ToLower();
            var all = "ВСЕ КАТЕГОРИИ";
            var item = comboBoxCategory.SelectedItem;
            if (string.IsNullOrEmpty(phrase) && item.Equals(all))
            {
                buttonShowNotes_Click(sender, e);
                return;
            }
            var sb = new StringBuilder();
            if (!string.IsNullOrEmpty(phrase) && item.Equals(all))
            {
                sb.AppendLine("ПОИСК ВО ВСЕХ КАТЕГОРИЯХ");
                sb.AppendLine();
                var isSmthFound = false;
                for (int i = 0; i < storage.Notes.Count; i++)
                {
                    var note = storage.Notes[i];
                    if (note.Tags.ToLower().Contains(phrase) ||
                        note.Text.ToLower().Contains(phrase))
                    {
                        sb.AppendLine($"Номер: {i + 1}");
                        sb.AppendLine($"Категория: {note.CategoryName}");
                        sb.AppendLine($"Метки: {note.Tags}");
                        sb.AppendLine($"Текст: {note.Text}");
                        sb.AppendLine("---------------------------------");
                        isSmthFound = true;
                    }
                }
                if (!isSmthFound)
                {
                    sb.AppendLine("Ничего не найдено");
                }
            }
            else if (string.IsNullOrEmpty(phrase) && !item.Equals(all)) 
            {
                sb.AppendLine("ВСЕ ЗАМЕТКИ КАТЕГОРИИ \"" + 
                    $"{comboBoxCategory.SelectedItem.ToString().ToUpper()}\"");
                sb.AppendLine();
                var isSmthFound = false;
                for (int i = 0; i < storage.Notes.Count; i++)
                {
                    var note = storage.Notes[i];
                    if (note.CategoryName.Equals(item))
                    {
                        sb.AppendLine($"Номер: {i + 1}");
                        sb.AppendLine($"Категория: {note.CategoryName}");
                        sb.AppendLine($"Метки: {note.Tags}");
                        sb.AppendLine($"Текст: {note.Text}");
                        sb.AppendLine("---------------------------------");
                        isSmthFound = true;
                    }
                }
                if (!isSmthFound)
                {
                    sb.AppendLine("Ничего не найдено");
                }
            }
            else if (!string.IsNullOrEmpty(phrase) && !item.Equals(all))
            {
                sb.AppendLine("ПОИСК В КАТЕГОРИИ \"" +
                    $"{comboBoxCategory.SelectedItem.ToString().ToUpper()}\"");
                sb.AppendLine();
                var isSmthFound = false;
                for (int i = 0; i < storage.Notes.Count; i++)
                {
                    var note = storage.Notes[i];
                    if ((note.Tags.ToLower().Contains(phrase) ||
                        note.Text.ToLower().Contains(phrase)) &&
                        note.CategoryName.Equals(item))
                    {
                        sb.AppendLine($"Номер: {i + 1}");
                        sb.AppendLine($"Категория: {note.CategoryName}");
                        sb.AppendLine($"Метки: {note.Tags}");
                        sb.AppendLine($"Текст: {note.Text}");
                        sb.AppendLine("---------------------------------");
                        isSmthFound = true;
                    }
                }
                if (!isSmthFound)
                {
                    sb.AppendLine("Ничего не найдено");
                }
            }
            richTextBox.Text = sb.ToString();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PrintSearchResult(sender, e);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintSearchResult(sender, e);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "txt | *.txt" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {                   
                    try
                    {
                        File.WriteAllLines(dialog.FileName,
                            richTextBox.Text.Split(new string[] { "\n" },
                            StringSplitOptions.RemoveEmptyEntries));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка записи");
                        return;
                    }
                    MessageBox.Show("Запись прошла успешно");
                }
            }
        }
    }
}
