using Microsoft.AspNetCore.Mvc;

namespace Gestordeentrega.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Delivery list");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Delivery {id}");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Delivery created");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok($"Delivery {id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Delivery {id} deleted");
        }
    }
}