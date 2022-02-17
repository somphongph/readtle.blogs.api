using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Readtle.Blogs.Domain.Entities
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("createdOn")]
        public DateTime CreatedOn { get; set; }

        [BsonElement("createdBy")]
        public string? CreatedBy { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("modifieldOn")]
        public DateTime ModifieldOn { get; set; }

        [BsonElement("modifieldBy")]
        public string? ModifieldBy { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("deletedOn")]
        public DateTime? DeletedOn { get; set; }

        [BsonElement("deletedBy")]
        public string? DeletedBy { get; set; }
    }
}