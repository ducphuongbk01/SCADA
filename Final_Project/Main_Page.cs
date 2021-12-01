using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Final_Project
{
    public partial class Main_Page : Form
    {
        public bool state_Motor_1_1 = false;
        public bool state_Motor_1_2 = false;
        public bool state_Motor_2_1 = false;
        public bool state_Motor_2_2 = false;
        public bool state_Motor_A = false;
        public bool state_Valve_3_1 = false;
        public bool state_Valve_3_2 = false;
        static string root_path = @"E:\VisualStudioProject\SCADA\FinalProject\Final_Project\Final_Project\Images\";

        Image pump_gray = Image.FromFile(root_path + "pump_gray.wmf");
        Image pump_green = Image.FromFile(root_path + "pump_green.wmf");
        Image pump_red = Image.FromFile(root_path + "pump_red.wmf");

        Image valve_gray = Image.FromFile(root_path + "valve_gray.wmf");
        Image valve_green = Image.FromFile(root_path + "valve_green.wmf");
        Image valve_red = Image.FromFile(root_path + "valve_red.wmf");

        Image mixer_gray = Image.FromFile(root_path + "mixer_gray.wmf");
        Image mixer_green = Image.FromFile(root_path + "mixer_green.wmf");
        Image mixer_red = Image.FromFile(root_path + "mixer_red.wmf");

        Image pipe_hor_gray = Image.FromFile(root_path + "pipe_gray.wmf");
        Image pipe_hor_blue = Image.FromFile(root_path + "pipe_blue.wmf");

        Image pipe_ver_gray = Image.FromFile(root_path + "pipe_up_gray.wmf");
        Image pipe_ver_blue = Image.FromFile(root_path + "pipe_up_blue.wmf");

        Image pipe_90up_gray = Image.FromFile(root_path + "pipe_gray90up.wmf");
        Image pipe_90up_blue = Image.FromFile(root_path + "pipe_blue90up.wmf");

        Image pipe_90down_gray = Image.FromFile(root_path + "pipe_gray90down.wmf");
        Image pipe_90down_blue = Image.FromFile(root_path + "pipe_blue90down.wmf");

        Image btGreen_press = Image.FromFile(root_path + "btgreen_press.wmf");
        Image btGreen_unpress = Image.FromFile(root_path + "btgreen_unpress.wmf");

        Image btRed_press = Image.FromFile(root_path + "btred_press.wmf");
        Image btRed_unpress = Image.FromFile(root_path + "btred_unpress.wmf");

        Image light_green = Image.FromFile(root_path + "light_green.wmf");
        Image light_yellow = Image.FromFile(root_path + "light_yellow.wmf");
        Image light_gray = Image.FromFile(root_path + "light_gray.wmf");

        public SCADA Parent;
        public Main_Page()
        {
            InitializeComponent();
            UpdateTimer.Start();
        }

        private void change_Pipe_Color(string pipe, string color)
        {
            switch (pipe)
            {
                case "1_1":
                    {
                        if(color == "gray")
                        {
                            pbMotor_1_1.BackgroundImage = pump_gray;
                            pbMotor_1_1.BackColor = Color.Transparent;
                            pbMotor_1_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_1_1.BackgroundImage = pipe_hor_gray;
                            pbPipe_1_1.BackColor = Color.Transparent;
                            pbPipe_1_1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if(color == "normal")
                        {
                            pbMotor_1_1.BackgroundImage = pump_green;
                            pbMotor_1_1.BackColor = Color.Transparent;
                            pbMotor_1_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_1_1.BackgroundImage = pipe_hor_blue;
                            pbPipe_1_1.BackColor = Color.Transparent;
                            pbPipe_1_1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            pbMotor_1_1.BackgroundImage = pump_red;
                            pbMotor_1_1.BackColor = Color.Transparent;
                            pbMotor_1_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_1_1.BackgroundImage = pipe_hor_gray;
                            pbPipe_1_1.BackColor = Color.Transparent;
                            pbPipe_1_1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                case "1_2":
                    {
                        if (color == "gray")
                        {
                            pbMotor_1_2.BackgroundImage = pump_gray;
                            pbMotor_1_2.BackColor = Color.Transparent;
                            pbMotor_1_2.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_1_2.BackgroundImage = pipe_hor_gray;
                            pbPipe_1_2.BackColor = Color.Transparent;
                            pbPipe_1_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (color == "normal")
                        {
                            pbMotor_1_2.BackgroundImage = pump_green;
                            pbMotor_1_2.BackColor = Color.Transparent;
                            pbMotor_1_2.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_1_2.BackgroundImage = pipe_hor_blue;
                            pbPipe_1_2.BackColor = Color.Transparent;
                            pbPipe_1_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            pbMotor_1_2.BackgroundImage = pump_red;
                            pbMotor_1_2.BackColor = Color.Transparent;
                            pbMotor_1_2.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_1_2.BackgroundImage = pipe_hor_gray;
                            pbPipe_1_2.BackColor = Color.Transparent;
                            pbPipe_1_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                case "2_1":
                    {
                        if (color == "gray")
                        {
                            pbMotor_2_1.BackgroundImage = pump_gray;
                            pbMotor_2_1.BackColor = Color.Transparent;
                            pbMotor_2_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_1.BackgroundImage = pipe_hor_gray;
                            pbPipe_2_1.BackColor = Color.Transparent;
                            pbPipe_2_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_1_out.BackgroundImage = pipe_hor_gray;
                            pbPipe_2_1_out.BackColor = Color.Transparent;
                            pbPipe_2_1_out.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (color == "normal")
                        {
                            pbMotor_2_1.BackgroundImage = pump_green;
                            pbMotor_2_1.BackColor = Color.Transparent;
                            pbMotor_2_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_1.BackgroundImage = pipe_hor_blue;
                            pbPipe_2_1.BackColor = Color.Transparent;
                            pbPipe_2_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_1_out.BackgroundImage = pipe_hor_blue;
                            pbPipe_2_1_out.BackColor = Color.Transparent;
                            pbPipe_2_1_out.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            pbMotor_2_1.BackgroundImage = pump_red;
                            pbMotor_2_1.BackColor = Color.Transparent;
                            pbMotor_2_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_1.BackgroundImage = pipe_hor_gray;
                            pbPipe_2_1.BackColor = Color.Transparent;
                            pbPipe_2_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_1_out.BackgroundImage = pipe_hor_gray;
                            pbPipe_2_1_out.BackColor = Color.Transparent;
                            pbPipe_2_1_out.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                case "2_2":
                    {
                        if (color == "gray")
                        {
                            pbMotor_2_2.BackgroundImage = pump_gray;
                            pbMotor_2_2.BackColor = Color.Transparent;
                            pbMotor_2_2.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_2.BackgroundImage = pipe_hor_gray;
                            pbPipe_2_2.BackColor = Color.Transparent;
                            pbPipe_2_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (color == "normal")
                        {
                            pbMotor_2_2.BackgroundImage = pump_green;
                            pbMotor_2_2.BackColor = Color.Transparent;
                            pbMotor_2_2.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_2.BackgroundImage = pipe_hor_blue;
                            pbPipe_2_2.BackColor = Color.Transparent;
                            pbPipe_2_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            pbMotor_2_2.BackgroundImage = pump_red;
                            pbMotor_2_2.BackColor = Color.Transparent;
                            pbMotor_2_2.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_2_2.BackgroundImage = pipe_hor_gray;
                            pbPipe_2_2.BackColor = Color.Transparent;
                            pbPipe_2_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                case "3_1":
                    {
                        if (color == "gray")
                        {
                            pbValve_3_1.BackgroundImage = valve_gray;
                            pbValve_3_1.BackColor = Color.Transparent;
                            pbValve_3_1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (color == "normal")
                        {
                            pbValve_3_1.BackgroundImage = valve_green;
                            pbValve_3_1.BackColor = Color.Transparent;
                            pbValve_3_1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            pbValve_3_1.BackgroundImage = valve_red;
                            pbValve_3_1.BackColor = Color.Transparent;
                            pbValve_3_1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                case "3_2":
                    {
                        if (color == "gray")
                        {
                            pbValve_3_2.BackgroundImage = valve_gray;
                            pbValve_3_2.BackColor = Color.Transparent;
                            pbValve_3_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (color == "normal")
                        {
                            pbValve_3_2.BackgroundImage = valve_green;
                            pbValve_3_2.BackColor = Color.Transparent;
                            pbValve_3_2.BackgroundImageLayout = ImageLayout.Stretch;


                        }
                        else
                        {
                            pbValve_3_2.BackgroundImage = valve_red;
                            pbValve_3_2.BackColor = Color.Transparent;
                            pbValve_3_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                case "2_valve":
                    {
                        if (color == "gray")
                        {
                            pbPipeTank2_out.BackgroundImage = pipe_hor_gray;
                            pbPipeTank2_out.BackColor = Color.Transparent;
                            pbPipeTank2_out.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipeTank2_90up_out.BackgroundImage = pipe_90up_gray;
                            pbPipeTank2_90up_out.BackColor = Color.Transparent;
                            pbPipeTank2_90up_out.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipeTank2_up.BackgroundImage = pipe_ver_gray;
                            pbPipeTank2_up.BackColor = Color.Transparent;
                            pbPipeTank2_up.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_3_1.BackgroundImage = pipe_90down_gray;
                            pbPipe_3_1.BackColor = Color.Transparent;
                            pbPipe_3_1.BackgroundImageLayout = ImageLayout.Stretch;


                            pbPipe_3_2.BackgroundImage = pipe_hor_gray;
                            pbPipe_3_2.BackColor = Color.Transparent;
                            pbPipe_3_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else
                        {
                            pbPipeTank2_out.BackgroundImage = pipe_hor_blue;
                            pbPipeTank2_out.BackColor = Color.Transparent;
                            pbPipeTank2_out.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipeTank2_90up_out.BackgroundImage = pipe_90up_blue;
                            pbPipeTank2_90up_out.BackColor = Color.Transparent;
                            pbPipeTank2_90up_out.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipeTank2_up.BackgroundImage = pipe_ver_blue;
                            pbPipeTank2_up.BackColor = Color.Transparent;
                            pbPipeTank2_up.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_3_1.BackgroundImage = pipe_90down_blue;
                            pbPipe_3_1.BackColor = Color.Transparent;
                            pbPipe_3_1.BackgroundImageLayout = ImageLayout.Stretch;

                            pbPipe_3_2.BackgroundImage = pipe_hor_blue;
                            pbPipe_3_2.BackColor = Color.Transparent;
                            pbPipe_3_2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                default: break;
            }
        }

        private void pbMotor_1_1_Click(object sender, EventArgs e)
        {
            if (state_Motor_1_1)
            {
                state_Motor_1_1 = false;
                Device_Faceplate fplt = Parent.Device_Faceplates[0];
                fplt.Hide();
            }
            else
            {
                state_Motor_1_1 = true;
                Device_Faceplate fplt = Parent.Device_Faceplates[0];
                fplt.Show();
            }
        }

        private void pbMotor_1_2_Click(object sender, EventArgs e)
        {
            if (state_Motor_1_2)
            {
                state_Motor_1_2 = false;
                Device_Faceplate fplt = Parent.Device_Faceplates[1];
                fplt.Hide();
            }
            else
            {
                state_Motor_1_2 = true;
                Device_Faceplate fplt = Parent.Device_Faceplates[1];
                fplt.Show();
            }
        }

        private void pbMotor_2_1_Click(object sender, EventArgs e)
        {
            if (state_Motor_2_1)
            {
                state_Motor_2_1 = false;
                Device_Faceplate fplt = Parent.Device_Faceplates[2];
                fplt.Hide();
            }
            else
            {
                state_Motor_2_1 = true;
                Device_Faceplate fplt = Parent.Device_Faceplates[2];
                fplt.Show();
            }
        }

        private void pbMotor_2_2_Click(object sender, EventArgs e)
        {
            if (state_Motor_2_2)
            {
                state_Motor_2_2 = false;
                Device_Faceplate fplt = Parent.Device_Faceplates[3];
                fplt.Hide();
            }
            else
            {
                state_Motor_2_2 = true;
                Device_Faceplate fplt = Parent.Device_Faceplates[3];
                fplt.Show();
            }
        }

        private void pbMotor_A_Click(object sender, EventArgs e)
        {
            if (state_Motor_A)
            {
                state_Motor_A = false;
                Device_Faceplate fplt = Parent.Device_Faceplates[4];
                fplt.Hide();
            }
            else
            {
                state_Motor_A = true;
                Device_Faceplate fplt = Parent.Device_Faceplates[4];
                fplt.Show();
            }
        }

        private void pbValve_3_1_Click(object sender, EventArgs e)
        {
            if (state_Valve_3_1)
            {
                state_Valve_3_1 = false;
                Device_Faceplate fplt = Parent.Device_Faceplates[5];
                fplt.Hide();
            }
            else
            {
                state_Valve_3_1 = true;
                Device_Faceplate fplt = Parent.Device_Faceplates[5];
                fplt.Show();
            }
        }

        private void pbValve_3_2_Click(object sender, EventArgs e)
        {
            if (state_Valve_3_2)
            {
                state_Valve_3_2 = false;
                Device_Faceplate fplt = Parent.Device_Faceplates[6];
                fplt.Hide();
            }
            else
            {
                state_Valve_3_2 = true;
                Device_Faceplate fplt = Parent.Device_Faceplates[6];
                fplt.Show();
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            //Motor_1_1
            if (Parent.Devices[0].RunFeedback)
            {
                change_Pipe_Color("1_1", "normal");
            }
            else if (Parent.Devices[0].Fault)
            {
                change_Pipe_Color("1_1", "fault");
            }
            else
            {
                change_Pipe_Color("1_1", "gray");
            }

            //Motor_1_2
            if (Parent.Devices[1].RunFeedback)
            {
                change_Pipe_Color("1_2", "normal");
            }
            else if (Parent.Devices[1].Fault)
            {
                change_Pipe_Color("1_2", "fault");
            }
            else
            {
                change_Pipe_Color("1_2", "gray");
            }

            //Motor_2_1
            if (Parent.Devices[2].RunFeedback)
            {
                change_Pipe_Color("2_1", "normal");
            }
            else if (Parent.Devices[2].Fault)
            {
                change_Pipe_Color("2_1", "fault");
            }
            else
            {
                change_Pipe_Color("2_1", "gray");
            }

            //Motor_2_2
            if (Parent.Devices[3].RunFeedback)
            {
                change_Pipe_Color("2_2", "normal");
            }
            else if (Parent.Devices[3].Fault)
            {
                change_Pipe_Color("2_2", "fault");
            }
            else
            {
                change_Pipe_Color("2_2", "gray");
            }

            //Motor_A
            if (Parent.Devices[4].RunFeedback)
            {
                pbMotor_A.BackgroundImage = mixer_green;
                pbMotor_A.BackColor = Color.Transparent;
                pbMotor_A.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (Parent.Devices[4].Fault)
            {
                pbMotor_A.BackgroundImage = mixer_red;
                pbMotor_A.BackColor = Color.Transparent;
                pbMotor_A.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbMotor_A.BackgroundImage = mixer_gray;
                pbMotor_A.BackColor = Color.Transparent;
                pbMotor_A.BackgroundImageLayout = ImageLayout.Stretch;
            }

            //Valve_3_1
            if (Parent.Devices[5].RunFeedback)
            {
                change_Pipe_Color("3_1", "normal");
                change_Pipe_Color("2_valve", "normal");
            }
            else if (Parent.Devices[5].Fault)
            {
                change_Pipe_Color("3_1", "fault");
                change_Pipe_Color("2_valve", "gray");
            }
            else
            {
                change_Pipe_Color("3_1", "gray");
                change_Pipe_Color("2_valve", "gray");
            }

            //Valve_3_2
            if (Parent.Devices[6].RunFeedback)
            {
                change_Pipe_Color("3_2", "normal");
                change_Pipe_Color("2_valve", "normal");
            }
            else if (Parent.Devices[6].Fault)
            {
                change_Pipe_Color("3_2", "fault");
            }
            else
            {
                change_Pipe_Color("3_2", "gray");
            }

            //Level
            lbLevelTank1.Text = Parent.S71500.tank_1.level.ToString();
            lbLevelTank2.Text = Parent.S71500.tank_2.level.ToString();
            vpbTank1.Value = Parent.S71500.tank_1.level;
            vpbTank2.Value = Parent.S71500.tank_2.level;

            //Sensor
            if (Parent.S71500.tank_1.HI)
            {
                pbTank1HI.BackgroundImage = light_yellow;
                pbTank1HI.BackColor = Color.Transparent;
                pbTank1HI.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbTank1HI.BackgroundImage = light_gray;
                pbTank1HI.BackColor = Color.Transparent;
                pbTank1HI.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (Parent.S71500.tank_1.LO)
            {
                pbTank1LO.BackgroundImage = light_yellow;
                pbTank1LO.BackColor = Color.Transparent;
                pbTank1LO.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbTank1LO.BackgroundImage = light_gray;
                pbTank1LO.BackColor = Color.Transparent;
                pbTank1LO.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (Parent.S71500.tank_2.HI)
            {
                pbTank2HI.BackgroundImage = light_yellow;
                pbTank2HI.BackColor = Color.Transparent;
                pbTank2HI.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbTank2HI.BackgroundImage = light_gray;
                pbTank2HI.BackColor = Color.Transparent;
                pbTank2HI.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (Parent.S71500.tank_2.LO)
            {
                pbTank2LO.BackgroundImage = light_yellow;
                pbTank2LO.BackColor = Color.Transparent;
                pbTank2LO.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbTank2LO.BackgroundImage = light_gray;
                pbTank2LO.BackColor = Color.Transparent;
                pbTank2LO.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            //Motor 1_1
            if(cbMotor_1_1.Checked)
            {
                Parent.write_PLC(Parent.Devices[0].addr_mode, (Int16)2);
            }
            else
            {
                Parent.write_PLC(Parent.Devices[0].addr_mode, (Int16)1);
            }

            //Motor 1_2
            if (cbMotor_1_2.Checked)
            {
                Parent.write_PLC(Parent.Devices[1].addr_mode, (Int16)2);
            }
            else
            {
                Parent.write_PLC(Parent.Devices[1].addr_mode, (Int16)1);
            }

            //Motor 1_1
            if (cbMotor_2_1.Checked)
            {
                Parent.write_PLC(Parent.Devices[2].addr_mode, (Int16)2);
            }
            else
            {
                Parent.write_PLC(Parent.Devices[2].addr_mode, (Int16)1);
            }

            //Motor 2_2
            if (cbMotor_2_2.Checked)
            {
                Parent.write_PLC(Parent.Devices[3].addr_mode, (Int16)2);
            }
            else
            {
                Parent.write_PLC(Parent.Devices[3].addr_mode, (Int16)1);
            }

            //Motor A
            if (cbMotor_A.Checked)
            {
                Parent.write_PLC(Parent.Devices[4].addr_mode, (Int16)2);
            }
            else
            {
                Parent.write_PLC(Parent.Devices[4].addr_mode, (Int16)1);
            }

            //Valve 3_1
            if (cbValve_3_1.Checked)
            {
                Parent.write_PLC(Parent.Devices[5].addr_mode, (Int16)2);
            }
            else
            {
                Parent.write_PLC(Parent.Devices[5].addr_mode, (Int16)1);
            }

            //Motor 3_2
            if (cbValve_3_2.Checked)
            {
                Parent.write_PLC(Parent.Devices[6].addr_mode, (Int16)2);
            }
            else
            {
                Parent.write_PLC(Parent.Devices[6].addr_mode, (Int16)1);
            }
        }

        private void pbStart_MouseDown(object sender, MouseEventArgs e)
        {
            pbStart.BackgroundImage = btGreen_press;
            pbStart.BackColor = Color.Transparent;
            pbStart.BackgroundImageLayout = ImageLayout.Stretch;
            Parent.write_GlobalControlValue("StartAuto", true);
        }

        private void pbStart_MouseUp(object sender, MouseEventArgs e)
        {
            pbStart.BackgroundImage = btGreen_unpress;
            pbStart.BackColor = Color.Transparent;
            pbStart.BackgroundImageLayout = ImageLayout.Stretch;
            Parent.write_GlobalControlValue("StartAuto", false);
        }

        private void pbStop_MouseDown(object sender, MouseEventArgs e)
        {
            pbStop.BackgroundImage = btRed_press;
            pbStop.BackColor = Color.Transparent;
            pbStop.BackgroundImageLayout = ImageLayout.Stretch;
            Parent.write_GlobalControlValue("StopAuto", true);
        }
        private void pbStop_MouseUp(object sender, MouseEventArgs e)
        {
            pbStop.BackgroundImage = btRed_unpress;
            pbStop.BackColor = Color.Transparent;
            pbStop.BackgroundImageLayout = ImageLayout.Stretch;
            Parent.write_GlobalControlValue("StopAuto", false);
        }

        private void btSimFault_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = (bool)Parent.S71500.thePLC.Read("DB11.DBX6.0");
                if (check)
                {
                    btSimFault.Text = "Sim";
                    Parent.write_PLC("DB11.DBX6.0", false);
                }
                else
                {
                    btSimFault.Text = "No Sim";
                    Parent.write_PLC("DB11.DBX6.0", true);
                }
            }
            catch
            {
                ;
            }

        }

        private void btExport_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(export);
            thrd.Start();
            this.WindowState = FormWindowState.Minimized;
        }

        void export()
        {
            string cur_time = DateTime.Now.ToString();
            cur_time = cur_time.Replace('/', '_');
            cur_time = cur_time.Replace(' ', '_');
            cur_time = cur_time.Replace(':', '_');
            string file_path = @"E:\VisualStudioProject\SCADA\Report_Final_Project\Report_" + cur_time + ".pdf";
            try
            {
                if (File.Exists(file_path))
                {
                    File.Delete(file_path);
                }
                Parent.ExportPdf(file_path, "REPORT");
                System.Diagnostics.Process.Start(file_path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
