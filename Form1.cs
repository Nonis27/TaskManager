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
            // Make a reference to the TaskManagerData class
            taskManagerData = new TaskManagerData();

            // Initialize timer
            ErrorTimer.Interval = 5000;
            ErrorTimer.Tick += ErrorTimer_Tick;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool titleExists = false;
            string newTitle = textBox.Text;
            foreach (var task in TaskManagerData.taskDictionary.Values)
            {
                if (task.Title == newTitle)
                {
                    titleExists = true;
                    break;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!titleExists)
                {
                    taskManagerData.AddTaskToList(textBox.Text, TaskList);
                }
                textBox.Clear();
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                TaskDetailsForm taskDetailsForm = new TaskDetailsForm();
                taskDetailsForm.SetTaskDetails(taskManagerData.ReturnDetails("Bob"));
                taskDetailsForm.Show();
            }
            else
            {
                NoItemSelectedError.SetError(TaskList, "No item selected.");
                ErrorTimer.Start();
            }
        }

        private void ErrorTimer_Tick(object? sender, EventArgs e)
        {
            NoItemSelectedError.SetError(TaskList, "");
            ErrorTimer.Stop();
        }
    }
}
