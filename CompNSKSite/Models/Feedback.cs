using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompNSKSite.Models
{
    [Table("Feedback")]
    public class Feedback
    {
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Display(Name = "Введите номер телефона")]
        [Required(ErrorMessage = "Введите номер телефона")]
        public string Phone_Number { get; set; }

        [Display(Name = "Введите email")]
        [Required(ErrorMessage = "Введите email")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Введите сообщение")]
        public string Message { get; set; }

        public DateTime Submission_Date { get; set; } = DateTime.Now;
    }
}
