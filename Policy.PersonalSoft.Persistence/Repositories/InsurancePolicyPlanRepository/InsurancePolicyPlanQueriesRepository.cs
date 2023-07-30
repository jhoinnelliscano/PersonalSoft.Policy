using MongoDB.Driver;
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence.Context;
using Policy.PersonalSoft.Persistence.Mappers;
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyPlanRepository;

namespace Policy.PersonalSoft.Persistence.Repositories.InsurancePolicyPlanRepository
{
    public class InsurancePolicyPlanQueriesRepository : IInsurancePolicyPlanQueriesRepository
    {
        private readonly IInsuranceDbContext dbContext;

        public InsurancePolicyPlanQueriesRepository(IInsuranceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<InsurancePolicyPlan> GetByCodeAsync(string policyPlanCode)
        {
            var a = await dbContext.InsurancePolicyPlanCollection.Find(_ => true).ToListAsync();

            var insurancePolicyPlanEntity = await dbContext.InsurancePolicyPlanCollection.Find(x => x.Code.Equals(policyPlanCode)).FirstOrDefaultAsync();
            return InsurancePolicyPlanMapper.MappToInsurancePolicyPlan(insurancePolicyPlanEntity);
        }

        public async Task<IEnumerable<InsurancePolicyPlan>?> GetAllAsync()
        {
            var insurancePolicyPlanEntity = await dbContext.InsurancePolicyPlanCollection.Find(_ => true).ToListAsync();
            if (insurancePolicyPlanEntity == null) return null;
            return insurancePolicyPlanEntity.Select(x => InsurancePolicyPlanMapper.MappToInsurancePolicyPlan(x)).ToList();
        }
    }
}
