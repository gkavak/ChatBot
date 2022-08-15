using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ChatBotsController : ControllerBase
{
    private readonly IChatBotEntryManager _chatBotEntryManager;
    private readonly IChatBotQuestionManager _chatBotQuestionManager;
   

    public ChatBotsController(IChatBotEntryManager chatBotEntryManager, IChatBotQuestionManager questionManager)
    {
        _chatBotEntryManager = chatBotEntryManager;
        _chatBotQuestionManager = questionManager;
    }



    [HttpGet(Name = "AskQuestion")]
    public async Task<ChatBotResponseDTO> AskQuestion(Dictionary<string,string> useranswer)
    {
        //save the user answers,check the user answers
        throw new NotImplementedException();
    }

}

