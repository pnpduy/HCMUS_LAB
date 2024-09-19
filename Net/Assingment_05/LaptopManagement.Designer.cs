namespace Assingment_05
{
    partial class LaptopManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaptopManagementForm));
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnLoadSQL = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateSource = new System.Windows.Forms.Button();
            this.dgwLaptopList = new System.Windows.Forms.DataGridView();
            this.colLaptopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaptopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaptopType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLapImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLaptopList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcel.Location = new System.Drawing.Point(26, 24);
            this.btnLoadExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(285, 32);
            this.btnLoadExcel.TabIndex = 0;
            this.btnLoadExcel.Text = "Load Data From Excel";
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // btnLoadSQL
            // 
            this.btnLoadSQL.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSQL.Location = new System.Drawing.Point(351, 24);
            this.btnLoadSQL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadSQL.Name = "btnLoadSQL";
            this.btnLoadSQL.Size = new System.Drawing.Size(285, 32);
            this.btnLoadSQL.TabIndex = 1;
            this.btnLoadSQL.Text = "Load Data From SQL";
            this.btnLoadSQL.UseVisualStyleBackColor = true;
            this.btnLoadSQL.Click += new System.EventHandler(this.btnLoadSQL_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(26, 453);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(134, 453);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(242, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateSource
            // 
            this.btnUpdateSource.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSource.Location = new System.Drawing.Point(368, 453);
            this.btnUpdateSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateSource.Name = "btnUpdateSource";
            this.btnUpdateSource.Size = new System.Drawing.Size(268, 37);
            this.btnUpdateSource.TabIndex = 5;
            this.btnUpdateSource.Text = "Update To DataSource";
            this.btnUpdateSource.UseVisualStyleBackColor = true;
            this.btnUpdateSource.Click += new System.EventHandler(this.btnUpdateSource_Click);
            // 
            // dgwLaptopList
            // 
            this.dgwLaptopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLaptopList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLaptopID,
            this.colLaptopName,
            this.colLaptopType,
            this.colProductDate,
            this.colProcessor,
            this.colHDD,
            this.colRAM,
            this.colPrice});
            this.dgwLaptopList.Location = new System.Drawing.Point(26, 80);
            this.dgwLaptopList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwLaptopList.Name = "dgwLaptopList";
            this.dgwLaptopList.RowHeadersWidth = 62;
            this.dgwLaptopList.RowTemplate.Height = 28;
            this.dgwLaptopList.Size = new System.Drawing.Size(610, 343);
            this.dgwLaptopList.TabIndex = 6;
            this.dgwLaptopList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgwLaptopList.Click += new System.EventHandler(this.dgwLaptopList_SelectionChanged);
            // 
            // colLaptopID
            // 
            this.colLaptopID.DataPropertyName = "LaptopID";
            this.colLaptopID.HeaderText = "LaptopID";
            this.colLaptopID.MinimumWidth = 8;
            this.colLaptopID.Name = "colLaptopID";
            this.colLaptopID.Width = 150;
            // 
            // colLaptopName
            // 
            this.colLaptopName.DataPropertyName = "LaptopName";
            this.colLaptopName.HeaderText = "Laptop Name";
            this.colLaptopName.MinimumWidth = 8;
            this.colLaptopName.Name = "colLaptopName";
            this.colLaptopName.Width = 150;
            // 
            // colLaptopType
            // 
            this.colLaptopType.DataPropertyName = "LaptopType";
            this.colLaptopType.HeaderText = "Laptop Type";
            this.colLaptopType.MinimumWidth = 8;
            this.colLaptopType.Name = "colLaptopType";
            this.colLaptopType.Width = 150;
            // 
            // colProductDate
            // 
            this.colProductDate.DataPropertyName = "ProductDate";
            this.colProductDate.HeaderText = "Product Date";
            this.colProductDate.MinimumWidth = 8;
            this.colProductDate.Name = "colProductDate";
            this.colProductDate.Width = 150;
            // 
            // colProcessor
            // 
            this.colProcessor.DataPropertyName = "Processor";
            this.colProcessor.HeaderText = "Processor";
            this.colProcessor.MinimumWidth = 8;
            this.colProcessor.Name = "colProcessor";
            this.colProcessor.Width = 150;
            // 
            // colHDD
            // 
            this.colHDD.DataPropertyName = "HDD";
            this.colHDD.HeaderText = "HDD";
            this.colHDD.MinimumWidth = 8;
            this.colHDD.Name = "colHDD";
            this.colHDD.Width = 150;
            // 
            // colRAM
            // 
            this.colRAM.DataPropertyName = "RAM";
            this.colRAM.HeaderText = "RAM";
            this.colRAM.MinimumWidth = 8;
            this.colRAM.Name = "colRAM";
            this.colRAM.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 150;
            // 
            // picLapImage
            // 
            this.picLapImage.Image = ((System.Drawing.Image)(resources.GetObject("picLapImage.Image")));
            this.picLapImage.Location = new System.Drawing.Point(644, 80);
            this.picLapImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLapImage.Name = "picLapImage";
            this.picLapImage.Size = new System.Drawing.Size(400, 325);
            this.picLapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLapImage.TabIndex = 7;
            this.picLapImage.TabStop = false;
            this.picLapImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LaptopManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 525);
            this.Controls.Add(this.picLapImage);
            this.Controls.Add(this.dgwLaptopList);
            this.Controls.Add(this.btnUpdateSource);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadSQL);
            this.Controls.Add(this.btnLoadExcel);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LaptopManagementForm";
            this.Text = "Laptop Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLaptopList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLapImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnLoadSQL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateSource;
        private System.Windows.Forms.DataGridView dgwLaptopList;
        private System.Windows.Forms.PictureBox picLapImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaptopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaptopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaptopType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}

