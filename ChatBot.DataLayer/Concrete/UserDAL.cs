
using ChatBot.Common.DataAccess;
using ChatBot.Common.Entities;
using ChatBot.DataLayer.Abstract;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;

namespace ChatBot.DataLayer.Concrete
{

    public class UserDAL : MongoDbRepositoryBase<UserEntity>, IUserDAL
    {
        public UserDAL(IOptions<MongoDbSettings> options) : base(options)
        {
         
        }

        public async Task<UserEntity> GetUserByEmail(string email)
        {
            return await this.GetAsync(u => u.Email == email);
        }
    }
}