using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.Admin.ServiceView
{
    public class ServiceViews
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(300)]
        public string ServiceHeader { get; set; }
        public string ServiceText { get; set; }
        public string ServiceImage { get; set; }
        public int LanguageId { get; set; }
    }
}
