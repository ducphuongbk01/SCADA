using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace Final_Project
{
    public class PLC
    {
        string IPAddress;
        System.Timers.Timer ReadPLCTimer = new System.Timers.Timer();
        public Plc thePLC;

        public SCADA Parent;

        public string Addr_Motor_1_1;
        public string Addr_Motor_1_2;
        public string Addr_Motor_2_1;
        public string Addr_Motor_2_2;
        public string Addr_Motor_A;
        public string Addr_Valve_3_1;
        public string Addr_Valve_3_2;
        public string Addr_Start_Auto;
        public string Addr_Stop_Auto;

        public Feild_Device Motor_1_1 = new Feild_Device();
        public Feild_Device Motor_1_2 = new Feild_Device();
        public Feild_Device Motor_2_1 = new Feild_Device();
        public Feild_Device Motor_2_2 = new Feild_Device();
        public Feild_Device Motor_A = new Feild_Device();
        public Feild_Device Valve_3_1 = new Feild_Device();
        public Feild_Device Valve_3_2 = new Feild_Device();
        public Tank tank_1 = new Tank();
        public Tank tank_2 = new Tank();
        public Control_Button Auto_Control = new Control_Button();

        public DateTime time_stamp;

        public PLC(string IPAddr)
        {
            IPAddress = IPAddr;
            thePLC = new Plc(CpuType.S71500, IPAddress, 0, 1);
            try
            {
                thePLC.Open();
            }
            catch
            {
                ;
            }

            Addr_Motor_1_1 = "DB4";
            Addr_Motor_1_2 = "DB6";
            Addr_Motor_2_1 = "DB7";
            Addr_Motor_2_2 = "DB5";
            Addr_Motor_A = "DB8";
            Addr_Valve_3_1 = "DB9";
            Addr_Valve_3_2 = "DB10";
            Addr_Start_Auto = "DB11.DBX0.0";
            Addr_Stop_Auto = "DB11.DBX0.1";

            ReadPLCTimer.Interval = 100;
            ReadPLCTimer.Elapsed += ReadPLCTimer_Elapsed;
            ReadPLCTimer.Enabled = true;
            ReadPLCTimer.Start();
        }

        private void ReadPLCTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (thePLC.IsConnected)
            {
                try
                {
                    thePLC.ReadClass(Motor_1_1, 4);
                    thePLC.ReadClass(Motor_1_2, 6);
                    thePLC.ReadClass(Motor_2_1, 7);
                    thePLC.ReadClass(Motor_2_2, 5);
                    thePLC.ReadClass(Motor_A, 8);
                    thePLC.ReadClass(Valve_3_1, 9);
                    thePLC.ReadClass(Valve_3_2, 10);

                    tank_1.level = Convert.ToInt16((ushort)thePLC.Read("MW50"));
                    tank_1.HI = (bool)thePLC.Read("DB11.DBX0.2");
                    tank_1.LO = (bool)thePLC.Read("DB11.DBX0.3");

                    tank_2.level = Convert.ToInt16((ushort)thePLC.Read("MW52"));
                    tank_2.HI = (bool)thePLC.Read("DB11.DBX0.4");
                    tank_2.LO = (bool)thePLC.Read("DB11.DBX0.5");

                    Auto_Control.Start_Auto = (bool)thePLC.Read("DB11.DBX0.0");
                    Auto_Control.Stop_Auto = (bool)thePLC.Read("DB11.DBX0.1");

                    time_stamp = DateTime.Now;
                }
                catch
                {
                    ;
                }

            }
        }
    }

    public class Feild_Device
    {
        public ushort Mode { get; set; }
        public bool Start { get; set; }
        public bool Stop { get; set; }
        public bool RunCondition { get; set; }
        public bool StopCondition { get; set; }
        public bool RunFeedback { get; set; }
        public bool Reset { get; set; }
        public byte aByte { get; set; }
        public bool Cmd { get; set; }
        public bool Fault { get; set; }
    }

    public class Tank
    {
        public int level { get; set; }
        public bool HI { get; set; }
        public bool LO { get; set; }
    }

    public class Control_Button
    {
        public bool Start_Auto { get; set; }
        public bool Stop_Auto { get; set; }
    }
}
