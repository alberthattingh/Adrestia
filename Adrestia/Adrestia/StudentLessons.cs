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
    }
}
