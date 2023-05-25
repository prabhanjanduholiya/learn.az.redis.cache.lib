using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace learn.az.key.vault.demo.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public SecretsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public List<string> Get()
        {
            List<string> result = new List<string>() {
                _configuration["db-connection-string"]
            };
            return result;
        }
    }
}
