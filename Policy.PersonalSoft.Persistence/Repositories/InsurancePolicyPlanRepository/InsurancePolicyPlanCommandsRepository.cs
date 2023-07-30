
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence.Context;
using Policy.PersonalSoft.Persistence.Mappers;
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyPlanRepository;

namespace Policy.PersonalSoft.Persistence.Repositories.InsurancePolicyPlanRepository
{
    public class InsurancePolicyPlanCommandsRepository : IInsurancePolicyPlanCommandsRepository
    {
        private readonly IInsuranceDbContext dbContext;

        public InsurancePolicyPlanCommandsRepository(IInsuranceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(InsurancePolicyPlan insurancePolicyPlan)
        {
            var insurancePolicyEntity = InsurancePolicyPlanMapper.MappToInsurancePolicyPlanEntity(insurancePolicyPlan);
            await dbContext.InsurancePolicyPlanCollection.InsertOneAsync(insurancePolicyEntity);
        }
    }
}
