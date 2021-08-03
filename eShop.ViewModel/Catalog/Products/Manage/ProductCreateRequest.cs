using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModel.Catalog.Products.DTO
{
    public class ProductCreateRequest {
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
    }
}
