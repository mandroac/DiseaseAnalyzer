using DiseaseAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseaseAnalyzer
{
    public partial class MedicalRecordsForm : Form
    {
        private Patient patient;
        DiseaseAnalyzerDBContext DBContext;

        public MedicalRecordsForm(int patient_ID, DiseaseAnalyzerDBContext dbcontext)
        {
            this.DBContext = dbcontext;
            this.patient = DBContext.Patients.First(ptnt => ptnt.Patient_ID == patient_ID);
            InitializeComponent();

        }

        private void MedicalRecordsForm_Load(object sender, EventArgs e)
        {
            foreach (var item in DBContext.MedicalRecords.Where(rc => rc.Patient_ID == patient.Patient_ID))
            {
                dataGridView1.Rows.Add(item.Record); 
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedGrid = dataGridView1[e.ColumnIndex, e.RowIndex];
            MessageBox.Show(selectedGrid.Value.ToString() ,"Медичний запис користувача");
        }
    }
}
