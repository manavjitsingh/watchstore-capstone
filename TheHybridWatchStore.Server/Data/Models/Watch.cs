using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheHybridWatchStore.Server.Data.Models
{
    public class Watch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }  // Watch Name

        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }  // Brand (e.g., Tissot)

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(50)]
        public string Movement { get; set; }  // Movement (e.g., Automatic)

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }  // Price

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public List<string> Features { get; set; }
        public WatchSpecs Specs { get; set; }
        public ICollection<WatchImage> Images { get; set; }


    }
}
