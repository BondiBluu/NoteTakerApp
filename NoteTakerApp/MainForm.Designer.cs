namespace NoteTakerApp
{
    partial class MainForm
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
            taskTextBox1 = new TextBox();
            taskLabel = new Label();
            descriptionLabel = new Label();
            descTextBox1 = new TextBox();
            timeComboBox = new ComboBox();
            publishButton = new Button();
            toDoDataGridView = new DataGridView();
            doneDataGridView = new DataGridView();
            toDoLabel = new Label();
            doneLabel = new Label();
            urgencyCheckBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)toDoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doneDataGridView).BeginInit();
            SuspendLayout();
            // 
            // taskTextBox1
            // 
            taskTextBox1.Location = new Point(23, 59);
            taskTextBox1.Name = "taskTextBox1";
            taskTextBox1.Size = new Size(188, 31);
            taskTextBox1.TabIndex = 0;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(18, 21);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(45, 25);
            taskLabel.TabIndex = 1;
            taskLabel.Text = "Task";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(17, 107);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description";
            // 
            // descTextBox1
            // 
            descTextBox1.Location = new Point(22, 145);
            descTextBox1.Multiline = true;
            descTextBox1.Name = "descTextBox1";
            descTextBox1.Size = new Size(289, 71);
            descTextBox1.TabIndex = 2;
            // 
            // timeComboBox
            // 
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Items.AddRange(new object[] { "Morning", "Midday", "Afternoon", "Evening", "Night" });
            timeComboBox.Location = new Point(29, 245);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(182, 33);
            timeComboBox.TabIndex = 4;
            timeComboBox.Text = "Time of Day";
            // 
            // publishButton
            // 
            publishButton.Location = new Point(29, 391);
            publishButton.Name = "publishButton";
            publishButton.Size = new Size(159, 42);
            publishButton.TabIndex = 6;
            publishButton.Text = "Publish";
            publishButton.UseVisualStyleBackColor = true;
            // 
            // toDoDataGridView
            // 
            toDoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoDataGridView.Location = new Point(432, 59);
            toDoDataGridView.Name = "toDoDataGridView";
            toDoDataGridView.RowHeadersWidth = 62;
            toDoDataGridView.Size = new Size(723, 143);
            toDoDataGridView.TabIndex = 7;
            // 
            // doneDataGridView
            // 
            doneDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doneDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doneDataGridView.Location = new Point(432, 290);
            doneDataGridView.Name = "doneDataGridView";
            doneDataGridView.RowHeadersWidth = 62;
            doneDataGridView.Size = new Size(723, 143);
            doneDataGridView.TabIndex = 8;
            // 
            // toDoLabel
            // 
            toDoLabel.AutoSize = true;
            toDoLabel.Location = new Point(432, 21);
            toDoLabel.Name = "toDoLabel";
            toDoLabel.Size = new Size(121, 25);
            toDoLabel.TabIndex = 9;
            toDoLabel.Text = "To Be Done: 0";
            // 
            // doneLabel
            // 
            doneLabel.AutoSize = true;
            doneLabel.Location = new Point(432, 245);
            doneLabel.Name = "doneLabel";
            doneLabel.Size = new Size(142, 25);
            doneLabel.TabIndex = 10;
            doneLabel.Text = "Tasks Finished: 0";
            // 
            // urgencyCheckBox1
            // 
            urgencyCheckBox1.AutoSize = true;
            urgencyCheckBox1.Location = new Point(29, 306);
            urgencyCheckBox1.Name = "urgencyCheckBox1";
            urgencyCheckBox1.Size = new Size(92, 29);
            urgencyCheckBox1.TabIndex = 11;
            urgencyCheckBox1.Text = "Urgent";
            urgencyCheckBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 445);
            Controls.Add(urgencyCheckBox1);
            Controls.Add(doneLabel);
            Controls.Add(toDoLabel);
            Controls.Add(doneDataGridView);
            Controls.Add(toDoDataGridView);
            Controls.Add(publishButton);
            Controls.Add(timeComboBox);
            Controls.Add(descriptionLabel);
            Controls.Add(descTextBox1);
            Controls.Add(taskLabel);
            Controls.Add(taskTextBox1);
            Name = "MainForm";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)doneDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox taskTextBox1;
        private Label taskLabel;
        private Label descriptionLabel;
        private TextBox descTextBox1;
        private ComboBox timeComboBox;
        private Button publishButton;
        private DataGridView toDoDataGridView;
        private DataGridView doneDataGridView;
        private Label toDoLabel;
        private Label doneLabel;
        private CheckBox urgencyCheckBox1;
    }
}
