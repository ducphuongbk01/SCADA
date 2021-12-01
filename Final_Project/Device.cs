using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class  Device
    {
        public string Name;
        public ushort Mode { get; set; }
        public bool Start { get; set; }
        public bool Stop { get; set; }
        public bool RunFeedback { get; set; }
        public bool Reset { get; set; }
        public bool Fault { get; set; }

        int Period = 250;

        System.Timers.Timer UpdateTimer = null;

        public SCADA Parent;

        public string data_block;
        public string addr_mode, addr_start, addr_stop, addr_reset;

        public Device(string name)
        {
            Name = name;
        }

        public void Initialize_Addr()
        {
            switch (Name)
            {
                case "Motor_1_1":
                    {
                        data_block = Parent.S71500.Addr_Motor_1_1;
                        break;
                    }
                case "Motor_1_2":
                    {
                        data_block = Parent.S71500.Addr_Motor_1_2;
                        break;
                    }
                case "Motor_2_1":
                    {
                        data_block = Parent.S71500.Addr_Motor_2_1;
                        break;
                    }
                case "Motor_2_2":
                    {
                        data_block = Parent.S71500.Addr_Motor_2_2;
                        break;
                    }
                case "Motor_A":
                    {
                        data_block = Parent.S71500.Addr_Motor_A;
                        break;
                    }
                case "Valve_3_1":
                    {
                        data_block = Parent.S71500.Addr_Valve_3_1;
                        break;
                    }
                case "Valve_3_2":
                    {
                        data_block = Parent.S71500.Addr_Valve_3_2;
                        break;
                    }
                default: break;
            }
            addr_mode = data_block + ".DBW0";
            addr_start = data_block + ".DBX2.0";
            addr_stop = data_block + ".DBX2.1";
            addr_reset = data_block + ".DBX2.5";
        }

        public void Engine()
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTags;
            UpdateTimer.Start();
        }

        private void UpdateTags(object sender, System.Timers.ElapsedEventArgs e)
        {
            PLC plc = Parent.S71500;

            switch(Name)
            {
                case "Motor_1_1":
                    {
                        Mode = plc.Motor_1_1.Mode;
                        RunFeedback = plc.Motor_1_1.RunFeedback;
                        Fault = plc.Motor_1_1.Fault;
                        break;
                    }
                case "Motor_1_2":
                    {
                        Mode = plc.Motor_1_2.Mode;
                        RunFeedback = plc.Motor_1_2.RunFeedback;
                        Fault = plc.Motor_1_2.Fault;
                        break;
                    }
                case "Motor_2_1":
                    {
                        Mode = plc.Motor_2_1.Mode;
                        RunFeedback = plc.Motor_2_1.RunFeedback;
                        Fault = plc.Motor_2_1.Fault;
                        break;
                    }
                case "Motor_2_2":
                    {
                        Mode = plc.Motor_2_2.Mode;
                        RunFeedback = plc.Motor_2_2.RunFeedback;
                        Fault = plc.Motor_2_2.Fault;
                        break;
                    }
                case "Motor_A":
                    {
                        Mode = plc.Motor_A.Mode;
                        RunFeedback = plc.Motor_A.RunFeedback;
                        Fault = plc.Motor_A.Fault;
                        break;
                    }
                case "Valve_3_1":
                    {
                        Mode = plc.Valve_3_1.Mode;
                        RunFeedback = plc.Valve_3_1.RunFeedback;
                        Fault = plc.Valve_3_1.Fault;
                        break;
                    }
                case "Valve_3_2":
                    {
                        Mode = plc.Valve_3_2.Mode;
                        RunFeedback = plc.Valve_3_2.RunFeedback;
                        Fault = plc.Valve_3_2.Fault;
                        break;
                    }
                default: break;
            }
        }

        public void write_Control(string func, object value)
        {
            switch(func)
            {
                case "Mode":
                    {
                        Parent.write_PLC(addr_mode, value);
                        break;
                    }
                case "Start":
                    {
                        Parent.write_PLC(addr_start, value);
                        break;
                    }
                case "Stop":
                    {
                        Parent.write_PLC(addr_stop, value);
                        break;
                    }
                case "Reset":
                    {
                        Parent.write_PLC(addr_reset, value);
                        break;
                    }
                default: break;
            }
        }

        public void reset_Faceplate_State()
        {
            switch (Name)
            {
                case "Motor_1_1":
                    {
                        Parent.main_Page.state_Motor_1_1 = false;
                        break;
                    }
                case "Motor_1_2":
                    {
                        Parent.main_Page.state_Motor_1_2 = false;
                        break;
                    }
                case "Motor_2_1":
                    {
                        Parent.main_Page.state_Motor_2_1 = false;
                        break;
                    }
                case "Motor_2_2":
                    {
                        Parent.main_Page.state_Motor_2_2 = false;
                        break;
                    }
                case "Motor_A":
                    {
                        Parent.main_Page.state_Motor_A = false;
                        break;
                    }
                case "Valve_3_1":
                    {
                        Parent.main_Page.state_Valve_3_1 = false;
                        break;
                    }
                case "Valve_3_2":
                    {
                        Parent.main_Page.state_Valve_3_2 = false;
                        break;
                    }
                default: break;
            }
        }
    }
}
