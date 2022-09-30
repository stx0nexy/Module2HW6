using Module2HW6.Models;
using Module2HW6.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Services
{
    public class ListElectrical : IListElectrical
    {
        public IElectricalAppliances[] ElectricalAppliances { get; set; }
    }
}
