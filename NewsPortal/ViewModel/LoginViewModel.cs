using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace NewsPortal.ViewModel
{
    public class LoginViewModel
    {
      

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Не указан Логин")]
        [DataType(DataType.Text)]
        [Display(Name = "Введите логин")]
        public string Login { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage="Не указан пароль")]
        [DataType (DataType.Password)]
        [Display(Name ="Введите пароль")] 
        public string Password { get; set; }
    }
}
