using MinhaPrimeiraApi.Business.Services.Abstractions.Gym;
using MinhaPrimeiraApi.Data.Repositories.Abstraction.Gym;
using MinhaPrimeiraApi.Domain.Models.Base;
using MinhaPrimeiraApi.Domain.Models.Gym;

namespace MinhaPrimeiraApi.Business.Services.Gym
{
    public class GymService : IGymService
    {

        #region ..:: Services ::..

        private readonly IGymRepository _repository;

        #endregion

        #region ..:: Constructors ::..

        public GymService(IGymRepository repository)
        {
            _repository = repository;
        } 

        #endregion

        #region ..:: Methods ::..

        public Task<BaseResultEntity> CreateEquipmentsAsync(EquipmentsRegisterRequest model)
        {
            var validateEquipment = ValidateCreateEquipments(model);
            if (!validateEquipment.Success)
            {
                return Task.FromResult(validateEquipment);
            }

            var result = _repository.CreateEquipmentAsync(model).Result;

            if (!result)
            {
                return Task.FromResult(new BaseResultEntity
                {
                    Message = "Something went wrong attempting to create this equipment",
                    Success = false,
                });
            }

            validateEquipment.Message = "equipment created successfully!"; // temp
            return Task.FromResult(validateEquipment);
        }

        #endregion

        #region ..:: Validations ::..

        private BaseResultEntity ValidateCreateEquipments(EquipmentsRegisterRequest model)
        {
            if (model == null)
            {
                return new BaseResultEntity
                {
                    Message = "You need to fill at least one equipment",
                    Success = false,
                };
            }

            if (string.IsNullOrEmpty(model.EquipmentName) ||
                model.EquipmentName.Length < 3)
            {
                return new BaseResultEntity
                {
                    Message = "You need to inform a valid equipment valid",
                    Success = false,
                };
            }

            if (model.MaximumWeight <= 0)
            {
                return new BaseResultEntity
                {
                    Message = "You need to inform a valid weight",
                    Success = false,
                };
            }

            return new BaseResultEntity
            {
                Message = "",
                Success = true,
            };
        }

        #endregion
    }
}
