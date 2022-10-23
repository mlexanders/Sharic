using System.ComponentModel.DataAnnotations;

namespace SharicCommon.Data.Models
{
    public class AuthModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public Password Password { get; set; }
    }
}
