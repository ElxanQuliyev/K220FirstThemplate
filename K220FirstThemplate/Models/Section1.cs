using System.ComponentModel.DataAnnotations;

namespace K220FirstThemplate.Models
{
    public class Section1
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Header { get; set; } = null!;
        [MaxLength(350)]
        public string? Description { get; set; }

        [MaxLength(650)]
        public string? PhotoUrl { get; set; }
    }
}
