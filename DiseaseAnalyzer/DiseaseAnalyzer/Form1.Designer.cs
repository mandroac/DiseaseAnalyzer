
namespace DiseaseAnalyzer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SymptomsListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.symptomsDataGrid = new System.Windows.Forms.DataGridView();
            this.diseaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coughSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.throatingSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jawGlandSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rashSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vomittingSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earGlandSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headAcheSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chillsSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightFearSymptomValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diseaseAnalyzerDataSet = new DiseaseAnalyzer.DiseaseAnalyzerDataSet();
            this.diseasesTableAdapter = new DiseaseAnalyzer.DiseaseAnalyzerDataSetTableAdapters.DiseasesTableAdapter();
            this.diseaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseAnalyzerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SymptomsListBox
            // 
            this.SymptomsListBox.CheckOnClick = true;
            this.SymptomsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SymptomsListBox.FormattingEnabled = true;
            this.SymptomsListBox.Items.AddRange(new object[] {
            "Температура",
            "Нежить",
            "Кашель",
            "Біль у горлі",
            "Збільшення підчелюсних залоз",
            "Задишка",
            "Висипка",
            "Рвота",
            "Опухлість завушних залоз",
            "Біль у животі",
            "Розлади кишківника",
            "Пожовтіння шкіри",
            "Головний біль",
            "Озноб",
            "Страх світла"});
            this.SymptomsListBox.Location = new System.Drawing.Point(28, 52);
            this.SymptomsListBox.Name = "SymptomsListBox";
            this.SymptomsListBox.Size = new System.Drawing.Size(324, 340);
            this.SymptomsListBox.TabIndex = 0;
            this.SymptomsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SymptomsListBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Симптоми";
            // 
            // symptomsDataGrid
            // 
            this.symptomsDataGrid.AllowUserToAddRows = false;
            this.symptomsDataGrid.AllowUserToDeleteRows = false;
            this.symptomsDataGrid.AllowUserToOrderColumns = true;
            this.symptomsDataGrid.AutoGenerateColumns = false;
            this.symptomsDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.symptomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.symptomsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseNameDataGridViewTextBoxColumn,
            this.temperatureSymptomValueDataGridViewTextBoxColumn,
            this.coldSymptomValueDataGridViewTextBoxColumn,
            this.coughSymptomValueDataGridViewTextBoxColumn,
            this.throatingSymptomValueDataGridViewTextBoxColumn,
            this.jawGlandSymptomValueDataGridViewTextBoxColumn,
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn,
            this.rashSymptomValueDataGridViewTextBoxColumn,
            this.vomittingSymptomValueDataGridViewTextBoxColumn,
            this.earGlandSymptomValueDataGridViewTextBoxColumn,
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn,
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn,
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn,
            this.headAcheSymptomValueDataGridViewTextBoxColumn,
            this.chillsSymptomValueDataGridViewTextBoxColumn,
            this.lightFearSymptomValueDataGridViewTextBoxColumn});
            this.symptomsDataGrid.DataSource = this.diseasesBindingSource;
            this.symptomsDataGrid.GridColor = System.Drawing.SystemColors.Window;
            this.symptomsDataGrid.Location = new System.Drawing.Point(382, 52);
            this.symptomsDataGrid.Name = "symptomsDataGrid";
            this.symptomsDataGrid.ReadOnly = true;
            this.symptomsDataGrid.RowHeadersWidth = 51;
            this.symptomsDataGrid.RowTemplate.Height = 24;
            this.symptomsDataGrid.Size = new System.Drawing.Size(804, 320);
            this.symptomsDataGrid.TabIndex = 2;
            this.symptomsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.symptomsDataGrid_CellDoubleClick);
            // 
            // diseaseNameDataGridViewTextBoxColumn
            // 
            this.diseaseNameDataGridViewTextBoxColumn.DataPropertyName = "Disease_Name";
            this.diseaseNameDataGridViewTextBoxColumn.Frozen = true;
            this.diseaseNameDataGridViewTextBoxColumn.HeaderText = "Назва хвороби";
            this.diseaseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diseaseNameDataGridViewTextBoxColumn.Name = "diseaseNameDataGridViewTextBoxColumn";
            this.diseaseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // temperatureSymptomValueDataGridViewTextBoxColumn
            // 
            this.temperatureSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Temperature_Symptom_Value";
            this.temperatureSymptomValueDataGridViewTextBoxColumn.HeaderText = "Температура";
            this.temperatureSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperatureSymptomValueDataGridViewTextBoxColumn.Name = "temperatureSymptomValueDataGridViewTextBoxColumn";
            this.temperatureSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.temperatureSymptomValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // coldSymptomValueDataGridViewTextBoxColumn
            // 
            this.coldSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Cold_Symptom_Value";
            this.coldSymptomValueDataGridViewTextBoxColumn.HeaderText = "Нежить";
            this.coldSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coldSymptomValueDataGridViewTextBoxColumn.Name = "coldSymptomValueDataGridViewTextBoxColumn";
            this.coldSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.coldSymptomValueDataGridViewTextBoxColumn.Width = 60;
            // 
            // coughSymptomValueDataGridViewTextBoxColumn
            // 
            this.coughSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Cough_Symptom_Value";
            this.coughSymptomValueDataGridViewTextBoxColumn.HeaderText = "Кашель";
            this.coughSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coughSymptomValueDataGridViewTextBoxColumn.Name = "coughSymptomValueDataGridViewTextBoxColumn";
            this.coughSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.coughSymptomValueDataGridViewTextBoxColumn.Width = 60;
            // 
            // throatingSymptomValueDataGridViewTextBoxColumn
            // 
            this.throatingSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Throating_Symptom_Value";
            this.throatingSymptomValueDataGridViewTextBoxColumn.HeaderText = "Біль у горлі";
            this.throatingSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.throatingSymptomValueDataGridViewTextBoxColumn.Name = "throatingSymptomValueDataGridViewTextBoxColumn";
            this.throatingSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.throatingSymptomValueDataGridViewTextBoxColumn.Width = 80;
            // 
            // jawGlandSymptomValueDataGridViewTextBoxColumn
            // 
            this.jawGlandSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Jaw_Gland_Symptom_Value";
            this.jawGlandSymptomValueDataGridViewTextBoxColumn.HeaderText = "Збільшення підчелюсних залоз";
            this.jawGlandSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jawGlandSymptomValueDataGridViewTextBoxColumn.Name = "jawGlandSymptomValueDataGridViewTextBoxColumn";
            this.jawGlandSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.jawGlandSymptomValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // breathlessnessSymptomValueDataGridViewTextBoxColumn
            // 
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Breathlessness_Symptom_Value";
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn.HeaderText = "Задишка";
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn.Name = "breathlessnessSymptomValueDataGridViewTextBoxColumn";
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.breathlessnessSymptomValueDataGridViewTextBoxColumn.Width = 70;
            // 
            // rashSymptomValueDataGridViewTextBoxColumn
            // 
            this.rashSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Rash_Symptom_Value";
            this.rashSymptomValueDataGridViewTextBoxColumn.HeaderText = "Висипка";
            this.rashSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rashSymptomValueDataGridViewTextBoxColumn.Name = "rashSymptomValueDataGridViewTextBoxColumn";
            this.rashSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.rashSymptomValueDataGridViewTextBoxColumn.Width = 70;
            // 
            // vomittingSymptomValueDataGridViewTextBoxColumn
            // 
            this.vomittingSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Vomitting_Symptom_Value";
            this.vomittingSymptomValueDataGridViewTextBoxColumn.HeaderText = "Рвота";
            this.vomittingSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vomittingSymptomValueDataGridViewTextBoxColumn.Name = "vomittingSymptomValueDataGridViewTextBoxColumn";
            this.vomittingSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.vomittingSymptomValueDataGridViewTextBoxColumn.Width = 50;
            // 
            // earGlandSymptomValueDataGridViewTextBoxColumn
            // 
            this.earGlandSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Ear_Gland_Symptom_Value";
            this.earGlandSymptomValueDataGridViewTextBoxColumn.HeaderText = "Опухлість завушних залоз";
            this.earGlandSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.earGlandSymptomValueDataGridViewTextBoxColumn.Name = "earGlandSymptomValueDataGridViewTextBoxColumn";
            this.earGlandSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.earGlandSymptomValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // stomachAcheSymptomValueDataGridViewTextBoxColumn
            // 
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Stomach_Ache_Symptom_Value";
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn.HeaderText = "Біль у животі";
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn.Name = "stomachAcheSymptomValueDataGridViewTextBoxColumn";
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.stomachAcheSymptomValueDataGridViewTextBoxColumn.Width = 70;
            // 
            // intestineDisorderSymptomValueDataGridViewTextBoxColumn
            // 
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Intestine_Disorder_Symptom_Value";
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn.HeaderText = "Розлади кишківника";
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn.Name = "intestineDisorderSymptomValueDataGridViewTextBoxColumn";
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.intestineDisorderSymptomValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // yellolwishSkinSymptomValueDataGridViewTextBoxColumn
            // 
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Yellolwish_Skin_Symptom_Value";
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn.HeaderText = "Пожовтіння шкіри";
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn.Name = "yellolwishSkinSymptomValueDataGridViewTextBoxColumn";
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.yellolwishSkinSymptomValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // headAcheSymptomValueDataGridViewTextBoxColumn
            // 
            this.headAcheSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Head_Ache_Symptom_Value";
            this.headAcheSymptomValueDataGridViewTextBoxColumn.HeaderText = "Головний біль";
            this.headAcheSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.headAcheSymptomValueDataGridViewTextBoxColumn.Name = "headAcheSymptomValueDataGridViewTextBoxColumn";
            this.headAcheSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.headAcheSymptomValueDataGridViewTextBoxColumn.Width = 90;
            // 
            // chillsSymptomValueDataGridViewTextBoxColumn
            // 
            this.chillsSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Chills_Symptom_Value";
            this.chillsSymptomValueDataGridViewTextBoxColumn.HeaderText = "Озноб";
            this.chillsSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chillsSymptomValueDataGridViewTextBoxColumn.Name = "chillsSymptomValueDataGridViewTextBoxColumn";
            this.chillsSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.chillsSymptomValueDataGridViewTextBoxColumn.Width = 50;
            // 
            // lightFearSymptomValueDataGridViewTextBoxColumn
            // 
            this.lightFearSymptomValueDataGridViewTextBoxColumn.DataPropertyName = "Light_Fear_Symptom_Value";
            this.lightFearSymptomValueDataGridViewTextBoxColumn.HeaderText = "Страх світла";
            this.lightFearSymptomValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lightFearSymptomValueDataGridViewTextBoxColumn.Name = "lightFearSymptomValueDataGridViewTextBoxColumn";
            this.lightFearSymptomValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.lightFearSymptomValueDataGridViewTextBoxColumn.Width = 60;
            // 
            // diseasesBindingSource
            // 
            this.diseasesBindingSource.DataMember = "Diseases";
            this.diseasesBindingSource.DataSource = this.diseaseAnalyzerDataSet;
            // 
            // diseaseAnalyzerDataSet
            // 
            this.diseaseAnalyzerDataSet.DataSetName = "DiseaseAnalyzerDataSet";
            this.diseaseAnalyzerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diseasesTableAdapter
            // 
            this.diseasesTableAdapter.ClearBeforeFill = true;
            // 
            // diseaseChart
            // 
            chartArea5.Name = "ChartArea1";
            this.diseaseChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.diseaseChart.Legends.Add(legend5);
            this.diseaseChart.Location = new System.Drawing.Point(28, 424);
            this.diseaseChart.Name = "diseaseChart";
            this.diseaseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Вагові коефіцієнти";
            this.diseaseChart.Series.Add(series5);
            this.diseaseChart.Size = new System.Drawing.Size(1158, 399);
            this.diseaseChart.TabIndex = 4;
            this.diseaseChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(580, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вагові коефіцієнти кожної хвороби";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "* Двічі натисніть на назву хвороби щоб відкрити довідку";
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(915, 843);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(67, 17);
            this.patientLabel.TabIndex = 7;
            this.patientLabel.Text = "Пацієнт: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 829);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(412, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зберегти діагноз";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 829);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(412, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Переглянути історію хворіб";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 883);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diseaseChart);
            this.Controls.Add(this.symptomsDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SymptomsListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disease Analyzer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symptomsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseAnalyzerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SymptomsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView symptomsDataGrid;
        private DiseaseAnalyzerDataSet diseaseAnalyzerDataSet;
        private System.Windows.Forms.BindingSource diseasesBindingSource;
        private DiseaseAnalyzerDataSetTableAdapters.DiseasesTableAdapter diseasesTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart diseaseChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coughSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn throatingSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jawGlandSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breathlessnessSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rashSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vomittingSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earGlandSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stomachAcheSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intestineDisorderSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellolwishSkinSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headAcheSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chillsSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lightFearSymptomValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

