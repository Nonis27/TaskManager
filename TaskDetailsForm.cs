using TaskManager;

namespace TaskManager
{
    public partial class TaskDetailsForm : Form
    {
        public TaskDetailsForm()
        {
            InitializeComponent();
        }

        public void DisplayDetails(string details)
        {
            TaskDetailsText.Text = details;

        }
    }
}
