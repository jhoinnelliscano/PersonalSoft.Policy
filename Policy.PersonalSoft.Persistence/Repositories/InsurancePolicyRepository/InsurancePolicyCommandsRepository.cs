using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence.Context;
using Policy.PersonalSoft.Persistence.Mappers;
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyRepository;

namespace Policy.PersonalSoft.Persistence.Repositories.InsurancePolicyRepository
{
    public class InsurancePolicyCommandsRepository : IInsurancePolicyCommandsRepository
    {
        private readonly IInsuranceDbContext dbContext;

        public InsurancePolicyCommandsRepository(IInsuranceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(InsurancePolicy insurancePolicy)
        {
            var insurancePolicyEntity = InsurancePolicyMapper.MappToInsurancePolicyEntity(insurancePolicy);
            await dbContext.InsurancePolicyCollection.InsertOneAsync(insurancePolicyEntity);
        }
    }
}
