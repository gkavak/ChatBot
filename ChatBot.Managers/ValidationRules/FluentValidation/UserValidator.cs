using ChatBot.Dtos;

using FluentValidation;
using System.Text.RegularExpressions;

namespace ChatBot.Managers.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<UserDto>
    {
        private readonly Func<string, bool> PasswordConvention = (ps) => true;

        public UserValidator()
        {
            RuleFor(user => user.Name).MaximumLength(10);
            RuleFor(user => user.Email).Must(MailConvention);
            RuleFor(user => user.Password).MinimumLength(5).MaximumLength(15).Must(PasswordConvention);
            RuleFor(user => user.Phone).NotEmpty();

        }
        private bool MailConvention(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
