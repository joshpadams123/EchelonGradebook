using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EchelonGradebook.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Must enter an Email or a Username.")]
        public String username { get; set; }

        [Required(ErrorMessage = "Must enter a Password.")]
        public String password { get; set; }
        public int ID { get; set; }
    }
}
