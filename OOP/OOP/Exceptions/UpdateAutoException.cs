using System;

namespace OOP.Exceptions
{
    [Serializable]
    public class UpdateAutoException : Exception
    {
        public UpdateAutoException() : base("The car with current ID doesn't exist.") { }
        public UpdateAutoException(string message, Exception inner) : base(message, inner) { }
        protected UpdateAutoException(System.Runtime.Serialization.SerializationInfo info,
                                      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}