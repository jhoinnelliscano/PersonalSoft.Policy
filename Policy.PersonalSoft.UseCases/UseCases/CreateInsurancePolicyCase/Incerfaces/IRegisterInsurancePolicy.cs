
using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces
{
    public interface IRegisterInsurancePolicy
    {
        Task RegisterNewInsurancePolicyAsync(InsurancePolicy insurancePolicy);
    }
}
