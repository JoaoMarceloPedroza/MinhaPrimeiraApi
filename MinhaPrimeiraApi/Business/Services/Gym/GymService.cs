using MinhaPrimeiraApi.Business.Services.Abstractions.Gym;
using MinhaPrimeiraApi.Domain.Models.Gym;

namespace MinhaPrimeiraApi.Business.Services.Gym
{
    public class GymService : IGymService
    {
        public Task<bool> CreateEquipmentsAsync(EquipmentsRegisterRequest model)
        {
            return Task.FromResult(true);   
        }
    }
}
