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
    public partial class FormCreateTask : Form
    {
        private DataStorage storage;
        public FormCreateTask()
        {
            InitializeComponent();
            storage = DataStorage.GetInstance();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxText.Text) && 
                dateTimePicker.Value.AddMinutes(1.0) >= DateTime.Now)
            {
                storage.Tasks.Add(new Models.Task
                {
                    Deadline = dateTimePicker.Value,
                    Text = textBoxText.Text
                });
                Close();
            }
            else if (string.IsNullOrEmpty(textBoxText.Text))
            {
                MessageBox.Show("Не заполнено поле \"Текст\"");
            }
            else
            {
                MessageBox.Show("Дата должна быть не меньше текущей");
            }
        }
    }
}
