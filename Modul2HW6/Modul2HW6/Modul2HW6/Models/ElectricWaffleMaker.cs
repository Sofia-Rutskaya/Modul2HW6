namespace Modul2HW6.Models
{
    public class ElectricWaffleMaker : HeatingElectricalAppliances
    {
        public override string Name { get; set; } = "Electric waffle maker";
        public override double Weight { get; set; }
        public override double Сapacity { get; set; } // от 450 до 1600 Вт
        public override bool NonStickCoating { get; set; } = true;
        public override bool PotentiallyDangerous { get; set; } = true;
    }
}
