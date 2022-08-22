using ChatBot.Common.Entities;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;

namespace ChatBot.Managers.Abstract
{
    public interface IUserManager
    {
        Task<IDataResult<UserDto>> GetUserByEmail(string email);
        Task<IResult> AddUserAsync(UserDto user);
        List<OperationClaim> GetClaims(UserDto user);
    }
}
