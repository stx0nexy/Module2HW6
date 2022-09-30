using Module2HW6.Models;
using Module2HW6.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Helper
{
    public static class FindPower
    {
        public static Outcome FindElectricalAppliance(this IListElectrical listElectrical, int lowerPower, int hightPower)
        {
            IElectricalAppliances[] electricalAppliances = listElectrical.ElectricalAppliances;
            IElectricalAppliances[] findingElectricalAppliance = new IElectricalAppliances[electricalAppliances.Length];
            var j = 0;

            for (var i = 0; i < electricalAppliances.Length; i++)
            {
                if (electricalAppliances[i].Power >= lowerPower && electricalAppliances[i].Power <= hightPower)
                {
                    findingElectricalAppliance[j++] = electricalAppliances[i];
                }
            }

            var countFinding = j;
            if (countFinding < electricalAppliances.Length)
            {
                Array.Resize(ref findingElectricalAppliance, countFinding);
            }

            return new Outcome
            {
                Status = countFinding > 0,
                Message = countFinding > 0 ? $"Found {countFinding} electrical appliance(s) for {lowerPower} - {hightPower}" : $"electrical appliance(s) for {lowerPower} - {hightPower} is not found",
                ElectricalAppliances = findingElectricalAppliance
            };
        }
    }
}
