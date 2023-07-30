using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class InsurancePolicyPlanController : ControllerBase
    {
        private readonly IInsurancePolicyPlanService insurancePolicyPlanService;
        public InsurancePolicyPlanController(IInsurancePolicyPlanService insurancePolicyPlanService)
        {
            this.insurancePolicyPlanService = insurancePolicyPlanService;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<ServiceResponseObject<IEnumerable<InsurancePolicyPlan>>>> GetAll()
        {
            var result = await insurancePolicyPlanService.GetAllAsyn();
            return Ok(new ServiceResponseObject<IEnumerable<InsurancePolicyPlan>>((int)HttpStatusCode.OK, "Successful", result));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ServiceResponseObject<string>>> Create(CreateInsurancePolicyPlanCommand request)
        {
            await insurancePolicyPlanService.CreateAsyn(request);
            return Ok(new ServiceResponseObject<string>((int)HttpStatusCode.OK, "Successful", "Insurance policy created."));
        }
    }
}
