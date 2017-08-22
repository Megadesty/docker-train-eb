using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class Brewery
    {
        public string Location { get; set; }
        public string Name { get; set; }
    }

    public class BreweriesController : ApiController
    {
        private static List<Brewery> breweries = new List<Brewery>
        {
            new Brewery { Name = "Einbecker", Location = "Einbeck" },
            new Brewery { Name = "Zipfer", Location = "Zipf" },
            new Brewery { Name = "Herrenhäuser", Location = "Hannover" }
        };

        // GET api/values
        [HttpGet]
        [Route("api/breweries")]
        public async Task<IHttpActionResult> GetAll()
        {
            // Simulate DB access
            await Task.Delay(10);

            return Ok(BreweriesController.breweries.ToArray());
        }

        // POST api/values
        [HttpPost]
        [Route("api/breweries")]
        public async Task<IHttpActionResult> Post([FromBody]Brewery newItem)
        {
            // Simulate DB access
            await Task.Delay(10);

            BreweriesController.breweries.Add(newItem);
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
