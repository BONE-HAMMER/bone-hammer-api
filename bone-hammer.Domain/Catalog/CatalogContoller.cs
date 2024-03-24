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
           new Item("Shirt", "Ohio State shirt.", 29.99m),
           new Item("Shorts", "Ohio State shorts." "Nike, 44.99m")
        };
        return Ok(items);
    }
    [HttpGet("{id:int}")]
    public IactionResult GetItem(int id)
    {
        var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
        item.Id= id;
        return Ok(item);
    }

    [HttpPost]
    Public IactionResult Post(Item item)
    {
        return Created("/catalog/42", item);
    
    }
    [HttpPost("{id:int}/rating")]
    public IactionResult PostRating(int id, [FromBody] Rating rating)
    {
        var item =new Item("Shirt," "Ohio State Shirt." "Nike", 29.99m);
        item.Id = id;
        item.AddRating(rating);

        return Ok(item);
}
[HttpPut("{id:int}")]
public IActionResult Put(int id, Item item)
{
    return NoContent();
}
[HttpDelete("{id:int}")]
public IActionResult Delete(int id)
{
    return NoContent();
}

}

