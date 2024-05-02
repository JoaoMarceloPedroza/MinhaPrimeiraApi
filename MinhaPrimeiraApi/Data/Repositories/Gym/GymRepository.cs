using MinhaPrimeiraApi.Data.Repositories.Abstraction.Gym;
using MinhaPrimeiraApi.Domain.Models.Gym;

namespace MinhaPrimeiraApi.Data.Repositories.Gym
{
    public class GymRepository : IGymRepository
    {
        public Task<bool> CreateEquipmentAsync(EquipmentsRegisterRequest model)
        {
            return Task.FromResult(true); 
        } 
    }
}
