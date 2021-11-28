using Modul2HW6.Models.Abstracts;

namespace Modul2HW6.Models
{
    public class ElectricShaver : PersonalHygieneDevices
    {
        public override string Name { get; set; } = "Electric shaver";
        public override double Weight { get; set; }
        public override double Сapacity { get; set; }
        public override TypeAppliances Appliances { get; set; } = TypeAppliances.ElectricShaver;
    }
}
