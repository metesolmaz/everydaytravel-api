using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactUs.Entities1.ContactUs
{
    public class Contact
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(60)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Message { get; set; }
    }
}