using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Bookingroom.MVC.ViewModel
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указано Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Длина пароля должна быть от 8 до 25 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Это поле обязательно")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }


    }
}
