using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.Admin.AllTours
{
    public class MainTours
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(50)]
        public string TourName { get; set; }
        public int LanguageId { get; set; }
    }
}
