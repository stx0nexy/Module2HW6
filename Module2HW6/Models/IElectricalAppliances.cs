using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public interface IElectricalAppliances
    {
        string Name { get; set; }
        int Volt { get; set; }
        int Power { get; set; }
        string Type { get; set; }
    }
}
