using Modul2HW6.Models.Abstracts;

namespace Modul2HW6.Models
{
    public class Blender : HeatingElectricalAppliances
    {
        public override string Name { get; set; } = "Blender";
        public override double Weight { get; set; }
        public override double Сapacity { get; set; }
        public override TypeAppliances Appliances { get; set; }
    }
}
