using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "لطفا این فیلد را پر کنید")]
        [MaxLength(100 ,ErrorMessage = "حداکثر مجاز کاراکتر 100 میباشد")]
        public string Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "لطفا این فیلد را پر کنید")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
