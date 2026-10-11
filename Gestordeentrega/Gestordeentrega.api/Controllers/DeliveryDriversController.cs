using Microsoft.AspNetCore.Mvc;

namespace Gestordeentrega.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryDriversController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Delivery driver list");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Delivery driver {id}");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Delivery driver created");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok($"Delivery driver {id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Delivery driver {id} deleted");
        }
    }
}