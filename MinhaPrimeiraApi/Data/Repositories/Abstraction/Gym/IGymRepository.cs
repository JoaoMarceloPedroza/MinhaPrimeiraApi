using MinhaPrimeiraApi.Domain.Models.Gym;

namespace MinhaPrimeiraApi.Data.Repositories.Abstraction.Gym
{
    public interface IGymRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> CreateEquipmentAsync(EquipmentsRegisterRequest model);
    }
}
