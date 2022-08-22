using ChatBot.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Entities
{
    public class UserOperationClaim : MsSQLDbEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FKOperationClaimId { get; set; }
    }
}
