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

        //Database:
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marné\Documents\NWU\CMPG 223\Assignment\Adrestia\Adrestia\Adrestia\LessonTest.mdf;Integrated Security=True";

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

            string sql = "INSERT INTO LESSON_STUDENT VALUES (@lesson, @student";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@lesson", selectedLesson);
            command.Parameters.AddWithValue("@student", studentID);
            command.ExecuteNonQuery();

            sql = "SELECT Count(LessonID) FROM LESSON_STUDENT WHERE LessonID = '" + selectedLesson + "'";
            command = new SqlCommand(sql, conn);
            int count =(int)command.ExecuteScalar();

            int places = int.Parse(selectedMax) - count;
      
            sql = "UPDATE [LESSON] SET placesAvailable = '" + places + "' WHERE LessonID = '" + selectedLesson + "';";

            conn.Close();
        }
    }
}
