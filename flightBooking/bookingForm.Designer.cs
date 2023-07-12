
namespace flightBooking
{
    partial class bookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTravelDoc = new System.Windows.Forms.Label();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.travelIssueDate = new System.Windows.Forms.DateTimePicker();
            this.travelExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.bagge = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTravelDocument = new System.Windows.Forms.TextBox();
            this.rdbPassport = new System.Windows.Forms.RadioButton();
            this.rdbIdCard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bagge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(101, 25);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(163, 20);
            this.txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(336, 26);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(162, 20);
            this.txtTo.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(40, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "FullName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(625, 77);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(148, 28);
            this.txtFullName.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(625, 136);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(148, 29);
            this.txtCountry.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trave Document";
            // 
            // lblTravelDoc
            // 
            this.lblTravelDoc.AutoSize = true;
            this.lblTravelDoc.Location = new System.Drawing.Point(333, 244);
            this.lblTravelDoc.Name = "lblTravelDoc";
            this.lblTravelDoc.Size = new System.Drawing.Size(65, 13);
            this.lblTravelDoc.TabIndex = 12;
            this.lblTravelDoc.Text = "Passport No";
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Location = new System.Drawing.Point(386, 293);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(112, 13);
            this.lblExpired.TabIndex = 13;
            this.lblExpired.Text = "Passport Expired Date";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(37, 286);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(102, 13);
            this.lblIssue.TabIndex = 14;
            this.lblIssue.Text = "Passport Issue Date";
            this.lblIssue.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Baggage";
            // 
            // travelIssueDate
            // 
            this.travelIssueDate.Location = new System.Drawing.Point(160, 286);
            this.travelIssueDate.Name = "travelIssueDate";
            this.travelIssueDate.Size = new System.Drawing.Size(200, 20);
            this.travelIssueDate.TabIndex = 16;
            // 
            // travelExpiredDate
            // 
            this.travelExpiredDate.Location = new System.Drawing.Point(513, 293);
            this.travelExpiredDate.Name = "travelExpiredDate";
            this.travelExpiredDate.Size = new System.Drawing.Size(200, 20);
            this.travelExpiredDate.TabIndex = 17;
            // 
            // bagge
            // 
            this.bagge.Location = new System.Drawing.Point(101, 325);
            this.bagge.Name = "bagge";
            this.bagge.Size = new System.Drawing.Size(51, 20);
            this.bagge.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "KG";
            // 
            // txtTravelDocument
            // 
            this.txtTravelDocument.Location = new System.Drawing.Point(404, 240);
            this.txtTravelDocument.Name = "txtTravelDocument";
            this.txtTravelDocument.Size = new System.Drawing.Size(186, 20);
            this.txtTravelDocument.TabIndex = 20;
            // 
            // rdbPassport
            // 
            this.rdbPassport.AutoSize = true;
            this.rdbPassport.Location = new System.Drawing.Point(6, 19);
            this.rdbPassport.Name = "rdbPassport";
            this.rdbPassport.Size = new System.Drawing.Size(66, 17);
            this.rdbPassport.TabIndex = 0;
            this.rdbPassport.TabStop = true;
            this.rdbPassport.Text = "Passport";
            this.rdbPassport.UseVisualStyleBackColor = true;
            this.rdbPassport.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbIdCard
            // 
            this.rdbIdCard.AutoSize = true;
            this.rdbIdCard.Location = new System.Drawing.Point(89, 19);
            this.rdbIdCard.Name = "rdbIdCard";
            this.rdbIdCard.Size = new System.Drawing.Size(61, 17);
            this.rdbIdCard.TabIndex = 1;
            this.rdbIdCard.TabStop = true;
            this.rdbIdCard.Text = "ID Card";
            this.rdbIdCard.UseVisualStyleBackColor = true;
            this.rdbIdCard.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbIdCard);
            this.groupBox1.Controls.Add(this.rdbPassport);
            this.groupBox1.Location = new System.Drawing.Point(142, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 47);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(40, 366);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(196, 58);
            this.btnBooking.TabIndex = 21;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // bookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 456);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.txtTravelDocument);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bagge);
            this.Controls.Add(this.travelExpiredDate);
            this.Controls.Add(this.travelIssueDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.lblTravelDoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bookingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bagge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTravelDoc;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker travelIssueDate;
        private System.Windows.Forms.DateTimePicker travelExpiredDate;
        private System.Windows.Forms.NumericUpDown bagge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTravelDocument;
        private System.Windows.Forms.RadioButton rdbPassport;
        private System.Windows.Forms.RadioButton rdbIdCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBooking;
    }
}

