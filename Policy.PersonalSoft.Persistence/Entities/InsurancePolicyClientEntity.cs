
using MongoDB.Bson.Serialization.Attributes;

namespace Policy.PersonalSoft.Persistence.Entities
{
    public class InsurancePolicyClientEntity
    {
        [BsonElement("Identification")]
        public string Identification { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Birthdate")]
        public DateTime Birthdate { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("City")]
        public string City { get; set; }
    }
}
