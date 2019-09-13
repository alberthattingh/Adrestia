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
        string conString = Security.ConnectionString;
        //Public Variables
        public DateTime lessonDate;
        public DateTime lessonTime;
        public double lessonPrice;
        public string lessonDescription;
        public int lessonStudents;
        public string selectedLesson;
 
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
            btnAddLesson.Enabled = false; 
            //Objects
            lbFinal.Items.Clear();
            monthCalendar1.ShowToday = true;
            cbxPrice.Text = "";
            cbxTime.Text = "";
            tbDescription.Text = "";
            nudStudents.Value = 1;

        }

        private void BtnAddLesson_Click(object sender, EventArgs e)
        {
            //Query:
            string query = @"INSERT INTO LESSON VALUES(@LessonDate, @LessonTime, @Price, @Description, @MaxNoOfStudents, @InstructorID)";
            //INSERT INTO DATABASE
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@LessonDate", lessonDate);
            comm.Parameters.AddWithValue("@LessonTime", lessonTime);
            comm.Parameters.AddWithValue("@Price", lessonPrice);
            comm.Parameters.AddWithValue("@Description", lessonDescription);
            comm.Parameters.AddWithValue("@MaxNoOfStudents", lessonStudents);
            comm.Parameters.AddWithValue("@InstructorID", instID);
            comm.ExecuteNonQuery();

            //UPDATE DATA IN DATA GRID VIEW
            //Data load into data grid view:
            string loadQuery = @"SELECT * FROM LESSON";

            SqlCommand com = new SqlCommand(loadQuery, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            adap.Fill(ds, "LESSON");

            dgvLessons.DataSource = ds;
            dgvLessons.DataMember = "LESSON";
            conn.Close();
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
                lessonDescription = description;
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
                btnAddLesson.Enabled = true;
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

        private void LessonsInstructor_Load(object sender, EventArgs e)
        {
            btnAddLesson.Enabled = false;
            btnDeleteLesson.Enabled = false;
            btnEditLesson.Enabled = false;
            //Data load into data grid view:
            string loadQuery = @"SELECT * FROM LESSON";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand com = new SqlCommand(loadQuery, conn);
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

               selectedLesson = Convert.ToString(selectedRow.Cells["LessonId"].Value);
               lblSelected.Text = "Selected Lesson: " + selectedLesson;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDeleteLesson_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM LESSON WHERE LessonId = '" + selectedLesson + "'";
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmn = new SqlCommand(deleteQuery, conn);
                cmn.ExecuteNonQuery();
                conn.Close();

                //UPDATE DATA IN DATA GRID VIEW
                //Data load into data grid view:
                string loadQuery = @"SELECT * FROM LESSON";

                SqlCommand com = new SqlCommand(loadQuery, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.SelectCommand = com;
                adap.Fill(ds, "LESSON");

                dgvLessons.DataSource = ds;
                dgvLessons.DataMember = "LESSON";
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void RdpDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnDeleteLesson.Enabled = true;
            btnEditLesson.Enabled = false;
        }

        private void RdpEdit_CheckedChanged(object sender, EventArgs e)
        {
            btnEditLesson.Enabled = true;
            btnDeleteLesson.Enabled = false;
            //Clear everything
            //Variables:
            lessonDescription = "";
            lessonPrice = 0.00;
            lessonDate = DateTime.Today;
            lessonTime = DateTime.Now;
            lessonStudents = 1;
            //Butttons
            btnPreview.Enabled = true;
            btnAddLesson.Enabled = false;
            cbxPrice.DropDownStyle = ComboBoxStyle.DropDown;
            cbxTime.DropDownStyle = ComboBoxStyle.DropDown;
            //Objects
            lbFinal.Items.Clear();
            monthCalendar1.ShowToday = true;
            cbxPrice.Text = "";
            cbxTime.Text = "";
            tbDescription.Text = "";
            nudStudents.Value = 1;

            //Read data into controls
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            try
            {
                SqlDataReader reader;
                string sqlQuery, output = "";

                sqlQuery = "SELECT * From LESSON";
                SqlCommand cmn = new SqlCommand(sqlQuery, conn);
                reader = cmn.ExecuteReader();

                while (reader.Read())
                {
                    tbDescription.Text = reader.GetValue(4).ToString();
                    cbxPrice.Text = reader.GetValue(3).ToString();
                    cbxTime.Text = reader.GetValue(2).ToString();
                    nudStudents.Value = Convert.ToInt32(reader.GetValue(5));

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnEditLesson_Click(object sender, EventArgs e)
        {
           /* //Exception handeling
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
                lessonDescription = description;
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
            if (correct == true)
            {

            }**/
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
