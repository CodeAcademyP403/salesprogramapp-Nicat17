using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Model
{
    public class ShopProduct : ProductItem
    {
        [Required]
        [Range(minimum: 0, maximum: 100000, ErrorMessage = "Please, Input Valid Price")]
        public decimal TotalPrice { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime BuyingTime { get; set; }

        public int BuyerId { get; set; }


    }
}
