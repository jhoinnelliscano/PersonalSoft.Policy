
using Policy.PersonalSoft.EntityDomain.Domain;
using System.ComponentModel.DataAnnotations;

namespace Policy.PersonalSoft.EntityDomain.Commands
{
    public class CreateInsurancePolicyCommand
    {
        [Required (ErrorMessage = "El el campo PolicyPlanId (código del plan de poliza) es requerido.")]
        public string PolicyPlanId { get; set; }
        
        [Required(ErrorMessage = "El campo ClientIdentification (número de identificación del cliente) es requerido.")]
        public string ClientIdentification { get; set; }
        
        [Required(ErrorMessage = "El campo ClientName (nombre del cliente) es requerido.")]
        public string ClientName { get; set; }
        
        [Required(ErrorMessage = "El campo ClientAddress (dirección de cliente) es requerido.")]
        public string ClientAddress { get; set; }

        [Required(ErrorMessage = "El campo ClientBirthdate (fecha de nacimiento del de cliente) es requerido.")]
        public DateTime ClientBirthdate { get; set; }

        [Required(ErrorMessage = "EL campo ClientCity (ciudad de residencia del cliente) es requerido.")]
        public string ClientCity { get; set; }
        
        [Required(ErrorMessage = "El campo AcquisitionDate (fecha de adquisicíon de la poliza) es requerido.")]
        public DateTime AcquisitionDate { get; set; }
        
        [Required(ErrorMessage = "El campo ExpirationDate (fecha de expiración de la poliza) es requerido.")]
        public DateTime ExpirationDate { get; set; }
        
        [Required(ErrorMessage = "El campo Toppings (códigos de las coberturas) es requerida.")]
        public IList<string> Toppings { get; set; }
        
        [Required(ErrorMessage = "El campo MaxValue (valor maximo de cobertura de la poliza) es requerido.")]
        public decimal MaxValue { get; set; }
        
        [Required(ErrorMessage = "El campo AutomobileLicensePlate (número de placa del vehiculo) requerido.")]
        public string AutomobileLicensePlate { get; set; }
        
        [Required(ErrorMessage = "El campo AutomobileModel (modelo del vehiculo) es requerido.")]
        public string AutomobileModel { get; set; }
        
        [Required(ErrorMessage = "El campo AutomobileHasInspection (¿el vehiculo tiene inpección?) es requerido.")]
        public string AutomobileHasInspection { get; set; }


        public InsurancePolicy GetDomain() 
        {
            return  new InsurancePolicy()
            {
                PolicyPlanCode = PolicyPlanId,
                MaxValue = MaxValue,
                Toppings = Toppings,
                Client = new Client()
                {
                    Identification = ClientIdentification,
                    Address = ClientAddress,
                    Birthdate = ClientBirthdate,
                    City = ClientCity,
                    Name = ClientName,
                },
                Automobile = new Automobile()
                {
                    HasInspection = AutomobileHasInspection,
                    LicensePlate = AutomobileLicensePlate,
                    Model = AutomobileModel
                },
                AcquisitionDate = DateTime.Now,
            };
        }

    }
}
