using ChatBot.Common.Entities;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;

namespace ChatBot.Managers.Abstract
{
    public interface IUserManager
    {
        Task<IDataResult<UserDTO>> GetUserByEmail(string email);
        Task<IResult> AddUserAsync(UserDTO user);
        List<OperationClaim> GetClaims(UserDTO user);
    }
}
