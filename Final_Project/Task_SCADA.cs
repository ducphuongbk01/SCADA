using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Task_SCADA
    {
        public string Name;
        int Period;
        System.Timers.Timer UpdateTimer = null;
        System.Timers.Timer MonitoringTimer = null;
        public List<Tag> Tags = new List<Tag>();

        public SCADA Parent;

        Random r = new Random();

        public Task_SCADA(string name, int period)
        {
            Name = name;
            Period = period;
        }

        public void AddTag(Tag tag)
        {
            tag.Parent = this;
            Tags.Add(tag);
        }

        public Tag FindTag(string name)
        {
            Tag tag = null;
            for (int i = 0; i < Tags.Count; i++)
            {
                tag = Tags[i];
                if (tag.Name == name)
                {
                    return tag;
                }
            }

            return null;
        }
        public void Engine()
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTags;
            UpdateTimer.Start();

            MonitoringTimer = new System.Timers.Timer(Period);
            MonitoringTimer.AutoReset = true;
            MonitoringTimer.Elapsed += ConsoleMonitor;
            MonitoringTimer.Start();
        }
        public void Sleep()
        {
            if (UpdateTimer != null)
            {
                UpdateTimer.Stop();
            }
        }

        public void Resume()
        {
            if (UpdateTimer != null)
            {
                UpdateTimer.Start();
            }
        }


        public void Kill()
        {
            if (UpdateTimer != null)
            {
                UpdateTimer.Dispose();
                UpdateTimer = null;
            }
        }

        private void UpdateTags(object sender, System.Timers.ElapsedEventArgs e)
        {
            Tag tag;

            for (int i = 0; i < Tags.Count; i++)
            {
                tag = Tags[i];
                string[] temp = tag.Address.Split('.');
                string obj = temp[0];
                string signal = temp[1];
                switch (obj)
                {
                    case "Motor_1":
                        {
                            switch (signal)
                            {
                                case "Mode":
                                    tag.Value = Parent.S71500.Motor_1_1.Mode;
                                    break;
                                case "RunFeedBack":
                                    tag.Value = Parent.S71500.Motor_1_1.RunFeedback;
                                    break;
                                case "Fault":
                                    tag.Value = Parent.S71500.Motor_1_1.Fault;
                                    break;
                            }
                        }
                        break;
                    case "Motor_2":
                        {
                            switch (signal)
                            {
                                case "Mode":
                                    tag.Value = Parent.S71500.Motor_1_2.Mode;
                                    break;
                                case "RunFeedBack":
                                    tag.Value = Parent.S71500.Motor_1_2.RunFeedback;
                                    break;
                                case "Fault":
                                    tag.Value = Parent.S71500.Motor_1_2.Fault;
                                    break;
                            }
                        }
                        break;
                    case "Motor_3":
                        {
                            switch (signal)
                            {
                                case "Mode":
                                    tag.Value = Parent.S71500.Motor_2_1.Mode;
                                    break;
                                case "RunFeedBack":
                                    tag.Value = Parent.S71500.Motor_2_1.RunFeedback;
                                    break;
                                case "Fault":
                                    tag.Value = Parent.S71500.Motor_2_1.Fault;
                                    break;
                            }
                        }
                        break;
                    default: break;
                }
                tag.TimeStamp = DateTime.Now;
            }
        }

        private void ConsoleMonitor(object sender, System.Timers.ElapsedEventArgs e)
        {
            Tag tag;
            for (int i = 0; i < Tags.Count; i++)
            {
                tag = Tags[i];
                //Console.WriteLine($"Tag Name = {tag.Name} TimeStamp = {tag.TimeStamp}, Value = {tag.Value}");   
            }
        }
    }
}
