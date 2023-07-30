
using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces
{
    public interface IInsurancePolicyFacade
    {
        Task CreateInsurancePolicyAsync(InsurancePolicy insurancePolicy);
    }
}
