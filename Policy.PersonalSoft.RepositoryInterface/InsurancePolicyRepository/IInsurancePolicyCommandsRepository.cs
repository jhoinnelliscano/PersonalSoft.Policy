using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.RepositoryInterface.InsurancePolicyRepository
{
    public interface IInsurancePolicyCommandsRepository
    {
        Task CreateAsync(InsurancePolicy insurancePolicy);
    }
}
