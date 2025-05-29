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
            if (textBox != null)
            {
                TaskList.Items.Add(taskManagerData.AddTask(textBox.Text));
            }
        }
    }
}
