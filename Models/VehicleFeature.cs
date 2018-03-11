using System.ComponentModel.DataAnnotations.Schema;

namespace EntityPractice.Models
{
    [Table("VehicleFeatures")]
    public class VehicleFeature
    {
        public int VehicleId { get; set; }
        public int FeatureId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Feature MyProperty { get; set; }
    }
}