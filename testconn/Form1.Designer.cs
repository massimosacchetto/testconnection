
namespace testconn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.IP1 = new System.Windows.Forms.TextBox();
            this.IP2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stop_ping = new System.Windows.Forms.Button();
            this.output_a = new System.Windows.Forms.ListBox();
            this.output_b = new System.Windows.Forms.ListBox();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(38, 21);
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(158, 22);
            this.IP1.TabIndex = 0;
            this.IP1.Text = "8.8.8.8";
            // 
            // IP2
            // 
            this.IP2.Location = new System.Drawing.Point(202, 21);
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(158, 22);
            this.IP2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop_ping
            // 
            this.stop_ping.Location = new System.Drawing.Point(366, 77);
            this.stop_ping.Name = "stop_ping";
            this.stop_ping.Size = new System.Drawing.Size(75, 50);
            this.stop_ping.TabIndex = 3;
            this.stop_ping.Text = "Stop";
            this.stop_ping.UseVisualStyleBackColor = true;
            this.stop_ping.Click += new System.EventHandler(this.start_ping_Click);
            // 
            // output_a
            // 
            this.output_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_a.FormattingEnabled = true;
            this.output_a.ItemHeight = 16;
            this.output_a.Location = new System.Drawing.Point(38, 49);
            this.output_a.Name = "output_a";
            this.output_a.Size = new System.Drawing.Size(158, 338);
            this.output_a.TabIndex = 4;
            // 
            // output_b
            // 
            this.output_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_b.FormattingEnabled = true;
            this.output_b.ItemHeight = 16;
            this.output_b.Location = new System.Drawing.Point(202, 49);
            this.output_b.Name = "output_b";
            this.output_b.Size = new System.Drawing.Size(158, 338);
            this.output_b.TabIndex = 5;
            // 
            // timerPing
            // 
            this.timerPing.Interval = 1000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(447, 45);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(452, 159);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "IP Address 2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(199, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP Address 2";
            // 
            // chart2
            // 
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(447, 228);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(452, 159);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "IP Address 2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(444, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "IP Address 2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(444, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "IP Address 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.output_b);
            this.Controls.Add(this.output_a);
            this.Controls.Add(this.stop_ping);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.IP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "testconnection";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP1;
        private System.Windows.Forms.TextBox IP2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stop_ping;
        private System.Windows.Forms.ListBox output_a;
        private System.Windows.Forms.ListBox output_b;
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

