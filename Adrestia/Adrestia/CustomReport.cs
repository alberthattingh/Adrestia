using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrestia
{
    public partial class CustomReport : Form
    {
        public CustomReport()
        {
            InitializeComponent();
        }


        // Variables
        public string sqlReport;
        string sqlFrom;
        string sqlSelect;

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if(!cbIFirstName.Checked && !cbILastName.Checked && !cbICellNo.Checked && !cbIEmail.Checked &&
                !cbSFirstName.Checked && !cbSLastName.Checked && !cbSCellNo.Checked &&!cbSEmail.Checked && !cbLessonDate.Checked &&
                !cbLessonTime.Checked && !cbLessonPrice.Checked && !cbLessonDesc.Checked && !cbplacesAvailable.Checked && !cbLessonInstructor.Checked && !cbEventDate.Checked &&
                !cbEventTime.Checked &&!cbChildrenCost.Checked && !cbAdultCost.Checked && !cbPensionerCost.Checked && !cbVenue.Checked && !cbEventType.Checked &&
                !cbEventTypeDesc.Checked && !cbVenueDesc.Checked && !cbMaxSeats.Checked && !cbSaleDate.Checked && !cbSaleTime.Checked && !cbNoOfAdults.Checked &&
                !cnNoOfChildren.Checked && !cnNoOfPensioners.Checked && !cbTotalOfSale.Checked && !cbSender.Checked && !cbReceiver.Checked && !cbMessageDate.Checked &&
                !cbMessageTime.Checked && !cbMessageText.Checked && !cbBackupDate.Checked && !cbBackupTime.Checked)
            {
                MessageBox.Show("Please select at least one field for the report");
            }
            else
            {
                sqlReport = "SELECT " + sqlSelect + " FROM " + sqlFrom ;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            sqlReport = "";
            this.Close();
        }

        private void HideAllGroupBoxes()
        {
            gbInstructors.Visible = false;
            gbStudents.Visible = false;
            gbLessons.Visible = false;
            gbSpecialEvents.Visible = false;
            gbEventTypes.Visible = false;
            gbEventVenues.Visible = false;
            gbTicketSales.Visible = false;
            gbMessaging.Visible = false;
            gbBackupLog.Visible = false;
        }

        private void UncheckAllCheckboxes()
        {
            cbIFirstName.Checked = false;
            cbILastName.Checked = false;
            cbICellNo.Checked = false;
            cbIEmail.Checked = false;
            cbSFirstName.Checked = false;
            cbSLastName.Checked = false;
            cbSCellNo.Checked = false;
            cbSEmail.Checked = false;
            cbLessonDate.Checked = false;
            cbLessonTime.Checked = false;
            cbLessonPrice.Checked = false;
            cbLessonDesc.Checked = false;
            cbplacesAvailable.Checked = false;
            cbLessonInstructor.Checked = false;
            cbEventDate.Checked = false;
            cbEventTime.Checked = false;
            cbChildrenCost.Checked = false;
            cbAdultCost.Checked = false;
            cbPensionerCost.Checked = false;
            cbVenue.Checked = false;
            cbEventType.Checked = false;
            cbEventTypeDesc.Checked = false;
            cbVenueDesc.Checked = false;
            cbMaxSeats.Checked = false;
            cbSaleDate.Checked = false;
            cbSaleTime.Checked = false;
            cbNoOfAdults.Checked = false;
            cnNoOfChildren.Checked = false;
            cnNoOfPensioners.Checked = false;
            cbTotalOfSale.Checked = false;
            cbSalesEventID.Checked = false;
            cbSender.Checked = false;
            cbReceiver.Checked = false;
            cbMessageDate.Checked = false;
            cbMessageTime.Checked = false;
            cbMessageText.Checked = false;
            cbBackupDate.Checked = false;
            cbBackupTime.Checked = false;
        }

       
        private void RbInstructors_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbInstructors.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "[USER]";
            sqlSelect = "InstructorID ";

        }

        private void RbStudents_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbStudents.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "[USER]";
            sqlSelect = "UserID ";
        }

        private void RbLessons_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbLessons.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "LESSON ";
            sqlSelect = "LessonID ";
        }

        private void RbSpecialEvents_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbSpecialEvents.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "SPECIAL_EVENT ";
            sqlSelect = "EventID ";
        }

        private void RbEventTypes_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbEventTypes.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "EVENT_TYPE ";
            sqlSelect = "EventTypeID ";
        }

        private void RbEventVenues_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbEventVenues.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "VENUE ";
            sqlSelect = "VenueID ";
        }

        private void RbTicketSales_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbTicketSales.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "TICKET_SALE ";
            sqlSelect = "SaleID ";
        }

        private void RbMessaging_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbMessaging.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "MESSAGE ";
            sqlSelect = "MessageID ";
        }

        private void RbBackupLogs_CheckedChanged(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            gbBackupLog.Visible = true;
            UncheckAllCheckboxes();
            sqlFrom = "BACKUP_LOG ";
            sqlSelect = "BackupID ";
        }

        
        private void CbUserType_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", UserType";
        }

        private void CbIFirstName_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", FirstName";
        }

        private void CbILastName_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", LastName";
        }

        private void CbICellNo_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", CellNo";
        }

        private void CbIEmail_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Email";
        }

        private void CbSalary_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Salary";
        }


        private void CbSFirstName_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", FirstName";
        }

        private void CbSLastName_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", LastName";
        }

        private void CbSCellNo_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", CellNo";
        }

        private void CbSEmail_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Email";
        }

        private void CbCredits_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Credits";
        }

        private void CbLessonDesc_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Description";
        }

        private void CbLessonDate_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", LessonDate";
        }

        private void CbLessonTime_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", LessonTime";
        }

        private void CbLessonPrice_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", LessonPrice";
        }

        private void CbplacesAvailable_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", AvailablePlaces";
        }

        private void CbLessonOrganizer_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", InstructorID";
        }

        private void CbEventDate_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", EventDate";
        }

        private void CbEventTime_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", EventTime";
        }

        private void CbAdultCost_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", CostAdult";
        }

        private void CbChildrenCost_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", CostChildren";
        }

        private void CbPensionerCost_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", CostPensioner";
        }

        private void CbVenue_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", VenueID";
        }

        private void CbEventType_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", EventTypeID";
        }


        private void CbEventTypeDesc_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Description";
        }


        private void CbVenueDesc_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Description";
        }

        private void CbMaxSeats_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", MaxNoSeats";
        }

        private void CbSaleDate_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", SaleDate";
        }

        private void CbSaleTime_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", SaleTime";
        }

        private void CbNoOfAdults_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", NoOfAdults";
        }

        private void CnNoOfChildren_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", NoOfChildren";
        }

        private void CnNoOfPensioners_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", NoOfPensioners";
        }

        private void CbTotalOfSale_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", TotalOfSale";
        }

        private void CbSalesEventID_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", EventID";
        }

        private void CbSender_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Sender";
        }

        private void CbReceiver_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Receiver";
        }

        private void CbMessageText_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", MessageText";
        }

        private void CbMessageDate_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Date";
        }

        private void CbMessageTime_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", Time";
        }

        private void CbBackupDate_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", BackupDate";
        }

        private void CbBackupTime_CheckedChanged(object sender, EventArgs e)
        {
            sqlSelect += ", BackupTime";
        }

        private void GbMessaging_Enter(object sender, EventArgs e)
        {

        }
    }
}
