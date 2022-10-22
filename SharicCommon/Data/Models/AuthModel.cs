using SharicApi.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
