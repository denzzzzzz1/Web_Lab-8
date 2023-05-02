using System.ComponentModel.DataAnnotations;

namespace Sierov_D_KN_2_3.Models
{
    public class Account
    {
        [Display(Name="NICKNAME")]
        [Required(ErrorMessage = "Enter name!")]
        public string name { get; set; }

        [Display(Name = "EMAIL")]
        [Required(ErrorMessage = "Enter email!")]
        public string email { get; set; }

        [Display(Name = "PASSWORD")]
        [Required(ErrorMessage = "Enter password!")]
        public string password { get; set; }
    }
}
