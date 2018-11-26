using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreManager.ViewModels
{
    public class ProductSaleViewModel
    {
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        public ApplicationUser User { get; set; }

    }
}