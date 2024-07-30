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
            urgentRadioButton = new RadioButton();
            publishButton = new Button();
            dataGridView1 = new DataGridView();
            taskColumn1 = new DataGridViewTextBoxColumn();
            descColumn = new DataGridViewTextBoxColumn();
            timeColumn = new DataGridViewTextBoxColumn();
            urgentColumn = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // taskTextBox1
            // 
            taskTextBox1.Location = new Point(23, 76);
            taskTextBox1.Name = "taskTextBox1";
            taskTextBox1.Size = new Size(188, 31);
            taskTextBox1.TabIndex = 0;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(18, 38);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(45, 25);
            taskLabel.TabIndex = 1;
            taskLabel.Text = "Task";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(17, 125);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description";
            // 
            // descTextBox1
            // 
            descTextBox1.Location = new Point(22, 163);
            descTextBox1.Multiline = true;
            descTextBox1.Name = "descTextBox1";
            descTextBox1.Size = new Size(289, 91);
            descTextBox1.TabIndex = 2;
            // 
            // timeComboBox
            // 
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Items.AddRange(new object[] { "Morning", "Midday", "Afternoon", "Evening", "Night" });
            timeComboBox.Location = new Point(23, 273);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(182, 33);
            timeComboBox.TabIndex = 4;
            timeComboBox.Text = "Time of Day";
            // 
            // urgentRadioButton
            // 
            urgentRadioButton.AutoSize = true;
            urgentRadioButton.Location = new Point(22, 325);
            urgentRadioButton.Name = "urgentRadioButton";
            urgentRadioButton.Size = new Size(91, 29);
            urgentRadioButton.TabIndex = 5;
            urgentRadioButton.TabStop = true;
            urgentRadioButton.Text = "Urgent";
            urgentRadioButton.UseVisualStyleBackColor = true;
            // 
            // publishButton
            // 
            publishButton.Location = new Point(17, 391);
            publishButton.Name = "publishButton";
            publishButton.Size = new Size(159, 42);
            publishButton.TabIndex = 6;
            publishButton.Text = "Publish";
            publishButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { taskColumn1, descColumn, timeColumn, urgentColumn });
            dataGridView1.Location = new Point(432, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(723, 143);
            dataGridView1.TabIndex = 7;
            // 
            // taskColumn1
            // 
            taskColumn1.HeaderText = "Task";
            taskColumn1.MinimumWidth = 8;
            taskColumn1.Name = "taskColumn1";
            taskColumn1.ReadOnly = true;
            taskColumn1.Width = 150;
            // 
            // descColumn
            // 
            descColumn.HeaderText = "Description";
            descColumn.MinimumWidth = 8;
            descColumn.Name = "descColumn";
            descColumn.ReadOnly = true;
            descColumn.Width = 150;
            // 
            // timeColumn
            // 
            timeColumn.HeaderText = "Time";
            timeColumn.MinimumWidth = 8;
            timeColumn.Name = "timeColumn";
            timeColumn.ReadOnly = true;
            timeColumn.Width = 150;
            // 
            // urgentColumn
            // 
            urgentColumn.HeaderText = "Urgent";
            urgentColumn.MinimumWidth = 8;
            urgentColumn.Name = "urgentColumn";
            urgentColumn.ReadOnly = true;
            urgentColumn.Width = 150;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(432, 290);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(723, 143);
            dataGridView2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Task";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Time";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Urgent";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 445);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(publishButton);
            Controls.Add(urgentRadioButton);
            Controls.Add(timeComboBox);
            Controls.Add(descriptionLabel);
            Controls.Add(descTextBox1);
            Controls.Add(taskLabel);
            Controls.Add(taskTextBox1);
            Name = "MainForm";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox taskTextBox1;
        private Label taskLabel;
        private Label descriptionLabel;
        private TextBox descTextBox1;
        private ComboBox timeComboBox;
        private RadioButton urgentRadioButton;
        private Button publishButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn taskColumn1;
        private DataGridViewTextBoxColumn descColumn;
        private DataGridViewTextBoxColumn timeColumn;
        private DataGridViewTextBoxColumn urgentColumn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
