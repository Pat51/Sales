using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sales.Common.Models
{
   public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime LastBuy { get; set; }
        public float Stock { get; set; }

    }
}
