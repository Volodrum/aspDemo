using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitAspDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        // POST api/postexample
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {

            return Ok($"Отримано значення: {value}");
        }

        // POST api/postexample/data
        [HttpPost("data")]
        public ActionResult<object> PostData([FromBody] DataModel data)
        {

            return Ok(new { Message = "Дані успішно отримано", Data = data });
        }
    }

    public class DataModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
