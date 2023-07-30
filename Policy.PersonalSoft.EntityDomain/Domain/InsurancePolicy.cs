
using System.Security.Cryptography.X509Certificates;

namespace Policy.PersonalSoft.EntityDomain.Domain
{
    public class InsurancePolicy
    {
        public string? PolicyId { get; set; }
        public string PolicyPlanCode { get; set; }
        public Client Client { get; set; }
        public Automobile Automobile { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal MaxValue { get; set; }      
        public IList<string> Toppings { get; set; }
    }
}
