using TaskManager;
using System;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        TaskManager taskManager;
        public Form1()
        {
            InitializeComponent();
            taskManager = new TaskManager();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBox != null)
            {
                TaskList.Items.Add(textBox.Text);
                taskManager.AddTask(textBox.Text);
            }
        }
    }
}
