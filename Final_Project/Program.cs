using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    static class Program
    {
        public static SCADA Root;
        public static Main_Page theMain_Page;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create scada root
            Root = new SCADA();

            // Add main page
            theMain_Page = new Main_Page();
            Root.AddMain(theMain_Page);

            // Add PLC
            PLC plc = new PLC("192.168.1.201");
            Root.AddPlc(plc);

            //Add and run Task

            //Add and run Device
            Device device_1 = new Device("Motor_1_1");
            Device device_2 = new Device("Motor_1_2");
            Device device_3 = new Device("Motor_2_1");
            Device device_4 = new Device("Motor_2_2");
            Device device_5 = new Device("Motor_A");
            Device device_6 = new Device("Valve_3_1");
            Device device_7 = new Device("Valve_3_2");

            Root.AddDevice(device_1);
            Root.AddDevice(device_2);
            Root.AddDevice(device_3);
            Root.AddDevice(device_4);
            Root.AddDevice(device_5);
            Root.AddDevice(device_6);
            Root.AddDevice(device_7);

            Root.RunDevice("Motor_1_1");
            Root.RunDevice("Motor_1_2");
            Root.RunDevice("Motor_2_1");
            Root.RunDevice("Motor_2_2");
            Root.RunDevice("Motor_A");
            Root.RunDevice("Valve_3_1");
            Root.RunDevice("Valve_3_2");

            //Add Device Faceplate
            Device_Faceplate fp_1 = new Device_Faceplate(device_1);
            Device_Faceplate fp_2 = new Device_Faceplate(device_2);
            Device_Faceplate fp_3 = new Device_Faceplate(device_3);
            Device_Faceplate fp_4 = new Device_Faceplate(device_4);
            Device_Faceplate fp_5 = new Device_Faceplate(device_5);
            Device_Faceplate fp_6 = new Device_Faceplate(device_6);
            Device_Faceplate fp_7 = new Device_Faceplate(device_7);

            Root.AddDevice_Faceplates(fp_1, "Motor_1_1");
            Root.AddDevice_Faceplates(fp_2, "Motor_1_2");
            Root.AddDevice_Faceplates(fp_3, "Motor_2_1");
            Root.AddDevice_Faceplates(fp_4, "Motor_2_2");
            Root.AddDevice_Faceplates(fp_5, "Motor_A");
            Root.AddDevice_Faceplates(fp_6, "Valve_3_1");
            Root.AddDevice_Faceplates(fp_7, "Valve_3_2");

            Application.EnableVisualStyles();
            Application.Run(theMain_Page);
        }
    }
}
