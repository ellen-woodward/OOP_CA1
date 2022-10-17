using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Worker
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal HourlyRate { get; set; }

        public Worker(string name, string type, decimal hourlyRate)
        {
            Name = name;
            Type = type;
            HourlyRate = hourlyRate;
        }
    }
}
