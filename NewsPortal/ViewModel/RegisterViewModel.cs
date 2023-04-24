using System.ComponentModel.DataAnnotations;

namespace NewsPortal.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Не указан Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Введите почту")]
        public string Email { get; set; }
        
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Не указано Имя")]
        [DataType(DataType.Text)]
        [Display(Name = "Введите имя")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Не указан Логин")]
        [DataType(DataType.Text)]
        [Display(Name = "Введите логин")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Не указан пароль")]
        [DataType(DataType.Password)]
        [Display(Name ="Введите пароль")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage="Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name ="Введите пароль повторно")]
        public string ConfirmPassword { get; set; }

    }
}
