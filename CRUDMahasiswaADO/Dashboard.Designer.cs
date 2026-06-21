namespace CRUDMahasiswaADO
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadDataChart = new System.Windows.Forms.Button();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            this.btnDataMhs = new System.Windows.Forms.Button();
            this.chartProdi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "REKAP DATA MAHASISWA";
            // 
            // LoadDataChart
            // 
            this.LoadDataChart.Location = new System.Drawing.Point(390, 68);
            this.LoadDataChart.Name = "LoadDataChart";
            this.LoadDataChart.Size = new System.Drawing.Size(100, 26);
            this.LoadDataChart.TabIndex = 8;
            this.LoadDataChart.Text = "Load";
            this.LoadDataChart.UseVisualStyleBackColor = true;
            this.LoadDataChart.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(184, 68);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalMasuk.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tanggal Masuk";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(496, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 26);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbTipe
            // 
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Location = new System.Drawing.Point(669, 65);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(106, 28);
            this.cmbTipe.TabIndex = 10;
            this.cmbTipe.SelectedIndexChanged += new System.EventHandler(this.cmbTipe_SelectedIndexChanged);
            // 
            // btnDataMhs
            // 
            this.btnDataMhs.Location = new System.Drawing.Point(635, 403);
            this.btnDataMhs.Name = "btnDataMhs";
            this.btnDataMhs.Size = new System.Drawing.Size(137, 35);
            this.btnDataMhs.TabIndex = 11;
            this.btnDataMhs.Text = "Data Mahasiswa";
            this.btnDataMhs.UseVisualStyleBackColor = true;
            this.btnDataMhs.Click += new System.EventHandler(this.btnDataMhs_Click);
            // 
            // chartProdi
            // 
            chartArea3.Name = "ChartArea1";
            this.chartProdi.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProdi.Legends.Add(legend3);
            this.chartProdi.Location = new System.Drawing.Point(49, 118);
            this.chartProdi.Name = "chartProdi";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartProdi.Series.Add(series3);
            this.chartProdi.Size = new System.Drawing.Size(723, 279);
            this.chartProdi.TabIndex = 12;
            this.chartProdi.Text = "chart1";
            this.chartProdi.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartProdi);
            this.Controls.Add(this.btnDataMhs);
            this.Controls.Add(this.cmbTipe);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.LoadDataChart);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadDataChart;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbTipe;
        private System.Windows.Forms.Button btnDataMhs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdi;
    }
}