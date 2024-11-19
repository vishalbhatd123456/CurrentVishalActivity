
using Microsoft.AspNetCore.Mvc;


namespace CurrentActivityApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrentActivityController : ControllerBase
    {
        //this variable stores default current activity
        private static string _currentActivity = "Idle";

        //GET api/currentactivity
        [HttpGet]
        public ActionResult<string> GetCurrentActivity()
        {
            return Ok(_currentActivity); //200, synchronous
        }

        //POST api/currentactivity
        [HttpPost]
        public IActionResult UpdateCurrentActivity([FromBody] string newActivity)
        {
            if(string.IsNullOrEmpty(newActivity))
            {
                return BadRequest("Activity cannot be empty");
            }
            _currentActivity = newActivity;
            return Ok($"Activity updated to : {newActivity}");
        }
    }
}