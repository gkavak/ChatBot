using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Common.Entities
{
    public class MsSQLDbEntity : IEntity<string>
    {
        public string Id => throw new NotImplementedException();

        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ModifiedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
