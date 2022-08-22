using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Dtos.Abstract
{
    public abstract class DtoAbstract
    {
        public string Id { get; }  
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedAt { get; set; }= DateTime.UtcNow;
    }
}
