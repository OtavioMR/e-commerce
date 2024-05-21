using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api_rest.Models;

namespace api_rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ProductModel>> AllProducts()
        {
            return Ok();
        }
    }
}