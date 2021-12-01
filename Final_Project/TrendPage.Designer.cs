
namespace Final_Project
{
    partial class TrendPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.lbGraph = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cTrend)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTrend
            // 
            this.cTrend.BackColor = System.Drawing.Color.Transparent;
            customLabel1.Text = "OFF";
            customLabel2.FromPosition = 1D;
            customLabel2.Text = "ON";
            customLabel2.ToPosition = 1D;
            chartArea1.AxisY.CustomLabels.Add(customLabel1);
            chartArea1.AxisY.CustomLabels.Add(customLabel2);
            chartArea1.Name = "ChartArea1";
            this.cTrend.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cTrend.Legends.Add(legend1);
            this.cTrend.Location = new System.Drawing.Point(3, 3);
            this.cTrend.Name = "cTrend";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "State";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Fault";
            this.cTrend.Series.Add(series1);
            this.cTrend.Series.Add(series2);
            this.cTrend.Size = new System.Drawing.Size(650, 333);
            this.cTrend.TabIndex = 0;
            this.cTrend.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "State Trend";
            this.cTrend.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbState);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(119, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 52);
            this.panel1.TabIndex = 5;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(195, 9);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(92, 31);
            this.lbState.TabIndex = 4;
            this.lbState.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Sate:";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // lbGraph
            // 
            this.lbGraph.AutoSize = true;
            this.lbGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGraph.Location = new System.Drawing.Point(16, 75);
            this.lbGraph.Name = "lbGraph";
            this.lbGraph.Size = new System.Drawing.Size(30, 16);
            this.lbGraph.TabIndex = 6;
            this.lbGraph.Text = "ON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "OFF";
            // 
            // TrendPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGraph);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cTrend);
            this.Name = "TrendPage";
            this.Size = new System.Drawing.Size(656, 433);
            this.Load += new System.EventHandler(this.TrendPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cTrend)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cTrend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbGraph;
        private System.Windows.Forms.Label label3;
    }
}
