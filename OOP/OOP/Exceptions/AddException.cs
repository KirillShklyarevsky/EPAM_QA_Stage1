using System;

namespace OOP.Exceptions
{
    [Serializable]
    public class AddException : Exception
    {
        public AddException() : base("Unable to add new vehicle model.") { }
        public AddException(string message, Exception inner) : base(message, inner) { }
        protected AddException(System.Runtime.Serialization.SerializationInfo info,
                               System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}