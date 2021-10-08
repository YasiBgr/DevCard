using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace devCard_MVC.Models
{
    public class contact
    {
        [Required(ErrorMessage ="این فیلد اجباریست")]
        [MinLength(3, ErrorMessage = "حداقل طول 3 کارکتر")]
        [MaxLength(100, ErrorMessage = "حداقل طول 100 کارکتر")]
        public string nAme { get; set; }
        [Required(ErrorMessage = "این فیلد اجباریست")]
        [EmailAddress(ErrorMessage ="لطفا در قالب ایمیل وارد کنید")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Servise { get; set; }
    }
}
