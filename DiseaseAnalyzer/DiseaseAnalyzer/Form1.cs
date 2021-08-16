using DiseaseAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseaseAnalyzer
{
    public partial class Form1 : Form
    {
        DiseaseAnalyzerDBContext DBContext = new DiseaseAnalyzerDBContext();
        Dictionary<string, int> DiseaseCoefficients = new Dictionary<string, int>();

        private Patient patient;
        public Form1(int patient_ID)
        {
            InitializeComponent();
            this.patient = DBContext.Patients.First(ptnt => ptnt.Patient_ID == patient_ID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.diseasesTableAdapter.Fill(this.diseaseAnalyzerDataSet.Diseases);
            foreach (var item in DBContext.Diseases)
            {
                DiseaseCoefficients.Add(item.Disease_Name, 0);
            }
            Update_Chart();
            diseaseChart.ChartAreas[0].AxisY.Maximum = 100;

            patientLabel.Text += patient.FullName;
        }

        private void SymptomsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string checkedItemLabel = SymptomsListBox.Items[e.Index].ToString();
            int colIndex = 15, multiplier;

            if (e.NewValue == CheckState.Checked) multiplier = 1;
            else multiplier = -1;
            
            
            for (var it = symptomsDataGrid.Columns.GetFirstColumn(DataGridViewElementStates.None); 
                it != symptomsDataGrid.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None); 
                it = symptomsDataGrid.Columns.GetNextColumn(it, DataGridViewElementStates.None, DataGridViewElementStates.None))
            {
                if (checkedItemLabel == it.HeaderText) colIndex = it.Index;   
            }


            switch (colIndex)
            {
                case 1:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Temperature_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Temperature_Symptom_Value;
                    }
                    break;
                case 2:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Cold_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Cold_Symptom_Value;
                    }
                    break;
                case 3:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Cough_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Cough_Symptom_Value;
                    }
                    break;
                case 4:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Throating_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Throating_Symptom_Value;
                    }
                    break;
                case 5:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Jaw_Gland_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Jaw_Gland_Symptom_Value;
                    }
                    break;
                case 6:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Breathlessness_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Breathlessness_Symptom_Value;
                    }
                    break;
                case 7:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Rash_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Rash_Symptom_Value;
                    }
                    break;
                case 8:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Vomitting_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Vomitting_Symptom_Value;
                    }
                    break;

                case 9:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Ear_Gland_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Ear_Gland_Symptom_Value;
                    }
                    break;
                case 10:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Stomach_Ache_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Stomach_Ache_Symptom_Value;
                    }
                    break;
                case 11:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Intestine_Disorder_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Intestine_Disorder_Symptom_Value;
                    }
                    break;
                case 12:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Yellolwish_Skin_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Yellolwish_Skin_Symptom_Value;
                    }
                    break;
                case 13:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Head_Ache_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Head_Ache_Symptom_Value;
                    }
                    break;
                case 14:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Chills_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Chills_Symptom_Value;
                    }
                    break;
                case 15:
                    foreach (var item in DBContext.Diseases.Where(temp => temp.Light_Fear_Symptom_Value != null))
                    {
                        DiseaseCoefficients[item.Disease_Name] += multiplier * (int)item.Light_Fear_Symptom_Value;
                    }
                    break;
            }

            Update_Chart();
        }

        private void Update_Chart()
        {
            diseaseChart.Series["Вагові коефіцієнти"].Points.Clear();
            foreach (var item in DiseaseCoefficients)
            {
                diseaseChart.Series["Вагові коефіцієнти"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void symptomsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                var selectedGrid = symptomsDataGrid[e.ColumnIndex, e.RowIndex];
                MessageBox.Show(DBContext.Diseases.First(item => item.Disease_Name == selectedGrid.Value.ToString()).Disease_Description, selectedGrid.Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "Діагноз пацієнта " + patient.FullName + " станом на " + DateTime.Now + ": \n\n";
            Boolean isSick = false;

            foreach (var key in DiseaseCoefficients.Keys)
            {
                if (DiseaseCoefficients[key] == 100)
                {
                    result += "ВИЯВЛЕНА ХВОРОБА  '" + key + "'. Терміново зверніться до лікаря!\n\n";
                    isSick = true;
                }
                else if (DiseaseCoefficients[key] > 59 && DiseaseCoefficients[key] <= 99)
                {
                    result += "Висока ймовірність захворювання на '" + key + "'. Будь ласка зверніться до лікаря для більш детального обстеження.\n\n";
                    isSick = true;
                }
                else if (DiseaseCoefficients[key] > 36 && DiseaseCoefficients[key] <= 59)
                {
                    result += "Виявлені некритичні ознаки захворювання на '" + key + "'. Будь ласка зверніться до лікаря якщо протягом наступних 2-3 днів самопочуття погіршиться.\n\n";
                    isSick = true;
                }
            }

            if (!isSick)
            {
                result += "Вітаємо! Ви відносно здорові.";
            }

            try
            {
                DBContext.MedicalRecords.Add(new MedicalRecord() { Patient = this.patient, Patient_ID = patient.Patient_ID, Record = result });
                DBContext.SaveChanges();
                MessageBox.Show("Запис успішно збережено!", "Успіх!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка від сервера: " + ex.Message, "Упс... Щось не так.");
                return;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicalRecordsForm mrf = new MedicalRecordsForm(patient.Patient_ID, DBContext);
            mrf.ShowDialog();
        }
    }
}
