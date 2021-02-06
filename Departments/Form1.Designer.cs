
namespace Departments
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.table = new System.Windows.Forms.DataGridView();
            this.deptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(12, 12);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(160, 25);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "Load file...";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(329, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(244, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Department Database";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos CSV(*.csv)|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptCode,
            this.deptName,
            this.munCode,
            this.munName,
            this.munType});
            this.table.Location = new System.Drawing.Point(185, 51);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(544, 174);
            this.table.TabIndex = 2;
            // 
            // deptCode
            // 
            this.deptCode.HeaderText = "Department Code";
            this.deptCode.Name = "deptCode";
            this.deptCode.ReadOnly = true;
            // 
            // deptName
            // 
            this.deptName.HeaderText = "Department";
            this.deptName.Name = "deptName";
            this.deptName.ReadOnly = true;
            // 
            // munCode
            // 
            this.munCode.HeaderText = "Municipality Code";
            this.munCode.Name = "munCode";
            this.munCode.ReadOnly = true;
            // 
            // munName
            // 
            this.munName.HeaderText = "Municipality";
            this.munName.Name = "munName";
            this.munName.ReadOnly = true;
            // 
            // munType
            // 
            this.munType.HeaderText = "Type";
            this.munType.Name = "munType";
            this.munType.ReadOnly = true;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox.Location = new System.Drawing.Point(726, 16);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.Text = "Choose letter...";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(302, 231);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(324, 262);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // graphButton
            // 
            this.graphButton.Enabled = false;
            this.graphButton.Location = new System.Drawing.Point(12, 43);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(160, 25);
            this.graphButton.TabIndex = 5;
            this.graphButton.Text = "Generate graph...";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 522);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.table);
            this.Controls.Add(this.title);
            this.Controls.Add(this.loadFileButton);
            this.Name = "Form1";
            this.Text = "Department Database";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn munCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn munName;
        private System.Windows.Forms.DataGridViewTextBoxColumn munType;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button graphButton;
    }
}

