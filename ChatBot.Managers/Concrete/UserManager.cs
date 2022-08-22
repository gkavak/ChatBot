using AutoMapper;
using ChatBot.Common.Aspects.Autofac.Validation;
using ChatBot.Common.Entities;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Results.Concrete;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Enitities;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Constants;
using ChatBot.Managers.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserDAL _userDAL;
        private readonly IMapper _mapper;
        public UserManager(IUserDAL userDAL, IMapper mapper)
        {
            _userDAL = userDAL;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(UserValidator))]
        public async Task<IResult> AddUserAsync(UserDto user)
        {  
            var userEnty = _mapper.Map<UserEntity>(user);
             await _userDAL.InsertOneAsync(userEnty);

            /*
             * return res  ?
                new SuccessResult(message: MessageTexts.UserInsertSuccess) :
                new FailureResult(message: MessageTexts.UserInsertFailure);
            */

            return new SuccessResult(message: MessageTexts.UserInsertSuccess);

        }

        public async Task<IDataResult<UserDto>> GetUserByEmail(string email)
        {
            var user =  await _userDAL.GetUserByEmail(email);
            if (user != null)
            {
                var dtoUser = _mapper.Map<UserDto>(user);
                return new SuccessDataResult<UserDto>(data: dtoUser, message: MessageTexts.UserFound);
            }
            return new FailureDataResult<UserDto>(message:MessageTexts.UserNotFound);
        }

        
        public List<OperationClaim> GetClaims(UserDto user)
        {
            var userEnt = _mapper.Map<UserEntity>(user);
            return _userDAL.GetClaims(userEnt);
        }

       
    }
}
