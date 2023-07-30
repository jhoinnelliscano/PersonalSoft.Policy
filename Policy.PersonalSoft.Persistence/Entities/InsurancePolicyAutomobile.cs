
using MongoDB.Bson.Serialization.Attributes;

namespace Policy.PersonalSoft.Persistence.Entities
{
    public class InsurancePolicyAutomobile
    {
        [BsonElement("LicensePlate")]
        public string LicensePlate { get; set; }

        [BsonElement("Model")]
        public string Model { get; set; }

        [BsonElement("HasInspection")]
        public string HasInspection { get; set; }
    }
}
