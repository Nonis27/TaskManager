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
            components = new System.ComponentModel.Container();
            TaskList = new ListBox();
            addButton = new Button();
            textBox = new TextBox();
            label1 = new Label();
            detailsButton = new Button();
            NoItemSelectedError = new ErrorProvider(components);
            ErrorTimer = new System.Windows.Forms.Timer(components);
            monthCalendar1 = new MonthCalendar();
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
            TaskList.Size = new Size(351, 224);
            TaskList.TabIndex = 0;
            TaskList.ValueMember = "Key";
            // 
            // addButton
            // 
            addButton.Location = new Point(381, 68);
            addButton.Name = "addButton";
            addButton.Size = new Size(160, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Add Task";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(381, 35);
            textBox.Name = "textBox";
            textBox.Size = new Size(160, 27);
            textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Task Title";
            // 
            // detailsButton
            // 
            detailsButton.Location = new Point(12, 242);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(94, 29);
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
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthCalendar1.Location = new Point(662, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(942, 493);
            Controls.Add(monthCalendar1);
            Controls.Add(detailsButton);
            Controls.Add(label1);
            Controls.Add(textBox);
            Controls.Add(addButton);
            Controls.Add(TaskList);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)NoItemSelectedError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TaskList;
        private Button addButton;
        private TextBox textBox;
        private Label label1;
        private Button detailsButton;
        private ErrorProvider NoItemSelectedError;
        private System.Windows.Forms.Timer ErrorTimer;
        private MonthCalendar monthCalendar1;
    }
}
