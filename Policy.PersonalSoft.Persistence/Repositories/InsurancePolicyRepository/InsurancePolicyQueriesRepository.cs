using Amazon.Auth.AccessControlPolicy;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Driver;
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence.Context;
using Policy.PersonalSoft.Persistence.Entities;
using Policy.PersonalSoft.Persistence.Mappers;
using Policy.PersonalSoft.RepositoryInterface.InsurancePolicyRepository;
using System;

namespace Policy.PersonalSoft.Persistence.Repositories.InsurancePolicyRepository
{
    public class InsurancePolicyQueriesRepository : IInsurancePolicyQueriesRepository
    {
        private readonly IInsuranceDbContext dbContext;

        public InsurancePolicyQueriesRepository(IInsuranceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<InsurancePolicy> GetByPolicyIdOrLicensePlate(string search)
        {
            InsurancePolicyEntity insurancePolicyEntity;

            if (ObjectId.TryParse(search, out ObjectId objectId))
            {
                insurancePolicyEntity = await dbContext.InsurancePolicyCollection.Find(x => x.Id == search).FirstOrDefaultAsync();
            }
            else
            {
                insurancePolicyEntity = await dbContext.InsurancePolicyCollection.Find(x => x.Automobile.LicensePlate == search).FirstOrDefaultAsync();
            }
            return InsurancePolicyMapper.MappToInsurancePolicy(insurancePolicyEntity);
        }

        public async Task<IEnumerable<InsurancePolicy>?> GetAllAsync()
        {
            var InsurancePolicyEntity = await dbContext.InsurancePolicyCollection.Find(_ => true).ToListAsync();
            if (InsurancePolicyEntity == null) return null;
            return InsurancePolicyEntity.Select(x => InsurancePolicyMapper.MappToInsurancePolicy(x)).ToList();
        }
    }
}
