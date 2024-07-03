using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.Admin.Footers
{
    public class Footer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(90)]
        public string FooterLeftTitle { get; set; }
        [StringLength(90)]
        public string FooterMidTitle { get; set; }
        [StringLength(90)]
        public string FooterRightTitle { get; set; }
        [StringLength(300)]
        public string FooterLeftContent { get; set; }
        public string FooterMidContent { get; set; }
        public int LanguageId { get; set; }
    }
}
