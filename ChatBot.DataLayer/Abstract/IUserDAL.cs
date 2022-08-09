using ChatBot.Common.DataAccess;
using ChatBot.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBot.Common.DataAccess;
namespace ChatBot.DataLayer.Abstract
{
    public interface IUserDAL:IRepository<UserEntity,string>
    {
        Task<UserEntity> GetUserByEmail(string email);
        
    }
}
