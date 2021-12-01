using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;

namespace Final_Project
{
    public partial class TrendPage : UserControl
    {
        Device Parent;
        kayChart stateData, faultData;
        public TrendPage(Device parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private double getState()
        {
            if(Parent.RunFeedback)
            {
                lbState.Invoke((MethodInvoker)(() => lbState.Text = "ON"));
                lbGraph.Invoke((MethodInvoker)(() => lbGraph.Text = "ON"));
            }
            else if(Parent.Fault)
            {
                lbState.Invoke((MethodInvoker)(() => lbState.Text = "Fault"));
                lbGraph.Invoke((MethodInvoker)(() => lbGraph.Text = "Fault"));
            }
            else
            {
                lbState.Invoke((MethodInvoker)(() => lbState.Text = "OFF"));
                lbGraph.Invoke((MethodInvoker)(() => lbGraph.Text = "ON"));
            }

            return Convert.ToDouble(Parent.RunFeedback);
        }

        private double getFault()
        {
            return Convert.ToDouble(Parent.Fault);
        }

        private void TrendPage_Load(object sender, EventArgs e)
        {
            stateData = new kayChart(cTrend, 500);
            stateData.serieName = "State";
            faultData = new kayChart(cTrend, 500);
            faultData.serieName = "Fault";
            Task.Factory.StartNew(() =>
            {
                stateData.updateChart(getState, 500);
            });
            Task.Factory.StartNew(() =>
            {
                faultData.updateChart(getFault, 500);
            });
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(Parent.RunFeedback);
            Console.WriteLine(Parent.Fault);
            UpdateTimer.Stop();
        }
    }
}
