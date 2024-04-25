using MinhaPrimeiraApi.Business.Services.Abstractions.User;
using MinhaPrimeiraApi.Data.Repositories.Abstraction.User;
using MinhaPrimeiraApi.Domain.Models.User;

namespace MinhaPrimeiraApi.Business.Services.User
{
    public class UserService : IUserService
    {
        #region ..:: Variables ::..

        private IUserRepository _repository;

        #endregion

        #region ..:: Construtor ::..

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        #endregion

        public Task<bool> CreateAsync(UserRegisterRequest model)
        {
            var validateUser = ValidateUserCreation(model);
            if (!validateUser)
            {
                return Task.FromResult(false);
            }

            var result = _repository.CreateAsync(model).Result;

            if (!result)
            {
                return Task.FromResult(false);
            }


            return Task.FromResult(true);
        }

        private bool ValidateUserCreation(UserRegisterRequest model)
        {
            if (model.Username.Trim().Length < 4)
            {
                return false;
            }

            if (model.Name.Trim().Length < 5)
            {
                return false;
            }

            if (model.Password.Length < 8)
            {
                return false;
            }

            if (model.Email.Length < 20)
            {
                return false;
            }
            
            if (DateTime.Now.Date < model.BirthYear.AddYears(18))
            {
                return false;
            }

            return true;
        }
    }
}
