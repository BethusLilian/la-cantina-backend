using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace la_cantina_backend.Models
{
    public class Tag
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Name { get; set; }
    }
}
