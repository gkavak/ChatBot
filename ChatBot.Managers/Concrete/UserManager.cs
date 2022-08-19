using AutoMapper;
using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Common.Utils.Results.Concrete;
using ChatBot.DataLayer.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
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
        public async Task<IDataResult<UserDto>> GetUserByEmail(string email)
        {
            var user =  await _userDAL.GetUserByEmail(email);
            if (user != null)
            {
                var dtoUser = _mapper.Map<UserDto>(user);
                return new SuccessDataResult<UserDto>(data: dtoUser, message: "User Found");
            }
            return new FailureDataResult<UserDto>(message: "User could not be Found");
        }

        public async Task<IDataResult<UserDto>> GetUserByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
