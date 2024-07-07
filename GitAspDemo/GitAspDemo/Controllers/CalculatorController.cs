using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitAspDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("calc/")]
        public ActionResult<string> Calc(decimal x, decimal y, string op)
        {
            decimal res;
            switch (op)
            {
                case "+":
                    res = x + y;
                    break;
                case "-":
                    res = x - y;
                    break;
                case "*":
                    res = x * y;
                    break;
                case "/":
                    if (y == 0)
                        return "Result: Infinity";
                    res = x / y;
                    break;
                default:
                    return "Invalid operation!";
            }
            return $"Result: {res}";
        }
    }
}
