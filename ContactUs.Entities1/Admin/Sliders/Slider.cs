using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContactUs.Entities1.Admin.Sliders
{
    public class Slider
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(200)]
        public string ImagePath { get; set; } 
        [StringLength(200)]
        public string ImagePathLeft { get; set; }
        [StringLength(200)]
        public string SliderTopText { get; set; }
        [StringLength(200)]
        public string SliderBottomText { get; set; }
        [StringLength(250)]
        public string SliderBottomDescription { get; set; }
        public int LanguageId { get; set; }
    }
}
