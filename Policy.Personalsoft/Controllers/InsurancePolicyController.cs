using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Policy.PersonalSoft.EntityDomain.Commands;
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.EntityDomain.Objects;
using Policy.PersonalSoft.UseCases.Interfaces;
using System.Net;

namespace Policy.PersonalSoft.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsurancePolicyController : ControllerBase
    {
        private readonly IInsurancePolicyService insurancePolicyService;
        public InsurancePolicyController(IInsurancePolicyService insurancePolicyService)
        { 
            this.insurancePolicyService = insurancePolicyService; ;
        }

        /// <summary>
        /// Servicio para consultar todas las polizas registradas
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<ServiceResponseObject<IEnumerable<InsurancePolicy>>>> GetAll()
        {
            var result = await insurancePolicyService.GetAllAsyn();
            return Ok(new ServiceResponseObject<IEnumerable<InsurancePolicy>>((int)HttpStatusCode.OK, "Successful", result));
        }

        /// <summary>
        /// Servicio para consultar poliza por número de placa o número depoliza
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        [Route("search")]
        public async Task<ActionResult<ServiceResponseObject<InsurancePolicy>>> GetByPolicyIdOrLicensePlate(string search)
        {
            var result = await insurancePolicyService.GetByPolicyIdOrLicensePlate(search);
            return Ok(new ServiceResponseObject<InsurancePolicy>((int)HttpStatusCode.OK, "Successful", result));
        }


        /// <summary>
        /// Servicio para crear una nueva poliza
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ServiceResponseObject<string>>> Create(CreateInsurancePolicyCommand request)
        {
            await insurancePolicyService.CreateAsyn(request);
            return Ok(new ServiceResponseObject<string>((int)HttpStatusCode.OK, "Successful", "Insurance policy created."));
        }
    }
}
