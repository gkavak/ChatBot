using ChatBot.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Dtos
{
    public class UserDto:DtoAbstract
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Region { get; set; }

        public string Password { get; set; }
    }
}
