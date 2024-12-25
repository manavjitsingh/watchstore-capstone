using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheHybridWatchStore.Server.Data.Models
{
    public class WatchSpecs
    {
        [Key]
        public int SpecsId { get; set; }
        public string CaseMaterial { get; set; }  // Case Material (e.g., Stainless Steel)

        [MaxLength(50)]
        public string StrapMaterial { get; set; }  // Strap Material (e.g., Leather, Silicone)

        [MaxLength(50)]
        public string DialColor { get; set; }  // Dial Color (e.g., Blue)

        [MaxLength(50)]
        public string CaseShape { get; set; }  // Case Shape (e.g., Round)

        public double CaseDiameter { get; set; }  // Case Diameter (in mm)

        public double CaseThickness { get; set; }  // Case Thickness (in mm)

        public int WaterResistanceDepth { get; set; }
        [MaxLength(50)]
        public string Engine { get; set; }  // Engine (e.g., Caliber: ETA C07.111)

        public int PowerReserve { get; set; }  // Power Reserve (in hours)
        [ForeignKey("Watch")]
        public int WatchId { get; set; }  // Foreign Key to the Watch

        public Watch Watch { get; set; }  // Navigation property to Watch
    }
}
