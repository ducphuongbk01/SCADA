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
    public partial class ControlPage : UserControl
    {
        Image btGreen_press = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\btgreen_press.wmf");
        Image btGreen_unpress = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\btgreen_unpress.wmf");

        Image btRed_press = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\btred_press.wmf");
        Image btRed_unpress = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\btred_unpress.wmf");

        Image btYellow_press = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\btyellow_press.wmf");
        Image btYellow_unpress = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\btyellow_unpress.wmf");

        Image light_green = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\light_green.wmf");
        Image light_yellow = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\light_yellow.wmf");
        Image light_gray = Image.FromFile(@"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\light_gray.wmf");

        Device Parent;
        public ControlPage(Device parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void pbStart_MouseDown(object sender, MouseEventArgs e)
        {
            pbStart.BackgroundImage = btGreen_press;
            pbStart.BackColor = Color.Transparent;
            pbStart.BackgroundImageLayout = ImageLayout.Stretch;

            set_StateAllButton(false);
            if (Parent.Parent.S71500.thePLC.IsConnected)
            {
                Parent.write_Control("Start", true);
            }
            else
                MessageBox.Show("Cannot connect to PLC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            set_StateAllButton(true);
        }

        private void pbStart_MouseUp(object sender, MouseEventArgs e)
        {
            pbStart.BackgroundImage = btGreen_unpress;
            pbStart.BackColor = Color.Transparent;
            pbStart.BackgroundImageLayout = ImageLayout.Stretch;

            set_StateAllButton(false);
            if (Parent.Parent.S71500.thePLC.IsConnected)
            {
                Parent.write_Control("Start", false);
            }
            else
                MessageBox.Show("Cannot connect to PLC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            set_StateAllButton(true);           
        }

        private void pbStop_MouseDown(object sender, MouseEventArgs e)
        {
            pbStop.BackgroundImage = btRed_press;
            pbStop.BackColor = Color.Transparent;
            pbStop.BackgroundImageLayout = ImageLayout.Stretch;

            set_StateAllButton(false);
            if (Parent.Parent.S71500.thePLC.IsConnected)
            {
                Parent.write_Control("Stop", true);
            }
            else
                MessageBox.Show("Cannot connect to PLC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            set_StateAllButton(true);           
        }

        private void pbStop_MouseUp(object sender, MouseEventArgs e)
        {
            pbStop.BackgroundImage = btRed_unpress;
            pbStop.BackColor = Color.Transparent;
            pbStop.BackgroundImageLayout = ImageLayout.Stretch;

            set_StateAllButton(false);
            if (Parent.Parent.S71500.thePLC.IsConnected)
            {
                Parent.write_Control("Stop", false);
            }
            else
                MessageBox.Show("Cannot connect to PLC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            set_StateAllButton(true);
        }

        private void pbReset_MouseDown(object sender, MouseEventArgs e)
        {
            pbReset.BackgroundImage = btYellow_press;
            pbReset.BackColor = Color.Transparent;
            pbReset.BackgroundImageLayout = ImageLayout.Stretch;

            set_StateAllButton(false);
            if (Parent.Parent.S71500.thePLC.IsConnected)
            {
                Parent.write_Control("Reset", true);
            }
            else
                MessageBox.Show("Cannot connect to PLC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            set_StateAllButton(true);
        }

        private void pbReset_MouseUp(object sender, MouseEventArgs e)
        {
            pbReset.BackgroundImage = btYellow_unpress;
            pbReset.BackColor = Color.Transparent;
            pbReset.BackgroundImageLayout = ImageLayout.Stretch;

            set_StateAllButton(false);
            if (Parent.Parent.S71500.thePLC.IsConnected)
            {
                Parent.write_Control("Reset", false);
            }
            else
                MessageBox.Show("Cannot connect to PLC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            set_StateAllButton(true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_StateAllButton(false);
            if (Parent.Parent.S71500.thePLC.IsConnected)
            {
                Parent.write_Control("Mode", Int16.Parse(cbMode.Text));
            }
            else
                MessageBox.Show("Cannot connect to PLC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            set_StateAllButton(true);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (Parent.RunFeedback)
            {
                pnRFB.BackgroundImage = light_green;
                pnRFB.BackColor = Color.Transparent;
                pnRFB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pnRFB.BackgroundImage = light_gray;
                pnRFB.BackColor = Color.Transparent;
                pnRFB.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (Parent.Fault)
            {
                pbFault.BackgroundImage = light_yellow;
                pbFault.BackColor = Color.Transparent;
                pbFault.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbFault.BackgroundImage = light_gray;
                pbFault.BackColor = Color.Transparent;
                pbFault.BackgroundImageLayout = ImageLayout.Stretch;
            }

            lbCurmode.Text = Parent.Mode.ToString();
        }

        private void ControlPage_Load(object sender, EventArgs e)
        {
            cbMode.Text = Parent.Mode.ToString();
            UpdateTimer.Start();
        }

        private void set_StateAllButton(bool state)
        {
            pbStart.Enabled = state;
            pbStop.Enabled = state;
            pbReset.Enabled = state;
            cbMode.Enabled = state;
            UpdateTimer.Enabled = state;
        }
    }
}
