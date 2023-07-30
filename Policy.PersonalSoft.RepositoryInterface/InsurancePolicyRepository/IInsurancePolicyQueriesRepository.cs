using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.RepositoryInterface.InsurancePolicyRepository
{
    public interface IInsurancePolicyQueriesRepository
    {
        Task<IEnumerable<InsurancePolicy>?> GetAllAsync();
        Task<InsurancePolicy> GetByPolicyIdOrLicensePlate(string search);

    }
}
