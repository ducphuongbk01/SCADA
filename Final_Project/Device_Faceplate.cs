using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Device_Faceplate : Form
    {
        Device Parent;
        public ControlPage ctrlPage;
        public TrendPage trPage;
        public ReportPage rpPage;
        public Device_Faceplate(Device parent)
        {
            Parent = parent;

            ctrlPage = new ControlPage(parent);
            ctrlPage.Size = new Size(656, 433);
            ctrlPage.Location = new Point(3, 36);

            trPage = new TrendPage(parent);
            trPage.Size = new Size(656, 433);
            trPage.Location = new Point(3, 36);

            rpPage = new ReportPage(parent);
            rpPage.Size = new Size(656, 433);
            rpPage.Location = new Point(3, 36);

            this.Controls.Add(ctrlPage);
            this.Controls.Add(trPage);
            this.Controls.Add(rpPage);

            InitializeComponent();
        }

        private void Device_Faceplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.reset_Faceplate_State();
            this.Hide();
            e.Cancel = true;
        }

        private void btCtrlPage_Click(object sender, EventArgs e)
        {
            ctrlPage.Show();
            ctrlPage.BringToFront();
            trPage.Hide();
            rpPage.Hide();
            state_Color("ControlPage");
        }

        private void btTrendPage_Click(object sender, EventArgs e)
        {
            trPage.Show();
            trPage.BringToFront();
            rpPage.Hide();
            ctrlPage.Hide();
            state_Color("TrendPage");
        }

        private void btReportPage_Click(object sender, EventArgs e)
        {
            rpPage.Show();
            rpPage.BringToFront();
            trPage.Hide();
            ctrlPage.Hide();
            state_Color("ReportPage");
        }

        private void state_Color(string state_page)
        {
            if (state_page == "ControlPage")
            {
                btCtrlPage.BackColor = Color.LimeGreen;
                btTrendPage.BackColor = Color.Gainsboro;
                btReportPage.BackColor = Color.Gainsboro;
                btCtrlPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                btTrendPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                btReportPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
            else if (state_page == "TrendPage")
            {
                btTrendPage.BackColor = Color.LimeGreen;
                btCtrlPage.BackColor = Color.Gainsboro;
                btReportPage.BackColor = Color.Gainsboro;
                btTrendPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                btCtrlPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                btReportPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
            else
            {
                btReportPage.BackColor = Color.LimeGreen;
                btCtrlPage.BackColor = Color.Gainsboro;
                btTrendPage.BackColor = Color.Gainsboro;
                btReportPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                btCtrlPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                btTrendPage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
        }

        private void Device_Faceplate_Load(object sender, EventArgs e)
        {
            ctrlPage.Show();
            ctrlPage.BringToFront();
            trPage.Hide();
            state_Color("ControlPage");
        }
    }
}
