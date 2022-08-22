using AutoMapper;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Results.Concrete;
using ChatBot.Common.Utils.Security.Hashing;
using ChatBot.Common.Utils.Security.JWT;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Constants;
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
        private IMapper _mapper;
        public AuthorizationManager(IUserManager userManager, ITokenHelper tokenHelper,IMapper mapper ) 
        {
            _userManager = userManager;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        public IDataResult<UserDTO> Register(UserRegisterDTO userForRegisterDto, string password)
        {
            byte[] passwordHash;
            HashingHelper.CreatePasswordHash(password, out passwordHash);
            var userDto = new UserDTO
            {
                Email = userForRegisterDto.Email,
                Name = userForRegisterDto.Name,
                Password = passwordHash,
                sqlId = Int32.Parse(userForRegisterDto.sqlId)
            };
            _userManager.AddUserAsync(userDto);
            return new SuccessDataResult<UserDTO>(userDto, MessageTexts.RegisterSuccess);
        }

        public IDataResult<UserDTO> Login(UserLoginDTO userForLoginDto)
        {
            var userToCheck = _userManager.GetUserByEmail(userForLoginDto.Email).Result.Data;
            if (userToCheck == null)
            {
                return new FailureDataResult<UserDTO>(message:MessageTexts.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Password))
            {
                return new FailureDataResult<UserDTO>(message:MessageTexts.PasswordMissMatch);
            }

            return new SuccessDataResult<UserDTO>(userToCheck, MessageTexts.LoginSuccess);
        }

        public IResult IsUserExists(string email)
        {
            var user = _userManager.GetUserByEmail(email).Result;
            if ( user.Success)
            {
                return new FailureResult(message:MessageTexts.UserExist);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(UserDTO user)
        {    
            var claims = _userManager.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken,MessageTexts.TokenCreated);
        }

       
    }
}
