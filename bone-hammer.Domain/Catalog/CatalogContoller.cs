using Microsoft.AspNetCore.Mvc;
using bone-hammer.Domain.Catalog;

namespace bone-hammer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world");
        }
    }
}
