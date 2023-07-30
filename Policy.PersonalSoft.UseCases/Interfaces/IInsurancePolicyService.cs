
using Policy.PersonalSoft.EntityDomain.Commands;
using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.UseCases.Interfaces
{
    public interface IInsurancePolicyService
    {
        Task<IEnumerable<InsurancePolicy>> GetAllAsyn();
        Task<InsurancePolicy> GetByPolicyIdOrLicensePlate(string search);
        Task CreateAsyn(CreateInsurancePolicyCommand createInsurancePolicyCommand);

    }
}
