using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreManager.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Product Name"),Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Display(Name = "Expiration Date")]
        public DateTime? ExpirationDate { get; set; }
        [Display(Name = "Date Added"),Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public Double Price { get; set; }
    }
}