
using ChatBot.Common.DataAccess;
using ChatBot.Common.Entities;
using ChatBot.Common.Utils.IoC;
using ChatBot.DataLayer.Abstract;
using ChatBot.Enitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;

namespace ChatBot.DataLayer.Concrete
{

    public class UserDAL : MongoDbRepositoryBase<UserEntity>, IUserDAL
    {
        private readonly MsSQLDbContext _dbContext;
        public UserDAL(IOptions<MongoDbSettings> options,MsSQLDbContext sqlDb) : base(options)
        {
         _dbContext = sqlDb;
        }

        public async Task<UserEntity> GetUserByEmail(string email)
        {
            return await base.FindOneAsync(user => user.Email == email);
        }
        public override Task InsertOneAsync(UserEntity user)
        {
            return base.InsertOneAsync(user);
        }

        public List<OperationClaim> GetClaims(UserEntity user)
        {
            var context =_dbContext;
           
            var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.FKOperationClaimId
                         where userOperationClaim.UserId == user.sqlId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

         
        }
    }
}