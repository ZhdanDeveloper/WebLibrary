using Microsoft.AspNetCore.Mvc;
namespace WebLibrary_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [NonAction]
        public string GetName() => User.Identity.Name;
    }
}