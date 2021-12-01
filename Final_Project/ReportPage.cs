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
    public partial class ReportPage : UserControl
    {
        bool last_sate = false;
        bool last_fault = false;
        UInt32 num_product = 0;
        Int32 index = 0;
        Int32 level_past = 0;
        public DataTable table;
        Device Parent;
        public ReportPage(Device parent)
        {
            Parent = parent;
            table = new DataTable("table");
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Time", Type.GetType("System.String"));
            table.Columns.Add("Mode", Type.GetType("System.String"));
            table.Columns.Add("Start/Stop", Type.GetType("System.String"));
            table.Columns.Add("Fault", Type.GetType("System.String"));
            table.Columns.Add("Number of Products", Type.GetType("System.UInt32"));
            InitializeComponent();
            UpdateTimer.Start();
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = table;
            last_sate = Parent.RunFeedback;
            last_fault = Parent.Fault;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (Parent.Fault && !last_fault)
            {
                index += 1;
                string state = (Parent.RunFeedback) ? "Start" : "Stop";
                string fault = (Parent.Fault) ? "Fault" : "NOT";
                table.Rows.Add(index, DateTime.Now.ToString(), Parent.Mode.ToString(), state, fault, num_product);
            }
            else if ((Parent.Name == "Valve_3_1") || (Parent.Name == "Valve_3_2"))
            {
                if (last_sate && (!Parent.RunFeedback))
                {
                    num_product += 1;
                    index += 1;
                    string state = (Parent.RunFeedback) ? "Start" : "Stop";
                    string fault = (Parent.Fault) ? "Fault" : "NOT";
                    table.Rows.Add(index, DateTime.Now.ToString(), Parent.Mode.ToString(), state, fault, num_product);
                }
                else if (last_sate != Parent.RunFeedback)
                {
                    index += 1;
                    string state = (Parent.RunFeedback) ? "Start" : "Stop";
                    string fault = (Parent.Fault) ? "Fault" : "NOT";
                    table.Rows.Add(index, DateTime.Now.ToString(), Parent.Mode.ToString(), state, fault, num_product);
                }
            }
            else if (last_sate != Parent.RunFeedback)
            {
                index += 1;
                string state = (Parent.RunFeedback) ? "Start" : "Stop";
                string fault = (Parent.Fault) ? "Fault" : "NOT";
                table.Rows.Add(index, DateTime.Now.ToString(), Parent.Mode.ToString(), state, fault, num_product);
            }

            last_sate = Parent.RunFeedback;
            last_fault = Parent.Fault;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dgvTable.AllowUserToAddRows = false;
            try
            {
                while (dgvTable.Rows.Count > 1)
                {
                    dgvTable.Rows.RemoveAt(dgvTable.Rows.Count - 1);
                }
            }
            finally
            {
                dgvTable.AllowUserToAddRows = true;
            }

            try
            {
                table.Rows.Clear();
                index = 0;
                num_product = 0;
            }
            catch
            {
                MessageBox.Show("Cannot clear the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
