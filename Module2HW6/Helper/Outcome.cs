using Module2HW6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Helper
{
    public class Outcome
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public IElectricalAppliances[] ElectricalAppliances { get; set; }
    }
}
