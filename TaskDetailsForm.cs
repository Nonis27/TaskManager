using TaskManager;

namespace TaskManager
{
    public partial class TaskDetailsForm : Form
    {
        TaskManagerData taskManagerData;
        int Key;
        public TaskDetailsForm()
        {
            InitializeComponent();
            taskManagerData = new TaskManagerData();
        }

        public void GetTaskKey(int key)
        {
            Key = key;
            if (TaskManagerData.taskDictionary.TryGetValue(Key, out TaskManagerData.TaskInfo taskInfo))
            {
                TaskDetailsText.Text = taskInfo.Details;
                bool taskHasDetails = string.IsNullOrEmpty(taskInfo.Details);
                AddDetailsButton.Enabled = taskHasDetails;
                AddDetailsButton.Visible = taskHasDetails;
            }
            else
            {
                TaskDetailsText.Text = string.Empty;
                AddDetailsButton.Enabled = false;
                MessageBox.Show($"Task with key: {Key} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sorry for the spageti code :(
        private void AddDetailsButton_Click(object sender, EventArgs e)
        {
            if (TaskDetailsText != null)
            {
                if (TaskManagerData.taskDictionary.TryGetValue(Key, out TaskManagerData.TaskInfo taskInfo))
                {
                    if (string.IsNullOrEmpty(taskInfo.Details))
                    {
                        if (!string.IsNullOrWhiteSpace(TaskDetailsText.Text))
                        {
                            taskInfo.Details = TaskDetailsText.Text;

                            // Update the Dictionary and disable the add details button
                            TaskManagerData.taskDictionary[Key] = taskInfo;
                            AddDetailsButton.Enabled = false;
                            AddDetailsButton.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Please enter details before adding.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The task already has details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AddDetailsButton.Enabled = false;
                        AddDetailsButton.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show($"There is now task assigned to the key {Key}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // The control is that because the list is null in this case
                TaskDetailsTextNullError.SetError(AddDetailsButton, "Task Details are null");
                NullTextErrorTimer.Start();
            }
        }

        private void NullTextErrorTimer_Tick(object sender, EventArgs e)
        {
            TaskDetailsTextNullError.SetError(TaskDetailsText, "");
            NullTextErrorTimer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TaskDetailsForm.ActiveForm != null)
            {
                TaskDetailsForm.ActiveForm.Close();
            }
        }
    }
}
