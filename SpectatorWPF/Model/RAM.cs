using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.Model
{
    public class RAM
    {
        public int Capacity => MemorySlots.Sum(memory => memory.Size);
        public List<Memory> MemorySlots { get; }

        public RAM()
        {
            //MemorySlots = AskManagement.GetRam();
        }
    }

    public class Memory
    {
        public string PartNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Serial { get; set; }
        public string Location { get; set; }
        public ushort Size { get; set; }
        public uint ClockSpeed { get; set; }
        public uint Voltage { get; set; }
    }
}
