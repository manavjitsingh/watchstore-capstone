using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TheHybridWatchStore.Server.Data.Models
{
    public class WatchImage
    {
        [Key]
        public int ImagesId { get; set; }

        [Required]
        public string ImagePath { get; set; }  // Path or URL to the image file

        [ForeignKey("Watch")]
        public int WatchId { get; set; }  // Foreign Key to the Watch
        [JsonIgnore]
        public Watch Watch { get; set; }  // Navigation property to Watch
    }
}
