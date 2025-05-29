namespace TaskManager
{
    partial class Form1
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
            TaskList = new ListBox();
            addButton = new Button();
            textBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // TaskList
            // 
            TaskList.FormattingEnabled = true;
            TaskList.Location = new Point(12, 12);
            TaskList.Name = "TaskList";
            TaskList.Size = new Size(332, 204);
            TaskList.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(364, 176);
            addButton.Name = "addButton";
            addButton.Size = new Size(160, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Add Task";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(364, 55);
            textBox.Name = "textBox";
            textBox.Size = new Size(160, 27);
            textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(942, 493);
            Controls.Add(label1);
            Controls.Add(textBox);
            Controls.Add(addButton);
            Controls.Add(TaskList);
            Name = "Form1";
            Text = "Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TaskList;
        private Button addButton;
        private TextBox textBox;
        private Label label1;
    }
}
