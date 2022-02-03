using System;

namespace OOP.Exceptions
{
    [Serializable]
    public class InitializationException : Exception
    {
        public InitializationException(string message) : base(String.Format("Unable to initialize the {0}.", message)) { }
        public InitializationException(string message, Exception inner) : base(message, inner) { }
        protected InitializationException(System.Runtime.Serialization.SerializationInfo info,
                                          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}