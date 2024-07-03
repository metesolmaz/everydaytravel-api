using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContactUs.Entities1.Admin.HomeTours
{
    public class HomeTours
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(200)]
        public string ToursHeader { get; set; }
        [StringLength(250)]
        public string ToursText { get; set; }
        [StringLength(120)]
        public string ToursButtonText { get; set; }
        public int LanguageId { get; set; }
    }
}
