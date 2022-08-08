using System.ComponentModel.DataAnnotations;

namespace K220FirstThemplate.Models
{
    public class Section2
    {
        [Key]
        public int SectionId { get; set; }
        [MaxLength(250)]
        public string Title { get; set; } = null!;
        [MaxLength(350)]
        public string SubTitle { get; set; }=null!;
        [MaxLength(650)]
        public string? Description { get; set; }
        [MaxLength(650)]
        public string? PhotoUrl { get; set; }
        [MaxLength(350)]
        public string? Option1 { get; set; }
        [MaxLength(350)]
        public string? Option2 { get; set; }
        [MaxLength(350)]
        public string? Option3 { get; set; }
    }
}
