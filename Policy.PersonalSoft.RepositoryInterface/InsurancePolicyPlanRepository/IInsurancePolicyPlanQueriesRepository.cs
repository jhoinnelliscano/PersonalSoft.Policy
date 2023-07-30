using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.RepositoryInterface.InsurancePolicyPlanRepository
{
    public interface IInsurancePolicyPlanQueriesRepository
    {
        Task<IEnumerable<InsurancePolicyPlan>?> GetAllAsync();
        Task<InsurancePolicyPlan> GetByCodeAsync(string policyPlanCode);
    }
}
