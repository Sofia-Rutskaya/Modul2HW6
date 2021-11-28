using Modul2HW6.Models.Abstracts;

namespace Modul2HW6.Models
{
    public class WashingMashines : LinenProcessingMachines
    {
        public override string Name { get; set; } = "Washing Mashine";
        public override double Weight { get; set; }
        public override double Сapacity { get; set; }
        public override int MaximumWeight { get; set; } = 6;
        public override int MaximumNumberOfRevolutions { get; set; } = 1000;
        public override TypeAppliances Appliances { get; set; } = TypeAppliances.WashingMashines;
    }
}
