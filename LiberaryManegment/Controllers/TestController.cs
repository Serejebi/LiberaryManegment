using System.Web.Http;

namespace LiberaryManegment.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/test")]
        public IHttpActionResult Get()
        {
            return Ok("API is working from TestController!");
        }
    }
}
