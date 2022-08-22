using ChatBot.Common.Entities;
using ChatBot.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Common.Utils.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(UserDTO user, List<OperationClaim> operationClaims);
    }
}
