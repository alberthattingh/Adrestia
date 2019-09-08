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
        public string selectedVal;
 
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
            lessonStudents = 1;
            //Butttons
            btnPreview.Enabled = true;
            //Objects
            lbFinal.Items.Clear();
            monthCalendar1.ShowToday = true;
            cbxPrice.Text = "";
            cbxTime.Text = "";
            tbDescription.Text = "";
            nudStudents.Value = 1;

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
            //Exception handeling
            Boolean correct = true;

            //Select Description
            string description = tbDescription.Text;
            if (description == "")
            {
                MessageBox.Show("You did not fill in a description!");
                tbDescription.Focus();
                correct = false;
            }
            else
            {
                correct = true;
            }

            //Select date:
            String sDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            lessonDate = Convert.ToDateTime(sDate);
            if (Convert.ToDateTime(sDate) < DateTime.Today)
            {
                correct = false;
                MessageBox.Show("Can't Select Past Date!");
            }

            //Select Time:
            if (cbxTime.SelectedIndex == -1)
            {
                MessageBox.Show("No Time Has Been Selected!");
                cbxTime.Focus();
            }


            //Select Price:
            if (cbxPrice.SelectedIndex == -1)
            {
                MessageBox.Show("No Price Has Been Selected!");
                cbxPrice.Focus();
            }


            //Exception handeling
            if(correct == true)
            {
                
                //Clear list box
                lbFinal.Items.Clear();
                //Date
                lbFinal.Items.Add("Date: \t\t\t" + sDate);
                //Time
                string sTime = cbxTime.GetItemText(cbxTime.SelectedItem);
                lessonTime = Convert.ToDateTime(sTime);
                lbFinal.Items.Add("Time: \t\t\t" + sTime);
                //Descriprion::
                lbFinal.Items.Add("Description: \t\t" + description); 
                //Price:
                double price = Convert.ToDouble(cbxPrice.GetItemText(cbxPrice.SelectedItem));
                lessonPrice = price;
                lbFinal.Items.Add("Price: \t\t\tR" + price.ToString());
                //Select Students
                int students = Convert.ToInt32(Math.Round(nudStudents.Value, 0));
                lessonStudents = students;
                lbFinal.Items.Add("Max Student: \t\t" + students.ToString());
                
            }
            
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


            //Display Data
            string LoadQuery = @"SELECT * FROM LESSON";

            SqlCommand comShow = new SqlCommand(LoadQuery, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = comShow;
            adap.Fill(ds, "LESSON");

            dgvLessons.DataSource = ds;
            dgvLessons.DataMember = "LESSON";
            conn.Close();


        }

        private void LessonsInstructor_Load(object sender, EventArgs e)
        {
            string LoadQuery = @"SELECT * FROM LESSON";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand com = new SqlCommand(LoadQuery, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            adap.Fill(ds, "LESSON");

            dgvLessons.DataSource = ds;
            dgvLessons.DataMember = "LESSON";
            conn.Close();
        }

        private void DgvLessons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLessons.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvLessons.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvLessons.Rows[selectedrowindex];
                selectedVal = Convert.ToString(selectedRow.Cells["LessonID"].Value);
                lbltest.Text = selectedVal;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            //Delete
            try
            {
                string deleteQuery = "DELETE FROM LESSON WHERE LessonID = '" + selectedVal + "'";
                
                conn.Open();
                SqlCommand cmn = new SqlCommand(deleteQuery, conn);
                cmn.ExecuteNonQuery();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //Show updated data:
            string LoadQuery = @"SELECT * FROM LESSON";

           

            SqlCommand com = new SqlCommand(LoadQuery, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            adap.Fill(ds, "LESSON");

            dgvLessons.DataSource = ds;
            dgvLessons.DataMember = "LESSON";
            conn.Close();
        }
    }
}
