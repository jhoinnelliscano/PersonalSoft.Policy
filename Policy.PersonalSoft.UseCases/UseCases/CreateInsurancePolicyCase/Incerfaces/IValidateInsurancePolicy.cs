

namespace Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces
{
    public interface IValidateInsurancePolicy
    {
        Task ValidateInsurancePolicyPlanCurrentAsync(string policyPlanCode);
    }
}
