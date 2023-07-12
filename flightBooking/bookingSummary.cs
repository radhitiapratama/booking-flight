using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightBooking
{
    public partial class bookingSummary : Form
    {
        public bookingSummary()
        {
            InitializeComponent();
        }

        private void bookingSummary_Load(object sender, EventArgs e)
        {
            lblResultDestination.Text = bookingForm.from + " " + bookingForm.to;
            lblResultPersonDetail.Text = bookingForm.country + " " + bookingForm.fullName;
            lblResultTravelDate.Text  = bookingForm.startTravelDate + " - " + bookingForm.endTravelDate;

            if (bookingForm.IDCard)
            {
                lblPassport.Text = "ID Card No";
                lblPassportIssueDate.Text = "ID Card Issue Date";
                lblPassportExpired.Text = "ID Card Expired Date";

                lblResultPassportNo.Text = bookingForm.travelDocumentNo;
                lblResultPassportIssue.Text = bookingForm.issueDate;
                lblResultPassportExpired.Text = bookingForm.expiredDate;
            }

            if (bookingForm.Passport)
            {
                lblResultPassportNo.Text = bookingForm.travelDocumentNo;
                lblResultPassportIssue.Text  = bookingForm.issueDate;
                lblResultPassportExpired.Text = bookingForm.expiredDate;
            }

            lblResultWeight.Text = bookingForm.weightBaggage + "Kg";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
