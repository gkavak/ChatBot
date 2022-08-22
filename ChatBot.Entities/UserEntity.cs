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

        [BsonElement("sqlId")]
        public int sqlId { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public byte[] Password { get; set; }
    }
}


