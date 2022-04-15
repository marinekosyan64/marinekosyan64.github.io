using CORSTest.ApiModels;
using CORSTest.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CORSTest.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        protected readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<ApiResponseBase> Login(ApiLogin login)
        
        {
            var response = await _userService.Login(login);

            return new ApiResponseBase
            {
                ResponseObject = response
            };
        }
    }
}
