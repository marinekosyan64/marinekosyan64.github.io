using CORSTest.ApiModels;
using System.Threading.Tasks;

namespace CORSTest.UserService
{
    public interface IUserService
    {
        Task<ApiResponseBase> Login(ApiLogin model);
    }
}
