using ChatBot.Common.Utils.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Common.Utils.Results.ConcreteBase
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string? Message { get; }

        public Result(bool succes, string message) : this(succes)
        {
            Message = message;
        }
        public Result(bool succes) => Success = succes;
    }
}
