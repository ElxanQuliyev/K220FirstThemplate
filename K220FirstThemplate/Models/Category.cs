using System.ComponentModel.DataAnnotations;

namespace K220FirstThemplate.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string CategoryName { get; set; } = null!;
    }
}
