namespace TaskManager
{
    partial class DeleteTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TaskTitleLabel = new Label();
            TaskDueDate = new Label();
            DeleteTaskButton = new Button();
            CancelDeleteButton = new Button();
            SuspendLayout();
            // 
            // TaskTitleLabel
            // 
            TaskTitleLabel.AutoSize = true;
            TaskTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskTitleLabel.Location = new Point(12, 29);
            TaskTitleLabel.Name = "TaskTitleLabel";
            TaskTitleLabel.Size = new Size(72, 20);
            TaskTitleLabel.TabIndex = 0;
            TaskTitleLabel.Text = "Task Title:";
            // 
            // TaskDueDate
            // 
            TaskDueDate.AutoSize = true;
            TaskDueDate.Location = new Point(12, 9);
            TaskDueDate.Name = "TaskDueDate";
            TaskDueDate.Size = new Size(106, 20);
            TaskDueDate.TabIndex = 1;
            TaskDueDate.Text = "Task Due Date:";
            // 
            // DeleteTaskButton
            // 
            DeleteTaskButton.Location = new Point(12, 92);
            DeleteTaskButton.Name = "DeleteTaskButton";
            DeleteTaskButton.Size = new Size(94, 29);
            DeleteTaskButton.TabIndex = 2;
            DeleteTaskButton.Text = "Delete Task";
            DeleteTaskButton.UseVisualStyleBackColor = true;
            DeleteTaskButton.Click += DeleteTaskButton_Click;
            // 
            // CancelDeleteButton
            // 
            CancelDeleteButton.Location = new Point(216, 92);
            CancelDeleteButton.Name = "CancelDeleteButton";
            CancelDeleteButton.Size = new Size(74, 29);
            CancelDeleteButton.TabIndex = 3;
            CancelDeleteButton.Text = "Cancel";
            CancelDeleteButton.UseVisualStyleBackColor = true;
            CancelDeleteButton.Click += CancelButton_Click;
            // 
            // DeleteTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(302, 133);
            Controls.Add(CancelDeleteButton);
            Controls.Add(DeleteTaskButton);
            Controls.Add(TaskDueDate);
            Controls.Add(TaskTitleLabel);
            Name = "DeleteTaskForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TaskTitleLabel;
        private Label TaskDueDate;
        private Button DeleteTaskButton;
        private Button CancelDeleteButton;
    }
}