using Moq;
using Policy.PersonalSoft.EntityDomain.Commands;
using Policy.PersonalSoft.EntityDomain.Domain;
using Policy.PersonalSoft.Persistence;
using Policy.PersonalSoft.UseCases.Interfaces;
using Policy.PersonalSoft.UseCases.Services;
using Policy.PersonalSoft.UseCases.UseCases.CreateInsurancePolicyCase.incerfaces;

namespace Policy.PersonalSoft.UnitTest
{
    public class InsurancePolicyTest
    {
        [Fact]
        public async Task Get_All_Insurance_Policy_Successful()
        {
            IEnumerable<InsurancePolicy> response = new List<InsurancePolicy>()
            {
                new () 
                {
                    PolicyId = "1"
                },
                new () 
                {
                  PolicyId = "2"
                },
                new () 
                {
                  PolicyId = "3"
                }
            };

            var unitOfWork = new Mock<IUnitOfWork>();
            var insurancePolicyFacade = new Mock<IInsurancePolicyFacade>();

            unitOfWork.Setup(x => x.InsurancePolicyQueriesRepository.GetAllAsync())
                      .ReturnsAsync(response);

            IInsurancePolicyService insurancePolicyService = new InsurancePolicyService(unitOfWork.Object, insurancePolicyFacade.Object);
            var result = await insurancePolicyService.GetAllAsyn();

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Get_Insurance_Policy_By_PolicyId_Successful()
        {
            string policyid = "123";
            string licensePlate = "456";
            string search = policyid;

            InsurancePolicy response = new() 
            {
                PolicyId = policyid, 
                Automobile = new Automobile() 
                {
                    LicensePlate = licensePlate
                }                                 
            };
         
            var unitOfWork = new Mock<IUnitOfWork>();
            var insurancePolicyFacade = new Mock<IInsurancePolicyFacade>();

            unitOfWork.Setup(x => x.InsurancePolicyQueriesRepository.GetByPolicyIdOrLicensePlate(search))
                      .ReturnsAsync(response);

            IInsurancePolicyService insurancePolicyService = new InsurancePolicyService(unitOfWork.Object, insurancePolicyFacade.Object);
            var result = await insurancePolicyService.GetByPolicyIdOrLicensePlate(search);

            Assert.NotNull(result);
            Assert.Equal(policyid, result.PolicyId);
        }

        [Fact]
        public async Task Get_Insurance_Policy_By_LicensePlate_Successful()
        {
            string policyid = "123";
            string licensePlate = "456";
            string search = licensePlate;

            InsurancePolicy response = new()
            {
                PolicyId = policyid,
                Automobile = new Automobile()
                {
                    LicensePlate = licensePlate
                }
            };
            
            var unitOfWork = new Mock<IUnitOfWork>();
            var insurancePolicyFacade = new Mock<IInsurancePolicyFacade>();

            unitOfWork.Setup(x => x.InsurancePolicyQueriesRepository.GetByPolicyIdOrLicensePlate(search))
                      .ReturnsAsync(response);

            IInsurancePolicyService insurancePolicyService = new InsurancePolicyService(unitOfWork.Object, insurancePolicyFacade.Object);
            var result = await insurancePolicyService.GetByPolicyIdOrLicensePlate(search);

            Assert.NotNull(result);
            Assert.Equal(policyid, result.PolicyId);
        }

        [Fact]
        public async Task Create_Insurance_Policy_Successful()
        {
            CreateInsurancePolicyCommand command = new CreateInsurancePolicyCommand();
            InsurancePolicy insurancePolicy = new InsurancePolicy();

            var unitOfWork = new Mock<IUnitOfWork>();
            var insurancePolicyFacade = new Mock<IInsurancePolicyFacade>();

            insurancePolicyFacade.Setup(x => x.CreateInsurancePolicyAsync(insurancePolicy));

            try
            {
                IInsurancePolicyService insurancePolicyService = new InsurancePolicyService(unitOfWork.Object, insurancePolicyFacade.Object);
                await insurancePolicyService.CreateAsyn(command);
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }
    }
}