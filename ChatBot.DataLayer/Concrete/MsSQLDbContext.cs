using ChatBot.Common.DataAccess;
using ChatBot.Common.Entities;
using ChatBot.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.DataLayer.Concrete
{
    public class MsSQLDbContext: DbContext
    {
        private readonly MsSQLDbSettings _options;
        public MsSQLDbContext(IOptions<MsSQLDbSettings> options)
        {
                _options = options.Value;
        }

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._options.ConnectionString);
        }

        public DbSet<ChatBotQuestionEntity> Questions { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }

        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
