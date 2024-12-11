namespace PMS
{
    partial class PatientL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appdataset = new PMS.Appdataset();
            this.appdatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientListTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientList_TBTableAdapter = new PMS.AppdatasetTableAdapters.PatientList_TBTableAdapter();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdivisionVillageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brgyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appdatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientListTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(81, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 435);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(891, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1029, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1112, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.suffixDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.blockNoDataGridViewTextBoxColumn,
            this.subdivisionVillageDataGridViewTextBoxColumn,
            this.brgyDataGridViewTextBoxColumn,
            this.cityAddressDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emergencyContactDataGridViewTextBoxColumn,
            this.allergiesDataGridViewTextBoxColumn,
            this.medicalHistoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientListTBBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 435);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // appdataset
            // 
            this.appdataset.DataSetName = "Appdataset";
            this.appdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appdatasetBindingSource
            // 
            this.appdatasetBindingSource.DataSource = this.appdataset;
            this.appdatasetBindingSource.Position = 0;
            // 
            // patientListTBBindingSource
            // 
            this.patientListTBBindingSource.DataMember = "PatientList_TB";
            this.patientListTBBindingSource.DataSource = this.appdatasetBindingSource;
            // 
            // patientList_TBTableAdapter
            // 
            this.patientList_TBTableAdapter.ClearBeforeFill = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            this.suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            this.suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            this.suffixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            this.suffixDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // blockNoDataGridViewTextBoxColumn
            // 
            this.blockNoDataGridViewTextBoxColumn.DataPropertyName = "Block_No";
            this.blockNoDataGridViewTextBoxColumn.HeaderText = "Block_No";
            this.blockNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blockNoDataGridViewTextBoxColumn.Name = "blockNoDataGridViewTextBoxColumn";
            this.blockNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // subdivisionVillageDataGridViewTextBoxColumn
            // 
            this.subdivisionVillageDataGridViewTextBoxColumn.DataPropertyName = "Subdivision/Village";
            this.subdivisionVillageDataGridViewTextBoxColumn.HeaderText = "Subdivision/Village";
            this.subdivisionVillageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subdivisionVillageDataGridViewTextBoxColumn.Name = "subdivisionVillageDataGridViewTextBoxColumn";
            this.subdivisionVillageDataGridViewTextBoxColumn.Width = 125;
            // 
            // brgyDataGridViewTextBoxColumn
            // 
            this.brgyDataGridViewTextBoxColumn.DataPropertyName = "Brgy";
            this.brgyDataGridViewTextBoxColumn.HeaderText = "Brgy";
            this.brgyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brgyDataGridViewTextBoxColumn.Name = "brgyDataGridViewTextBoxColumn";
            this.brgyDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityAddressDataGridViewTextBoxColumn
            // 
            this.cityAddressDataGridViewTextBoxColumn.DataPropertyName = "City_Address";
            this.cityAddressDataGridViewTextBoxColumn.HeaderText = "City_Address";
            this.cityAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityAddressDataGridViewTextBoxColumn.Name = "cityAddressDataGridViewTextBoxColumn";
            this.cityAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emergencyContactDataGridViewTextBoxColumn
            // 
            this.emergencyContactDataGridViewTextBoxColumn.DataPropertyName = "Emergency_Contact";
            this.emergencyContactDataGridViewTextBoxColumn.HeaderText = "Emergency_Contact";
            this.emergencyContactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emergencyContactDataGridViewTextBoxColumn.Name = "emergencyContactDataGridViewTextBoxColumn";
            this.emergencyContactDataGridViewTextBoxColumn.Width = 125;
            // 
            // allergiesDataGridViewTextBoxColumn
            // 
            this.allergiesDataGridViewTextBoxColumn.DataPropertyName = "Allergies";
            this.allergiesDataGridViewTextBoxColumn.HeaderText = "Allergies";
            this.allergiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allergiesDataGridViewTextBoxColumn.Name = "allergiesDataGridViewTextBoxColumn";
            this.allergiesDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicalHistoryDataGridViewTextBoxColumn
            // 
            this.medicalHistoryDataGridViewTextBoxColumn.DataPropertyName = "Medical_History";
            this.medicalHistoryDataGridViewTextBoxColumn.HeaderText = "Medical_History";
            this.medicalHistoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicalHistoryDataGridViewTextBoxColumn.Name = "medicalHistoryDataGridViewTextBoxColumn";
            this.medicalHistoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // PatientL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PatientL";
            this.Size = new System.Drawing.Size(1322, 632);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appdatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientListTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivisionVillageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brgyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientListTBBindingSource;
        private System.Windows.Forms.BindingSource appdatasetBindingSource;
        private Appdataset appdataset;
        private AppdatasetTableAdapters.PatientList_TBTableAdapter patientList_TBTableAdapter;
    }
}
