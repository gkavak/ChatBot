using ChatBot.Dtos;

using FluentValidation;
using System.Text.RegularExpressions;

namespace ChatBot.Managers.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<UserRegisterDTO>
    {
        private readonly Func<string, bool> PasswordConvention = (ps) => true;

        public UserValidator()
        {
            RuleFor(user => user.Name).NotNull().MaximumLength(10);
            RuleFor(user => user.Email).NotNull().Must(MailConvention);
            RuleFor(user => user.Password).NotNull().MinimumLength(5).MaximumLength(15).Must(PasswordConvention);
            RuleFor(user => user.sqlId).NotNull();

        }
        private bool MailConvention(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
