using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesWebApi.Controllers
{
    [Route("api/Cities")]
    public class CitiesApiController:Controller
    {
        public IActionResult Get()
        {
            var cities = Reposotory.Current.Cities;
            if (cities == null)
                return NotFound();
            else
                return Ok(cities);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cities = Reposotory.Current.Cities;
            if (cities.Any(c => c.Id == id))
                return Ok(cities.FirstOrDefault(c => c.Id == id));
            else
                return NotFound();
            
        }
    }
}
