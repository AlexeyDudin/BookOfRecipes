using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto.Response;

namespace WebAPI.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult GetResponse(Result response)
        {
            return response.Status switch
            {
                ResponseStatus.Ok => Ok( response ),
                ResponseStatus.Error => BadRequest( response ),
                ResponseStatus.UserNotFound => Unauthorized(),
                _ => BadRequest( response )
            };          
        }
    }
}
