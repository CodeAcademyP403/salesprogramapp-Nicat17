using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Model
{
    public class Buyer
    { 
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Please, Input Valid Name", MinimumLength = 2)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Percent is Required")]
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Please, Input Valid Percent")]
        public decimal Percent { get; set; }
    }
}
