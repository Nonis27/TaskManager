namespace TaskManager
{
    partial class TaskManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TaskList = new ListBox();
            AddTaskButton = new Button();
            textBox = new TextBox();
            TaskTitleLabel = new Label();
            detailsButton = new Button();
            NoItemSelectedError = new ErrorProvider(components);
            ErrorTimer = new System.Windows.Forms.Timer(components);
            MonthCalendar = new MonthCalendar();
            TaskDateTimePicker = new DateTimePicker();
            DueDateLabel = new Label();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NoItemSelectedError).BeginInit();
            SuspendLayout();
            // 
            // TaskList
            // 
            TaskList.BackColor = SystemColors.HighlightText;
            TaskList.DisplayMember = "Value";
            TaskList.FormattingEnabled = true;
            TaskList.HorizontalScrollbar = true;
            TaskList.Location = new Point(12, 12);
            TaskList.Name = "TaskList";
            TaskList.Size = new Size(460, 264);
            TaskList.TabIndex = 0;
            TaskList.ValueMember = "Key";
            // 
            // AddTaskButton
            // 
            AddTaskButton.Location = new Point(637, 121);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(91, 30);
            AddTaskButton.TabIndex = 1;
            AddTaskButton.Text = "Add Task";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(478, 35);
            textBox.Name = "textBox";
            textBox.Size = new Size(250, 27);
            textBox.TabIndex = 2;
            // 
            // TaskTitleLabel
            // 
            TaskTitleLabel.AutoSize = true;
            TaskTitleLabel.Location = new Point(478, 12);
            TaskTitleLabel.Name = "TaskTitleLabel";
            TaskTitleLabel.Size = new Size(69, 20);
            TaskTitleLabel.TabIndex = 3;
            TaskTitleLabel.Text = "Task Title";
            // 
            // detailsButton
            // 
            detailsButton.Location = new Point(478, 121);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(91, 30);
            detailsButton.TabIndex = 4;
            detailsButton.Text = "See Details";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // NoItemSelectedError
            // 
            NoItemSelectedError.ContainerControl = this;
            // 
            // ErrorTimer
            // 
            ErrorTimer.Tag = "";
            ErrorTimer.Tick += ErrorTimer_Tick;
            // 
            // MonthCalendar
            // 
            MonthCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MonthCalendar.Location = new Point(982, 12);
            MonthCalendar.MaxSelectionCount = 1;
            MonthCalendar.Name = "MonthCalendar";
            MonthCalendar.TabIndex = 5;
            MonthCalendar.DateSelected += MonthCalendar_DateSelected;
            // 
            // TaskDateTimePicker
            // 
            TaskDateTimePicker.Location = new Point(478, 88);
            TaskDateTimePicker.Name = "TaskDateTimePicker";
            TaskDateTimePicker.Size = new Size(250, 27);
            TaskDateTimePicker.TabIndex = 6;
            TaskDateTimePicker.Value = new DateTime(2025, 7, 2, 22, 36, 59, 0);
            // 
            // DueDateLabel
            // 
            DueDateLabel.AutoSize = true;
            DueDateLabel.Location = new Point(478, 65);
            DueDateLabel.Name = "DueDateLabel";
            DueDateLabel.Size = new Size(72, 20);
            DueDateLabel.TabIndex = 7;
            DueDateLabel.Text = "Due Date";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(1154, 631);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(90, 30);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // TaskManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1262, 673);
            Controls.Add(CloseButton);
            Controls.Add(DueDateLabel);
            Controls.Add(TaskDateTimePicker);
            Controls.Add(MonthCalendar);
            Controls.Add(detailsButton);
            Controls.Add(TaskTitleLabel);
            Controls.Add(textBox);
            Controls.Add(AddTaskButton);
            Controls.Add(TaskList);
            Name = "TaskManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)NoItemSelectedError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TaskList;
        private Button AddTaskButton;
        private TextBox textBox;
        private Label TaskTitleLabel;
        private Button detailsButton;
        private ErrorProvider NoItemSelectedError;
        private System.Windows.Forms.Timer ErrorTimer;
        private MonthCalendar MonthCalendar;
        private Label DueDateLabel;
        private DateTimePicker TaskDateTimePicker;
        private Button CloseButton;
    }
}
