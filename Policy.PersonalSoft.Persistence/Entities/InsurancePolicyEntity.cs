
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Policy.PersonalSoft.Persistence.Entities
{
    public class InsurancePolicyEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("PolicyPlanCode")]
        public string PolicyPlanCode { get; set; }

        [BsonElement("AcquisitionDate")]
        public DateTime AcquisitionDate { get; set; }

        [BsonElement("ExpirationDate")]
        public DateTime ExpirationDate { get; set; }

        [BsonElement("MaxValue")]
        public decimal MaxValue { get; set; }

        [BsonElement("Toppings")]
        public IList<string> Toppings { get; set; }

        [BsonElement("Client")]
        public InsurancePolicyClientEntity Client { get; set; }

        [BsonElement("Automobile")]
        public InsurancePolicyAutomobile Automobile { get; set; }
    }
}
