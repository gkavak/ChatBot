using ChatBot.Common.Utils.Results.Abstract;
using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Concrete;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ChatBotController : ControllerBase
{
    private readonly IChatBotManager _chatBotManager;
   

    public ChatBotController(IChatBotManager chatBotManager)
    {
        _chatBotManager = chatBotManager;
    }



    [HttpGet("AskQuestion")]
    public async Task<IDataResult<ChatBotResponseDTO>> AskQuestion(UserQuestionDTO useranswer)
    {
        //save the user answers,check the user answers
       return await _chatBotManager.AskQuestion(useranswer);
    }

}

