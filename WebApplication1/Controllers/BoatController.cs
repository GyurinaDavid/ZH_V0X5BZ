using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]

        public IActionResult Mindegy()
        {
            Models.HajosContext hajosContext= new Models.HajosContext();
            var kérdés = from x in hajosContext.Questions select x.Question1;

            return Ok(kérdés);
        }       


    }
}
