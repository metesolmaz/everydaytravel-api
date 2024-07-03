using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContactUs.Entities1.Admin.AboutUs
{
    public  class About
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(50)]
        public string MainHeader { get; set; }
        public string MainImage { get; set; }
        public string TopImageLeft { get; set; }
        public string TopImageRight { get; set; }
        [StringLength(150)]
        public string TopContentHeader { get; set; }
        [StringLength(300)]
        public string TopContentDescription { get; set; }
        public string TopContentJson { get; set; }
        public string MidContentJson { get; set; }
        public string MidContentImage { get; set; }
        [StringLength(200)]
        public string BottomHeader { get; set; }
        [StringLength(200)]
        public string BottomContent { get; set; }
        public string BottomContentImage { get; set; }
        public int LanguageId { get; set; }        
    }
}
