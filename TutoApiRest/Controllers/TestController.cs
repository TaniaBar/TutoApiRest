using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApiRest.DTOs;

namespace TutoApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<TestResponse> TestGet()
        {
            return new TestResponse()
            {
                Success = true,
                Token = null
            };
        }

        [HttpGet("{name}")]
        public ActionResult<TestResponse> TestGet(string name)
        {
            return new TestResponse()
            {
                Success = true,
                Token = name
            };
        }

        [HttpPost]
        public ActionResult<TestResponse> TestPost(TestRequest request)
        {
            if (request.Username.Equals("giada", StringComparison.InvariantCultureIgnoreCase))
            {
                return new TestResponse()
                {
                    Success = true,
                    Token = "Salut Giada!",
                };

            }
            return BadRequest("Tu n'es pas Giada :(");
        }
    }
}
