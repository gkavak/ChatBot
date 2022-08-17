using ChatBot.Common.DataAccess;
using ChatBot.Common.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ChatBot.Enitities
{
    [BsonCollection("Users")]
    public class UserEntity : MongoDbEntity 
    { 
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

        [BsonElement("created_at")]
        public string CreatedAt { get; set; }

        [BsonElement("modified_at")]
        public string ModifiedAt { get; set; }
    }
}


