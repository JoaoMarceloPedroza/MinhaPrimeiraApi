using MinhaPrimeiraApi.Data.Repositories.Abstraction.User;
using MinhaPrimeiraApi.Domain.Models.User;

namespace MinhaPrimeiraApi.Data.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        public Task<bool> CreateAsync(UserRegisterRequest model)
        {
            return Task.FromResult(true);
        }
    }
}

// o que voce vai mandar e pegar do banco de dados
