using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Required]
        [ForeignKey(nameof(ProductID))]
        public int ProductID { get; set; }
        public List<Product> Products { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerID))]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime TransactionDate { get; set; }
        public double PriceTotal { get; set; }
    }
}