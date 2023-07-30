
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyPlanRepository;
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyRepository;

namespace Policy.PersonalSoft.Persistence
{
    public interface IUnitOfWork
    {
        IInsurancePolicyQueriesRepository InsurancePolicyQueriesRepository { get; }
        IInsurancePolicyCommandsRepository InsurancePolicyCommandsRepository { get; }
        IInsurancePolicyPlanQueriesRepository InsurancePolicyPlanQueriesRepository { get; }
        //IInsurancePolicyPlanCommandsRepository InsurancePolicyPlanCommandsRepository { get; }
    }
}
