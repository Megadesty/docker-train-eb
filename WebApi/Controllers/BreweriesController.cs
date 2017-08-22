using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class Brewery
    {
        public string Location { get; set; }
        public string Name { get; set; }
    }

    [Route("api/[controller]")]
    public class BreweriesController : Controller
    {
        private static List<Brewery> breweries = new List<Brewery>
        {
            new Brewery { Name = "Einbecker", Location = "Einbeck" },
            new Brewery { Name = "Zipfer", Location = "Zipf" },
            new Brewery { Name = "Herrenhäuser", Location = "Hannover" }
        };

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Simulate DB access
            await Task.Delay(10);

            return Ok(BreweriesController.breweries.ToArray());
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Brewery newItem)
        {
            // Simulate DB access
            await Task.Delay(10);

            BreweriesController.breweries.Add(newItem);
            return StatusCode(201);
        }
    }
}
