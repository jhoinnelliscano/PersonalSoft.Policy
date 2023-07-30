
using MongoDB.Driver;
using Policy.PersonalSoft.Persistence.Entities;

namespace Policy.PersonalSoft.Persistence.Context
{
    public interface IInsuranceDbContext
    {
        IMongoCollection<InsurancePolicyEntity> InsurancePolicyCollection { get; }
        IMongoCollection<InsurancePolicyPlanEntity> InsurancePolicyPlanCollection { get; }
    }
}
