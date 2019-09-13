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
    public partial class StudentLessons : UserControl
    {
        //Var
        public string selectedLesson;
        public string selectedDescription;
        public string selectedDate;
        public string selectedTime;
        public string selectedAvailable;
        public string selectedMax;
        public string selectedInstructor;
        public string selectedPrice;
        public int studentID;
        public string removeID;

        public int userID;

        //Database:
        string conString = Security.ConnectionString;
            //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marné\Documents\NWU\CMPG 223\Assignment\Adrestia\Adrestia\Adrestia\LessonTest.mdf;Integrated Security=True";

        public StudentLessons()
        {
            InitializeComponent();
        }

        private void StudentLessons_Load(object sender, EventArgs e)
        {
            //Data load into data grid view:
            string loadQuery = @"SELECT * FROM LESSON ORDER BY LessonDate ASC";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand com = new SqlCommand(loadQuery, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            adap.Fill(ds, "LESSON");

            dgvStudentLessons.DataSource = ds;
            dgvStudentLessons.DataMember = "LESSON";
            conn.Close();

            
        }

        private void DgvStudentLessons_SelectionChanged(object sender, EventArgs e)
        {
            lbLessonSum.Items.Clear();
            if (dgvStudentLessons.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvStudentLessons.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvStudentLessons.Rows[selectedrowindex];

                selectedLesson = Convert.ToString(selectedRow.Cells["LessonId"].Value);
                selectedDate = Convert.ToString(selectedRow.Cells["LessonDate"].Value);
                selectedTime = Convert.ToString(selectedRow.Cells["LessonTime"].Value);
                selectedPrice = Convert.ToString(selectedRow.Cells["Price"].Value);
                selectedDescription = Convert.ToString(selectedRow.Cells["Description"].Value);
                selectedMax = Convert.ToString(selectedRow.Cells["MaxNoOfStudents"].Value);
                selectedInstructor = Convert.ToString(selectedRow.Cells["InstructorID"].Value);
                lbLessonSum.Items.Add("Selected Lesson: \t\t" + selectedLesson);
                lbLessonSum.Items.Add("Lesson Date: \t\t" + selectedDate);
                lbLessonSum.Items.Add("Lesson Time:: \t\t" + selectedTime);
                lbLessonSum.Items.Add("Price: \t\t\tR" + selectedPrice);
                lbLessonSum.Items.Add("Description: \t\t" + selectedDescription);
                lbLessonSum.Items.Add("Available Spaces: \t\t" + selectedMax);
                lbLessonSum.Items.Add("Instructor ID: \t\t" + selectedInstructor);
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            btnEvents form3 = new btnEvents();
            studentID = int.Parse(form3.UserID);

            int places = int.Parse(selectedMax);
            double price = double.Parse(selectedPrice);
            string credits = "";
            double Avecredits = 0.00;
            

            //Get value of students available credits:
            try
            {
                
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlDataReader reader;
                string sqlQuery =  "";
                

                sqlQuery = "SELECT * From STUDENT WHERE StudentID = '" + userID + "'";
                SqlCommand cmn = new SqlCommand(sqlQuery, conn);
                reader = cmn.ExecuteReader();

                while (reader.Read())
                {
                    credits = reader.GetValue(5).ToString();
                }
                conn.Close();
            }
            catch (SqlException err)
             {
             MessageBox.Show(err.Message);
             }
            Avecredits = Convert.ToDouble(credits);
            //Book Lesson
            if (places > 0 && Avecredits >= price)
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                string sql;


                string stm = "SELECT COUNT(*) FROM LESSON_STUDENT WHERE LessonID = '" + selectedLesson + "' AND StudentID = '" + userID + "'";
                SqlCommand comm = new SqlCommand(stm, conn);
                Int32 count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("You Allready booked for this lesson");
                }
                else
                {
                    sql = "INSERT INTO LESSON_STUDENT VALUES (@LessonID, @StudentID)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@LessonID", selectedLesson);
                    command.Parameters.AddWithValue("@StudentID", userID);
                    command.ExecuteNonQuery();
                    int newAvailable = places - 1;
                    string sqlQuery = "UPDATE LESSON SET MaxNoOfStudents  = '" + newAvailable + "' WHERE LessonID = '" + selectedLesson + "'";
                    SqlCommand cmn = new SqlCommand(sqlQuery, conn);
                    cmn.ExecuteNonQuery();

                    double finalcredits = Avecredits - price;
                    sqlQuery = "UPDATE STUDENT SET Credits  = '" + finalcredits + "' WHERE StudentID = '" + userID + "'";
                    SqlCommand cmn2 = new SqlCommand(sqlQuery, conn);
                    cmn2.ExecuteNonQuery();

                    //Data load into data grid view:
                    string loadQuery = @"SELECT * FROM LESSON";

                    SqlCommand com = new SqlCommand(loadQuery, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adap = new SqlDataAdapter();
                    adap.SelectCommand = com;
                    adap.Fill(ds, "LESSON");

                    dgvStudentLessons.DataSource = ds;
                    dgvStudentLessons.DataMember = "LESSON";
                    conn.Close();
                    MessageBox.Show("Lesson succesfully booked");
                }
            }
            else if (Avecredits < price)
            {
                MessageBox.Show("You dont have enough credits");
            }
            else
            {
                MessageBox.Show("There are no available spaces in this class");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnShowBooked_Click(object sender, EventArgs e)
        {
            lbBookedLessons.Items.Add("ID\t" + "DATE\t\t\t" + "TIME\t\t" + "DESCRIPTION\t" + "INSTRUCTOR\t");
            ///Load Booked lessons.
            try
            {
                //VAR
                int LessonID;
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                SqlDataReader reader;
                string sqlQuery, output, sqlQuery2 = "";

                sqlQuery = "SELECT * From LESSON_STUDENT WHERE StudentID = " + userID;
                SqlCommand cmn = new SqlCommand(sqlQuery, conn);
                reader = cmn.ExecuteReader();
                int getLessonID;
                while (reader.Read())
                {

                    getLessonID = (int)reader.GetValue(0);

                    SqlDataReader sqlReader2;
                    sqlQuery2 = "SELECT * FROM LESSON WHERE LessonID =" + getLessonID;
                    SqlCommand cmn2 = new SqlCommand(sqlQuery2, conn);
                    cmn2 = new SqlCommand(sqlQuery2, conn);
                    sqlReader2 = cmn2.ExecuteReader();

                    while(sqlReader2.Read())
                    {
                        lbBookedLessons.Items.Add(sqlReader2.GetValue(0) + "\t" + sqlReader2.GetValue(1).ToString() + "\t" + sqlReader2.GetValue(2).ToString() + "\t\t" + sqlReader2.GetValue(4) + "\t" + sqlReader2.GetValue(6).ToString());
                        
                        //LessonID = reader.GetInt32(0);
                        //1lbBookedLessons.Items.Add(LessonID);
                    }
                    
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnCancelBooking_Click(object sender, EventArgs e)
        {
            
            string id = lbBookedLessons.SelectedItem.ToString().Split('\t')[0];
            
            //VAR
            string credits = "";
            string price = "";
            string spaces = "";
            double doubleCredits = 0.00;
            double doublePrice = 0.00;
            int intspaces = 0;
                
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            //string removeID = lbLessonSum.GetItemText(lbLessonSum.SelectedItem);
            //string removeID = lbBookedLessons.GetItemText(lbBookedLessons.SelectedItem);
            

            //Get value of students available credits:
            try
            {
                SqlDataReader reader;
                string Query = "";


                Query = "SELECT * From STUDENT WHERE StudentID = '" + userID + "'";
                SqlCommand comm = new SqlCommand(Query, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    credits = reader.GetValue(5).ToString();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            //doubleCredits = Convert.ToDouble(credits);

            //Get value of refund credits:
            try
            {
                SqlDataReader reader;
                string Query = "";


                Query = "SELECT * From LESSON WHERE LessonID = '" + removeID + "'";
                SqlCommand comm = new SqlCommand(Query, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    price = reader.GetValue(3).ToString();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            //doublePrice = Convert.ToDouble(price);

            //Get value of available spaces:
            try
            {
                SqlDataReader reader;
                string Query = "";


                Query = "SELECT * From LESSON WHERE LessonID = '" + removeID + "'";
                SqlCommand comm = new SqlCommand(Query, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    spaces = reader.GetValue(5).ToString();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            //intspaces = int.Parse(spaces);
            conn.Close();


            //TOTAL TO ADD;
            //double total = Convert.ToDouble(price + credits);
             //double total =  doublePrice + doubleCredits;

            conn.Open();
;           string sqlQuery = "UPDATE STUDENT SET Credits  = '" + credits + price + "' WHERE StudentID = '" + userID + "'";
            SqlCommand cmn = new SqlCommand(sqlQuery, conn);
            cmn.ExecuteNonQuery();

            sqlQuery = "UPDATE LESSON SET MaxNoOfStudents  = '" + spaces + 1 + "' WHERE LessonID = '" + selectedLesson + "'";
            cmn = new SqlCommand(sqlQuery, conn);
            cmn.ExecuteNonQuery();

            //Delete froomm database
            string deleteQuery = "DELETE FROM LESSON_STUDENT WHERE LessonId = '" + id + "'";
            cmn = new SqlCommand(deleteQuery, conn);
            cmn.ExecuteNonQuery();
            conn.Close();

            //Data load into data grid view:
            string loadQuery = @"SELECT * FROM LESSON";

            SqlCommand com = new SqlCommand(loadQuery, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            adap.Fill(ds, "LESSON");

            dgvStudentLessons.DataSource = ds;
            dgvStudentLessons.DataMember = "LESSON";
            conn.Close();
            MessageBox.Show("Lesson succesfully canceled");

            //RELOAD DATA:
            lbBookedLessons.Items.Clear();
            lbBookedLessons.Items.Add("ID\t" + "DATE\t\t\t" + "TIME\t\t" + "DESCRIPTION\t" + "INSTRUCTOR\t");
            ///Load Booked lessons.
            try
            {
                //VAR
                int LessonID;
                conn = new SqlConnection(conString);
                conn.Open();

                SqlDataReader reader;
                string  output, sqlQuery2 = "";

                sqlQuery = "SELECT * From LESSON_STUDENT WHERE StudentID = " + userID;
                cmn = new SqlCommand(sqlQuery, conn);
                reader = cmn.ExecuteReader();
                int getLessonID;
                while (reader.Read())
                {

                    getLessonID = (int)reader.GetValue(0);

                    SqlDataReader sqlReader2;
                    sqlQuery2 = "SELECT * FROM LESSON WHERE LessonID =" + getLessonID;
                    SqlCommand cmn2 = new SqlCommand(sqlQuery2, conn);
                    cmn2 = new SqlCommand(sqlQuery2, conn);
                    sqlReader2 = cmn2.ExecuteReader();

                    while (sqlReader2.Read())
                    {
                        lbBookedLessons.Items.Add(sqlReader2.GetValue(0) + "\t" + sqlReader2.GetValue(1).ToString() + "\t" + sqlReader2.GetValue(2).ToString() + "\t\t" + sqlReader2.GetValue(4) + "\t" + sqlReader2.GetValue(6).ToString());

                        //LessonID = reader.GetInt32(0);
                        //1lbBookedLessons.Items.Add(LessonID);
                    }

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }



        }

        private void LbBookedLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            //removeID = lbLessonSum.SelectedItem.ToString();
            ///label1.Text = lbLessonSum.SelectedItem.ToString();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
