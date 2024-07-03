using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContactUs.Entities1.Admin.Banners
{
   
        public class MidBanner
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }
            [StringLength(30)]
            public string Mail { get; set; }
            [StringLength(40)]
            public string Icons { get; set; }
            [StringLength(20)]
            public string Phone { get; set; }
            [StringLength(150)]
            public string Logo { get; set; }
            [StringLength(70)]
            public string BannerText { get; set; }
            public int LanguageId { get; set; }
        }
    
}
