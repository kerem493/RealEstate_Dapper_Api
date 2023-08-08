using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductrepository _productrepository;

        public ProductsController(IProductrepository productrepository)
        {
            _productrepository = productrepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productrepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductLListWithCategory")]
        public async Task<IActionResult> ProductLListWithCategory()
        {
            var values = await _productrepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
    }
}
