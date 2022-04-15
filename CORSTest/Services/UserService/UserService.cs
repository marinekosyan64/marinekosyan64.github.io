using CORSTest.ApiModels;
using System;
using System.Threading.Tasks;

namespace CORSTest.UserService
{
    public class UserService : IUserService
    {
        public async Task<ApiResponseBase> Login(ApiLogin model)
        {
            string token = string.Empty;
            if (model.UserName == "111")
            {
                token = Guid.NewGuid().ToString("N");
            }            

            return new ApiResponseBase
            {
                ResponseObject = new
                {
                    UserName = model.UserName,
                    Token = token
                }
            };
        }
    }
}
