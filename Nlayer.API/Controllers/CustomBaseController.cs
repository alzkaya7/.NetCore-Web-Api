using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nlayer.Core.DTOs;

namespace Nlayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            //Status code 200 ise geriye null dön , değilse gelen status kodu dön ..

            if (response.StatusCode==204)
            {
                return new ObjectResult(null);

            };

            return new ObjectResult(response)

            {

                StatusCode = response.StatusCode
            };


           

        }



    }
}
