using System.Collections.Generic;

namespace ComponentAnalysis.Models
{
    public class Component

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Tag> Usage { get; set; }
        public List<string> OtherNames { get; set; }
        public decimal? PricePerKG { get; set; }
        public string AdverseReactions { get; set; }
    }
}
