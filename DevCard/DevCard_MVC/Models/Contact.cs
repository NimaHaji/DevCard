using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="پر کردن این فیلد الزامیست")]
        [MaxLength(100,ErrorMessage ="طول کاراکتر نباید بیشتر از 100 باشد .")]
        [MinLength(2,ErrorMessage ="طول کاراکتر نباید از 2 کمتر باشد")]
        public string name { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد الزامیست")]
        [EmailAddress(ErrorMessage ="فرمت ایمیل اشتباه می باشد")]
        public string email { get; set; }
        public string service { get; set; }
        public string message { get; set; }
    }
}
