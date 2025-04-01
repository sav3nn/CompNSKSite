using System.ComponentModel.DataAnnotations;

namespace CompNSKSite.Models
{
    public class Contact
    {
        [Display(Name="Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя!")]
        [StringLength(10, ErrorMessage ="Имя более 10 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите номер телефона")]
        [Required(ErrorMessage = "Вам нужно ввести номер телефона!")]
        public string Phone { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Вам нужно ввести почту!")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение!")]
        public string Message { get; set; }

    }
}
