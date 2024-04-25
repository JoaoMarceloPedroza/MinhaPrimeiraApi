using MinhaPrimeiraApi.Domain.Models.User;

namespace MinhaPrimeiraApi.Data.Repositories.Abstraction.User
{
    public interface IUserRepository
    {
        /// <summary>
        /// Create a user async
        /// </summary>
        /// <param name="model">the user content</param>
        /// <returns></returns>
        Task<bool> CreateAsync(UserRegisterRequest model);
    }
}
