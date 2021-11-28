namespace Modul2HW6.Models
{
    public class Freezer : RefrigerationAppliances
    {
        public override string Name { get; set; } = "Freezer";
        public override double Weight { get; set; }
        public override double Сapacity { get; set; }
        public override bool HighProtectionAgainstElectricShock { get; set; } = true;
        public override int TemperatureInside { get; set; } = 3;
    }
}
