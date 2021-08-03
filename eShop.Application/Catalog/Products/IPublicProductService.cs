using eShop.ViewModel.Catalog.Products.DTO;
using eShop.ViewModel.CommonDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products
{
    public interface IPublicProductService {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
