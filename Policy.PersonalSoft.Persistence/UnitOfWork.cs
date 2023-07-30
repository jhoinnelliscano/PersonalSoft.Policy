using Policy.PersonalSoft.Persistence.Context;
using Policy.PersonalSoft.Persistence.Repositories.InsurancePolicyPlanRepository;
using Policy.PersonalSoft.Persistence.Repositories.InsurancePolicyRepository;
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyPlanRepository;
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyRepository;

namespace Policy.PersonalSoft.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IInsuranceDbContext insuranceDbContext;
        private IInsurancePolicyQueriesRepository? insurancePolicyQueriesRepository;
        private IInsurancePolicyCommandsRepository? insurancePolicyCommandsRepository;
        private IInsurancePolicyPlanQueriesRepository? insurancePolicyPlanQueriesRepository;
       // private IInsurancePolicyPlanCommandsRepository? insurancePolicyPlanCommandsRepository;

        public UnitOfWork(IInsuranceDbContext insuranceDbContext) 
        {
            this.insuranceDbContext = insuranceDbContext;
        }


        public IInsurancePolicyQueriesRepository InsurancePolicyQueriesRepository
        {
            get
            {
                insurancePolicyQueriesRepository ??= new InsurancePolicyQueriesRepository(this.insuranceDbContext);
                return insurancePolicyQueriesRepository;
            }
        }

        public IInsurancePolicyCommandsRepository InsurancePolicyCommandsRepository
        {
            get
            {
                insurancePolicyCommandsRepository ??= new InsurancePolicyCommandsRepository(this.insuranceDbContext);
                return insurancePolicyCommandsRepository;
            }
        }

        public IInsurancePolicyPlanQueriesRepository InsurancePolicyPlanQueriesRepository
        {
            get
            {
                insurancePolicyPlanQueriesRepository ??= new InsurancePolicyPlanQueriesRepository(this.insuranceDbContext);
                return insurancePolicyPlanQueriesRepository;
            }
        }

        //public IInsurancePolicyPlanCommandsRepository InsurancePolicyPlanCommandsRepository
        //{
        //    get
        //    {
        //        insurancePolicyPlanCommandsRepository ??= new InsurancePolicyPlanCommandsRepository(this.insuranceDbContext);
        //        return insurancePolicyPlanCommandsRepository;
        //    }
        //}
    }
}
