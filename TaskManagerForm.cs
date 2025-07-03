using TaskManager;
using System;

namespace TaskManager
{
    public partial class TaskManagerForm : Form
    {
        TaskManagerData taskManagerData;
        TaskDetailsForm taskDetailsForm;
        public TaskManagerForm()
        {
            InitializeComponent();
            // Make a reference to the TaskManagerData class
            taskManagerData = new TaskManagerData();

            // Make a reference to the TaskDetailsForm class
            taskDetailsForm = new TaskDetailsForm();

            // Initialize timer
            ErrorTimer.Interval = 5000;
            ErrorTimer.Tick += ErrorTimer_Tick;

            // Set the Date of TaskDateTimePicker as today
            TaskDateTimePicker.Value = DateTime.Now;
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            bool titleExists = false;
            bool validDate = false;
            string newTitle = textBox.Text;
            DateTime taskDueDate = DateTime.Now.Date;

            // Check if the title exists and if the date is valid
            foreach (var task in TaskManagerData.taskDictionary.Values)
            {
                if (task.Title == newTitle)
                {
                    titleExists = true;
                    break;
                }
            }

            if (TaskDateTimePicker != null)
            {
                if (TaskDateTimePicker.Value.Date == DateTime.Now.Date)
                {
                    validDate = false;
                    MessageBox.Show("The date you selected is today.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TaskDateTimePicker.Value.Date <  DateTime.Now.Date)
                {
                    validDate = false;
                    MessageBox.Show("You can't select a past date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    taskDueDate = TaskDateTimePicker.Value.Date;
                    validDate = true;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!titleExists && validDate && taskDueDate != DateTime.Now.Date)
                {
                    // Save the task title and the due date
                    taskManagerData.AddTaskToList(textBox.Text, TaskList, taskDueDate);

                    // Highlight the due date in the month calendar
                    MonthCalendar.AddBoldedDate(taskDueDate);
                    MonthCalendar.UpdateBoldedDates();

                    // Clear the text in textBox and reset TaskDateTimePicker
                    textBox.Clear();
                    TaskDateTimePicker.Value = DateTime.Now;
                }
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                // Get the key of the selected item
                var selectedPair = (KeyValuePair<int, string>)TaskList.SelectedItem;
                int key = selectedPair.Key;

                taskDetailsForm.GetTaskKey(key);
                taskDetailsForm.SetDetailsButtonText(key);
                taskDetailsForm.ShowDialog();
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
