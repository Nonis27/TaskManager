using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaskManager;

namespace TaskManager
{
    public partial class DeleteTaskForm : Form
    {
        private TaskManagerData taskManagerData;
        private TaskManagerForm taskManagerForm;
        private int Key { get; set; }
        public DeleteTaskForm(TaskManagerForm mainForm)
        {
            InitializeComponent();
            taskManagerData = new TaskManagerData();
            taskManagerForm = mainForm;
        }

        public void InitializeDeleteFormContent (int key)
        {
            Key = key;
            if (TaskManagerData.TaskDictionary.TryGetValue(key, out TaskManagerData.TaskInfo taskInfo))
            {
                TaskTitleLabel.Text = $"Task Title: {taskInfo.Title}";
                TaskDueDate.Text = taskInfo.TaskDueDate.ToShortDateString();
            }
            else
            {
                MessageBox.Show($"Task with key: {Key} not found in initialize details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskManagerData.TaskDictionary.TryGetValue(Key, out TaskManagerData.TaskInfo taskInfo))
            {
                TaskManagerData.TaskDictionary.Remove(Key);
                taskManagerForm.MonthCalendar.RemoveBoldedDate(taskInfo.TaskDueDate);
                taskManagerData.SaveTasks();

                foreach (var item in taskManagerForm.TaskList.Items)
                {
                    if (item is KeyValuePair<int, string> pair && pair.Key == Key)
                    {
                        taskManagerForm.TaskList.Items.Remove(Key);
                        break;
                    }
                }

                taskManagerForm.RefreshTaskList();
                taskManagerForm.RefreshMonthCalendar();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Task with key: {Key} not found is delete task button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (DeleteTaskForm.ActiveForm != null)
            {
                this.Close();
            }
        }
    }
}
