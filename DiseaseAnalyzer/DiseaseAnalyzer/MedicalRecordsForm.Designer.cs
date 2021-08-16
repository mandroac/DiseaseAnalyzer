
namespace DiseaseAnalyzer
{
    partial class MedicalRecordsForm
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
            this.components = new System.ComponentModel.Container();
            this.diseaseAnalyzerDataSet1 = new DiseaseAnalyzer.DiseaseAnalyzerDataSet1();
            this.medicalRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalRecordsTableAdapter = new DiseaseAnalyzer.DiseaseAnalyzerDataSet1TableAdapters.MedicalRecordsTableAdapter();
            this.diseaseAnalyzerDataSet2 = new DiseaseAnalyzer.DiseaseAnalyzerDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Records = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseAnalyzerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseAnalyzerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // diseaseAnalyzerDataSet1
            // 
            this.diseaseAnalyzerDataSet1.DataSetName = "DiseaseAnalyzerDataSet1";
            this.diseaseAnalyzerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalRecordsBindingSource
            // 
            this.medicalRecordsBindingSource.DataMember = "MedicalRecords";
            this.medicalRecordsBindingSource.DataSource = this.diseaseAnalyzerDataSet1;
            // 
            // medicalRecordsTableAdapter
            // 
            this.medicalRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // diseaseAnalyzerDataSet2
            // 
            this.diseaseAnalyzerDataSet2.DataSetName = "DiseaseAnalyzerDataSet";
            this.diseaseAnalyzerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Records});
            this.dataGridView1.Location = new System.Drawing.Point(48, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Records
            // 
            this.Records.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Records.HeaderText = "Медичні записи";
            this.Records.MinimumWidth = 6;
            this.Records.Name = "Records";
            this.Records.ReadOnly = true;
            // 
            // MedicalRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 430);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MedicalRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiseaseAnalyzer";
            this.Load += new System.EventHandler(this.MedicalRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diseaseAnalyzerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseAnalyzerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DiseaseAnalyzerDataSet1 diseaseAnalyzerDataSet1;
        private System.Windows.Forms.BindingSource medicalRecordsBindingSource;
        private DiseaseAnalyzerDataSet1TableAdapters.MedicalRecordsTableAdapter medicalRecordsTableAdapter;
        private DiseaseAnalyzerDataSet diseaseAnalyzerDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Records;
    }
}