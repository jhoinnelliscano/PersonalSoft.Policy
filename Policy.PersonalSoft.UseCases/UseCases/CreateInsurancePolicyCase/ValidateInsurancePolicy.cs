
using Policy.PersonalSoft.Common.Exceptions;
using Policy.PersonalSoft.Persistence;
using Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces;

namespace Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase
{
    public class ValidateInsurancePolicy : IValidateInsurancePolicy
    {
        private readonly IUnitOfWork unitOfWork;

        public ValidateInsurancePolicy(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task ValidateInsurancePolicyPlanCurrentAsync(string policyPlanCode)
        {
            var PolicyPlan = await unitOfWork.InsurancePolicyPlanQueriesRepository.GetByCodeAsync(policyPlanCode);
            
            if (PolicyPlan.EndDate <= DateTime.Now) 
                throw new ValidateInsurancePolicyException("Poliza expiro");

            if (PolicyPlan.StarDate > DateTime.Now) 
                throw new ValidateInsurancePolicyException("Poliza aún no entra en vigencia");
        }
    }
}
