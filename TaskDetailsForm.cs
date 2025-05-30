using TaskManager;

namespace TaskManager
{
    public partial class TaskDetailsForm : Form
    {
        public TaskDetailsForm()
        {
            InitializeComponent();
        }

        public void SetTaskDetails(string details)
        {
            if (TaskDetailsText != null)
            {
                TaskDetailsText.Text = details;
            }
        }

        private void AddDetailsButton_Click(object sender, EventArgs e)
        {
            if (TaskDetailsText != null)
            {
                if (!string.IsNullOrEmpty(TaskDetailsText.Text))
                {
                    MessageBox.Show("Task has already some details", "Task has details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TaskDetailsText.ReadOnly = false;
                }
            }
        }
        private void TaskDetailsText_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskDetailsText.Text))
            {
                MessageBox.Show("You need to add some details for the task", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!string.IsNullOrWhiteSpace(TaskDetailsText.Text))
            {
                TaskDetailsText.ReadOnly = true;
            }
            
        }
    }
}
