using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizationLocalizationWebApp.Models
{
    public class CustomerViewModel
    {
        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "MobileNo")]
        public string MobileNo { get; set; }
    }
}
