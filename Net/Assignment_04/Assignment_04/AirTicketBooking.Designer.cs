namespace Assignment_04
{
    partial class AirTicketBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirTicketBooking));
            this.textFlightList = new System.Windows.Forms.Label();
            this.textRegistrationList = new System.Windows.Forms.Label();
            this.lsbFlightList = new System.Windows.Forms.ListBox();
            this.rtxtRegistrationInfo = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFlightList
            // 
            this.textFlightList.AutoSize = true;
            this.textFlightList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFlightList.ForeColor = System.Drawing.Color.Red;
            this.textFlightList.Location = new System.Drawing.Point(133, 42);
            this.textFlightList.Name = "textFlightList";
            this.textFlightList.Size = new System.Drawing.Size(120, 26);
            this.textFlightList.TabIndex = 0;
            this.textFlightList.Text = "Flight List";
            // 
            // textRegistrationList
            // 
            this.textRegistrationList.AutoSize = true;
            this.textRegistrationList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegistrationList.ForeColor = System.Drawing.Color.Red;
            this.textRegistrationList.Location = new System.Drawing.Point(531, 42);
            this.textRegistrationList.Name = "textRegistrationList";
            this.textRegistrationList.Size = new System.Drawing.Size(185, 26);
            this.textRegistrationList.TabIndex = 1;
            this.textRegistrationList.Text = "Registration List";
            // 
            // lsbFlightList
            // 
            this.lsbFlightList.FormattingEnabled = true;
            this.lsbFlightList.ItemHeight = 23;
            this.lsbFlightList.Location = new System.Drawing.Point(54, 82);
            this.lsbFlightList.Name = "lsbFlightList";
            this.lsbFlightList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbFlightList.Size = new System.Drawing.Size(300, 395);
            this.lsbFlightList.TabIndex = 2;
            // 
            // rtxtRegistrationInfo
            // 
            this.rtxtRegistrationInfo.Location = new System.Drawing.Point(403, 84);
            this.rtxtRegistrationInfo.Name = "rtxtRegistrationInfo";
            this.rtxtRegistrationInfo.Size = new System.Drawing.Size(454, 393);
            this.rtxtRegistrationInfo.TabIndex = 3;
            this.rtxtRegistrationInfo.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(125, 497);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(464, 497);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 60);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "&Comfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(620, 497);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AirTicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 619);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtxtRegistrationInfo);
            this.Controls.Add(this.lsbFlightList);
            this.Controls.Add(this.textRegistrationList);
            this.Controls.Add(this.textFlightList);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AirTicketBooking";
            this.Text = "AirTicket Booking";
            this.Load += new System.EventHandler(this.AirTicketBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textFlightList;
        private System.Windows.Forms.Label textRegistrationList;
        private System.Windows.Forms.ListBox lsbFlightList;
        private System.Windows.Forms.RichTextBox rtxtRegistrationInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnLogout;
    }
}