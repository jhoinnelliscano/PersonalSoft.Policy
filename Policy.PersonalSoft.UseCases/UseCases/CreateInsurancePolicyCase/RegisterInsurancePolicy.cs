
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence;
using Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces;

namespace Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase
{
    public class RegisterInsurancePolicy : IRegisterInsurancePolicy
    {
        private readonly IUnitOfWork unitOfWork;

        public RegisterInsurancePolicy(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task RegisterNewInsurancePolicyAsync(InsurancePolicy insurancePolicy) 
        {
            await unitOfWork.InsurancePolicyCommandsRepository.CreateAsync(insurancePolicy);
        }
    }
}
