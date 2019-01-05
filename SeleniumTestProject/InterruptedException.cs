using System;
using System.Runtime.Serialization;

namespace SeleniumTestProject
{
    [Serializable]
    internal class InterruptedException : Exception
    {
        public InterruptedException()
        {
        }

        public InterruptedException(string message) : base(message)
        {
        }

        public InterruptedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InterruptedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}