using TaskManager;
using System;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        TaskManagerData taskManagerData;
        public Form1()
        {
            InitializeComponent();
            taskManagerData = new TaskManagerData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool titleExists = false;
            string newTitle = textBox.Text;
            foreach (var task in TaskManagerData.taskList.Values)
            {
                if (task == newTitle)
                {
                    titleExists = true;
                    break;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!titleExists)
                {
                    TaskList.Items.Add(taskManagerData.AddTask(textBox.Text));
                }
                textBox.Clear();
            }

            
        }
    }
}
