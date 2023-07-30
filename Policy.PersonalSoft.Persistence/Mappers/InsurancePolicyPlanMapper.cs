using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence.Entities;

namespace Policy.PersonalSoft.Persistence.Mappers
{
    public static class InsurancePolicyPlanMapper
    {
        public static InsurancePolicyPlanEntity? MappToInsurancePolicyPlanEntity(InsurancePolicyPlan domain)
        {
            if (domain == null) return null;

            var InsurancePolicyPlanEntity = new InsurancePolicyPlanEntity() 
            {
                 Id = domain.PlanId,
                 Code = domain.PlanCode,
                 Name = domain.PlanName,
                 StartDate = domain.StarDate,
                 EndDate = domain.EndDate
            }; 
            return InsurancePolicyPlanEntity;
        }

        public static InsurancePolicyPlan? MappToInsurancePolicyPlan(InsurancePolicyPlanEntity enity)
        {
            if (enity == null) return null;

            var InsurancePolicyPlan = new InsurancePolicyPlan()
            {
                 PlanId = enity.Id,
                 PlanCode = enity.Code,
                 PlanName = enity.Name,
                 StarDate = enity.StartDate,
                 EndDate = enity.EndDate                  
            };
            return InsurancePolicyPlan;
        }
    }
}
