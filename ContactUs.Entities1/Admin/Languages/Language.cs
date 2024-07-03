using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.Admin.Languages
{
    public class Language
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(60)]
        public string Name { get; set; }
        public string Icon { get; set; }
        public int LanguageId { get; set; }
    }
}
