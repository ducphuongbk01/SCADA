
namespace Final_Project
{
    partial class ControlPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPage));
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbReset = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnRFB = new System.Windows.Forms.Panel();
            this.pbFault = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbCurmode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).BeginInit();
            this.pnRFB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFault)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStart
            // 
            this.pbStart.BackColor = System.Drawing.Color.Transparent;
            this.pbStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStart.BackgroundImage")));
            this.pbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStart.Location = new System.Drawing.Point(75, 109);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(82, 74);
            this.pbStart.TabIndex = 0;
            this.pbStart.TabStop = false;
            this.pbStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseDown);
            this.pbStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseUp);
            // 
            // pbStop
            // 
            this.pbStop.BackColor = System.Drawing.Color.Transparent;
            this.pbStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStop.BackgroundImage")));
            this.pbStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStop.Location = new System.Drawing.Point(75, 216);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(82, 74);
            this.pbStop.TabIndex = 1;
            this.pbStop.TabStop = false;
            this.pbStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStop_MouseDown);
            this.pbStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbStop_MouseUp);
            // 
            // pbReset
            // 
            this.pbReset.BackColor = System.Drawing.Color.Transparent;
            this.pbReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReset.BackgroundImage")));
            this.pbReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReset.Location = new System.Drawing.Point(75, 323);
            this.pbReset.Name = "pbReset";
            this.pbReset.Size = new System.Drawing.Size(82, 74);
            this.pbReset.TabIndex = 2;
            this.pbReset.TabStop = false;
            this.pbReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbReset_MouseDown);
            this.pbReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbReset_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "START";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "STOP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "RESET";
            // 
            // pnRFB
            // 
            this.pnRFB.BackColor = System.Drawing.Color.Transparent;
            this.pnRFB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnRFB.BackgroundImage")));
            this.pnRFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnRFB.Controls.Add(this.pbFault);
            this.pnRFB.Location = new System.Drawing.Point(369, 170);
            this.pnRFB.Name = "pnRFB";
            this.pnRFB.Size = new System.Drawing.Size(200, 184);
            this.pnRFB.TabIndex = 6;
            // 
            // pbFault
            // 
            this.pbFault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFault.BackgroundImage")));
            this.pbFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFault.Location = new System.Drawing.Point(147, 135);
            this.pbFault.Name = "pbFault";
            this.pbFault.Size = new System.Drawing.Size(52, 49);
            this.pbFault.TabIndex = 0;
            this.pbFault.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(365, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "STATE";
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbMode.Location = new System.Drawing.Point(75, 58);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(129, 21);
            this.cbMode.TabIndex = 9;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "SETTING MODE";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 500;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "CURRENT MODE";
            // 
            // lbCurmode
            // 
            this.lbCurmode.AutoSize = true;
            this.lbCurmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurmode.Location = new System.Drawing.Point(351, 58);
            this.lbCurmode.Name = "lbCurmode";
            this.lbCurmode.Size = new System.Drawing.Size(63, 24);
            this.lbCurmode.TabIndex = 12;
            this.lbCurmode.Text = "mode";
            // 
            // ControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCurmode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnRFB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbReset);
            this.Controls.Add(this.pbStop);
            this.Controls.Add(this.pbStart);
            this.Name = "ControlPage";
            this.Size = new System.Drawing.Size(656, 433);
            this.Load += new System.EventHandler(this.ControlPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).EndInit();
            this.pnRFB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.PictureBox pbReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnRFB;
        private System.Windows.Forms.PictureBox pbFault;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCurmode;
    }
}
