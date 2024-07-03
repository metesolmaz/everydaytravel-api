using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.Admin.ToursViews
{
    public class ToursView
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(300)]
        public string TourHeader { get; set; }
        public string TourHeaderImage { get; set; }
        public int LanguageId { get; set; }
    }
}
