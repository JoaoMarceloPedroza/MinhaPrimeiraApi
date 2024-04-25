using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Business.Services.Abstractions.User;
using MinhaPrimeiraApi.Domain.Models.User;

namespace MinhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        #region ..:: Variables ::..

        private IUserService _service;

        #endregion

        #region ..:: Constructor ::..

        public UserController(IUserService service)
        {
            _service = service;
        }

        #endregion

        [HttpPost("login")]
        public IActionResult Login()
        {
            bool _false = true;
            if (_false)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost("register")]
        public ActionResult<dynamic> Register(UserRegisterRequest model)
        {
            var result = _service.CreateAsync(model).Result;

            if (!result)
            {
                return BadRequest(new { Success = false, Message = "Something went wrong attempting to create this user" });
            }

            return Ok(new { Success = true, Message = "User created successfully" });
        }
    }
}
