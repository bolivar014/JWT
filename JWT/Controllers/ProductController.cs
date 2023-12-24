using JWT.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Authorize] // Protección de todo el controlador para que sólo responda con authorize
        public IActionResult Get()
        {
            var listProducts = ProductConstants.Products;

            return Ok(listProducts);
        }
    }
}
