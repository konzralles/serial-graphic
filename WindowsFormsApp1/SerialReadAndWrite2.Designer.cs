namespace WindowsFormsApp1
{
    partial class SerialReadAndWrite2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_portname = new System.Windows.Forms.Label();
            this.lbl_baundrate = new System.Windows.Forms.Label();
            this.tb_maxDataCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_applyMaxDataCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1423, 346);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lbl_portname
            // 
            this.lbl_portname.AutoSize = true;
            this.lbl_portname.Location = new System.Drawing.Point(9, 361);
            this.lbl_portname.Name = "lbl_portname";
            this.lbl_portname.Size = new System.Drawing.Size(37, 13);
            this.lbl_portname.TabIndex = 1;
            this.lbl_portname.Text = "COM?";
            // 
            // lbl_baundrate
            // 
            this.lbl_baundrate.AutoSize = true;
            this.lbl_baundrate.Location = new System.Drawing.Point(9, 374);
            this.lbl_baundrate.Name = "lbl_baundrate";
            this.lbl_baundrate.Size = new System.Drawing.Size(62, 13);
            this.lbl_baundrate.TabIndex = 1;
            this.lbl_baundrate.Text = "Baundrate?";
            // 
            // tb_maxDataCount
            // 
            this.tb_maxDataCount.Location = new System.Drawing.Point(123, 384);
            this.tb_maxDataCount.Name = "tb_maxDataCount";
            this.tb_maxDataCount.Size = new System.Drawing.Size(100, 20);
            this.tb_maxDataCount.TabIndex = 2;
            this.tb_maxDataCount.Text = "360000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MaxRecordingData";
            // 
            // btn_applyMaxDataCount
            // 
            this.btn_applyMaxDataCount.Location = new System.Drawing.Point(229, 384);
            this.btn_applyMaxDataCount.Name = "btn_applyMaxDataCount";
            this.btn_applyMaxDataCount.Size = new System.Drawing.Size(30, 20);
            this.btn_applyMaxDataCount.TabIndex = 4;
            this.btn_applyMaxDataCount.Text = "OK";
            this.btn_applyMaxDataCount.UseVisualStyleBackColor = true;
            this.btn_applyMaxDataCount.Click += new System.EventHandler(this.btn_applyMaxDataCount_Click);
            // 
            // SerialReadAndWrite2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 620);
            this.Controls.Add(this.btn_applyMaxDataCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_maxDataCount);
            this.Controls.Add(this.lbl_baundrate);
            this.Controls.Add(this.lbl_portname);
            this.Controls.Add(this.chart1);
            this.Name = "SerialReadAndWrite2";
            this.Text = "SerialReadAndWrite2";
            this.Load += new System.EventHandler(this.SerialReadAndWrite2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_portname;
        private System.Windows.Forms.Label lbl_baundrate;
        private System.Windows.Forms.TextBox tb_maxDataCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_applyMaxDataCount;
    }
}