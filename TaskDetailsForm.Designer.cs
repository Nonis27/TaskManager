namespace TaskManager
{
    partial class TaskDetailsForm
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
            TaskDetailsText = new TextBox();
            SuspendLayout();
            // 
            // TaskDetailsText
            // 
            TaskDetailsText.BackColor = SystemColors.AppWorkspace;
            TaskDetailsText.Location = new Point(12, 12);
            TaskDetailsText.Multiline = true;
            TaskDetailsText.Name = "TaskDetailsText";
            TaskDetailsText.ReadOnly = true;
            TaskDetailsText.Size = new Size(438, 209);
            TaskDetailsText.TabIndex = 0;
            // 
            // TaskDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(462, 223);
            Controls.Add(TaskDetailsText);
            Name = "TaskDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskDetailsText;
    }
}