using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContactUs.Entities1.Admin.Banners
{
    public class TopBanner
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(40)]
        public string Icons { get; set; }
        [StringLength(50)]
        public string Link { get; set; }
    }
}
