using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ChatBot.Common.Entities
{
    public abstract class UserEntity : MongoDbEntity
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("region")]
        public string Region { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }
}


