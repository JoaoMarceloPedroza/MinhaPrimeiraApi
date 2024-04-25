using MinhaPrimeiraApi.Domain.Models.User;

namespace MinhaPrimeiraApi.Business.Services.Abstractions.User
{
    public interface IUserService
    {
        /// <summary>
        /// Create a user async
        /// </summary>
        /// <param name="model">the user content</param>
        /// <returns></returns>
        Task<bool> CreateAsync(UserRegisterRequest model); 
    }
}
