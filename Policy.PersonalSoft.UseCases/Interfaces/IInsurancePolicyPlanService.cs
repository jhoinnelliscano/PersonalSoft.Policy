using Policy.PersonalSoft.EntityDomain.Commands;
using Policy.PersonalSoft.EntityDomain.Domain;

namespace Policy.PersonalSoft.UseCases.Interfaces
{
    public interface IInsurancePolicyPlanService
    {
        Task CreateAsyn(CreateInsurancePolicyPlanCommand createInsurancePolicyPlanCommand);
        Task<IEnumerable<InsurancePolicyPlan>> GetAllAsyn();
    }
}
