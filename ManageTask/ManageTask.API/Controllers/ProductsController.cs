using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        
        [HttpGet("{productId}")]
        public IActionResult GetProduct([FromRoute] Guid productId)
        {
            var product = new Product { Id = productId,Name="Jackpot" };
            return Ok(product);
        }

    }
}
