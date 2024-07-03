using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.Admin.CallOuts
{
    public class CallOut
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(30)]
        public string IconP { get; set; }
        [StringLength(30)]
        public string IconM { get; set; }
        [StringLength(200)]
        public string Image { get; set; }
        [StringLength(200)]
        public string CallOutTopText { get; set; }
        [StringLength(200)]
        public string CallOutBottomText { get; set; }
        public int LanguageId { get; set; }
    }
}
