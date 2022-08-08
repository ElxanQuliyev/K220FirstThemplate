using System.ComponentModel.DataAnnotations;

namespace K220FirstThemplate.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Icon { get; set; }
        [MaxLength(200)]
        public string Title { get; set; } = null!;
        [MaxLength(400)]
        public string? Description { get; set; }
    }
}
