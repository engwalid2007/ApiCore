using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesWebApi.Controllers
{
    [Route("api/cities")]
    public class PointOfInterestController : Controller
    {
        [HttpGet("{cityId}/PointOfintersts")]
        public IActionResult Get(int cityId)
        {
            var cities = Reposotory.Current.Cities;
            if (cities == null)
                return NotFound("No Cities Found");
            if (!cities.Any(c => c.Id == cityId))
                return NotFound("City is not found");

            return Ok(cities.FirstOrDefault(c => c.Id == cityId).States);
        }

        [HttpGet("{cityId}/PointOfintersts/{id}")]
        public IActionResult Get(int cityId,int id)
        {
            var cities = Reposotory.Current.Cities;
            if (cities == null)
                return NotFound("No Cities Found");
            if (!cities.Any(c => c.Id == cityId))
                return NotFound("City is not found");

            var pointOfIntersts = cities.FirstOrDefault(c => c.Id == cityId).States;
            if (pointOfIntersts == null)
                return NotFound("No Point of intest Found");
            if (!pointOfIntersts.Any(c => c.Id == id))
                return NotFound("Point of intest is not found");
            return Ok(pointOfIntersts.FirstOrDefault(c => c.Id == id));

            return Ok();
        }
    }
}
