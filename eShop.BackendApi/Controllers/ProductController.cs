using eShop.Application.Catalog.Products;
using eShop.ViewModel.Catalog.Products.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IManageProductService _manageProductService;
        public ProductController(IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _manageProductService.GetAllPaging(new GetProductPagingRequest() { PageSize = 100});
            return Ok(products);
        }
    }
}
