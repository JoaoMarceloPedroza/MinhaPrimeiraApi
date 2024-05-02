using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Business.Services.Abstractions.Gym;
using MinhaPrimeiraApi.Domain.Models.Gym;
using System.Net;

namespace MinhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("gym")]
    public class GymController : ControllerBase
    {
        #region ..:: Variables ::..

        private IGymService _service;

        #endregion

        #region ..:: Constructor ::..

        public GymController(IGymService service)
        {
            _service = service;
        }

        #endregion

        [HttpPost("equipment")]
        public async Task<ActionResult> CreateEquipment(EquipmentsRegisterRequest model)
        {
            var result = await _service.CreateEquipmentsAsync(model);

            if (!result.Success)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, result);
            }

            return StatusCode((int)HttpStatusCode.OK, result);
        }
    }
}
