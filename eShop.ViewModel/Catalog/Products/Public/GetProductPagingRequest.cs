using eShop.ViewModel.CommonDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModel.Catalog.Products.DTO.Public
{
    public class GetProductPagingRequest: PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
