using eShop.ViewModel.Catalog.Products.DTO;
using eShop.ViewModel.CommonDTO;
using eShop.Data.EF;
using eShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace eShop.Application.Catalog.Products
{
    public class MangeProductService : IManageProductService
    {
        private readonly EShopDbContext _eShopDbContext;

        public MangeProductService(EShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price
            };

            _eShopDbContext.Products.Add(product);
            return await _eShopDbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            var query = from p in _eShopDbContext.Products
                        join c in _eShopDbContext.Categories on p.Id equals c.Id
                        select new { p };

            int totalRow = await query.CountAsync();
            var data = await query.Take(request.PageSize).Select(x=> new ProductViewModel() { 
                Id= x.p.Id,
                Stock = x.p.Stock
            }).ToListAsync();

            var pageResult = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                Items = data
            };

            return pageResult;
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
