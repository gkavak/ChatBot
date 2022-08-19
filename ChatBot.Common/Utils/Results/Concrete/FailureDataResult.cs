using ChatBot.Common.Utils.Results.ConcreteBase;

namespace ChatBot.Common.Utils.Results.Concrete
{
    public class FailureDataResult<T> : DataResult<T>
    {
        public FailureDataResult(T data, string message) : base(data, false, message)
        {

        }
        public FailureDataResult(T data) : base(data, false)
        {

        }
        public FailureDataResult(string message) : base(default, false, message)
        {

        }
        public FailureDataResult() : base(default, false)
        {

        }

        public FailureDataResult(T data, bool success, string message) : base(data, success, message)
        {
        }
    }
}
