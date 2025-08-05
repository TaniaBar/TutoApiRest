using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TutoApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<TestResponse> TestGet()
        {
        }

        [HttpPost]
        public ActionResult<TestResponse> TestPost(TestRequest request)
        {
            
        }
    }
}
