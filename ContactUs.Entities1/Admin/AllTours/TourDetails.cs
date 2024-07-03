using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContactUs.Entities1.Admin.AllTours
{
    public class TourDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(300)]
        public string TourHeader { get; set; }
        public string TourHeaderImage { get; set; }
        public string TourContent { get; set; }
        public string TourImage { get; set; }
        public bool ısPopular { get; set; }
        public bool ısVip { get; set; }
        public int TourId { get; set; }
        public int LanguageId { get; set; }
    }
}
