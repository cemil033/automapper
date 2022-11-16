using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models.ViewModels
{
    public class UserSignViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
