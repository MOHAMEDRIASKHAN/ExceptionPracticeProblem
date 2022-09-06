using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPracticeProblem
{
    public   class UserException : Exception
    {
        public enum ExceptionType
        {
            Empty_Message,
            NULL_Message
        }
        private readonly ExceptionType type;

        public UserException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
