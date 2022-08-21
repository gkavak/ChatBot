using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Security.JWT;
using ChatBot.Dtos;
using ChatBot.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Abstract
{
    public interface IAuthorizationManager
    {
        IDataResult<UserDto> Register(UserRegisterDTO userForRegisterDto, string password);
        IDataResult<UserDto> Login(UserLoginDTO userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(UserDto user);
    }
}
