using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiChartsInvestV2.Web.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }
        public string Id { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email!")]
        public string Email { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        public List<string> Claims { get; set; }
        public IList<string> Roles { get; set; }
    }
}
