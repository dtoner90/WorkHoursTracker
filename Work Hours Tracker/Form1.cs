using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Work_Hours_Tracker
{
    public partial class Form1 : Form
    {
        float currOvertimeRate = 0f;
        float overHours = 0f;
        float normHours = 0f;
        float overtimeAdded = 0f;
        string path = @"data.csv";

        private void overRateCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(overRateCombo.SelectedItem.ToString())
            {
                case "x1.5":
                    currOvertimeRate = 1.5f;
                    break;
                case "x2":
                    currOvertimeRate = 2.0f;
                    break;
            }
        }

        private void calcEarnings()
        {
            float sum = 0f;

            if (hoursTextBox.Text == "" || hoursTextBox.Text == "0") // if we're calculating only overtime
            {
                // get rate of pay based on current rate of pay * overtime rate
                overtimeAdded = currOvertimeRate * Convert.ToSingle(rateOfPayTextBox.Text);

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    // get sum of overtime hour cells
                    overHours += Convert.ToSingle(dataGridView1.Rows[i].Cells[2].Value);
                }
                sum += overtimeAdded * overHours;
                currEarningsTextBox.Text = sum.ToString();

                //reset hours
                overHours = 0;
            }

            else // if calculating both normal + overtime
            {
                // get rate of pay based on current rate of pay * overtime rate
                overtimeAdded = currOvertimeRate * Convert.ToSingle(rateOfPayTextBox.Text);

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    // get sum of all normal & overtime hours
                    overHours += Convert.ToSingle(dataGridView1.Rows[i].Cells[2].Value);
                    normHours += Convert.ToSingle(dataGridView1.Rows[i].Cells[1].Value);
                }
                
                // Get sum of all hours and multiply by rates accordingly
                sum += Convert.ToSingle(rateOfPayTextBox.Text) * normHours  + overtimeAdded * overHours;
                currEarningsTextBox.Text = sum.ToString();

                // reset hours 
                overHours = 0;
                normHours = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            overRateCombo.SelectedIndex = 0;
            if (File.Exists(path)) // if our data file exists
            {
                Funcs.ImportFile(dataGridView1, path);
            }
            calcEarnings();
        }

        private void submitHoursButton_Click(object sender, EventArgs e)
        {
            if (hoursTextBox.Text == "") // if we're calculating overtime only
            {
                if (overtimeTextBox.Text == "" || overtimeTextBox.Text == "0") // if empty or is 0
                {
                    MessageBox.Show("Enter hours.", "Work Hours Tracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    // add our overtime hours
                    dataGridView1.Rows.Add(new Object[] { monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Month.ToString() + "/"
                        + monthCalendar1.SelectionStart.Year.ToString(), "0", overtimeTextBox.Text });
                    //then calculate our earnings
                    calcEarnings();
                }
            }
            else
            {
                if (hoursTextBox.Text == "0") // if we have 0 normal hours & 0 overtime
                {
                    MessageBox.Show("Enter hours.", "Work Hours Tracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else 
                {
                    // add our normal hours
                    dataGridView1.Rows.Add(new Object[] { monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Month.ToString() + "/"
                    + monthCalendar1.SelectionStart.Year.ToString(), hoursTextBox.Text, overtimeTextBox.Text });
                    // then calculate our earnings
                    calcEarnings();
                }
            }
        }

        private void removeSelectionButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                }
            }

            calcEarnings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sb = new StringBuilder();
            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            File.WriteAllText(path, sb.ToString());
        }

        private void newMonth_Click(object sender, EventArgs e)
        {
            // Rename our file to the name of the previous month
            if (!File.Exists(DateTime.Now.AddMonths(-1).ToString("MMMM") + ".csv"))
            {
                File.Move(path, DateTime.Now.AddMonths(-1).ToString("MMMM") + ".csv");

                dataGridView1.Rows.Clear();
            }
        }
    }
} 
