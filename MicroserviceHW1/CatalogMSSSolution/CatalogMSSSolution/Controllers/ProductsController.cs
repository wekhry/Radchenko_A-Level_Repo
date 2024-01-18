using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogMSSSolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var products = new List<string>
            {
                "Product 1",
                "Product 2",
                "Product 3"
            };
            return Ok(products);
        }
    }
}
