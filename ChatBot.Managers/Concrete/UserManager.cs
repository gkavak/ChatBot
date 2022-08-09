using AutoMapper;
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
        public async Task<UserDto> GetUserByEmail(string email)
        {
            var user = await _userDAL.GetUserByEmail(email);
            var dtoUser = _mapper.Map<UserDto>(user);
            return dtoUser;
        }

        public Task<UserDto> GetUserByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
