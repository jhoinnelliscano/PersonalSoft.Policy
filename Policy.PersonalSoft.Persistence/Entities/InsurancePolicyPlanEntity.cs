using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Policy.PersonalSoft.Persistence.Entities
{
    public class InsurancePolicyPlanEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Code")]
        public string Code { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("StartDate")]
        public DateTime StartDate { get; set; }

        [BsonElement("EndDate")]
        public DateTime EndDate { get; set; }
    }
}
