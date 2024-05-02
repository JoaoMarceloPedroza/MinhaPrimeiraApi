using MinhaPrimeiraApi.Domain.Models.Gym;

namespace MinhaPrimeiraApi.Business.Services.Abstractions.Gym
{
    public interface IGymService
    {
        /// <summary>
        /// Create an Equipment async
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> CreateEquipmentsAsync(EquipmentsRegisterRequest model);
    }
}
