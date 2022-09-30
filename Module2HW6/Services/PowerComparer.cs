using Module2HW6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Services
{
    public class PowerComparer : IComparer<IElectricalAppliances>
    {
        public int Compare(IElectricalAppliances electricalAppliance1, IElectricalAppliances electricalAppliance2)
        {
            if (electricalAppliance1.Power > electricalAppliance2.Power)
            {
                return 1;
            }
            else if (electricalAppliance1.Power < electricalAppliance2.Power)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
