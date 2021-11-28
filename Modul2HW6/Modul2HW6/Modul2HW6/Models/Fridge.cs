namespace Modul2HW6.Models
{
    public class Fridge : RefrigerationAppliances
    {
        public override string Name { get; set; } = "Fridge";
        public override double Weight { get; set; }
        public override bool HighProtectionAgainstElectricShock { get; set; } = true;
        public override int TemperatureInside { get; set; } = -18;
    }
}
