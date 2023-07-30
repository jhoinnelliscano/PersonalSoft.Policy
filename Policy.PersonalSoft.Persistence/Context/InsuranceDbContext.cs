using MongoDB.Driver;
using Policy.PersonalSoft.Common.AppConfig;
using Policy.PersonalSoft.Persistence.Entities;

namespace Policy.PersonalSoft.Persistence.Context
{
    public class InsuranceDbContext : IInsuranceDbContext
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase mongoDatabase;
        private IMongoCollection<InsurancePolicyEntity> insurancePolicyCollection;
        private IMongoCollection<InsurancePolicyPlanEntity> insurancePolicyPlanCollection;

        private readonly string insurancePolicyCollectionName;
        private readonly string insurancePolicyPlanCollectionName;

        public InsuranceDbContext()
        {
            mongoClient = new MongoClient(AppConfiguration.Configuration["InsurancePolicyDatabase:ConnectionString"].ToString());
            mongoDatabase = mongoClient.GetDatabase(AppConfiguration.Configuration["InsurancePolicyDatabase:DatabaseName"].ToString());
            insurancePolicyCollectionName = AppConfiguration.Configuration["InsurancePolicyDatabase:InsurancePolicyCollectionName"].ToString();
            insurancePolicyPlanCollectionName = AppConfiguration.Configuration["InsurancePolicyDatabase:InsurancePolicyPlanCollectionName"].ToString();
        }

        public IMongoCollection<InsurancePolicyEntity> InsurancePolicyCollection
        {
            get
            {
                insurancePolicyCollection ??= mongoDatabase.GetCollection<InsurancePolicyEntity>(insurancePolicyCollectionName);
                return insurancePolicyCollection;
            }
        }

        public IMongoCollection<InsurancePolicyPlanEntity> InsurancePolicyPlanCollection
        {
            get
            {
                insurancePolicyPlanCollection ??= mongoDatabase.GetCollection<InsurancePolicyPlanEntity>(insurancePolicyPlanCollectionName);
                return insurancePolicyPlanCollection;
            }
        }

    }
}
