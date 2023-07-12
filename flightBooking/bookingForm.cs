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
    public partial class bookingForm : Form
    {
        public static Boolean Passport,IDCard;
        public static string from,to,startTravelDate,endTravelDate,fullName,country,travelDocumentNo,issueDate,expiredDate,
            weightBaggage;

        public bool checkValidation()
        {
            if (
                txtFrom.Text == "" || txtTo.Text == "" || txtFullName.Text == "" || txtCountry.Text == ""
                || txtTravelDocument.Text == "" || monthCalendar1.SelectionStart.ToString() == ""
                || monthCalendar1.SelectionEnd.ToString() == "" || travelIssueDate.Value.ToString() == "" || 
                travelExpiredDate.Value.ToString() == "" || bagge.Value.ToString() == ""
                )
            {

                MessageBox.Show("All input are required !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return  true;
            }

            return false ;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                return;
            }

            from = txtFrom.Text;
            to = txtTo.Text;
            startTravelDate = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
            endTravelDate = monthCalendar1.SelectionEnd.ToString("dd/MM/yyyy");
            fullName = txtFullName.Text;
            country = txtCountry.Text;
            travelDocumentNo = txtTravelDocument.Text;
            issueDate = travelIssueDate.Value.ToString("dd/MM/yyyy");
            expiredDate = travelIssueDate.Value.ToString("dd/MM/yyyy");
            weightBaggage = bagge.Value.ToString();

            if (rdbPassport.Checked)
            {
                Passport = true;
            }

            if (rdbIdCard.Checked)
            {
                IDCard = true;
            }

            this.Hide();
            bookingSummary bks = new bookingSummary();
            bks.Show();
        }

       
        public bookingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            rdbPassport.Checked = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblTravelDoc.Text = "ID Card No";
            lblIssue.Text = "ID Card Issue Date";
            lblExpired.Text = "ID Card Expired Date";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblTravelDoc.Text = "Passport No";
            lblIssue.Text = "Passport Issue Date";
            lblExpired.Text = "Passport Expired Date";
        }
    }
}
