using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Model.ViewModel
{
    public class LoginUser
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Please, Input Valid Name", MinimumLength = 2)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
