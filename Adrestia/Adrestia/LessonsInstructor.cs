using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrestia
{
    public partial class LessonsInstructor : UserControl
    {
        public string lessonDate;
        public string lessonTime;
        public string lessonPrice;
        public string lessonDescription;
        public int lessonStudents;
        public int lessonInstructor;
        
        public LessonsInstructor()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDate_Click(object sender, EventArgs e)
        {
            String sDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            lessonDate = sDate;
            if (Convert.ToDateTime(sDate) < DateTime.Today )
            {
                MessageBox.Show("Can't Select Past Date!");
            }
            else
            {
                lbFinal.Items.Add("Date: \t\t" + sDate);
                btnDate.Enabled = false;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LessonsInstructor_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnTime_Click(object sender, EventArgs e)
        {
            if (cbxTime.SelectedIndex == -1)
            {
                MessageBox.Show("No Time Has Been Selected!");
            }
            else
            {
                string sTime = cbxTime.GetItemText(cbxTime.SelectedItem);
                lessonTime = sTime;
                lbFinal.Items.Add("Time: \t\t" + sTime);
                btnTime.Enabled = false;
            }
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            if(cbxPrice.SelectedIndex == -1)
            {
                MessageBox.Show("No Time Has Been Selected!");
            }
            else
            {
                double price = Convert.ToDouble(cbxPrice.GetItemText(cbxPrice.SelectedItem));
                lessonPrice = price.ToString();
                lbFinal.Items.Add("Price: \t\tR" + price.ToString());
                btnPrice.Enabled = false;
            }
        }

        private void CbxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int students = Convert.ToInt32(Math.Round(nudStudents.Value, 0));
            lessonStudents = students;
            lbFinal.Items.Add("Max Student: \t" + students.ToString());
            btnStudents.Enabled = false;
        }

        private void BtnDescription_Click(object sender, EventArgs e)
        {
            string description = tbDescription.Text;
            lessonDescription = description;
            lbFinal.Items.Add("Description: \t" + description);
            btnDescription.Enabled = false;
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lessonDescription = "";
            lessonInstructor = 0;
            lessonPrice = "";
            lessonDate = "";
            lessonTime = "";
            lessonStudents = 0;

            btnDate.Enabled = true;
            btnTime.Enabled = true;
            btnStudents.Enabled = true;
            btnPrice.Enabled = true;
            btnDescription.Enabled = true;
            btnInsID.Enabled = true;

            lbFinal.Items.Clear();
        }
    }
}
