using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Assignment_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dayOfWeekTextBox.Visible = true;
            monthTextBox.Visible = true;
            dayOfMonthTextBox.Visible = true;
            yearTextBox.Visible = true;
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            string year = yearTextBox.Text;

            dateOutputLabel.Text = dayOfWeek + ", " +
                                   month + " " +
                                   dayOfMonth + ", " +
                                   year;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();

            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
