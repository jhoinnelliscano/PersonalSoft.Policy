
using Policy.PersonalSoft.EntityDomain.Domain;
using System.ComponentModel.DataAnnotations;

namespace Policy.PersonalSoft.EntityDomain.Commands
{
    public class CreateInsurancePolicyPlanCommand
    {
        [Required(ErrorMessage = "El el campo PlanName (nombre del plan de poliza) es requerido.")]
        public string PlanName { get; set; }

        [Required(ErrorMessage = "El el campo StarDate (fecha de inicio del plan de poliza) es requerido.")]
        public DateTime StarDate { get; set; }

        [Required(ErrorMessage = "El el campo EndDate (fecha de fin del plan de poliza) es requerido.")]
        public DateTime EndDate { get; set; }

        public InsurancePolicyPlan GetDomain() 
        {
            return new InsurancePolicyPlan()
            {
                PlanName = PlanName,
                StarDate = StarDate,
                EndDate = EndDate
            };
        }    

    }
}
