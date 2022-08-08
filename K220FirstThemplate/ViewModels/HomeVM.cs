using K220FirstThemplate.Models;

namespace K220FirstThemplate.ViewModels
{
    public class HomeVM
    {
        public Section1? Section1 { get; set; }
        public Section2? Section2 { get; set; }
        public List<Feature>? FeatureList { get; set; }
        public List<Product> ListProducts { get; set; }
    }
}
