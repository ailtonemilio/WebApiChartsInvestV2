using System.ComponentModel.DataAnnotations;

namespace WebApiChartsInvestV2.Web.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
