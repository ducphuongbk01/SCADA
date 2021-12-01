
namespace Final_Project
{
    partial class Device_Faceplate
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
            this.btCtrlPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReportPage = new System.Windows.Forms.Button();
            this.btTrendPage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCtrlPage
            // 
            this.btCtrlPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCtrlPage.Location = new System.Drawing.Point(0, 0);
            this.btCtrlPage.Name = "btCtrlPage";
            this.btCtrlPage.Size = new System.Drawing.Size(221, 30);
            this.btCtrlPage.TabIndex = 0;
            this.btCtrlPage.Text = "Control";
            this.btCtrlPage.UseVisualStyleBackColor = true;
            this.btCtrlPage.Click += new System.EventHandler(this.btCtrlPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btReportPage);
            this.panel1.Controls.Add(this.btTrendPage);
            this.panel1.Controls.Add(this.btCtrlPage);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 30);
            this.panel1.TabIndex = 1;
            // 
            // btReportPage
            // 
            this.btReportPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportPage.Location = new System.Drawing.Point(436, 0);
            this.btReportPage.Name = "btReportPage";
            this.btReportPage.Size = new System.Drawing.Size(220, 30);
            this.btReportPage.TabIndex = 2;
            this.btReportPage.Text = "Report";
            this.btReportPage.UseVisualStyleBackColor = true;
            this.btReportPage.Click += new System.EventHandler(this.btReportPage_Click);
            // 
            // btTrendPage
            // 
            this.btTrendPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrendPage.Location = new System.Drawing.Point(218, 0);
            this.btTrendPage.Name = "btTrendPage";
            this.btTrendPage.Size = new System.Drawing.Size(222, 30);
            this.btTrendPage.TabIndex = 1;
            this.btTrendPage.Text = "Trend";
            this.btTrendPage.UseVisualStyleBackColor = true;
            this.btTrendPage.Click += new System.EventHandler(this.btTrendPage_Click);
            // 
            // Device_Faceplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Device_Faceplate";
            this.Text = "Device_Faceplate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Device_Faceplate_FormClosing);
            this.Load += new System.EventHandler(this.Device_Faceplate_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCtrlPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btReportPage;
        private System.Windows.Forms.Button btTrendPage;
    }
}