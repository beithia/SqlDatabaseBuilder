using System;
using System.Runtime.Serialization;

namespace Xtrimmer.SqlDatabaseBuilder
{
    [Serializable]
    public class InvalidIdentityException : Exception
    {
        public InvalidIdentityException()
        {
        }

        public InvalidIdentityException(string message) : base(message)
        {
        }

        public InvalidIdentityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidIdentityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}