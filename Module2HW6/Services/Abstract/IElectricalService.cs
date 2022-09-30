using Module2HW6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Services.Abstract
{
    public interface IElectricalService
    {
        int CountElectricalAppliancesApartments { get; set; }
        void Add(IElectricalAppliances electricalAppliance);

        void SetCapacity(int capacity);

        void DisplayListApplines();

        void DisplayListApplines(IElectricalAppliances[] electricalAppliances);

        string DisplayElectricalAppliance(IElectricalAppliances electricalAppliance);

        IListElectrical GeListElectrical();

        void Sort(IComparer<IElectricalAppliances> comparer);

        int GetSumUseingPower();

        int GetSumUseingPower(IElectricalAppliances[] electricalAppliances);
    }
}
