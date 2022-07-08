using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto.Response;

namespace WebAPI.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult GetResponse(Result response)
        {
            switch (response.Status)
            {
                case ResponseStatus.Ok:
                    return Ok(response.Content);
                case ResponseStatus.Error:
                    return BadRequest();
                default:
                    return BadRequest();
            }            
        }
    }
}
