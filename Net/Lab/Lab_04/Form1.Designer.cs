namespace Lab_04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgwPhoneList = new System.Windows.Forms.DataGridView();
            this.picPhoneImage = new System.Windows.Forms.PictureBox();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnLoadSQL = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateSource = new System.Windows.Forms.Button();
            this.colSmartPhoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSmartPhoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSmartPhoneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnnouncedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBattery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPhoneList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPhoneList
            // 
            this.dgwPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPhoneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSmartPhoneID,
            this.colSmartPhoneName,
            this.colSmartPhoneType,
            this.colAnnouncedDate,
            this.colPlatform,
            this.colCamera,
            this.colRAM,
            this.colBattery,
            this.colPrice});
            this.dgwPhoneList.Location = new System.Drawing.Point(40, 61);
            this.dgwPhoneList.MultiSelect = false;
            this.dgwPhoneList.Name = "dgwPhoneList";
            this.dgwPhoneList.RowHeadersWidth = 62;
            this.dgwPhoneList.RowTemplate.Height = 28;
            this.dgwPhoneList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwPhoneList.Size = new System.Drawing.Size(662, 463);
            this.dgwPhoneList.TabIndex = 0;
            this.dgwPhoneList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // picPhoneImage
            // 
            this.picPhoneImage.ErrorImage = null;
            this.picPhoneImage.Image = ((System.Drawing.Image)(resources.GetObject("picPhoneImage.Image")));
            this.picPhoneImage.InitialImage = null;
            this.picPhoneImage.Location = new System.Drawing.Point(722, 130);
            this.picPhoneImage.Name = "picPhoneImage";
            this.picPhoneImage.Size = new System.Drawing.Size(350, 330);
            this.picPhoneImage.TabIndex = 1;
            this.picPhoneImage.TabStop = false;
            this.picPhoneImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcel.Location = new System.Drawing.Point(41, 16);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(300, 35);
            this.btnLoadExcel.TabIndex = 2;
            this.btnLoadExcel.Text = "Load Data From Excel";
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadSQL
            // 
            this.btnLoadSQL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSQL.Location = new System.Drawing.Point(368, 16);
            this.btnLoadSQL.Name = "btnLoadSQL";
            this.btnLoadSQL.Size = new System.Drawing.Size(300, 35);
            this.btnLoadSQL.TabIndex = 3;
            this.btnLoadSQL.Text = "Load Data From SQL";
            this.btnLoadSQL.UseVisualStyleBackColor = true;
            this.btnLoadSQL.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(120, 547);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(216, 547);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(312, 547);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // btnUpdateSource
            // 
            this.btnUpdateSource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSource.Location = new System.Drawing.Point(449, 547);
            this.btnUpdateSource.Name = "btnUpdateSource";
            this.btnUpdateSource.Size = new System.Drawing.Size(250, 35);
            this.btnUpdateSource.TabIndex = 10;
            this.btnUpdateSource.Text = "Update To DataSource\r\n";
            this.btnUpdateSource.UseVisualStyleBackColor = true;
            this.btnUpdateSource.Click += new System.EventHandler(this.button6_Click);
            // 
            // colSmartPhoneID
            // 
            this.colSmartPhoneID.DataPropertyName = "SmartPhoneID";
            this.colSmartPhoneID.HeaderText = "SmartPhoneID";
            this.colSmartPhoneID.MinimumWidth = 8;
            this.colSmartPhoneID.Name = "colSmartPhoneID";
            this.colSmartPhoneID.Width = 150;
            // 
            // colSmartPhoneName
            // 
            this.colSmartPhoneName.DataPropertyName = "Smart Phone Name";
            this.colSmartPhoneName.HeaderText = "Smart Phone Name";
            this.colSmartPhoneName.MinimumWidth = 8;
            this.colSmartPhoneName.Name = "colSmartPhoneName";
            this.colSmartPhoneName.Width = 150;
            // 
            // colSmartPhoneType
            // 
            this.colSmartPhoneType.DataPropertyName = "Smart Phone Type";
            this.colSmartPhoneType.HeaderText = "Smart Phone Type";
            this.colSmartPhoneType.MinimumWidth = 8;
            this.colSmartPhoneType.Name = "colSmartPhoneType";
            this.colSmartPhoneType.Width = 150;
            // 
            // colAnnouncedDate
            // 
            this.colAnnouncedDate.DataPropertyName = "Announced Date";
            this.colAnnouncedDate.HeaderText = "Announced Date";
            this.colAnnouncedDate.MinimumWidth = 8;
            this.colAnnouncedDate.Name = "colAnnouncedDate";
            this.colAnnouncedDate.Width = 150;
            // 
            // colPlatform
            // 
            this.colPlatform.DataPropertyName = "Platform";
            this.colPlatform.HeaderText = "Platform";
            this.colPlatform.MinimumWidth = 8;
            this.colPlatform.Name = "colPlatform";
            this.colPlatform.Width = 150;
            // 
            // colCamera
            // 
            this.colCamera.DataPropertyName = "Camera";
            this.colCamera.HeaderText = "Camera";
            this.colCamera.MinimumWidth = 8;
            this.colCamera.Name = "colCamera";
            this.colCamera.Width = 150;
            // 
            // colRAM
            // 
            this.colRAM.DataPropertyName = "RAM\r\n";
            this.colRAM.HeaderText = "RAM";
            this.colRAM.MinimumWidth = 8;
            this.colRAM.Name = "colRAM";
            this.colRAM.Width = 150;
            // 
            // colBattery
            // 
            this.colBattery.DataPropertyName = "Battery";
            this.colBattery.HeaderText = "Battery";
            this.colBattery.MinimumWidth = 8;
            this.colBattery.Name = "colBattery";
            this.colBattery.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 607);
            this.Controls.Add(this.btnUpdateSource);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadSQL);
            this.Controls.Add(this.btnLoadExcel);
            this.Controls.Add(this.picPhoneImage);
            this.Controls.Add(this.dgwPhoneList);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Phone Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPhoneList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoneImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPhoneList;
        private System.Windows.Forms.PictureBox picPhoneImage;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnLoadSQL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSmartPhoneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSmartPhoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSmartPhoneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnouncedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBattery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}

