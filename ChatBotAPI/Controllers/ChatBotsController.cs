using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ChatBotsController : ControllerBase
{
    private readonly IChatBotManager _chatBotManager;

    public ChatBotsController(IChatBotManager repository)
    {
        _chatBotManager = repository;
    }



    [HttpGet(Name = "AskQuestion")]
    public async Task<ChatBotRespondsDTO> AskQuestion()
    {
        throw new NotImplementedException();
    }

}

