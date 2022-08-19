using ChatBot.Common.Utils.Results.ConcreteBase;

namespace ChatBot.Common.Utils.Results.Concrete
{
    public class FailureResult : Result
    {
        public FailureResult(string message) : base(false, message)
        {

        }

        public FailureResult() : base(false)
        {

        }
    }
}
