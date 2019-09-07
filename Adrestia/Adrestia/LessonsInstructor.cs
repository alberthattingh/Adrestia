using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adrestia
{
    public partial class LessonsInstructor : UserControl
    {

        public string UserID;

        //Database:
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marné\Documents\NWU\CMPG 223\Assignment\GitHub\Adrestia\Adrestia\Adrestia\Database2.mdf;Integrated Security=True";
        //Public Variables
        public DateTime lessonDate;
        public DateTime lessonTime;
        public double lessonPrice;
        public string lessonDescription;
        public int lessonStudents;
 
        //Value for the InstructorID
        public int instID = 1000;
        
        public LessonsInstructor()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Variables:
            lessonDescription = "";
            lessonPrice = 0.00;
            lessonDate = DateTime.Today;
            lessonTime = DateTime.Now;
            lessonStudents = 0;
            //Butttons
            btnPreview.Enabled = true;
            //Objects
            lbFinal.Items.Clear();
            monthCalendar1.ShowToday = true;
            cbxPrice.Text = "";
            cbxTime.Text = "";
            tbDescription.Text = "";
            nudStudents.Value = 0;

        }

        private void BtnAddLesson_Click(object sender, EventArgs e)
        {
            //Query:
            string query = @"INSERT INTO LESSON VALUES(@LessonDate, @LessonTime, @Price, @Description, @MaxNoOfStudents, @InstructorID)";
            //INSERT INTO DATABASE
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@LessonDate", lessonDate.ToShortDateString());
            comm.Parameters.AddWithValue("@LessonTime", lessonTime.ToShortTimeString());
            comm.Parameters.AddWithValue("@Price", lessonPrice);
            comm.Parameters.AddWithValue("@Description", lessonDescription);
            comm.Parameters.AddWithValue("@MaxNoOfStudents", lessonStudents);
            comm.Parameters.AddWithValue("@InstructorID", instID);
            comm.ExecuteNonQuery();


        }

        private void CbxTime_TextUpdate(object sender, EventArgs e)
        {
            if (cbxTime.SelectedIndex == -1)
            {
                MessageBox.Show("No Time Has Been Selected!");
            }
            else
            {
                string sTime = cbxTime.GetItemText(cbxTime.SelectedItem);
                lessonTime = Convert.ToDateTime(sTime);

                lbFinal.Items.Add("Time: \t\t" + sTime);
                
            }
        }

        private void CbxPrice_TextUpdate(object sender, EventArgs e)
        {
            if (cbxPrice.SelectedIndex == -1)
            {
                MessageBox.Show("No Time Has Been Selected!");
            }
            else
            {
                double price = Convert.ToDouble(cbxPrice.GetItemText(cbxPrice.SelectedItem));
                lessonPrice = price;
                lbFinal.Items.Add("Price: \t\tR" + price.ToString());
                
            }
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            //Select date:
            String sDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            lessonDate = Convert.ToDateTime(sDate);
            if (Convert.ToDateTime(sDate) < DateTime.Today)
            {
                MessageBox.Show("Can't Select Past Date!");
            }
            else
            {
                lbFinal.Items.Add("Date: \t\t" + sDate);
                
            }

            //Select Time:
            if (cbxTime.SelectedIndex == -1)
            {
                MessageBox.Show("No Time Has Been Selected!");
            }
            else
            {
                string sTime = cbxTime.GetItemText(cbxTime.SelectedItem);
                lessonTime = Convert.ToDateTime(sTime);

                lbFinal.Items.Add("Time: \t\t" + sTime);
                
            }

            //Select Price:
            if (cbxPrice.SelectedIndex == -1)
            {
                MessageBox.Show("No Time Has Been Selected!");
            }
            else
            {
                double price = Convert.ToDouble(cbxPrice.GetItemText(cbxPrice.SelectedItem));
                lessonPrice = price;
                lbFinal.Items.Add("Price: \t\tR" + price.ToString());
                
            }

            //Select Students
            int students = Convert.ToInt32(Math.Round(nudStudents.Value, 0));
            lessonStudents = students;
            lbFinal.Items.Add("Max Student: \t" + students.ToString());
            

            //Select Description
            string description = tbDescription.Text;
            lessonDescription = description;
            lbFinal.Items.Add("Description: \t" + description);
            
        }
    }
}
