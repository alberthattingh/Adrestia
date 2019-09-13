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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Adrestia
{
    public partial class Reporting : UserControl
    {
        public string connectionString = Security.ConnectionString;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public SqlCommand command;
        public DataSet ds;
        public SqlDataReader reader;
        string sqlReport;
        CustomReport customReportForm = new CustomReport();

        public Reporting()
        {
            InitializeComponent();
        }

        private void BtnTicketSales_Click(object sender, EventArgs e)
        {
            if (rbWeekly.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE WHERE SaleDate >= '" + DateTime.Today.AddDays(-7).ToShortDateString() + "'";
            }
            else if (rbMonthly.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE WHERE SaleDate >= '" + DateTime.Today.AddMonths(-1).ToShortDateString() + "'";
            }
            else if (rbYearly.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE WHERE SaleDate >= '" + DateTime.Today.AddYears(-1).ToShortDateString() + "'";

            }
            else if (rbAll.Checked)
            {
                sqlReport = "SELECT * FROM TICKET_SALE";
            }
            PopulateGridView(this.sqlReport);
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            customReportForm.ShowDialog();
            if (customReportForm.sqlReport != "")
            {
                PopulateGridView(customReportForm.sqlReport);
            }

        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            rbWeekly.Checked = true;
        }

        public void PopulateGridView(string sqlReport)
        {
            try
            {
                connection.Open();

                string sql = sqlReport;
                command = new SqlCommand(sql, connection);
                ds = new DataSet();

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "ReportTable");

                dataGridView1.DataMember = "ReportTable";
                dataGridView1.DataSource = ds;

                adapter.Dispose();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
                connection.Close();
            }

        }

        private void BtnExportToPdf_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                    catch { }
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
