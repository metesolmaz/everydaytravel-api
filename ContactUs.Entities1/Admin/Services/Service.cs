using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.Admin.Services
{
    public class Service
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(50)]
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public int LanguageId { get; set; }
    }
}
