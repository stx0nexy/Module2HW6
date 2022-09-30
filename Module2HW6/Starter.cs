using Module2HW6.Helper;
using Module2HW6.Models.Cleaning.NotWaterCleaning.ClothesDryer.Beko;
using Module2HW6.Models.Cleaning.NotWaterCleaning.ClothesDryer.Philips;
using Module2HW6.Models.Cleaning.NotWaterCleaning.VacuumСleaner.Samsung;
using Module2HW6.Models.Cleaning.WaterCleaning.ElectricMop.LG;
using Module2HW6.Models.Cleaning.WaterCleaning.WashingMachine.Philips;
using Module2HW6.Models.Kitchen.BuiltIn.Dishwasher.Tefal;
using Module2HW6.Models.Kitchen.BuiltIn.Oven.Beko;
using Module2HW6.Models.Kitchen.Separate.FoodProcessor.LG;
using Module2HW6.Models.Kitchen.Separate.Microwave.Bosch;
using Module2HW6.Services;
using Module2HW6.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class Starter
    {
        private readonly IElectricalService _electricalService;
        public Starter(IElectricalService electricalService)
        {
            _electricalService = electricalService;
        }

        public void Run()
        {
            AddingElectricalApplineceInAppatments();
            _electricalService.Sort(new PowerComparer());
            _electricalService.DisplayListApplines();

            Console.WriteLine($"Summary power = {_electricalService.GetSumUseingPower()}W");
            Console.WriteLine();

            var result = _electricalService.GeListElectrical().FindElectricalAppliance(100, 800);
            if (result.Status)
            {
                Console.WriteLine(result.Message);
                _electricalService.DisplayListApplines(result.ElectricalAppliances);
                Console.WriteLine($"Summary power = {_electricalService.GetSumUseingPower(result.ElectricalAppliances)}W");
            }
        }

        public void AddingElectricalApplineceInAppatments()
        {
            _electricalService.Add(new DC7130ClothesDryer());
            _electricalService.Add(new GC9315ClothesDryer());
            _electricalService.Add(new PSG7014ClothesDryer());
            _electricalService.Add(new SC4520VacuumCleaner());
            _electricalService.Add(new DE823ElecticMop());
            _electricalService.Add(new STR97020WashingMashine());
            _electricalService.Add(new PWQ93Dishwasher());
            _electricalService.Add(new MRE0983Oven());
            _electricalService.Add(new P654QFoodProcessor());
            _electricalService.Add(new MB10Microwave());
        }
    }
}
