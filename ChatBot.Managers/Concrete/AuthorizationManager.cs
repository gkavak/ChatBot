using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Security.JWT;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Concrete
{
    public class AuthorizationManager : IAuthorizationManager
    {
        private IUserManager _userManager;
        private ITokenHelper _tokenHelper;
        public AuthorizationManager(IUserManager userManager, ITokenHelper tokenHelper ) 
        {
            _userManager = userManager;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(UserDto user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserDto> Login(UserLoginDTO userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserDto> Register(UserRegisterDTO userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
