using Policy.PersonalSoft.EntityDomain.Commands;
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence;
using Policy.PersonalSoft.UseCases.Interfaces;
using Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase;
using Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces;

namespace Policy.PersonalSoft.UseCases.Services
{
    public class InsurancePolicyService : IInsurancePolicyService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IInsurancePolicyFacade insurancePolicyUserCase;

        public InsurancePolicyService(IUnitOfWork unitOfWork, IInsurancePolicyFacade insurancePolicyUserCase)
        {
            this.unitOfWork = unitOfWork;
            this.insurancePolicyUserCase = insurancePolicyUserCase;
        }

        public async Task CreateAsyn(CreateInsurancePolicyCommand createInsurancePolicyCommand)
        {
            var insurancePolicy = createInsurancePolicyCommand.GetDomain();
            await insurancePolicyUserCase.CreateInsurancePolicyAsync(insurancePolicy);
        }

        public async Task<IEnumerable<InsurancePolicy>> GetAllAsyn() => await unitOfWork.InsurancePolicyQueriesRepository.GetAllAsync();

        public async Task<InsurancePolicy> GetByPolicyIdOrLicensePlate(string search) => await unitOfWork.InsurancePolicyQueriesRepository.GetByPolicyIdOrLicensePlate(search);
    }
}
