namespace Work_Hours_Tracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currEarnings = new System.Windows.Forms.Label();
            this.rateOfPayLabel = new System.Windows.Forms.Label();
            this.currEarningsTextBox = new System.Windows.Forms.TextBox();
            this.rateOfPayTextBox = new System.Windows.Forms.TextBox();
            this.submitHoursButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.overtimeLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.overtimeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overRateCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeSelectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // currEarnings
            // 
            this.currEarnings.AutoSize = true;
            this.currEarnings.Location = new System.Drawing.Point(138, 516);
            this.currEarnings.Name = "currEarnings";
            this.currEarnings.Size = new System.Drawing.Size(87, 13);
            this.currEarnings.TabIndex = 5;
            this.currEarnings.Text = "Current earnings:";
            // 
            // rateOfPayLabel
            // 
            this.rateOfPayLabel.AutoSize = true;
            this.rateOfPayLabel.Location = new System.Drawing.Point(29, 516);
            this.rateOfPayLabel.Name = "rateOfPayLabel";
            this.rateOfPayLabel.Size = new System.Drawing.Size(65, 13);
            this.rateOfPayLabel.TabIndex = 5;
            this.rateOfPayLabel.Text = "Rate(per H):";
            // 
            // currEarningsTextBox
            // 
            this.currEarningsTextBox.Location = new System.Drawing.Point(141, 532);
            this.currEarningsTextBox.Name = "currEarningsTextBox";
            this.currEarningsTextBox.ReadOnly = true;
            this.currEarningsTextBox.Size = new System.Drawing.Size(100, 20);
            this.currEarningsTextBox.TabIndex = 4;
            // 
            // rateOfPayTextBox
            // 
            this.rateOfPayTextBox.Location = new System.Drawing.Point(32, 532);
            this.rateOfPayTextBox.Name = "rateOfPayTextBox";
            this.rateOfPayTextBox.Size = new System.Drawing.Size(68, 20);
            this.rateOfPayTextBox.TabIndex = 5;
            this.rateOfPayTextBox.Text = "8";
            // 
            // submitHoursButton
            // 
            this.submitHoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitHoursButton.Location = new System.Drawing.Point(164, 244);
            this.submitHoursButton.Name = "submitHoursButton";
            this.submitHoursButton.Size = new System.Drawing.Size(75, 24);
            this.submitHoursButton.TabIndex = 3;
            this.submitHoursButton.Text = "Submit";
            this.submitHoursButton.UseVisualStyleBackColor = true;
            this.submitHoursButton.Click += new System.EventHandler(this.submitHoursButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 9);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.TabStop = false;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(9, 180);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "Hours:";
            // 
            // overtimeLabel
            // 
            this.overtimeLabel.AutoSize = true;
            this.overtimeLabel.Location = new System.Drawing.Point(9, 222);
            this.overtimeLabel.Name = "overtimeLabel";
            this.overtimeLabel.Size = new System.Drawing.Size(81, 13);
            this.overtimeLabel.TabIndex = 3;
            this.overtimeLabel.Text = "Overtime hours:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(12, 198);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(55, 20);
            this.hoursTextBox.TabIndex = 1;
            this.hoursTextBox.Text = "1";
            // 
            // overtimeTextBox
            // 
            this.overtimeTextBox.Location = new System.Drawing.Point(12, 238);
            this.overtimeTextBox.Name = "overtimeTextBox";
            this.overtimeTextBox.Size = new System.Drawing.Size(55, 20);
            this.overtimeTextBox.TabIndex = 2;
            this.overtimeTextBox.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Hours,
            this.Overtime});
            this.dataGridView1.Location = new System.Drawing.Point(32, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(183, 209);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabStop = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 70;
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            this.Hours.Width = 50;
            // 
            // Overtime
            // 
            this.Overtime.HeaderText = "Overtime";
            this.Overtime.Name = "Overtime";
            this.Overtime.ReadOnly = true;
            this.Overtime.Width = 60;
            // 
            // overRateCombo
            // 
            this.overRateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overRateCombo.FormattingEnabled = true;
            this.overRateCombo.Items.AddRange(new object[] {
            "x1.5",
            "x2"});
            this.overRateCombo.Location = new System.Drawing.Point(189, 198);
            this.overRateCombo.Name = "overRateCombo";
            this.overRateCombo.Size = new System.Drawing.Size(50, 21);
            this.overRateCombo.TabIndex = 12;
            this.overRateCombo.SelectedValueChanged += new System.EventHandler(this.overRateCombo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Overtime rate:";
            // 
            // removeSelectionButton
            // 
            this.removeSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectionButton.Location = new System.Drawing.Point(164, 489);
            this.removeSelectionButton.Name = "removeSelectionButton";
            this.removeSelectionButton.Size = new System.Drawing.Size(75, 24);
            this.removeSelectionButton.TabIndex = 6;
            this.removeSelectionButton.Text = "Remove";
            this.removeSelectionButton.UseVisualStyleBackColor = true;
            this.removeSelectionButton.Click += new System.EventHandler(this.removeSelectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(251, 563);
            this.Controls.Add(this.removeSelectionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.overRateCombo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.submitHoursButton);
            this.Controls.Add(this.rateOfPayTextBox);
            this.Controls.Add(this.currEarningsTextBox);
            this.Controls.Add(this.overtimeTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.rateOfPayLabel);
            this.Controls.Add(this.currEarnings);
            this.Controls.Add(this.overtimeLabel);
            this.Controls.Add(this.hoursLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Hours Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currEarnings;
        private System.Windows.Forms.Label rateOfPayLabel;
        private System.Windows.Forms.TextBox currEarningsTextBox;
        private System.Windows.Forms.TextBox rateOfPayTextBox;
        private System.Windows.Forms.Button submitHoursButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label overtimeLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox overtimeTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox overRateCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeSelectionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overtime;
    }
}

