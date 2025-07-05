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

            // Load all the tasks and refresh listBox
            taskManagerData.LoadTasks();
            taskManagerData.SetMaxKey();

            RefreshTaskList();
            RefreshMonthCalendar();

            // Initialize timer
            ErrorTimer.Interval = 5000;
            ErrorTimer.Tick += ErrorTimer_Tick;

            // Set the Date of TaskDateTimePicker as today
            TaskDateTimePicker.Value = DateTime.Now;
        }

        public void RefreshTaskList()
        {
            TaskList.Items.Clear();
            foreach (var kvp in TaskManagerData.TaskDictionary)
            {
                TaskList.Items.Add(new KeyValuePair<int, string>(kvp.Key, kvp.Value.Title));
            }

            TaskList.Refresh();
        }

        public void RefreshMonthCalendar()
        {
            foreach (var item in TaskManagerData.TaskDictionary.Values)
            {
                MonthCalendar.AddBoldedDate(item.TaskDueDate);
            }

            MonthCalendar.UpdateBoldedDates();
            MonthCalendar.Refresh();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            bool titleExists = false;
            bool validDate = false;
            string newTitle = textBox.Text;
            DateTime taskDueDate = DateTime.Now.Date;

            // Check if the title exists and if the date is valid
            foreach (var task in TaskManagerData.TaskDictionary.Values)
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
                else if (TaskDateTimePicker.Value.Date < DateTime.Now.Date)
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
                    if (TaskDateTimePicker != null)
                    {
                        TaskDateTimePicker.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error, couldn't change TaskDateTimePicker value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

                taskDetailsForm.SetTaskDetailsText(key);
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

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = MonthCalendar.SelectionStart.Date;
            bool isBolded = MonthCalendar.BoldedDates.Any(d => d.Date == selectedDate);

            if (isBolded)
            {
                string text = "";

                // Iterate through everytask in taskDictionary
                foreach (var task in TaskManagerData.TaskDictionary.Values)
                {
                    if (task.TaskDueDate == selectedDate)
                    {
                        text += $"-{task.Title}{Environment.NewLine}";
                    }
                }
                MessageBox.Show(text, selectedDate.ToShortDateString());
            }
            else
            {
                MessageBox.Show("There are no tasks for the selected date.", selectedDate.ToShortDateString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            taskManagerData.SaveTasks();
            if (TaskManagerForm.ActiveForm != null)
            {
                this.Close();
            }
        }

        private void TaskList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                var kvp = (KeyValuePair<int, string>)TaskList.SelectedItem;
                int key = kvp.Key;

                using (DeleteTaskForm deleteTaskForm = new DeleteTaskForm(this))
                {
                    if (deleteTaskForm != null)
                    {
                        deleteTaskForm.InitializeDeleteFormContent(key);
                        deleteTaskForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error, DeleteTaskForm is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, no item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
