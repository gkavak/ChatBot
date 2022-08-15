using ChatBot.Dtos;
using ChatBot.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController:ControllerBase
{
    private readonly IUserManager _userManager;
    
    public UserController(IUserManager userManager)
    {
        _userManager = userManager;
    }

    [HttpGet(Name ="GetUserByEmail")]
    public async Task<UserDto> GetUserByEmail(string email) {
        return await this._userManager.GetUserByEmail(email);
    }

}