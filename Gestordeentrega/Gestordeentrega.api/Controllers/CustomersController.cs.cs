using Microsoft.AspNetCore.Mvc;

namespace Gestordeentrega.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Customer list");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Customer {id}");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Customer created");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok($"Customer {id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Customer {id} deleted");
        }
    }
}
