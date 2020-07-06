using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organizer.Models;
using Task = Organizer.Models.Task;

namespace Organizer
{
    public partial class FormTasks : Form
    {
        private DataStorage storage;
        public FormTasks()
        {
            InitializeComponent();
            storage = DataStorage.GetInstance();
        }

        private void PrintAllTasks()
        {
            StringBuilder sb = new StringBuilder();
            var i = 1;
            foreach(var task in storage.Tasks)
            {
                sb.AppendLine($"Номер: {i}");
                sb.AppendLine($"Срок: {task.Deadline.ToShortDateString()}");
                sb.AppendLine($"Задача: {task.Text}");
                sb.AppendLine("-------------------------");
                i++;
            }
            richTextBox.Text = sb.ToString();
        }

        private void FormTasks_Load(object sender, EventArgs e)
        {
            PrintAllTasks();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCreateTask();
            form.ShowDialog();
            PrintAllTasks();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Не указан номер удаляемой задачи");
                return;
            }
            var i = Convert.ToInt32(textBoxNumber.Text) - 1;
            if (i >= 0 && i < storage.Tasks.Count)
            {                
                if (MessageBox.Show("Удалить задачу?", "Удаление", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    storage.Tasks.RemoveAt(i);
                    MessageBox.Show("Удалено");
                }
                textBoxNumber.Text = "";
            } 
            else
            {
                MessageBox.Show("Неверный номер задачи");
            }
            PrintAllTasks();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                PrintAllTasks();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("РЕЗУЛЬТАТЫ ПОИСКА");
                sb.AppendLine();
                bool isSmthFound = false;
                for (int i = 0; i < storage.Tasks.Count; i++)
                {
                    if (storage.Tasks[i].Text.ToLower().Contains(textBoxSearch.Text.ToLower()))
                    {
                        sb.AppendLine($"Номер: {i + 1}");
                        sb.AppendLine($"Срок: {storage.Tasks[i].Deadline.ToShortDateString()}");
                        sb.AppendLine($"Задача: {storage.Tasks[i].Text}");
                        sb.AppendLine("-------------------------");
                        isSmthFound = true;
                    }
                }
                if (!isSmthFound)
                {
                    richTextBox.Text = "РЕЗУЛЬТАТЫ ПОИСКА\n\nНичего не найдено";
                }
                else
                {
                    richTextBox.Text = sb.ToString();
                }
            }
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
