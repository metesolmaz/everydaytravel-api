using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContactUs.Entities1.Admin.ContactUsViews
{
    public class ContactUsView
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(40)]
        public string MainHeader { get; set; }
        public string MainImage { get; set; }
        [StringLength(50)]
        public string AdressHeader { get; set; }
        public string AdressDescription { get; set; }
        [StringLength(90)]
        public string ContactHeader { get; set; }
        public string ContactDescriptionJson { get; set; }
        [StringLength(80)]
        public string InputNameText { get; set; }
        [StringLength(120)]
        public string InputMailText { get; set; }
        [StringLength(120)]
        public string InputPhoneText { get; set; }
        [StringLength(120)]
        public string InputMessageText { get; set; }
        [StringLength(50)]
        public string ButtonText { get; set; }
        public int LanguageId { get; set; }
    }
}
