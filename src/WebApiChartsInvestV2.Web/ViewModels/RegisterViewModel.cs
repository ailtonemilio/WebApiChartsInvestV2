using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApiChartsInvestV2.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "UserName inválido")]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O UserName é obrigatório")]
        [Remote(action: "IsUserNameInUse", controller: "Account")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm the Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
