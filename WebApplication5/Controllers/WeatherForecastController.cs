using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApplication5.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("getvalues")]
        public ActionResult<IEnumerable<operationClass>> GetValues()
        {
            var data = new List<operationClass>
            {
        new operationClass { nameOperation = "*", typeOperation = 1 },
        new operationClass { nameOperation = "%", typeOperation = 1 },
        new operationClass { nameOperation = "/", typeOperation = 1 },
        new operationClass { nameOperation = "+", typeOperation = 1 },
        new operationClass { nameOperation = "-", typeOperation = 1 }
            };

            return data;
        }
    }
}
