
namespace Policy.PersonalSoft.EntityDomain.Domain
{
    public class InsurancePolicyPlan
    {
        public string? PlanId { get; set; }
        public string PlanCode { get; set; }
        public string PlanName { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
