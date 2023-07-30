
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces;

namespace Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase
{
    public class InsurancePolicyFacade : IInsurancePolicyFacade
    {
        private readonly IValidateInsurancePolicy validateInsurancePolicy;
        private readonly IRegisterInsurancePolicy registerInsurancePolicy;

        public InsurancePolicyFacade(IValidateInsurancePolicy validateInsurancePolicy, IRegisterInsurancePolicy registerInsurancePolicyUserCase) 
        { 
            this.validateInsurancePolicy = validateInsurancePolicy;
            this.registerInsurancePolicy = registerInsurancePolicyUserCase;
        }

        public async Task CreateInsurancePolicyAsync(InsurancePolicy insurancePolicy) 
        {
            await validateInsurancePolicy.ValidateInsurancePolicyPlanCurrentAsync(insurancePolicy.PolicyPlanCode);
            await registerInsurancePolicy.RegisterNewInsurancePolicyAsync(insurancePolicy);
        }
    }
}
