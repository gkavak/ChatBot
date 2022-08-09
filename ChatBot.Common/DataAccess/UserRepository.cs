using ChatBot.Common.Entities;
using Microsoft.Extensions.Options;
namespace ChatBot.Common.DataAccess
{

    public class UserRepository : MongoDbRepositoryBase<UserEntity>
    {
        public UserRepository(IOptions<MongoDbSettings> options)
        {
            base(options);
        }

        public string Authenticate() => "Token claimed!";
    }
}