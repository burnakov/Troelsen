using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    [Serializable]
    class CarIsDeadException : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message) : base(message) { }
        public CarIsDeadException(string message, Exception inner) : base(message, inner) { }
        protected CarIsDeadException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public CarIsDeadException(string message, string cause, DateTime timeStamp) : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = timeStamp;
        }
    }
}
