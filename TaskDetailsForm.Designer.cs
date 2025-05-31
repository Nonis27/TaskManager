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
            components = new System.ComponentModel.Container();
            TaskDetailsText = new TextBox();
            AddDetailsButton = new Button();
            TaskDetailsTextNullError = new ErrorProvider(components);
            NullTextErrorTimer = new System.Windows.Forms.Timer(components);
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TaskDetailsTextNullError).BeginInit();
            SuspendLayout();
            // 
            // TaskDetailsText
            // 
            TaskDetailsText.BackColor = SystemColors.AppWorkspace;
            TaskDetailsText.Location = new Point(12, 12);
            TaskDetailsText.Multiline = true;
            TaskDetailsText.Name = "TaskDetailsText";
            TaskDetailsText.Size = new Size(438, 209);
            TaskDetailsText.TabIndex = 0;
            // 
            // AddDetailsButton
            // 
            AddDetailsButton.Location = new Point(12, 227);
            AddDetailsButton.Name = "AddDetailsButton";
            AddDetailsButton.Size = new Size(100, 30);
            AddDetailsButton.TabIndex = 1;
            AddDetailsButton.Text = "Add Details";
            AddDetailsButton.UseVisualStyleBackColor = true;
            AddDetailsButton.Click += AddDetailsButton_Click;
            // 
            // TaskDetailsTextNullError
            // 
            TaskDetailsTextNullError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            TaskDetailsTextNullError.ContainerControl = this;
            // 
            // NullTextErrorTimer
            // 
            NullTextErrorTimer.Interval = 4000;
            NullTextErrorTimer.Tick += NullTextErrorTimer_Tick;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(350, 227);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 30);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += button1_Click;
            // 
            // TaskDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(462, 263);
            Controls.Add(ExitButton);
            Controls.Add(AddDetailsButton);
            Controls.Add(TaskDetailsText);
            Name = "TaskDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskDetails";
            ((System.ComponentModel.ISupportInitialize)TaskDetailsTextNullError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskDetailsText;
        private Button AddDetailsButton;
        private ErrorProvider TaskDetailsTextNullError;
        private System.Windows.Forms.Timer NullTextErrorTimer;
        private Button ExitButton;
    }
}