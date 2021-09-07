using System;

namespace OOP.Exceptions
{
    [Serializable]
    public class RemoveAutoException : Exception
    {
        public RemoveAutoException() : base("The car with current ID doesn't exist.") { }
        public RemoveAutoException(string message, Exception inner) : base(message, inner) { }
        protected RemoveAutoException(System.Runtime.Serialization.SerializationInfo info,
                                      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}