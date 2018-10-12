using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Model
{
    public abstract class ProductItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, Enter Correct Category Name")]
        [StringLength(maximumLength: 100,  MinimumLength = 2, ErrorMessage = "Please, Enter Correct Category Name")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please, Enter Correct  Name")]
        [StringLength(maximumLength:100,MinimumLength =2, ErrorMessage = "Please, Enter Correct  Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, Enter Correct  Price")]
        [Range(minimum:0,maximum:100000, ErrorMessage = "Please, Enter Correct  Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please, Enter Correct  Currency")]
        public Currency Currency { get; set; }

        [Required(ErrorMessage = "Please, Enter Correct  Weight")]
        public Weight Weight { get; set; }


        [Required(ErrorMessage = "Please, Enter Correct Count")]
        [Range(minimum: 0, maximum: 100000, ErrorMessage = "Please, Enter Correct Count")]
        public short Count { get; set; }

        [Required(ErrorMessage = "Please, Enter Correct Usage")]
        public bool Usage { get; set; }

       
    }
}
