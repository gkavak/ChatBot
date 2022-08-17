﻿using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Concrete;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ChatBotController : ControllerBase
{
    private readonly IChatBotManager _chatBotManager;
   

    public ChatBotController(IChatBotManager chatBotManager)
    {
        _chatBotManager = chatBotManager;
    }



    [HttpGet(Name = "AskQuestion")]
    public async Task<ChatBotResponseDTO> AskQuestion(string useranswer)
    {
        //save the user answers,check the user answers
       return await _chatBotManager.AskQuestion(useranswer);
    }

}

