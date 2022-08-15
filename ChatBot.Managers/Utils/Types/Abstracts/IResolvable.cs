using ChatBot.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Types.Abstracts
{
    public interface IResolvable
    {
        ChatBotResponseDTO Resolve();
    }
}
