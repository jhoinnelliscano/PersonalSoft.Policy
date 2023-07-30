using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence.Entities;
using SharpCompress.Common;

namespace Policy.PersonalSoft.Persistence.Mappers
{
    public static class InsurancePolicyMapper
    {
        public static InsurancePolicyEntity? MappToInsurancePolicyEntity(InsurancePolicy domain)
        {
            if (domain == null) return null;

            var InsurancePolicyEntity = new InsurancePolicyEntity() 
            {
                AcquisitionDate = domain.AcquisitionDate,
                ExpirationDate = domain.ExpirationDate,
                MaxValue = domain.MaxValue,
                Id = domain.PolicyId,
                PolicyPlanCode = domain.PolicyPlanCode,
                Toppings = domain.Toppings,
                Automobile = new InsurancePolicyAutomobile()
                {
                    HasInspection = domain.Automobile.HasInspection,
                    LicensePlate = domain.Automobile.LicensePlate,
                    Model = domain.Automobile.Model
                },
                Client = new InsurancePolicyClientEntity()
                {
                    Address = domain.Client.Address,
                    Birthdate = domain.Client.Birthdate,
                    City = domain.Client.City,
                    Identification = domain.Client.Identification,
                    Name = domain.Client.Name,
                }

            }; 
            return InsurancePolicyEntity;
        }

        public static InsurancePolicy? MappToInsurancePolicy(InsurancePolicyEntity enity)
        {
            if (enity == null) return null;

            var InsurancePolicy = new InsurancePolicy()
            {
                AcquisitionDate = enity.AcquisitionDate,
                ExpirationDate = enity.ExpirationDate,
                MaxValue = enity.MaxValue,
                PolicyId = enity.Id,
                PolicyPlanCode = enity.PolicyPlanCode,
                Toppings = enity.Toppings,
                Automobile = new Automobile() 
                {
                     HasInspection = enity.Automobile.HasInspection,
                     LicensePlate = enity.Automobile.LicensePlate,
                     Model = enity.Automobile.Model
                },
                Client = new Client()
                {
                     Address = enity.Client.Address,
                     Birthdate = enity.Client.Birthdate,
                     City = enity.Client.City,
                     Identification = enity.Client.Identification,
                     Name = enity.Client.Name,
                }
            };
            return InsurancePolicy;
        }
    }
}
