using Microsoft.AspNetCore.Mvc;

namespace Gestordeentrega.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Order list");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Order {id}");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Order created");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok($"Order {id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Order {id} deleted");
        }
    }
}
