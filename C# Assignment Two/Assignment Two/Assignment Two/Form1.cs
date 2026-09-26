using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            // String values
            string studentName = txtname.Text;
            string department = txtdepartment.Text;

            // Convert String to int
            int studentID = int.Parse(txtstudentid.Text);
            int semester = int.Parse(txtsemester.Text);

            // Explicit conversion examples
            decimal moneyNumber = 4500m;
            int wholeNumber;

            wholeNumber = (int)moneyNumber;

            double realNumber;
            decimal anotherMoneyNumber = 625.70m;

            realNumber = (double)anotherMoneyNumber;

            // Output
            lbloutput.Text =
                "Student Name: " + studentName + "\r\n" +
                "Student ID: " + studentID + "\r\n" +
                "Department: " + department + "\r\n" +
                "Semester: " + semester + "\r\n\r\n" +
                "Money Number: " + moneyNumber + "\r\n" +
                "Whole Number after cast: " + wholeNumber + "\r\n" +
                "Decimal Number: " + anotherMoneyNumber + "\r\n" +
                "Double Number after cast: " + realNumber;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
