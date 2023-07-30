
using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.RepositoryInterface.InsurancePolicyPlanRepository
{
    public interface IInsurancePolicyPlanCommandsRepository
    {
        Task CreateAsync(InsurancePolicyPlan insurancePolicyPlan);
    }
}
