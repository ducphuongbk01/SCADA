using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Tag
    {
        public string Name;
        public string Address;
        public object Value;
        public DateTime TimeStamp;
        public Task_SCADA Parent;
        public Tag(string name, string addr)
        {
            Name = name;
            Address = addr;
        }
    }
}
