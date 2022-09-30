using Module2HW6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Services.Abstract
{
    public interface IListElectrical
    {
        public IElectricalAppliances[] ElectricalAppliances { get; set; }
    }
}
