using Net7Prueba.Models;
using Net7Prueba.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoTallerCodigofacilito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProduct() 
        {
            List<ProductEntity> product = this._productService.GetAllProduct();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct( ProductModel product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct([FromQuery]int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

        [HttpGet]
        [Route("GetProductById/{id}")]

        public IActionResult GetProductById(int id)
        {
            ProductEntity product = _productService.GetProductById(id);
            return Ok(product);
        }
    }
}
