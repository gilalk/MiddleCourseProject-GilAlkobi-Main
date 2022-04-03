using System.Runtime.Serialization;

namespace ManagerForm
{
    [Serializable]
    internal class invalidClassCodeException : Exception
    {
        public invalidClassCodeException()
        {
        }

        public invalidClassCodeException(string? message) : base(message)
        {
        }

        public invalidClassCodeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected invalidClassCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}